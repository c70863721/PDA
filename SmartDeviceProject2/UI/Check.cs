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
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }
        Dictionary<string, PartNoCollect> dictPartNo;
        Dictionary<string, string> dictChuGe;
        List<string> list;
        private void txtReelNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sendJson = txtReelNo.Text.Trim();
                if (dictPartNo == null)
                {
                    dictPartNo = new Dictionary<string, PartNoCollect>();
                }
                if (dictChuGe == null)
                {
                    dictChuGe = new Dictionary<string, string>();
                }
                if (list == null)
                {
                    list = new List<string>();
                }
                if (list.Contains(sendJson))
                {
                    MessageBox.Show("重复扫描");
                    txtReelNo.SelectAll();
                    return;
                }

                string receiveJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/Check.asmx/GetReelNo?json=" + sendJson);
                Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiveJson, typeof(Model.Result));
                if (result.Sid == 0)
                {
                    MessageBox.Show(result.Message);
                    txtReelNo.SelectAll();
                    return;
                }

                list.Add(sendJson);

                Model.FaLiaoReelNo receiveReelNo = (Model.FaLiaoReelNo)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.FaLiaoReelNo));

                PartNoCollect partNoCollect;
                if (!dictPartNo.ContainsKey(receiveReelNo.PartNo))
                {
                    partNoCollect = new PartNoCollect();
                    partNoCollect.SumQty = receiveReelNo.Qty;
                    partNoCollect.PanQty = 1;
                    partNoCollect.PartNo = receiveReelNo.PartNo;

                    dictPartNo.Add(receiveReelNo.PartNo, partNoCollect);
                }
                else
                {
                    partNoCollect = dictPartNo[receiveReelNo.PartNo];
                    partNoCollect.SumQty += receiveReelNo.Qty;
                    partNoCollect.PanQty += 1;
                    partNoCollect.PartNo = receiveReelNo.PartNo;
                }

                labQty.Text = receiveReelNo.Qty + "";     //当盘数量
                txtPartNo.Text = partNoCollect.PartNo;    //料号
                txtUsdQty.Text = partNoCollect.SumQty + "";  //汇总数量
                txtUsdPan.Text = partNoCollect.PanQty + "";
                txtFactory.Text = receiveReelNo.DeCode;  //工厂
                txtHourse.Text = GetChuGe(txtFactory.Text.Substring(0, 4), txtFactory.Text.Substring(4, 4), partNoCollect.PartNo);   //储格
                txtReelNo.SelectAll();
            }
        }
        private string GetChuGe(string factory, string warehous, string partNo)
        {
            if (dictChuGe.ContainsKey(factory + warehous + partNo))
            {
                return dictChuGe[factory + warehous + partNo];
            }
            else
            {
                string chuGe = "";
                chuGe = Data.HttpHelp.HttpGet(Model.Uti.Url + string.Format("/RFCCALL.asmx/GetChuGe?factory={0}&warehouse={1}&partNo={2}", factory, warehous, partNo));
                if (chuGe.Length > 0)
                {
                    dictChuGe.Add(factory + warehous + partNo, chuGe);
                }
                return chuGe;
            }
        }
        private class PartNoCollect
        {
            public int PanQty;
            public int SumQty;
            public string PartNo;
        }

        private void Check_Load(object sender, EventArgs e)
        {
            this.Text += "[" + Model.Uti.Name + "]";
        }
    }
}