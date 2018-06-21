namespace Tsmt.UI
{
    partial class LinTui
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
            this.txtChuGe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReelNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.labReelNo = new System.Windows.Forms.Label();
            this.txtWorkNo = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChuGe
            // 
            this.txtChuGe.Location = new System.Drawing.Point(73, 14);
            this.txtChuGe.MaxLength = 20;
            this.txtChuGe.Name = "txtChuGe";
            this.txtChuGe.Size = new System.Drawing.Size(139, 21);
            this.txtChuGe.TabIndex = 4;
            this.txtChuGe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChuGe_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.Text = "储格";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtReelNO
            // 
            this.txtReelNO.Location = new System.Drawing.Point(73, 45);
            this.txtReelNO.MaxLength = 20;
            this.txtReelNO.Name = "txtReelNO";
            this.txtReelNO.Size = new System.Drawing.Size(139, 21);
            this.txtReelNO.TabIndex = 7;
            this.txtReelNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReelNO_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.Text = "料卷";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labPass
            // 
            this.labPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labPass.ForeColor = System.Drawing.Color.Blue;
            this.labPass.Location = new System.Drawing.Point(95, 214);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(84, 21);
            this.labPass.Text = "过账OK";
            // 
            // labReelNo
            // 
            this.labReelNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labReelNo.ForeColor = System.Drawing.Color.Blue;
            this.labReelNo.Location = new System.Drawing.Point(64, 198);
            this.labReelNo.Name = "labReelNo";
            this.labReelNo.Size = new System.Drawing.Size(148, 21);
            this.labReelNo.Text = "TS321ASDFASDF";
            // 
            // txtWorkNo
            // 
            this.txtWorkNo.Location = new System.Drawing.Point(73, 169);
            this.txtWorkNo.MaxLength = 10;
            this.txtWorkNo.Name = "txtWorkNo";
            this.txtWorkNo.ReadOnly = true;
            this.txtWorkNo.Size = new System.Drawing.Size(139, 21);
            this.txtWorkNo.TabIndex = 22;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(73, 138);
            this.txtStatus.MaxLength = 10;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(139, 21);
            this.txtStatus.TabIndex = 21;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(73, 107);
            this.txtQty.MaxLength = 10;
            this.txtQty.Name = "txtQty";
            this.txtQty.ReadOnly = true;
            this.txtQty.Size = new System.Drawing.Size(139, 21);
            this.txtQty.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.Text = "工单";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(73, 76);
            this.txtPartNo.MaxLength = 10;
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.ReadOnly = true;
            this.txtPartNo.Size = new System.Drawing.Size(139, 21);
            this.txtPartNo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.Text = "状态";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(14, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 21);
            this.label12.Text = "数量";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(25, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 21);
            this.label8.Text = "料号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LinTui
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtReelNO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChuGe);
            this.Controls.Add(this.label1);
            this.Name = "LinTui";
            this.Text = "零数退料";
            this.Load += new System.EventHandler(this.LinTui_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtChuGe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReelNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Label labReelNo;
        private System.Windows.Forms.TextBox txtWorkNo;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
    }
}