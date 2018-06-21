namespace Tsmt.UI
{
    partial class PanDian
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
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.txtReelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(68, 109);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.ReadOnly = true;
            this.txtPartNo.Size = new System.Drawing.Size(156, 21);
            this.txtPartNo.TabIndex = 15;
            // 
            // txtReelNo
            // 
            this.txtReelNo.Location = new System.Drawing.Point(68, 65);
            this.txtReelNo.Name = "txtReelNo";
            this.txtReelNo.Size = new System.Drawing.Size(156, 21);
            this.txtReelNo.TabIndex = 14;
            this.txtReelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReelNo_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.Text = "料号";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.Text = "料卷";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.Text = "盘点";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtQTY
            // 
            this.txtQTY.Location = new System.Drawing.Point(68, 136);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.ReadOnly = true;
            this.txtQTY.Size = new System.Drawing.Size(156, 21);
            this.txtQTY.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.Text = "数量 ";
            // 
            // PanDian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.txtReelNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "PanDian";
            this.Text = "盘点";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.TextBox txtReelNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.Label label4;
    }
}