using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace Tsmt.UI
{
    public partial class Main : Form
    {
        Login login;
        FaLiao faLiao;
        TuiLiao tuiLiao;
        ZaFa zaFa;
        UpDate upDate;
        Check check;
        LinFa linFa;
        LinTui linTui;
        PanDian panDian;

        public Main()
        {
            InitializeComponent();
        }
        public Main(Login _form)
            : this()
        {
            login = _form;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Text += "[" + Model.Uti.Name + "]";
            Rectangle rectangle = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            int y = 30;
            int x = rectangle.Width;
            int _height = panel1.Height + 10;
            int x1 = (x / 2 - panel1.Width) / 2;
            int x2 = x - x1 - panel2.Width;
            panel1.Location = new Point(x1, y);
            panel2.Location = new Point(x2, y);
            y += _height ;
            panel3.Location = new Point(x1, y);
            panel4.Location = new Point(x2, y);
            y += _height ;
            panel5.Location = new Point(x1, y);
            panel6.Location = new Point(x2, y);
            y += _height ;
            panel7.Location = new Point(x1, y);
            panel8.Location = new Point(x2, y);

            UpdateVer();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (faLiao != null)
            {
                faLiao.Close();
            }
            if (tuiLiao != null)
            {
                tuiLiao.Close();
            }
            if (zaFa != null)
            {
                zaFa.Close();
            }
            if (upDate != null)
            {
                upDate.Close();
            }
            login.txtPassWord.Text = "";
            login.Show();
            this.Close();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox("厂区", Model.Uti.Factory);
            inputBox.ShowDialog();
            Model.Uti.Factory = inputBox.SetValues;

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TSMT");

            key.SetValue("FACTORY", Model.Uti.Factory);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (faLiao == null)
            {
                faLiao = new FaLiao();
            }
            else
            {
                faLiao.Close();
                faLiao = new FaLiao();

            }

            faLiao.Show();
        }

        private void Main_Closed(object sender, EventArgs e)
        {
            //string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            //path = path.Replace(@"\Tsmt.exe","");
            //using (System.Diagnostics.Process process = new System.Diagnostics.Process())
            //{
            //    process.StartInfo.FileName = path + @"\update.exe";
            //    process.Start();
            //}
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (tuiLiao == null)
            {
                tuiLiao = new TuiLiao();
            }
            else
            {
                tuiLiao.Close();
                tuiLiao = new TuiLiao();
            }

            tuiLiao.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (zaFa == null)
            {
                zaFa = new ZaFa();
            }
            else
            {
                zaFa.Close();
                zaFa = new ZaFa();
            }
            zaFa.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox("服务器", Model.Uti.Url);
            inputBox.ShowDialog();
            Model.Uti.Url = inputBox.SetValues;

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TSMT");

            key.SetValue("URL", Model.Uti.Url);

        }
        private void UpdateVer()
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(VersionChk));
            thread.IsBackground = true;
            thread.Start();
        }
        private void VersionChk()
        {
            System.Threading.Thread.Sleep(2000);
            string path = GetCurrentPath();
            if (File.Exists(path + @"\Version.xml"))
            {
                string iisVersion = Data.HttpHelp.HttpGet(Model.Uti.Url + "/DownLoad/Version.xml");
                //DataSet ds = new DataSet();
                //ds.ReadXml(ds, XmlReadMode.Auto);
                //DataTable dt = ds[0];

                string localVersion = "";
                using (StreamReader sr = new StreamReader(path + @"\Version.xml"))
                {
                    localVersion = sr.ReadToEnd();
                }

                if (!localVersion.Equals(iisVersion))
                {
                    DialogResult dr = MessageBox.Show("发现新版本,请确认更新", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

                    if (dr.ToString().Equals("Yes"))
                    {
                        System.Diagnostics.Process.Start(path + @"\TSMTUpdate.exe", null);
                        //System.Diagnostics.Process.GetCurrentProcess().Kill();
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
        }
        private string GetCurrentPath()
        {
            string appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            System.IO.FileInfo fi = new System.IO.FileInfo(appName);
            string path = fi.DirectoryName;
            return path;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (upDate == null)
            {
                upDate = new UpDate();
            }
            else
            {
                upDate.Close();
                upDate = new UpDate();

            }

            upDate.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //if (check == null)
            //{
            //    check = new Check();
            //}
            //else
            //{
            //    check.Close();
            //    check = new Check();
            //}

            //check.Show();
            if (panDian == null)
            {
                panDian = new PanDian();
            }
            else
            {
                panDian.Close();
                panDian = new PanDian();
            }
            panDian.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (linFa == null)
            {
                linFa = new LinFa();
            }
            else
            {
                linFa.Close();
                linFa = new LinFa();
            }
            linFa.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (linTui == null)
            {
                linTui = new LinTui();
            }
            else
            {
                linTui.Close();
                linTui = new LinTui();
            }
            linTui.Show();
        }
    }
}