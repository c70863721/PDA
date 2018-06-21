namespace Tsmt.UI
{
    partial class Check
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsdPan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsdQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHourse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.labQty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.Text = "盘点【零数料】";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.Text = "料卷";
            // 
            // txtReelNo
            // 
            this.txtReelNo.Location = new System.Drawing.Point(74, 60);
            this.txtReelNo.Name = "txtReelNo";
            this.txtReelNo.Size = new System.Drawing.Size(156, 21);
            this.txtReelNo.TabIndex = 0;
            this.txtReelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReelNo_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.Text = "料号";
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(74, 104);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.ReadOnly = true;
            this.txtPartNo.Size = new System.Drawing.Size(156, 21);
            this.txtPartNo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.Text = "已扫盘";
            // 
            // txtUsdPan
            // 
            this.txtUsdPan.Location = new System.Drawing.Point(74, 133);
            this.txtUsdPan.Name = "txtUsdPan";
            this.txtUsdPan.ReadOnly = true;
            this.txtUsdPan.Size = new System.Drawing.Size(156, 21);
            this.txtUsdPan.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.Text = "已扫数";
            // 
            // txtUsdQty
            // 
            this.txtUsdQty.Location = new System.Drawing.Point(74, 160);
            this.txtUsdQty.Name = "txtUsdQty";
            this.txtUsdQty.ReadOnly = true;
            this.txtUsdQty.Size = new System.Drawing.Size(156, 21);
            this.txtUsdQty.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.Text = "储格";
            // 
            // txtHourse
            // 
            this.txtHourse.Location = new System.Drawing.Point(74, 187);
            this.txtHourse.Name = "txtHourse";
            this.txtHourse.ReadOnly = true;
            this.txtHourse.Size = new System.Drawing.Size(156, 21);
            this.txtHourse.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.Text = "工厂仓别";
            // 
            // txtFactory
            // 
            this.txtFactory.Location = new System.Drawing.Point(74, 214);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.ReadOnly = true;
            this.txtFactory.Size = new System.Drawing.Size(156, 21);
            this.txtFactory.TabIndex = 5;
            // 
            // labQty
            // 
            this.labQty.Location = new System.Drawing.Point(74, 83);
            this.labQty.Name = "labQty";
            this.labQty.Size = new System.Drawing.Size(53, 20);
            this.labQty.Text = "0";
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.txtFactory);
            this.Controls.Add(this.txtHourse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUsdQty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsdPan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReelNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Check";
            this.Text = "盘点";
            this.Load += new System.EventHandler(this.Check_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReelNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsdPan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsdQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHourse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.Label labQty;
    }
}