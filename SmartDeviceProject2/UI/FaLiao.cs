using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Tsmt
{
    public partial class FaLiao : Form
    {
        public FaLiao()
        {
            InitializeComponent();
        }

        Model.FaLiaoWorkNo WorkNo;
        int PartNoSid;
        bool chkPartNo;
        private void FaLiao_Load(object sender, EventArgs e)
        {
            this.Text += "[" + Model.Uti.Name + "]";
            info();
        }

        private void txtReel_KeyDown(object sender, KeyEventArgs e)
        {
            labReelNo.Visible = false;
            labOK.Visible = false;
            txtReelQty.Text = "";

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

                reelNo.CustType = WorkNo.CustType;
                reelNo.ReelNo = txtReel.Text.Trim();
                reelNo.PartNo = cobPartNo.Text;
                reelNo.IssueSid = Convert.ToInt32(cobPartNo.SelectedValue);
                reelNo.UpdateEmp = Model.Uti.SajetNoSid;
                reelNo.WorkNo = txtWorkNo.Text;
                reelNo.PartNoYingFaQty = Convert.ToInt32(labYingFaQty.Text);
                reelNo.DeCode = txtDecode.Text;
                reelNo.PartNoSid = PartNoSid;
                try
                {
                    string sendJson = JsonConvert.SerializeObject(reelNo);
                    string receiveJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/FaLiao.asmx/GetReelNo?json=" + sendJson);
                    Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiveJson, typeof(Model.Result));
                    if (result.Sid == 0)
                    {
                        MessageBox.Show(result.Message);
                        txtReel.SelectAll();
                        return;
                    }

                    Model.FaLiaoReelNo receiveReelNo = (Model.FaLiaoReelNo)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.FaLiaoReelNo));

                    labFaQty.Text = (Convert.ToInt32(labFaQty.Text) + receiveReelNo.Qty) + "";
                    labNoFaQty.Text = (Convert.ToInt32(labNoFaQty.Text) + receiveReelNo.Qty) + "";
                    labFaPanQty.Text = (Convert.ToInt32(labFaPanQty.Text) + 1) + "";

                    txtReelQty.Text = receiveReelNo.Qty + "";
                    labReelNo.Text = receiveReelNo.ReelNo;
                    labOK.Visible = true;
                    labReelNo.Visible = true;
                    txtReel.Text = "";

                    Model.FaLiaoPartNo mPartNo = WorkNo.FaLiaoPartNoList.Find((Model.FaLiaoPartNo partNo) => partNo.Sid == reelNo.IssueSid);

                    mPartNo.YingFaQty = Convert.ToInt32(labYingFaQty.Text);
                    mPartNo.YiFaQty = Convert.ToInt32(labFaQty.Text);
                    mPartNo.WeiFaQty = Convert.ToInt32(labNoFaQty.Text);
                    mPartNo.YiFaPan = Convert.ToInt32(labFaPanQty.Text);

                    if (chkPartNo)
                    {
                        txtPartNo.Text = "";
                        txtPartNo.Focus();
                    }
                    else
                    {
                        txtReel.Focus();
                    }
                }
                catch (Exception ex)
                {
                    DAL.LED led = new Tsmt.DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);
                    MessageBox.Show(ex.Message);
                    txtReel.SelectAll();
                }

            }
        }

        private void txtWorkNo_KeyDown(object sender, KeyEventArgs e)
        {
            info();

            if (e.KeyCode == Keys.Enter)
            {

                string sendJson = txtWorkNo.Text.Trim();

                try
                {
                    string receiveJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/FaLiao.asmx/GetWorkNo?json=" + sendJson);

                    Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiveJson, typeof(Model.Result));
                    if (result.Sid == 0)
                    {
                        DAL.LED led = new DAL.LED();
                        led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒
                        MessageBox.Show(result.Message);
                        return;
                    }

                    WorkNo = (Model.FaLiaoWorkNo)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.FaLiaoWorkNo));

                    #region "机种列表赋值"
                    DataTable dt = new DataTable();
                    dt.Columns.Add("f001");
                    dt.Columns.Add("f002");
                    foreach (Model.FaLiaoPartNo item in WorkNo.FaLiaoPartNoList)
                    {
                        DataRow dr = dt.NewRow();
                        dr["f001"] = item.Sid;
                        dr["f002"] = item.PartNo;
                        dt.Rows.Add(dr);
                    }
                    cobPartNo.SelectedIndexChanged -= cobPartNo_SelectedIndexChanged;
                    cobPartNo.DataSource = dt;
                    cobPartNo.DisplayMember = "f002";
                    cobPartNo.ValueMember = "f001";
                    cobPartNo.SelectedIndex = -1;
                    cobPartNo.SelectedIndexChanged += cobPartNo_SelectedIndexChanged;

                    cobPartNo.Focus();
                    #endregion

                    cobPartNo.Focus();
                }
                catch (Exception ex)
                {
                    DAL.LED led = new DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void cobPartNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtReel.Text = "";
            txtReel.ReadOnly = true;
            string xiangCi = null;
            string yuLiuDan = null;

            int Sid = Convert.ToInt32(cobPartNo.SelectedValue);
            var Query = from cur in WorkNo.FaLiaoPartNoList where cur.Sid == Sid select cur;
            chkPartNo = false;

            foreach (Model.FaLiaoPartNo item in Query)
            {
                labYingFaQty.Text = item.YingFaQty + "";
                labFaQty.Text = item.YiFaQty + "";
                labNoFaQty.Text = item.WeiFaQty + "";
                labFaPanQty.Text = item.YiFaPan + "";
                txtDecode.Text = item.ChuGe;
                txtZhiCheng.Text = item.ZhiCheng;
                txtWH.Text = item.WH;
                chkPartNo = item.ChkPartNo;
                PartNoSid = item.PartNoSid;
                xiangCi = item.XiangCi;
                yuLiuDan = item.YuLiuDan;
                //数量管控不在检查
                //if (item.WeiFaQty >= 0)
                //{
                //    cobPartNo.Focus();
                //    return;
                //}

            }

            //数量汇总
            var Query1 = from cur in WorkNo.FaLiaoPartNoList where cur.PartNo == cobPartNo.Text && cur.WH == txtWH.Text && cur.YuLiuDan == yuLiuDan && cur.XiangCi == xiangCi group cur by new { cur.YiFaQty, cur.YiFaPan } into g select new { YiFaQty = g.Sum(item => item.YiFaQty), YiFaPan = g.Sum(item => item.YiFaPan) };
            foreach (var item in Query1)
            {
               
                labFaQty.Text = item.YiFaQty + "";
                labFaPanQty.Text = item.YiFaPan + "";
                //MessageBox.Show(labFaQty.Text);
                //MessageBox.Show(yuLiuDan);
            }
            labNoFaQty.Text = (Convert.ToInt32(labFaQty.Text) - Convert.ToInt32(labYingFaQty.Text)) + "";

            //比对料号
            if (chkPartNo)
            {
                Point pointPartNo = txtPartNo.Location;
                panel1.Location = new Point(12, pointPartNo.Y + 25);
                txtPartNo.ReadOnly = false;
                txtPartNo.Text = "";
                txtPartNo.Focus();
            }
            else
            {
                txtPartNo.ReadOnly = true;
                txtReel.ReadOnly = false;
                txtReel.Focus();
            }
        }
        private void info()
        {
            panel1.Location = new Point(12, 185);
            txtPartNo.ReadOnly = true;
            cobPartNo.DataSource = null;
            cobPartNo.Text = "";
            cobPartNo.Text = "";
            labYingFaQty.Text = "0";
            labFaQty.Text = "0";
            labNoFaQty.Text = "0";
            labFaPanQty.Text = "0";
            txtReel.Text = "";
            txtReelQty.Text = "";
            txtDecode.Text = "";
            txtZhiCheng.Text = "";
            labReelNo.Visible = false;
            labOK.Visible = false;
            txtReel.ReadOnly = true;
            txtWH.Text = "";
            txtPartNo.Text = "";
            txtWorkNo.Focus();
        }

        private void txtPartNo_KeyDown(object sender, KeyEventArgs e)
        {
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
                if (!txtPartNo.Text.Equals(cobPartNo.Text))
                {
                    MessageBox.Show("料号比对错误");
                    txtPartNo.SelectAll();
                    txtPartNo.Focus();
                    return;
                }
                txtReel.ReadOnly = false;
                txtReel.Focus();
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}