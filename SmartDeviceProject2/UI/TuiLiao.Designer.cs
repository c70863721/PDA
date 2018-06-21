namespace Tsmt.UI
{
    partial class TuiLiao
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
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.txtReel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkNo = new System.Windows.Forms.TextBox();
            this.labPass = new System.Windows.Forms.Label();
            this.labReelNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(71, 137);
            this.txtQty.MaxLength = 10;
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(139, 21);
            this.txtQty.TabIndex = 3;
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(71, 105);
            this.txtDecode.MaxLength = 10;
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.ReadOnly = true;
            this.txtDecode.Size = new System.Drawing.Size(139, 21);
            this.txtDecode.TabIndex = 2;
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(71, 42);
            this.txtPartNo.MaxLength = 10;
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.ReadOnly = true;
            this.txtPartNo.Size = new System.Drawing.Size(139, 21);
            this.txtPartNo.TabIndex = 1;
            // 
            // txtReel
            // 
            this.txtReel.Location = new System.Drawing.Point(71, 13);
            this.txtReel.MaxLength = 30;
            this.txtReel.Name = "txtReel";
            this.txtReel.Size = new System.Drawing.Size(139, 21);
            this.txtReel.TabIndex = 0;
            this.txtReel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReel_KeyDown);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(19, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 21);
            this.label12.Text = "数量";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 21);
            this.label9.Text = "储格";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 21);
            this.label8.Text = "料号";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 21);
            this.label7.Text = "料卷";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.Text = "状态";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(71, 170);
            this.txtStatus.MaxLength = 10;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(139, 21);
            this.txtStatus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.Text = "工单";
            // 
            // txtWorkNo
            // 
            this.txtWorkNo.Location = new System.Drawing.Point(71, 204);
            this.txtWorkNo.MaxLength = 10;
            this.txtWorkNo.Name = "txtWorkNo";
            this.txtWorkNo.ReadOnly = true;
            this.txtWorkNo.Size = new System.Drawing.Size(139, 21);
            this.txtWorkNo.TabIndex = 5;
            // 
            // labPass
            // 
            this.labPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labPass.ForeColor = System.Drawing.Color.Blue;
            this.labPass.Location = new System.Drawing.Point(93, 249);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(84, 21);
            this.labPass.Text = "过账OK";
            // 
            // labReelNo
            // 
            this.labReelNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labReelNo.ForeColor = System.Drawing.Color.Blue;
            this.labReelNo.Location = new System.Drawing.Point(62, 233);
            this.labReelNo.Name = "labReelNo";
            this.labReelNo.Size = new System.Drawing.Size(148, 21);
            this.labReelNo.Text = "TS321ASDFASDF";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.Text = "仓别";
            // 
            // txtWH
            // 
            this.txtWH.Location = new System.Drawing.Point(71, 73);
            this.txtWH.MaxLength = 10;
            this.txtWH.Name = "txtWH";
            this.txtWH.ReadOnly = true;
            this.txtWH.Size = new System.Drawing.Size(139, 21);
            this.txtWH.TabIndex = 2;
            // 
            // TuiLiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labReelNo);
            this.Controls.Add(this.txtWorkNo);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtWH);
            this.Controls.Add(this.txtDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "TuiLiao";
            this.Text = "退料";
            this.Load += new System.EventHandler(this.TuiLiao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.TextBox txtReel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWorkNo;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Label labReelNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWH;
    }
}