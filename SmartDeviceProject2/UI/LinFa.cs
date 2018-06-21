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
    public partial class LinFa : Form
    {
        public LinFa()
        {
            InitializeComponent();
        }

        Model.FaLiaoWorkNo WorkNo;
        int PartNoSid;
        bool chkPartNo;
        int issueSid = 0;
        string Decode = "";
        string ZhiCheng = "";
        string WH = "";

        private void LinFa_Load(object sender, EventArgs e)
        {
            this.Text += "[" + Model.Uti.Name + "]";
            info();
        }

        private void info()
        {
            this.txtReel.Text = "";
            this.cobLaoJiaBianHao.Text = "";
            this.cobLaoJiaBianHao.DataSource = null;
            labYingFaQty.Text = "0";
            labNoFaQty.Text = "0";
            labFaQty.Text = "0";
            labFaPanQty.Text = "0";
            labReelNo.Visible = false;
            this.labPass.Visible = false;
            this.txtWorkNo.Focus();
        }

        private void txtWorkNo_KeyDown(object sender, KeyEventArgs e)
        {
            info();

            if (e.KeyCode == Keys.Enter)
            {

                string sendJson = txtWorkNo.Text.Trim();

                try
                {
                    string receiveJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/LinFa.asmx/GetWorkNo?json=" + sendJson);
                    
                    Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiveJson, typeof(Model.Result));
                    if (result.Sid == 0)
                    {
                        DAL.LED led = new DAL.LED();
                        led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒
                        MessageBox.Show(result.Message);
                        return;
                    }

                    WorkNo = (Model.FaLiaoWorkNo)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.FaLiaoWorkNo));

                    DataTable dt = new DataTable();
                    dt.Columns.Add("f001"); //sid
                    dt.Columns.Add("f002"); //储位

                    foreach (Model.FaLiaoPartNo item in WorkNo.FaLiaoPartNoList)
                    {
                        DataRow dr = dt.NewRow();
                        dr["f001"] = item.Sid;
                        dr["f002"] = item.ChuGe;
                        dt.Rows.Add(dr);
                    }

                    //DataView dv = dt.DefaultView;
                    //DataTable result = dv.ToTable(true, "f004");

                    //this.cobLaoJiaBianHao.Items.Clear();
                    //this.cobLaoJiaBianHao.BeginUpdate();
                    //for (int i = 0; i < result.Rows.Count; i++)
                    //{

                    //    this.cobLaoJiaBianHao.Items.Add(Convert.ToString(result.Rows[i][0]));
                    //}
                    //this.cobLaoJiaBianHao.EndUpdate();
                    //if (this.cobLaoJiaBianHao.Items.Count > 0)
                    //{
                    //    this.cobLaoJiaBianHao.SelectedIndex = 1;
                    //}

                    cobLaoJiaBianHao.SelectedIndexChanged -= cobLaoJiaBianHao_SelectedIndexChanged;
                    cobLaoJiaBianHao.DataSource = dt;
                    cobLaoJiaBianHao.DisplayMember = "f002";
                    cobLaoJiaBianHao.ValueMember = "f001";
                    cobLaoJiaBianHao.SelectedIndex = -1;
                    cobLaoJiaBianHao.SelectedIndexChanged += cobLaoJiaBianHao_SelectedIndexChanged;

                    cobLaoJiaBianHao.Focus();
                }
                catch (Exception ex)
                {
                    DAL.LED led = new DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cobLaoJiaBianHao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string xiangCi = null;
            string yuLiuDan = null;
            issueSid = 0;

            int Sid = Convert.ToInt32(cobLaoJiaBianHao.SelectedValue);
            string chuge = cobLaoJiaBianHao.Text;

            //this.labPass.Text = cobLaoJiaBianHao.Text + Convert.ToString(cobLaoJiaBianHao.SelectedValue);
            //this.labPass.Visible = true;

            var Query = from cur in WorkNo.FaLiaoPartNoList where cur.Sid == Sid && cur.ChuGe == chuge select cur;
            chkPartNo = false;

            foreach (Model.FaLiaoPartNo item in Query)
            {
                labYingFaQty.Text = item.YingFaQty + "";
                labFaQty.Text = item.YiFaQty + "";
                labNoFaQty.Text = item.WeiFaQty + "";
                labFaPanQty.Text = item.YiFaPan + "";
                Decode = item.ChuGe;
                ZhiCheng = item.ZhiCheng;
                WH = item.WH;
                chkPartNo = item.ChkPartNo;
                PartNoSid = item.PartNoSid;
                this.txtPartNo.Text = item.PartNo;
                xiangCi = item.XiangCi;
                yuLiuDan = item.YuLiuDan;
                issueSid = item.Sid;
            }

            //数量汇总
            var Query1 = from cur in WorkNo.FaLiaoPartNoList where cur.PartNo == this.txtPartNo.Text && cur.WH == WH && cur.YuLiuDan == yuLiuDan && cur.XiangCi == xiangCi group cur by new { cur.YiFaQty, cur.YiFaPan } into g select new { YiFaQty = g.Sum(item => item.YiFaQty), YiFaPan = g.Sum(item => item.YiFaPan) };
            foreach (var item in Query1)
            {

                labFaQty.Text = item.YiFaQty + "";
                labFaPanQty.Text = item.YiFaPan + "";
                //MessageBox.Show(labFaQty.Text);
                //MessageBox.Show(yuLiuDan);
            }
            labNoFaQty.Text = (Convert.ToInt32(labFaQty.Text) - Convert.ToInt32(labYingFaQty.Text)) + "";


            txtReel.ReadOnly = false;
            txtReel.Focus();

            ////比对料号
            //if (chkPartNo)
            //{
            //    Point pointPartNo = txtPartNo.Location;
            //    panel1.Location = new Point(12, pointPartNo.Y + 25);
            //    txtPartNo.ReadOnly = false;
            //    txtPartNo.Text = "";
            //    txtPartNo.Focus();
            //}
            //else
            //{
            //    txtPartNo.ReadOnly = true;
            //    txtReel.ReadOnly = false;
            //    txtReel.Focus();
            //}
        }

        private void txtReel_KeyDown(object sender, KeyEventArgs e)
        {
            labReelNo.Visible = false;
            this.labPass.Visible = false;
            txtReelQty.Text = "";

            if (e.KeyCode == Keys.Down)
            {
                if (cobLaoJiaBianHao.SelectedIndex >= cobLaoJiaBianHao.Items.Count - 1)
                {
                    cobLaoJiaBianHao.SelectedIndex = 0;
                    return;
                }
                cobLaoJiaBianHao.SelectedIndex += 1;

                return;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (cobLaoJiaBianHao.SelectedIndex == 0)
                {
                    return;
                }
                cobLaoJiaBianHao.SelectedIndex -= 1;
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                Model.FaLiaoReelNo reelNo = new Tsmt.Model.FaLiaoReelNo();

                reelNo.CustType = WorkNo.CustType;
                reelNo.ReelNo = txtReel.Text.Trim();
                reelNo.PartNo = txtPartNo.Text;
                reelNo.IssueSid = issueSid;
                reelNo.UpdateEmp = Model.Uti.SajetNoSid;
                reelNo.WorkNo = txtWorkNo.Text;
                reelNo.PartNoYingFaQty = Convert.ToInt32(labYingFaQty.Text);
                reelNo.DeCode = Decode;
                reelNo.PartNoSid = PartNoSid;
                try
                {
                    string sendJson = JsonConvert.SerializeObject(reelNo);
                    string receiveJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/LinFa.asmx/GetReelNo?json=" + sendJson);
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
                    this.labPass.Visible = true;
                    labReelNo.Visible = true;
                    txtReel.Text = "";

                    //Model.FaLiaoPartNo mPartNo = WorkNo.FaLiaoPartNoList.Find((Model.FaLiaoPartNo partNo) => partNo.Sid == reelNo.IssueSid);

                    //mPartNo.YingFaQty = Convert.ToInt32(labYingFaQty.Text);
                    //mPartNo.YiFaQty = Convert.ToInt32(labFaQty.Text);
                    //mPartNo.WeiFaQty = Convert.ToInt32(labNoFaQty.Text);
                    //mPartNo.YiFaPan = Convert.ToInt32(labFaPanQty.Text);

                    //if (chkPartNo)
                    //{
                    //    txtPartNo.Text = "";
                    //    txtPartNo.Focus();
                    //}
                    //else
                    //{
                    //    txtReel.Focus();
                    //}
                    //this.cobLaoJiaBianHao.Focus();
                    if (cobLaoJiaBianHao.SelectedIndex >= cobLaoJiaBianHao.Items.Count - 1)
                    {
                        cobLaoJiaBianHao.SelectedIndex = 0;
                    }
                    cobLaoJiaBianHao.SelectedIndex += 1;

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sendJson = txtWorkNo.Text.Trim();

            if (sendJson.Length == 0)
            {
                return;
            }

            try
            {
                string receiveJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/LinFa.asmx/GetWorkNo?json=" + sendJson);

                Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiveJson, typeof(Model.Result));
                if (result.Sid == 0)
                {
                    DAL.LED led = new DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒
                    MessageBox.Show(result.Message);
                    return;
                }

                WorkNo = (Model.FaLiaoWorkNo)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.FaLiaoWorkNo));

                DataTable dt = new DataTable();
                dt.Columns.Add("f001"); //sid
                dt.Columns.Add("f002"); //储位

                foreach (Model.FaLiaoPartNo item in WorkNo.FaLiaoPartNoList)
                {
                    DataRow dr = dt.NewRow();
                    dr["f001"] = item.Sid;
                    dr["f002"] = item.ChuGe;
                    dt.Rows.Add(dr);
                }

                cobLaoJiaBianHao.SelectedIndexChanged -= cobLaoJiaBianHao_SelectedIndexChanged;
                cobLaoJiaBianHao.DataSource = dt;
                cobLaoJiaBianHao.DisplayMember = "f002";
                cobLaoJiaBianHao.ValueMember = "f001";
                cobLaoJiaBianHao.SelectedIndex = -1;
                cobLaoJiaBianHao.SelectedIndexChanged += cobLaoJiaBianHao_SelectedIndexChanged;

                cobLaoJiaBianHao.Focus();
            }
            catch (Exception ex)
            {
                DAL.LED led = new DAL.LED();
                led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒
                MessageBox.Show(ex.Message);
            }
        }

    }
}