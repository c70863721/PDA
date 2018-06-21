namespace Tsmt
{
    partial class FaLiao
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaLiao));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cobPartNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labYingFaQty = new System.Windows.Forms.Label();
            this.labNoFaQty = new System.Windows.Forms.Label();
            this.labFaQty = new System.Windows.Forms.Label();
            this.labFaPanQty = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReelQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.labReelNo = new System.Windows.Forms.Label();
            this.labOK = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtZhiCheng = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWH = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.Text = "工单";
            // 
            // txtWorkNo
            // 
            this.txtWorkNo.Location = new System.Drawing.Point(64, 6);
            this.txtWorkNo.MaxLength = 10;
            this.txtWorkNo.Name = "txtWorkNo";
            this.txtWorkNo.Size = new System.Drawing.Size(139, 21);
            this.txtWorkNo.TabIndex = 0;
            this.txtWorkNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkNo_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.Text = "料号";
            // 
            // cobPartNo
            // 
            this.cobPartNo.Location = new System.Drawing.Point(64, 33);
            this.cobPartNo.Name = "cobPartNo";
            this.cobPartNo.Size = new System.Drawing.Size(139, 22);
            this.cobPartNo.TabIndex = 1;
            this.cobPartNo.SelectedIndexChanged += new System.EventHandler(this.cobPartNo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.Text = "应发数:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(124, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.Text = "已发数:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.Text = "未发数:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(124, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.Text = "已发盘:";
            // 
            // labYingFaQty
            // 
            this.labYingFaQty.Location = new System.Drawing.Point(65, 88);
            this.labYingFaQty.Name = "labYingFaQty";
            this.labYingFaQty.Size = new System.Drawing.Size(53, 21);
            this.labYingFaQty.Text = "99999";
            // 
            // labNoFaQty
            // 
            this.labNoFaQty.Location = new System.Drawing.Point(65, 109);
            this.labNoFaQty.Name = "labNoFaQty";
            this.labNoFaQty.Size = new System.Drawing.Size(53, 21);
            this.labNoFaQty.Text = "99999";
            // 
            // labFaQty
            // 
            this.labFaQty.Location = new System.Drawing.Point(176, 88);
            this.labFaQty.Name = "labFaQty";
            this.labFaQty.Size = new System.Drawing.Size(50, 21);
            this.labFaQty.Text = "99999";
            // 
            // labFaPanQty
            // 
            this.labFaPanQty.Location = new System.Drawing.Point(176, 109);
            this.labFaPanQty.Name = "labFaPanQty";
            this.labFaPanQty.Size = new System.Drawing.Size(50, 21);
            this.labFaPanQty.Text = "99999";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 21);
            this.label7.Text = "料卷";
            // 
            // txtReel
            // 
            this.txtReel.Location = new System.Drawing.Point(51, 7);
            this.txtReel.MaxLength = 30;
            this.txtReel.Name = "txtReel";
            this.txtReel.ReadOnly = true;
            this.txtReel.Size = new System.Drawing.Size(139, 21);
            this.txtReel.TabIndex = 0;
            this.txtReel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReel_KeyDown);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 21);
            this.label8.Text = "数量";
            // 
            // txtReelQty
            // 
            this.txtReelQty.Location = new System.Drawing.Point(51, 36);
            this.txtReelQty.MaxLength = 10;
            this.txtReelQty.Name = "txtReelQty";
            this.txtReelQty.ReadOnly = true;
            this.txtReelQty.Size = new System.Drawing.Size(139, 21);
            this.txtReelQty.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(23, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 21);
            this.label9.Text = "储格";
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(64, 133);
            this.txtDecode.MaxLength = 20;
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.ReadOnly = true;
            this.txtDecode.Size = new System.Drawing.Size(139, 21);
            this.txtDecode.TabIndex = 4;
            // 
            // labReelNo
            // 
            this.labReelNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labReelNo.ForeColor = System.Drawing.Color.Blue;
            this.labReelNo.Location = new System.Drawing.Point(51, 58);
            this.labReelNo.Name = "labReelNo";
            this.labReelNo.Size = new System.Drawing.Size(148, 21);
            this.labReelNo.Text = "TS321ASDFASDF";
            this.labReelNo.Visible = false;
            // 
            // labOK
            // 
            this.labOK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labOK.ForeColor = System.Drawing.Color.Blue;
            this.labOK.Location = new System.Drawing.Point(78, 75);
            this.labOK.Name = "labOK";
            this.labOK.Size = new System.Drawing.Size(75, 21);
            this.labOK.Text = "过账OK";
            this.labOK.Visible = false;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 21);
            this.label12.Text = "制程别";
            // 
            // txtZhiCheng
            // 
            this.txtZhiCheng.Location = new System.Drawing.Point(64, 161);
            this.txtZhiCheng.MaxLength = 20;
            this.txtZhiCheng.Name = "txtZhiCheng";
            this.txtZhiCheng.ReadOnly = true;
            this.txtZhiCheng.Size = new System.Drawing.Size(139, 21);
            this.txtZhiCheng.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(23, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 21);
            this.label10.Text = "仓别";
            // 
            // txtWH
            // 
            this.txtWH.Location = new System.Drawing.Point(64, 61);
            this.txtWH.MaxLength = 20;
            this.txtWH.Name = "txtWH";
            this.txtWH.ReadOnly = true;
            this.txtWH.Size = new System.Drawing.Size(139, 21);
            this.txtWH.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtReel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labReelNo);
            this.panel1.Controls.Add(this.labOK);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtReelQty);
            this.panel1.Location = new System.Drawing.Point(12, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 100);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(23, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 21);
            this.label11.Text = "料号";
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(64, 190);
            this.txtPartNo.MaxLength = 20;
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.ReadOnly = true;
            this.txtPartNo.Size = new System.Drawing.Size(139, 21);
            this.txtPartNo.TabIndex = 2;
            this.txtPartNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartNo_KeyDown);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.Text = "菜单";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "工单明细更新";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // FaLiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cobPartNo);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.txtZhiCheng);
            this.Controls.Add(this.txtWH);
            this.Controls.Add(this.txtDecode);
            this.Controls.Add(this.txtWorkNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labNoFaQty);
            this.Controls.Add(this.labFaPanQty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labFaQty);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labYingFaQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaLiao";
            this.Text = "发料";
            this.Load += new System.EventHandler(this.FaLiao_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobPartNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labYingFaQty;
        private System.Windows.Forms.Label labNoFaQty;
        private System.Windows.Forms.Label labFaQty;
        private System.Windows.Forms.Label labFaPanQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReelQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.Label labReelNo;
        private System.Windows.Forms.Label labOK;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtZhiCheng;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}