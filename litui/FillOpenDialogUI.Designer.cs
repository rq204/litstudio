namespace litui
{
    partial class FillOpenDialogUI
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ivSavePath = new litsdk.InsertVarName();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.llbBaseDir = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.llbCheck = new System.Windows.Forms.Label();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.llbCheck);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.numericUpDown1);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.llbBaseDir);
            this.scActivityUI.Panel1.Controls.Add(this.tbSavePath);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.ivSavePath);
            // 
            // ivSavePath
            // 
            this.ivSavePath.Location = new System.Drawing.Point(384, 28);
            this.ivSavePath.Name = "ivSavePath";
            this.ivSavePath.Size = new System.Drawing.Size(20, 23);
            this.ivSavePath.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "文件路径";
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(97, 28);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(281, 21);
            this.tbSavePath.TabIndex = 4;
            // 
            // llbBaseDir
            // 
            this.llbBaseDir.AutoSize = true;
            this.llbBaseDir.Location = new System.Drawing.Point(406, 32);
            this.llbBaseDir.Name = "llbBaseDir";
            this.llbBaseDir.Size = new System.Drawing.Size(65, 12);
            this.llbBaseDir.TabIndex = 5;
            this.llbBaseDir.TabStop = true;
            this.llbBaseDir.Text = "[当前目录]";
            this.llbBaseDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBaseDir_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "操作超时";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(97, 69);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 21);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "秒";
            // 
            // llbCheck
            // 
            this.llbCheck.ForeColor = System.Drawing.Color.Green;
            this.llbCheck.Location = new System.Drawing.Point(95, 117);
            this.llbCheck.Name = "llbCheck";
            this.llbCheck.Size = new System.Drawing.Size(353, 38);
            this.llbCheck.TabIndex = 9;
            this.llbCheck.Text = "该组件可以自动填写文件路径至打开对话框并点击打开按钮";
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(477, 31);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 15;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // FillOpenDialogUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FillOpenDialogUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private litsdk.InsertVarName ivSavePath;
        private System.Windows.Forms.LinkLabel llbBaseDir;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label llbCheck;
        private System.Windows.Forms.LinkLabel llbOpen;
    }
}
