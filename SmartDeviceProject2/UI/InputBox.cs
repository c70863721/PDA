using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tsmt.UI
{
    public partial class InputBox : Form
    {
        public string SetValues;

        public InputBox(string setType, string setValues)
            : this()
        {
            SetValues = setValues;
            labType.Text = setType;
        }
        public InputBox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 100);
            txtBox.Text = SetValues;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SetValues = txtBox.Text.Trim();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetValues = txtBox.Text.Trim();
                this.Close();
            }
        }

    }
}