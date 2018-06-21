using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Microsoft.WindowsCE.Forms;
using Microsoft.Win32;
using Tsmt.UI;

namespace Tsmt
{
    public partial class Login : Form
    {
        UI.Main main;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassWord.Text = "";
            txtUser.Focus();
            RegistryInfo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccLogin();

        }
        private void AccLogin()
        {
            DateTime beginDT = DateTime.Now;
            Model.User user = new Model.User();
            user.UserNo = txtUser.Text;
            user.PassWord = txtPassWord.Text;

            string sendJson = JsonConvert.SerializeObject(user).ToString();     //序列号对象

            string receiveJson = Data.HttpHelp.HttpGet(Model.Uti.Url + "/Account.asmx/GetAccount?json=" + sendJson);

            Model.Result result = (Model.Result)JsonConvert.DeserializeObject(receiveJson, typeof(Model.Result));

            if (result == null)
            {
                DAL.LED led = new DAL.LED();
                led.SetLedStatus(DAL.LED.Status.ON, 500);//震动毫秒           

                return;
            }
            else
            {
                user = (Model.User)JsonConvert.DeserializeObject(result.Data.ToString(), typeof(Model.User));
                //user = (Model.User)result.Data;
                if (result.Sid == 0)
                {
                    MessageBox.Show(result.Message);
                    DAL.LED led = new DAL.LED();
                    led.SetLedStatus(DAL.LED.Status.ON, 500);//震动500毫秒

                    return;
                }
            }


            Model.Uti.Name = user.Name;
            Model.Uti.UserNo = user.UserNo;
            Model.Uti.UserNoSid = user.SFCSid;
            Model.Uti.SajetNoSid = user.SajetSid;

            if (main == null)
            {
                main = new UI.Main(this);
            }
            //DateTime endDT = DateTime.Now;
            //string k = (endDT - beginDT).ToString();
            //MessageBox.Show(k + "");
            this.Hide();
            main.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtPassWord.Text = "";
            txtUser.Text = "";

            txtUser.Focus();
        }

        private void RegistryInfo()
        {

            RegistryKey key = Registry.CurrentUser.OpenSubKey("TSMT");
            if (key == null)
            {
                RegistryKey key1 = Registry.CurrentUser.CreateSubKey("TSMT");
                key1.SetValue("URL", Model.Uti.Url);
                key1.SetValue("FACTORY", Model.Uti.Factory);
            }
            else
            {
                Model.Uti.Url = (string)key.GetValue("URL");
                Model.Uti.Factory = (string)key.GetValue("FACTORY");
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox("服务器", Model.Uti.Url);
            inputBox.ShowDialog();
            Model.Uti.Url = inputBox.SetValues;

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TSMT");

            key.SetValue("URL", Model.Uti.Url);
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox("厂区", Model.Uti.Factory);
            inputBox.ShowDialog();
            Model.Uti.Factory = inputBox.SetValues;

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TSMT");

            key.SetValue("FACTORY", Model.Uti.Factory);
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassWord.Text = "";
                txtPassWord.Focus();
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AccLogin();
            }
        }
    }
}