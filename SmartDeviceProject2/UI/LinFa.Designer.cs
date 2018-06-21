namespace Tsmt.UI
{
    partial class LinFa
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
            this.txtWorkNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cobLaoJiaBianHao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labNoFaQty = new System.Windows.Forms.Label();
            this.labFaPanQty = new System.Windows.Forms.Label();
            this.labFaQty = new System.Windows.Forms.Label();
            this.labYingFaQty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReel = new System.Windows.Forms.TextBox();
            this.labPass = new System.Windows.Forms.Label();
            this.labReelNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReelQty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWorkNo
            // 
            this.txtWorkNo.Location = new System.Drawing.Point(70, 7);
            this.txtWorkNo.MaxLength = 20;
            this.txtWorkNo.Name = "txtWorkNo";
            this.txtWorkNo.Size = new System.Drawing.Size(139, 21);
            this.txtWorkNo.TabIndex = 2;
            this.txtWorkNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkNo_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.Text = "工单";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.Text = "料架编号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cobLaoJiaBianHao
            // 
            this.cobLaoJiaBianHao.Location = new System.Drawing.Point(71, 33);
            this.cobLaoJiaBianHao.Name = "cobLaoJiaBianHao";
            this.cobLaoJiaBianHao.Size = new System.Drawing.Size(138, 22);
            this.cobLaoJiaBianHao.TabIndex = 6;
            this.cobLaoJiaBianHao.SelectedIndexChanged += new System.EventHandler(this.cobLaoJiaBianHao_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.Text = "料号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(124, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.Text = "已发盘:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.Text = "未发数:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(124, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.Text = "已发数:";
            // 
            // labNoFaQty
            // 
            this.labNoFaQty.Location = new System.Drawing.Point(65, 117);
            this.labNoFaQty.Name = "labNoFaQty";
            this.labNoFaQty.Size = new System.Drawing.Size(53, 21);
            this.labNoFaQty.Text = "99999";
            // 
            // labFaPanQty
            // 
            this.labFaPanQty.Location = new System.Drawing.Point(176, 117);
            this.labFaPanQty.Name = "labFaPanQty";
            this.labFaPanQty.Size = new System.Drawing.Size(50, 21);
            this.labFaPanQty.Text = "99999";
            // 
            // labFaQty
            // 
            this.labFaQty.Location = new System.Drawing.Point(176, 96);
            this.labFaQty.Name = "labFaQty";
            this.labFaQty.Size = new System.Drawing.Size(50, 21);
            this.labFaQty.Text = "99999";
            // 
            // labYingFaQty
            // 
            this.labYingFaQty.Location = new System.Drawing.Point(65, 96);
            this.labYingFaQty.Name = "labYingFaQty";
            this.labYingFaQty.Size = new System.Drawing.Size(53, 21);
            this.labYingFaQty.Text = "99999";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.Text = "应发数:";
            // 
            // txtReel
            // 
            this.txtReel.Location = new System.Drawing.Point(69, 140);
            this.txtReel.MaxLength = 30;
            this.txtReel.Name = "txtReel";
            this.txtReel.ReadOnly = true;
            this.txtReel.Size = new System.Drawing.Size(139, 21);
            this.txtReel.TabIndex = 32;
            this.txtReel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReel_KeyDown);
            // 
            // labPass
            // 
            this.labPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labPass.ForeColor = System.Drawing.Color.Blue;
            this.labPass.Location = new System.Drawing.Point(89, 215);
            this.labPass.Name = "labPass";
            this.labPass.Size = new System.Drawing.Size(69, 21);
            this.labPass.Text = "过账OK";
            // 
            // labReelNo
            // 
            this.labReelNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labReelNo.ForeColor = System.Drawing.Color.Blue;
            this.labReelNo.Location = new System.Drawing.Point(60, 198);
            this.labReelNo.Name = "labReelNo";
            this.labReelNo.Size = new System.Drawing.Size(148, 21);
            this.labReelNo.Text = "TS321ASDFASDF";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(19, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 21);
            this.label9.Text = "料卷";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(71, 61);
            this.txtPartNo.MaxLength = 30;
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.ReadOnly = true;
            this.txtPartNo.Size = new System.Drawing.Size(139, 21);
            this.txtPartNo.TabIndex = 55;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(86, 240);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 20);
            this.btnRefresh.TabIndex = 56;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.Text = "数量";
            // 
            // txtReelQty
            // 
            this.txtReelQty.Location = new System.Drawing.Point(69, 167);
            this.txtReelQty.MaxLength = 10;
            this.txtReelQty.Name = "txtReelQty";
            this.txtReelQty.ReadOnly = true;
            this.txtReelQty.Size = new System.Drawing.Size(139, 21);
            this.txtReelQty.TabIndex = 72;
            // 
            // LinFa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReelQty);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtPartNo);
            this.Controls.Add(this.txtReel);
            this.Controls.Add(this.labPass);
            this.Controls.Add(this.labReelNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labNoFaQty);
            this.Controls.Add(this.labFaPanQty);
            this.Controls.Add(this.labFaQty);
            this.Controls.Add(this.labYingFaQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cobLaoJiaBianHao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWorkNo);
            this.Controls.Add(this.label1);
            this.Name = "LinFa";
            this.Text = "零数发料";
            this.Load += new System.EventHandler(this.LinFa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtWorkNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobLaoJiaBianHao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labNoFaQty;
        private System.Windows.Forms.Label labFaPanQty;
        private System.Windows.Forms.Label labFaQty;
        private System.Windows.Forms.Label labYingFaQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReel;
        private System.Windows.Forms.Label labPass;
        private System.Windows.Forms.Label labReelNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReelQty;
    }
}