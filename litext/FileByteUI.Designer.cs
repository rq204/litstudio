namespace litext
{
    partial class FileByteUI
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
            this.rbFileDateToBase64 = new System.Windows.Forms.RadioButton();
            this.ivFilePath = new litsdk.InsertVarName();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.llbCur = new System.Windows.Forms.LinkLabel();
            this.tbOptFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.svOptVarName = new litsdk.SelectVarName();
            this.lbDes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBase64Str2File = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.rbBase64Str2File);
            this.scActivityUI.Panel1.Controls.Add(this.rbFileDateToBase64);
            this.scActivityUI.Panel1.Controls.Add(this.ivFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.llbCur);
            this.scActivityUI.Panel1.Controls.Add(this.tbOptFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.svOptVarName);
            this.scActivityUI.Panel1.Controls.Add(this.lbDes);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // rbFileDateToBase64
            // 
            this.rbFileDateToBase64.AutoSize = true;
            this.rbFileDateToBase64.Location = new System.Drawing.Point(106, 29);
            this.rbFileDateToBase64.Name = "rbFileDateToBase64";
            this.rbFileDateToBase64.Size = new System.Drawing.Size(119, 16);
            this.rbFileDateToBase64.TabIndex = 35;
            this.rbFileDateToBase64.Text = "文件内容转Base64";
            this.rbFileDateToBase64.UseVisualStyleBackColor = true;
            // 
            // ivFilePath
            // 
            this.ivFilePath.Location = new System.Drawing.Point(399, 115);
            this.ivFilePath.Name = "ivFilePath";
            this.ivFilePath.Size = new System.Drawing.Size(16, 16);
            this.ivFilePath.TabIndex = 34;
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(492, 116);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 33;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // llbCur
            // 
            this.llbCur.AutoSize = true;
            this.llbCur.Location = new System.Drawing.Point(423, 116);
            this.llbCur.Name = "llbCur";
            this.llbCur.Size = new System.Drawing.Size(65, 12);
            this.llbCur.TabIndex = 32;
            this.llbCur.TabStop = true;
            this.llbCur.Text = "[当前目录]";
            this.llbCur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCur_LinkClicked);
            // 
            // tbOptFilePath
            // 
            this.tbOptFilePath.Location = new System.Drawing.Point(107, 113);
            this.tbOptFilePath.Name = "tbOptFilePath";
            this.tbOptFilePath.Size = new System.Drawing.Size(284, 21);
            this.tbOptFilePath.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "文件路径";
            // 
            // svOptVarName
            // 
            this.svOptVarName.Location = new System.Drawing.Point(107, 151);
            this.svOptVarName.Name = "svOptVarName";
            this.svOptVarName.Size = new System.Drawing.Size(145, 23);
            this.svOptVarName.TabIndex = 29;
            this.svOptVarName.VarName = "";
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Location = new System.Drawing.Point(47, 156);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(53, 12);
            this.lbDes.TabIndex = 21;
            this.lbDes.Text = "操作变量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "操作类型";
            // 
            // radioButton1
            // 
            this.rbBase64Str2File.AutoSize = true;
            this.rbBase64Str2File.Location = new System.Drawing.Point(253, 30);
            this.rbBase64Str2File.Name = "radioButton1";
            this.rbBase64Str2File.Size = new System.Drawing.Size(179, 16);
            this.rbBase64Str2File.TabIndex = 36;
            this.rbBase64Str2File.Text = "Base64字符转二进制写入文件";
            this.rbBase64Str2File.UseVisualStyleBackColor = true;
            // 
            // FileByteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FileByteUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFileDateToBase64;
        private litsdk.InsertVarName ivFilePath;
        private System.Windows.Forms.LinkLabel llbOpen;
        private System.Windows.Forms.LinkLabel llbCur;
        private System.Windows.Forms.TextBox tbOptFilePath;
        private System.Windows.Forms.Label label3;
        private litsdk.SelectVarName svOptVarName;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbBase64Str2File;
    }
}
