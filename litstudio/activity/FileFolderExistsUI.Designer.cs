namespace litstudio
{
    partial class FileFolderExistsUI
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
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.rbDir = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFileDirPath = new System.Windows.Forms.TextBox();
            this.ivPath = new litsdk.InsertVarName();
            this.llbCurrentDir = new System.Windows.Forms.LinkLabel();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
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
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.llbCurrentDir);
            this.scActivityUI.Panel1.Controls.Add(this.ivPath);
            this.scActivityUI.Panel1.Controls.Add(this.tbFileDirPath);
            this.scActivityUI.Panel1.Controls.Add(this.rbDir);
            this.scActivityUI.Panel1.Controls.Add(this.rbFile);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "判断类型";
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(104, 30);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(71, 16);
            this.rbFile.TabIndex = 1;
            this.rbFile.TabStop = true;
            this.rbFile.Text = "文件存在";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // rbDir
            // 
            this.rbDir.AutoSize = true;
            this.rbDir.Location = new System.Drawing.Point(193, 30);
            this.rbDir.Name = "rbDir";
            this.rbDir.Size = new System.Drawing.Size(83, 16);
            this.rbDir.TabIndex = 1;
            this.rbDir.TabStop = true;
            this.rbDir.Text = "文件夹存在";
            this.rbDir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "操作路径";
            // 
            // tbFileDirPath
            // 
            this.tbFileDirPath.Location = new System.Drawing.Point(104, 77);
            this.tbFileDirPath.Name = "tbFileDirPath";
            this.tbFileDirPath.Size = new System.Drawing.Size(289, 21);
            this.tbFileDirPath.TabIndex = 2;
            // 
            // ivPath
            // 
            this.ivPath.Location = new System.Drawing.Point(400, 77);
            this.ivPath.Name = "ivPath";
            this.ivPath.Size = new System.Drawing.Size(20, 23);
            this.ivPath.TabIndex = 3;
            // 
            // llbCurrentDir
            // 
            this.llbCurrentDir.AutoSize = true;
            this.llbCurrentDir.Location = new System.Drawing.Point(426, 80);
            this.llbCurrentDir.Name = "llbCurrentDir";
            this.llbCurrentDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurrentDir.TabIndex = 4;
            this.llbCurrentDir.TabStop = true;
            this.llbCurrentDir.Text = "[当前目录]";
            this.llbCurrentDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurrentDir_LinkClicked);
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(499, 80);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 9;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // FileFolderExistsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FileFolderExistsUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private litsdk.InsertVarName ivPath;
        private System.Windows.Forms.TextBox tbFileDirPath;
        private System.Windows.Forms.RadioButton rbDir;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llbCurrentDir;
        private System.Windows.Forms.LinkLabel llbOpen;
    }
}
