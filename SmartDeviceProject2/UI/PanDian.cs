using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Tsmt.UI
{
    public partial class PanDian : Form
    {
        string fileName = DateTime.Now.Date.ToString("yyyyMMdd") + "-" + Convert.ToString(Model.Uti.UserNo) + ".csv";

        public PanDian()
        {
            InitializeComponent();
        }

        private void txtReelNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sendJson = txtReelNo.Text.Trim();
                string receiveJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/Check.asmx/DianJian?json=" + sendJson + "&filename=" + fileName );
                Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiveJson, typeof(Model.Result));
                if (result.Sid == 0)
                {
                    MessageBox.Show(result.Message);
                    txtReelNo.SelectAll();
                    return;
                }

                Model.FaLiaoReelNo receiveReelNo = (Model.FaLiaoReelNo)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.FaLiaoReelNo));
                this.txtPartNo.Text = receiveReelNo.PartNo;
                this.txtQTY.Text = Convert.ToString(receiveReelNo.Qty);

                //sw.WriteLine(receiveReelNo.PartNo + "," + receiveReelNo.ReelNo + "," + Convert.ToString(receiveReelNo.Qty) + "\n");

                txtReelNo.SelectAll();
            }
        }

        //private void btnUpload_Click(object sender, EventArgs e)
        //{
        //    sw.Close();
        //    string destPath = @"\\10.13.35.49\wh\";
        //    try
        //    {
        //        File.Copy(fileName, destPath + fileName, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Upload Error");
        //        return;
        //    }

        //    MessageBox.Show("上传成功");
        //}
    }
}