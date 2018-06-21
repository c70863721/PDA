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
    public partial class LinTui : Form
    {
        private Boolean chkChuGe = false;

        public LinTui()
        {
            InitializeComponent();
        }

        private void LinTui_Load(object sender, EventArgs e)
        {
            this.Text += "[" + Model.Uti.Name + "]";
            Info();
        }

        private void Info()
        {
            txtReelNO.Text = "";
            txtPartNo.Text = "";
            txtQty.Text = "";
            txtWorkNo.Text = "";
            txtStatus.Text = "";
            labReelNo.Visible = false;
            labPass.Visible = false;
            chkChuGe = false;
        }

        private void txtChuGe_KeyDown(object sender, KeyEventArgs e)
        {
            //检查储格是否存在及是否为空
            Info();
            if (e.KeyCode == Keys.Enter)
            {
                if (txtChuGe.Text.Trim().Length == 0)
                {
                    DAL.LED led = new DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒                     
                    MessageBox.Show("储格不能为空");
                    chkChuGe = false;
                    this.txtChuGe.Focus();
                    txtChuGe.SelectAll();
                    return;
                }
                string sendJson = "chuge=" + txtChuGe.Text;
                try
                {
                    string receiverJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/LinTui.asmx/CheckChuGe?" + sendJson);

                    Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiverJson, typeof(Model.Result));

                    if (result.Sid == 0)
                    {
                        DAL.LED led = new DAL.LED();
                        led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒                     
                        MessageBox.Show(result.Message);
                        chkChuGe = false;
                        txtChuGe.Focus();
                        txtChuGe.SelectAll();
                        return;
                    }
                    else
                    {
                        chkChuGe = true;
                        this.txtReelNO.Text = "";
                        this.txtReelNO.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    DAL.LED led = new Tsmt.DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);
                    MessageBox.Show(ex.Message);
                    chkChuGe = false;
                    this.txtChuGe.Focus();
                    this.txtChuGe.SelectAll();
                    return;
                }
            }
        }

        private void txtReelNO_KeyDown(object sender, KeyEventArgs e)
        {
            //检查chkChuGe的状态
            if (!chkChuGe)
            {
                DAL.LED led = new DAL.LED();
                led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒                     
                MessageBox.Show("储格不能为空");
                chkChuGe = false;
                txtChuGe.Focus();
                txtChuGe.SelectAll();
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                //检查料卷编号是否为空
                if (this.txtReelNO.Text.Trim().Length == 0)
                {
                    DAL.LED led = new DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒                     
                    MessageBox.Show("料卷不能为空");
                    this.txtReelNO.Focus();
                    this.txtReelNO.SelectAll();
                    return;
                }

                string sendJson = "chuge=" + txtChuGe.Text + "&" + "reelno=" + this.txtReelNO.Text + "&"  + "empsid=" + Model.Uti.SajetNoSid;
                try
                {
                    string receiverJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/LinTui.asmx/GetTuiLiao?" + sendJson);

                    Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiverJson, typeof(Model.Result));
                    Model.TuiLiaoReelNo reelNo;

                    if (result.Sid == 0)
                    {
                        DAL.LED led = new DAL.LED();
                        led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒                     
                        MessageBox.Show(result.Message);
                        this.txtReelNO.Focus();
                        this.txtReelNO.SelectAll();
                        return;
                    }
                    else
                    {
                        reelNo = (Model.TuiLiaoReelNo)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.TuiLiaoReelNo));

                        if (reelNo != null)
                        {
                            txtPartNo.Text = reelNo.PartNo;
                            txtQty.Text = reelNo.Qty + "";
                            txtStatus.Text = reelNo.Status;
                            txtWorkNo.Text = reelNo.WorkNo;
                            labReelNo.Text = reelNo.ReelNo;
                            labReelNo.Visible = true;
                            labPass.Visible = true;
                        }
                        this.txtChuGe.SelectAll();
                        this.txtChuGe.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    DAL.LED led = new Tsmt.DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);
                    MessageBox.Show(ex.Message);
                    this.txtReelNO.Focus();
                    this.txtReelNO.SelectAll();
                    return;
                }
            }
        }

    }
}