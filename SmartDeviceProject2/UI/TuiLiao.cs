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
    public partial class TuiLiao : Form
    {
        public TuiLiao()
        {
            InitializeComponent();
        }

        private void TuiLiao_Load(object sender, EventArgs e)
        {
            this.Text += "[" + Model.Uti.Name +"]";
            Info();
        }
        private void Info()
        {
            txtPartNo.Text = "";
            txtDecode.Text = "";
            txtQty.Text = "";
            txtWorkNo.Text = "";
            txtStatus.Text = "";
            txtWH.Text = "";
            labReelNo.Visible = false;
            labPass.Visible = false;
        }

        private void txtReel_KeyDown(object sender, KeyEventArgs e)
        {
            Info();

            if (e.KeyCode == Keys.Enter)
            {
                string sendJson = "reelno=" + txtReel.Text + "&" + "empsid=" + Model.Uti.SajetNoSid;
                try
                {
                    string receiverJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/TuiLiao.asmx/GetTuiLiao?" + sendJson);

                    Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiverJson, typeof(Model.Result));
                    Model.TuiLiaoReelNo reelNo;

                    if (result.Sid == 0)
                    {
                        DAL.LED led = new DAL.LED();
                        led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒                     
                        MessageBox.Show(result.Message);
                        txtReel.SelectAll();
                        return;
                    }
                    else
                    {
                        reelNo = (Model.TuiLiaoReelNo)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.TuiLiaoReelNo));

                        if (reelNo != null)
                        {
                            txtPartNo.Text = reelNo.PartNo;
                            txtDecode.Text = reelNo.DeCode;
                            txtQty.Text = reelNo.Qty + "";
                            txtStatus.Text = reelNo.Status;
                            txtWorkNo.Text = reelNo.WorkNo;
                            txtWH.Text = reelNo.WH;
                            labReelNo.Text = reelNo.ReelNo;
                            labReelNo.Visible = true;
                            labPass.Visible = true;
                            txtReel.Text = "";
                            txtReel.Focus();
                        }
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
    }
}