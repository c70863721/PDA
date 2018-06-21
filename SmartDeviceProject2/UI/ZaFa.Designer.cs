namespace Tsmt.UI
{
    partial class ZaFa
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
            this.cobPartNo = new System.Windows.Forms.ComboBox();
            this.txtReel = new System.Windows.Forms.TextBox();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.txtWorkNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labNoFaQty = new System.Windows.Forms.Label();
            this.labFaPanQty = new System.Windows.Forms.Label();
            this.labFaQty = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labYingFaQty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labPass = new System.Windows.Forms.Label();
            this.labReelNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cobPartNo
            // 
            this.cobPartNo.Location = new System.Drawing.Point(64, 51);
            this.cobPartNo.Name = "cobPartNo";
            this.cobPartNo.Size = new System.Drawing.Size(139, 22);
            this.cobPartNo.TabIndex = 1;
            this.cobPartNo.SelectedIndexChanged += new System.EventHandler(this.cobPartNo_SelectedIndexChanged);
            // 
            // txtReel
            // 
            this.txtReel.Location = new System.Drawing.Point(64, 204);
            this.txtReel.MaxLength = 30;
            this.txtReel.Name = "txtReel";
            this.txtReel.ReadOnly = true;
            this.txtReel.Size = new System.Drawing.Size(139, 21);
            this.txtReel.TabIndex = 3;
            this.txtReel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReel_KeyDown);
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(64, 166);
            this.txtWhere.MaxLength = 10;
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.ReadOnly = true;
            this.txtWhere.Size = new System.Drawing.Size(139, 21);
            this.txtWhere.TabIndex = 2;
            // 
            // txtWorkNo
            // 
            this.txtWorkNo.Location = new System.Drawing.Point(64, 12);
            this.txtWorkNo.MaxLength = 20;
            this.txtWorkNo.Name = "txtWorkNo";
            this.txtWorkNo.Size = new System.Drawing.Size(139, 21);
            this.txtWorkNo.TabIndex = 0;
            this.txtWorkNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkNo_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(123, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.Text = "已发盘:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.Text = "未发数:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(123, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.Text = "已发数:";
            // 
            // labNoFaQty
            // 
            this.labNoFaQty.Location = new System.Drawing.Point(64, 138);
            this.labNoFaQty.Name = "labNoFaQty";
            this.labNoFaQty.Size = new System.Drawing.Size(53, 21);
            this.labNoFaQty.Text = "99999";
            // 
            // labFaPanQty
            // 
            this.labFaPanQty.Location = new System.Drawing.Point(175, 138);
            this.labFaPanQty.Name = "labFaPanQty";
            this.labFaPanQty.Size = new System.Drawing.Size(50, 21);
            this.labFaPanQty.Text = "99999";
            // 
            // labFaQty
            // 
            this.labFaQty.Location = new System.Drawing.Point(175, 117);
            this.labFaQty.Name = "labFaQty";
            this.labFaQty.Size = new System.Drawing.Size(50, 21);
            this.labFaQty.Text = "99999";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(23, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 21);
            this.label9.Text = "储格";
            // 
            // labYingFaQty
            // 
            this.labYingFaQty.Location = new System.Drawing.Point(64, 117);
            this.labYingFaQty.Name = "labYingFaQty";
            this.labYingFaQty.Size = new System.Drawing.Size(53, 21);
            this.labYingFaQty.Text = "99999";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.Text = "应发数:";
            // 
            // labPass
            // 
            this.labPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labPass.ForeColor = System.Drawing.Color.Blue;
            this.labPass.Location = new System.Drawing.Point(93, 247);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(69, 21);
            this.labPass.Text = "过账OK";
            // 
            // labReelNo
            // 
            this.labReelNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labReelNo.ForeColor = System.Drawing.Color.Blue;
            this.labReelNo.Location = new System.Drawing.Point(64, 230);
            this.labReelNo.Name = "labReelNo";
            this.labReelNo.Size = new System.Drawing.Size(148, 21);
            this.labReelNo.Text = "TS321ASDFASDF";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 21);
            this.label7.Text = "料卷";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.Text = "料号";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.Text = "单据";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(23, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 21);
            this.label8.Text = "仓别";
            // 
            // txtWH
            // 
            this.txtWH.Location = new System.Drawing.Point(64, 85);
            this.txtWH.MaxLength = 10;
            this.txtWH.Name = "txtWH";
            this.txtWH.ReadOnly = true;
            this.txtWH.Size = new System.Drawing.Size(139, 21);
            this.txtWH.TabIndex = 2;
            // 
            // ZaFa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.cobPartNo);
            this.Controls.Add(this.txtReel);
            this.Controls.Add(this.txtWH);
            this.Controls.Add(this.txtWhere);
            this.Controls.Add(this.txtWorkNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labNoFaQty);
            this.Controls.Add(this.labFaPanQty);
            this.Controls.Add(this.labFaQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labYingFaQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labReelNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ZaFa";
            this.Text = "非工单发料";
            this.Load += new System.EventHandler(this.ZaFa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cobPartNo;
        private System.Windows.Forms.TextBox txtReel;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.TextBox txtWorkNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labNoFaQty;
        private System.Windows.Forms.Label labFaPanQty;
        private System.Windows.Forms.Label labFaQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labYingFaQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Label labReelNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtWH;
    }
}