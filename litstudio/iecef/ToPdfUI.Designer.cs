namespace litstudio.iecef
{
    partial class ToPdfUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbPdfPath = new System.Windows.Forms.TextBox();
            this.ivFilePath = new litsdk.InsertVarName();
            this.llbCurDir = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudScaleFactor = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.nudScaleFactor);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.ivFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.llbCurDir);
            this.scActivityUI.Panel1.Controls.Add(this.tbPdfPath);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pdf保存至";
            // 
            // tbPdfPath
            // 
            this.tbPdfPath.Location = new System.Drawing.Point(82, 16);
            this.tbPdfPath.Name = "tbPdfPath";
            this.tbPdfPath.Size = new System.Drawing.Size(346, 21);
            this.tbPdfPath.TabIndex = 1;
            // 
            // ivFilePath
            // 
            this.ivFilePath.Location = new System.Drawing.Point(436, 18);
            this.ivFilePath.Name = "ivFilePath";
            this.ivFilePath.Size = new System.Drawing.Size(16, 16);
            this.ivFilePath.TabIndex = 6;
            // 
            // llbCurDir
            // 
            this.llbCurDir.AutoSize = true;
            this.llbCurDir.Location = new System.Drawing.Point(458, 20);
            this.llbCurDir.Name = "llbCurDir";
            this.llbCurDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurDir.TabIndex = 5;
            this.llbCurDir.TabStop = true;
            this.llbCurDir.Text = "[当前目录]";
            this.llbCurDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurDir_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "该功能生成的pdf内容，和网页的真实页面可能会有不同，请实际测试后使用";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "缩放比例";
            // 
            // nudScaleFactor
            // 
            this.nudScaleFactor.Location = new System.Drawing.Point(82, 55);
            this.nudScaleFactor.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudScaleFactor.Name = "nudScaleFactor";
            this.nudScaleFactor.Size = new System.Drawing.Size(46, 21);
            this.nudScaleFactor.TabIndex = 9;
            this.nudScaleFactor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "%";
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(527, 20);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 10;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // ToPdfUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ToPdfUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleFactor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPdfPath;
        private litsdk.InsertVarName ivFilePath;
        private System.Windows.Forms.LinkLabel llbCurDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudScaleFactor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llbOpen;
    }
}
