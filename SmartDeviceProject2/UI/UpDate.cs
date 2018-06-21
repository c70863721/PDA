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
    public partial class UpDate : Form
    {
        public UpDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sendJson = txtWorkNo.Text.Trim();

            string receiveJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/FaLiaoRFCUpdate.asmx/Update?json=" + sendJson);

            Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiveJson, typeof(Model.Result));
            if (result.Sid == 0)
            {
                DAL.LED led = new DAL.LED();
                led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒
                MessageBox.Show(result.Message);
                return;
            }
            else
            {
                MessageBox.Show("更新成功");
            }
        }
    }
}