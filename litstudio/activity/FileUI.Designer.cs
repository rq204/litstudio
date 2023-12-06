namespace litstudio
{
    partial class FileUI
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
            this.rbMoveFile = new System.Windows.Forms.RadioButton();
            this.rbDeleteFile = new System.Windows.Forms.RadioButton();
            this.rbCreateDir = new System.Windows.Forms.RadioButton();
            this.rbCopyFile = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDest = new System.Windows.Forms.Label();
            this.tbSourcePath = new System.Windows.Forms.TextBox();
            this.tbDestPath = new System.Windows.Forms.TextBox();
            this.ivSource = new litsdk.InsertVarName();
            this.ivDestPath = new litsdk.InsertVarName();
            this.llbCurrentDir = new System.Windows.Forms.LinkLabel();
            this.llbDestDir = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbDeleteDir = new System.Windows.Forms.RadioButton();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            this.scActivityUI.Panel1.Controls.Add(this.linkLabel1);
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.rbDeleteDir);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.llbDestDir);
            this.scActivityUI.Panel1.Controls.Add(this.llbCurrentDir);
            this.scActivityUI.Panel1.Controls.Add(this.ivDestPath);
            this.scActivityUI.Panel1.Controls.Add(this.ivSource);
            this.scActivityUI.Panel1.Controls.Add(this.tbDestPath);
            this.scActivityUI.Panel1.Controls.Add(this.tbSourcePath);
            this.scActivityUI.Panel1.Controls.Add(this.rbCreateDir);
            this.scActivityUI.Panel1.Controls.Add(this.rbDeleteFile);
            this.scActivityUI.Panel1.Controls.Add(this.rbCopyFile);
            this.scActivityUI.Panel1.Controls.Add(this.rbMoveFile);
            this.scActivityUI.Panel1.Controls.Add(this.lbDest);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "操作类型";
            // 
            // rbMoveFile
            // 
            this.rbMoveFile.AutoSize = true;
            this.rbMoveFile.Location = new System.Drawing.Point(97, 34);
            this.rbMoveFile.Name = "rbMoveFile";
            this.rbMoveFile.Size = new System.Drawing.Size(71, 16);
            this.rbMoveFile.TabIndex = 1;
            this.rbMoveFile.TabStop = true;
            this.rbMoveFile.Text = "移动文件";
            this.rbMoveFile.UseVisualStyleBackColor = true;
            this.rbMoveFile.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDeleteFile
            // 
            this.rbDeleteFile.AutoSize = true;
            this.rbDeleteFile.Location = new System.Drawing.Point(247, 34);
            this.rbDeleteFile.Name = "rbDeleteFile";
            this.rbDeleteFile.Size = new System.Drawing.Size(71, 16);
            this.rbDeleteFile.TabIndex = 1;
            this.rbDeleteFile.TabStop = true;
            this.rbDeleteFile.Text = "删除文件";
            this.rbDeleteFile.UseVisualStyleBackColor = true;
            this.rbDeleteFile.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbCreateDir
            // 
            this.rbCreateDir.AutoSize = true;
            this.rbCreateDir.Location = new System.Drawing.Point(327, 34);
            this.rbCreateDir.Name = "rbCreateDir";
            this.rbCreateDir.Size = new System.Drawing.Size(83, 16);
            this.rbCreateDir.TabIndex = 1;
            this.rbCreateDir.TabStop = true;
            this.rbCreateDir.Text = "创建文件夹";
            this.rbCreateDir.UseVisualStyleBackColor = true;
            this.rbCreateDir.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbCopyFile
            // 
            this.rbCopyFile.AutoSize = true;
            this.rbCopyFile.Location = new System.Drawing.Point(172, 34);
            this.rbCopyFile.Name = "rbCopyFile";
            this.rbCopyFile.Size = new System.Drawing.Size(71, 16);
            this.rbCopyFile.TabIndex = 1;
            this.rbCopyFile.TabStop = true;
            this.rbCopyFile.Text = "复制文件";
            this.rbCopyFile.UseVisualStyleBackColor = true;
            this.rbCopyFile.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "原始路径";
            // 
            // lbDest
            // 
            this.lbDest.AutoSize = true;
            this.lbDest.Location = new System.Drawing.Point(31, 119);
            this.lbDest.Name = "lbDest";
            this.lbDest.Size = new System.Drawing.Size(53, 12);
            this.lbDest.TabIndex = 0;
            this.lbDest.Text = "目标路径";
            // 
            // tbSourcePath
            // 
            this.tbSourcePath.Location = new System.Drawing.Point(97, 74);
            this.tbSourcePath.Name = "tbSourcePath";
            this.tbSourcePath.Size = new System.Drawing.Size(294, 21);
            this.tbSourcePath.TabIndex = 2;
            // 
            // tbDestPath
            // 
            this.tbDestPath.Location = new System.Drawing.Point(97, 115);
            this.tbDestPath.Name = "tbDestPath";
            this.tbDestPath.Size = new System.Drawing.Size(294, 21);
            this.tbDestPath.TabIndex = 2;
            // 
            // ivSource
            // 
            this.ivSource.Location = new System.Drawing.Point(398, 77);
            this.ivSource.Name = "ivSource";
            this.ivSource.Size = new System.Drawing.Size(16, 16);
            this.ivSource.TabIndex = 3;
            // 
            // ivDestPath
            // 
            this.ivDestPath.Location = new System.Drawing.Point(397, 118);
            this.ivDestPath.Name = "ivDestPath";
            this.ivDestPath.Size = new System.Drawing.Size(16, 16);
            this.ivDestPath.TabIndex = 3;
            // 
            // llbCurrentDir
            // 
            this.llbCurrentDir.AutoSize = true;
            this.llbCurrentDir.Location = new System.Drawing.Point(420, 77);
            this.llbCurrentDir.Name = "llbCurrentDir";
            this.llbCurrentDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurrentDir.TabIndex = 5;
            this.llbCurrentDir.TabStop = true;
            this.llbCurrentDir.Text = "[当前目录]";
            this.llbCurrentDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurrentDir_LinkClicked);
            // 
            // llbDestDir
            // 
            this.llbDestDir.AutoSize = true;
            this.llbDestDir.Location = new System.Drawing.Point(420, 119);
            this.llbDestDir.Name = "llbDestDir";
            this.llbDestDir.Size = new System.Drawing.Size(65, 12);
            this.llbDestDir.TabIndex = 5;
            this.llbDestDir.TabStop = true;
            this.llbDestDir.Text = "[当前目录]";
            this.llbDestDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDestDir_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(515, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "当使用复制文件或是移动文件时，如果目标路径为目录（以\\结尾）则会按原文件名进行复制移动";
            // 
            // rbDeleteDir
            // 
            this.rbDeleteDir.AutoSize = true;
            this.rbDeleteDir.Location = new System.Drawing.Point(418, 34);
            this.rbDeleteDir.Name = "rbDeleteDir";
            this.rbDeleteDir.Size = new System.Drawing.Size(83, 16);
            this.rbDeleteDir.TabIndex = 7;
            this.rbDeleteDir.TabStop = true;
            this.rbDeleteDir.Text = "删除文件夹";
            this.rbDeleteDir.UseVisualStyleBackColor = true;
            this.rbDeleteDir.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(491, 77);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 9;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(491, 119);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 12);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[浏览]";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FileUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FileUI";
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
        private System.Windows.Forms.RadioButton rbCreateDir;
        private System.Windows.Forms.RadioButton rbDeleteFile;
        private System.Windows.Forms.RadioButton rbMoveFile;
        private System.Windows.Forms.TextBox tbDestPath;
        private System.Windows.Forms.TextBox tbSourcePath;
        private System.Windows.Forms.RadioButton rbCopyFile;
        private System.Windows.Forms.Label lbDest;
        private System.Windows.Forms.Label label3;
        private litsdk.InsertVarName ivDestPath;
        private litsdk.InsertVarName ivSource;
        private System.Windows.Forms.LinkLabel llbDestDir;
        private System.Windows.Forms.LinkLabel llbCurrentDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDeleteDir;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel llbOpen;
    }
}
