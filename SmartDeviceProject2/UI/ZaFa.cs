using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Tsmt.UI
{
    public partial class ZaFa : Form
    {
        public ZaFa()
        {
            InitializeComponent();
        }
        Model.ZaFaNo zaFaNo;
        int IssueSid;
        private void ZaFa_Load(object sender, EventArgs e)
        {
            this.Text += "[" + Model.Uti.Name +"]";
            Info();
        }
        private void Info()
        {
            labPass.Visible = false;
            labReelNo.Visible = false;
            labYingFaQty.Text = "0";
            labFaQty.Text = "0";
            labNoFaQty.Text = "0";
            labFaPanQty.Text = "0";
            cobPartNo.DataSource = null;
            cobPartNo.Text = "";
            txtReel.ReadOnly = true;
            txtWhere.Text = "";
            txtWH.Text = "";
        }

        private void txtWorkNo_KeyDown(object sender, KeyEventArgs e)
        {
            Info();

            if (e.KeyCode == Keys.Enter)
            {
                string receiverJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/ZaFa.asmx/GetZaFaNo?json=" + txtWorkNo.Text.Trim());
                Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiverJson, typeof(Model.Result));

                if (result.Sid == 0)
                {
                    DAL.LED led = new Tsmt.DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);
                    MessageBox.Show(result.Message);
                    return;
                }

                zaFaNo = (Model.ZaFaNo)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.ZaFaNo));

                #region "cob赋值"
                DataTable tablePartNo = new DataTable();
                tablePartNo.Columns.Add("f001");
                tablePartNo.Columns.Add("f002");

                foreach (Model.FaLiaoPartNo item in zaFaNo.ListFaLiaoPartNo)
                {
                    DataRow dr = tablePartNo.NewRow();
                    dr["f001"] = item.PartNoSid;
                    dr["f002"] = item.PartNo;
                    tablePartNo.Rows.Add(dr);
                }
                cobPartNo.SelectedIndexChanged -= cobPartNo_SelectedIndexChanged;
                cobPartNo.DataSource = tablePartNo;
                cobPartNo.DisplayMember = "f002";
                cobPartNo.ValueMember = "f001";
                cobPartNo.SelectedIndexChanged += cobPartNo_SelectedIndexChanged;
                cobPartNo.SelectedIndex = -1;
                cobPartNo.Focus();
                #endregion
            }
        }

        private void cobPartNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            labPass.Visible = false;
            labReelNo.Visible = false;
            var items = from partNo in zaFaNo.ListFaLiaoPartNo where partNo.PartNoSid == Convert.ToInt32(cobPartNo.SelectedValue) select partNo;

            foreach (Model.FaLiaoPartNo item in items)
            {
                labYingFaQty.Text = item.YingFaQty + "";
                labNoFaQty.Text = item.WeiFaQty + "";
                labFaQty.Text = item.YiFaQty + "";
                labFaPanQty.Text = item.YiFaPan + "";
                txtWhere.Text = item.ChuGe + "";
                IssueSid = item.Sid;
                txtWH.Text = item.WH;
                txtReel.Text = "";

                //数量检查不在管控
                //if (item.WeiFaQty >= 0)
                //{
                //    txtReel.ReadOnly = true;
                //    return;
                //}
                txtReel.ReadOnly = false;
                txtReel.Focus();
            }
        }

        private void txtReel_KeyDown(object sender, KeyEventArgs e)
        {
            labPass.Visible = false;
            labReelNo.Visible = false;

            if (e.KeyCode == Keys.Down)
            {
                if (cobPartNo.SelectedIndex >= cobPartNo.Items.Count - 1)
                {
                    cobPartNo.SelectedIndex = 0;
                    return;
                }
                cobPartNo.SelectedIndex += 1;
                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (cobPartNo.SelectedIndex == 0)
                {
                    return;
                }
                cobPartNo.SelectedIndex -= 1;
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                Model.FaLiaoReelNo reelNo = new Tsmt.Model.FaLiaoReelNo();
                reelNo.ReelNo = txtReel.Text.Trim();
                reelNo.PartNoSid = Convert.ToInt32(cobPartNo.SelectedValue);
                reelNo.UpdateEmp = Model.Uti.SajetNoSid;
                reelNo.DeCode = txtWhere.Text;
                reelNo.IssueNo = txtWorkNo.Text;
                reelNo.IssueSid = IssueSid;
                reelNo.PartNo = cobPartNo.Text;

                string sendJson = JsonConvert.SerializeObject(reelNo);
                string receiverJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/ZaFa.asmx/GetReelNo?json=" + sendJson);

                Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiverJson, typeof(Model.Result));
                if (result.Sid == 0)
                {
                    DAL.LED led = new Tsmt.DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);
                    MessageBox.Show(result.Message);
                    txtReel.SelectAll();
                    return;
                }


                Model.FaLiaoReelNo receiveReelNo = (Model.FaLiaoReelNo)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.FaLiaoReelNo));

                labFaQty.Text = (Convert.ToInt32(labFaQty.Text) + receiveReelNo.Qty) + "";
                labNoFaQty.Text = (Convert.ToInt32(labNoFaQty.Text) + receiveReelNo.Qty) + "";
                labFaPanQty.Text = (Convert.ToInt32(labFaPanQty.Text) + 1) + "";

                labReelNo.Text = receiveReelNo.ReelNo;
                txtReel.Text = "";
                labReelNo.Text = reelNo.ReelNo;
                labPass.Visible = true;
                labReelNo.Visible = true;
                txtReel.Focus();
            }
        }
    }
}