namespace litftp
{
    partial class FtpUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFileInfo = new System.Windows.Forms.Label();
            this.lbDirInfo = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.cbPassive = new System.Windows.Forms.CheckBox();
            this.ivServer = new litsdk.InsertVarName();
            this.ivUserName = new litsdk.InsertVarName();
            this.ivPort = new litsdk.InsertVarName();
            this.label10 = new System.Windows.Forms.Label();
            this.rbUpload = new System.Windows.Forms.RadioButton();
            this.rbDownload = new System.Windows.Forms.RadioButton();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.svFileVarName = new litsdk.SelectVarName();
            this.tbSelectDir = new System.Windows.Forms.TextBox();
            this.cbExistIgnore = new System.Windows.Forms.CheckBox();
            this.ivPassword = new litsdk.InsertVarName();
            this.cbSftp = new System.Windows.Forms.CheckBox();
            this.rbListDirFile = new System.Windows.Forms.RadioButton();
            this.rbListDirDir = new System.Windows.Forms.RadioButton();
            this.ivSelectDir = new litsdk.InsertVarName();
            this.rbUploadDir = new System.Windows.Forms.RadioButton();
            this.rbDownloadDir = new System.Windows.Forms.RadioButton();
            this.rbDeleteDir = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbDeleteDir);
            this.scActivityUI.Panel1.Controls.Add(this.rbDownloadDir);
            this.scActivityUI.Panel1.Controls.Add(this.rbUploadDir);
            this.scActivityUI.Panel1.Controls.Add(this.ivSelectDir);
            this.scActivityUI.Panel1.Controls.Add(this.ivPassword);
            this.scActivityUI.Panel1.Controls.Add(this.cbExistIgnore);
            this.scActivityUI.Panel1.Controls.Add(this.svFileVarName);
            this.scActivityUI.Panel1.Controls.Add(this.rbListDirDir);
            this.scActivityUI.Panel1.Controls.Add(this.rbListDirFile);
            this.scActivityUI.Panel1.Controls.Add(this.rbDelete);
            this.scActivityUI.Panel1.Controls.Add(this.rbDownload);
            this.scActivityUI.Panel1.Controls.Add(this.rbUpload);
            this.scActivityUI.Panel1.Controls.Add(this.ivPort);
            this.scActivityUI.Panel1.Controls.Add(this.ivUserName);
            this.scActivityUI.Panel1.Controls.Add(this.ivServer);
            this.scActivityUI.Panel1.Controls.Add(this.cbSftp);
            this.scActivityUI.Panel1.Controls.Add(this.cbPassive);
            this.scActivityUI.Panel1.Controls.Add(this.tbPort);
            this.scActivityUI.Panel1.Controls.Add(this.tbSelectDir);
            this.scActivityUI.Panel1.Controls.Add(this.tbPassword);
            this.scActivityUI.Panel1.Controls.Add(this.tbUserName);
            this.scActivityUI.Panel1.Controls.Add(this.tbServer);
            this.scActivityUI.Panel1.Controls.Add(this.lbDirInfo);
            this.scActivityUI.Panel1.Controls.Add(this.label10);
            this.scActivityUI.Panel1.Controls.Add(this.lbFileInfo);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "主机地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "密码";
            // 
            // lbFileInfo
            // 
            this.lbFileInfo.AutoSize = true;
            this.lbFileInfo.Location = new System.Drawing.Point(25, 166);
            this.lbFileInfo.Name = "lbFileInfo";
            this.lbFileInfo.Size = new System.Drawing.Size(53, 12);
            this.lbFileInfo.TabIndex = 0;
            this.lbFileInfo.Text = "文件地址";
            // 
            // lbDirInfo
            // 
            this.lbDirInfo.AutoSize = true;
            this.lbDirInfo.Location = new System.Drawing.Point(25, 205);
            this.lbDirInfo.Name = "lbDirInfo";
            this.lbDirInfo.Size = new System.Drawing.Size(53, 12);
            this.lbDirInfo.TabIndex = 0;
            this.lbDirInfo.Text = "上传目录";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(86, 85);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(175, 21);
            this.tbServer.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(85, 122);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(174, 21);
            this.tbUserName.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(327, 122);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(174, 21);
            this.tbPassword.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "端口";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(327, 85);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(51, 21);
            this.tbPort.TabIndex = 2;
            // 
            // cbPassive
            // 
            this.cbPassive.AutoSize = true;
            this.cbPassive.Location = new System.Drawing.Point(464, 87);
            this.cbPassive.Name = "cbPassive";
            this.cbPassive.Size = new System.Drawing.Size(72, 16);
            this.cbPassive.TabIndex = 3;
            this.cbPassive.Text = "被动模式";
            this.cbPassive.UseVisualStyleBackColor = true;
            // 
            // ivServer
            // 
            this.ivServer.Location = new System.Drawing.Point(267, 87);
            this.ivServer.Name = "ivServer";
            this.ivServer.Size = new System.Drawing.Size(16, 16);
            this.ivServer.TabIndex = 4;
            // 
            // ivUserName
            // 
            this.ivUserName.Location = new System.Drawing.Point(267, 125);
            this.ivUserName.Name = "ivUserName";
            this.ivUserName.Size = new System.Drawing.Size(16, 16);
            this.ivUserName.TabIndex = 4;
            // 
            // ivPort
            // 
            this.ivPort.Location = new System.Drawing.Point(384, 88);
            this.ivPort.Name = "ivPort";
            this.ivPort.Size = new System.Drawing.Size(16, 16);
            this.ivPort.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "操作类型";
            // 
            // rbUpload
            // 
            this.rbUpload.AutoSize = true;
            this.rbUpload.Location = new System.Drawing.Point(85, 20);
            this.rbUpload.Name = "rbUpload";
            this.rbUpload.Size = new System.Drawing.Size(71, 16);
            this.rbUpload.TabIndex = 0;
            this.rbUpload.TabStop = true;
            this.rbUpload.Text = "上传文件";
            this.rbUpload.UseVisualStyleBackColor = true;
            this.rbUpload.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDownload
            // 
            this.rbDownload.AutoSize = true;
            this.rbDownload.Location = new System.Drawing.Point(190, 20);
            this.rbDownload.Name = "rbDownload";
            this.rbDownload.Size = new System.Drawing.Size(71, 16);
            this.rbDownload.TabIndex = 5;
            this.rbDownload.TabStop = true;
            this.rbDownload.Text = "下载文件";
            this.rbDownload.UseVisualStyleBackColor = true;
            this.rbDownload.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(299, 20);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(71, 16);
            this.rbDelete.TabIndex = 5;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "删除文件";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // svFileVarName
            // 
            this.svFileVarName.Location = new System.Drawing.Point(84, 162);
            this.svFileVarName.Name = "svFileVarName";
            this.svFileVarName.Size = new System.Drawing.Size(199, 23);
            this.svFileVarName.TabIndex = 6;
            this.svFileVarName.VarName = "";
            // 
            // tbSelectDir
            // 
            this.tbSelectDir.Location = new System.Drawing.Point(84, 202);
            this.tbSelectDir.Name = "tbSelectDir";
            this.tbSelectDir.Size = new System.Drawing.Size(174, 21);
            this.tbSelectDir.TabIndex = 1;
            // 
            // cbExistIgnore
            // 
            this.cbExistIgnore.AutoSize = true;
            this.cbExistIgnore.Location = new System.Drawing.Point(299, 163);
            this.cbExistIgnore.Name = "cbExistIgnore";
            this.cbExistIgnore.Size = new System.Drawing.Size(180, 16);
            this.cbExistIgnore.TabIndex = 7;
            this.cbExistIgnore.Text = "文件存在时跳过忽略上传下载";
            this.cbExistIgnore.UseVisualStyleBackColor = true;
            // 
            // ivPassword
            // 
            this.ivPassword.Location = new System.Drawing.Point(508, 125);
            this.ivPassword.Name = "ivPassword";
            this.ivPassword.Size = new System.Drawing.Size(16, 16);
            this.ivPassword.TabIndex = 8;
            // 
            // cbSftp
            // 
            this.cbSftp.AutoSize = true;
            this.cbSftp.Location = new System.Drawing.Point(413, 87);
            this.cbSftp.Name = "cbSftp";
            this.cbSftp.Size = new System.Drawing.Size(48, 16);
            this.cbSftp.TabIndex = 3;
            this.cbSftp.Text = "Sftp";
            this.cbSftp.UseVisualStyleBackColor = true;
            // 
            // rbListDirFile
            // 
            this.rbListDirFile.AutoSize = true;
            this.rbListDirFile.Location = new System.Drawing.Point(428, 50);
            this.rbListDirFile.Name = "rbListDirFile";
            this.rbListDirFile.Size = new System.Drawing.Size(107, 16);
            this.rbListDirFile.TabIndex = 5;
            this.rbListDirFile.TabStop = true;
            this.rbListDirFile.Text = "遍历目录中文件";
            this.rbListDirFile.UseVisualStyleBackColor = true;
            this.rbListDirFile.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbListDirDir
            // 
            this.rbListDirDir.AutoSize = true;
            this.rbListDirDir.Location = new System.Drawing.Point(428, 20);
            this.rbListDirDir.Name = "rbListDirDir";
            this.rbListDirDir.Size = new System.Drawing.Size(107, 16);
            this.rbListDirDir.TabIndex = 5;
            this.rbListDirDir.TabStop = true;
            this.rbListDirDir.Text = "遍历目录中目录";
            this.rbListDirDir.UseVisualStyleBackColor = true;
            this.rbListDirDir.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // ivSelectDir
            // 
            this.ivSelectDir.Location = new System.Drawing.Point(264, 204);
            this.ivSelectDir.Name = "ivSelectDir";
            this.ivSelectDir.Size = new System.Drawing.Size(16, 16);
            this.ivSelectDir.TabIndex = 9;
            // 
            // rbUploadDir
            // 
            this.rbUploadDir.AutoSize = true;
            this.rbUploadDir.Location = new System.Drawing.Point(86, 50);
            this.rbUploadDir.Name = "rbUploadDir";
            this.rbUploadDir.Size = new System.Drawing.Size(71, 16);
            this.rbUploadDir.TabIndex = 10;
            this.rbUploadDir.TabStop = true;
            this.rbUploadDir.Text = "上传目录";
            this.rbUploadDir.UseVisualStyleBackColor = true;
            // 
            // rbDownloadDir
            // 
            this.rbDownloadDir.AutoSize = true;
            this.rbDownloadDir.Location = new System.Drawing.Point(190, 50);
            this.rbDownloadDir.Name = "rbDownloadDir";
            this.rbDownloadDir.Size = new System.Drawing.Size(71, 16);
            this.rbDownloadDir.TabIndex = 10;
            this.rbDownloadDir.TabStop = true;
            this.rbDownloadDir.Text = "下载目录";
            this.rbDownloadDir.UseVisualStyleBackColor = true;
            // 
            // rbDeleteDir
            // 
            this.rbDeleteDir.AutoSize = true;
            this.rbDeleteDir.Location = new System.Drawing.Point(299, 50);
            this.rbDeleteDir.Name = "rbDeleteDir";
            this.rbDeleteDir.Size = new System.Drawing.Size(71, 16);
            this.rbDeleteDir.TabIndex = 11;
            this.rbDeleteDir.TabStop = true;
            this.rbDeleteDir.Text = "删除目录";
            this.rbDeleteDir.UseVisualStyleBackColor = true;
            // 
            // FtpUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FtpUI";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private litsdk.InsertVarName ivPassword;
        private System.Windows.Forms.CheckBox cbExistIgnore;
        private litsdk.SelectVarName svFileVarName;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.RadioButton rbDownload;
        private System.Windows.Forms.RadioButton rbUpload;
        private litsdk.InsertVarName ivPort;
        private litsdk.InsertVarName ivUserName;
        private litsdk.InsertVarName ivServer;
        private System.Windows.Forms.CheckBox cbPassive;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbSelectDir;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label lbDirInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbFileInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbSftp;
        private System.Windows.Forms.RadioButton rbListDirDir;
        private System.Windows.Forms.RadioButton rbListDirFile;
        private litsdk.InsertVarName ivSelectDir;
        private System.Windows.Forms.RadioButton rbDownloadDir;
        private System.Windows.Forms.RadioButton rbUploadDir;
        private System.Windows.Forms.RadioButton rbDeleteDir;
    }
}
