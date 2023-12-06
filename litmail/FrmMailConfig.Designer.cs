namespace litmail
{
    partial class FrmMailConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbEmailConfigs = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.llbNew = new System.Windows.Forms.LinkLabel();
            this.llbEdit = new System.Windows.Forms.LinkLabel();
            this.llbDelete = new System.Windows.Forms.LinkLabel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbSMTPHost = new System.Windows.Forms.TextBox();
            this.cbEmailType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbHost = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPop3IMAPPort = new System.Windows.Forms.TextBox();
            this.tbPop3IMAPHost = new System.Windows.Forms.TextBox();
            this.ivpassword = new litsdk.InsertVarName();
            this.ivPOP3IMAPHost = new litsdk.InsertVarName();
            this.ivSMTPHost = new litsdk.InsertVarName();
            this.ivusername = new litsdk.InsertVarName();
            this.cbPop3IMAPSSL = new System.Windows.Forms.CheckBox();
            this.cbSMTPSSL = new System.Windows.Forms.CheckBox();
            this.tbSMTPPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSTARTTLS = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbEmailConfigs
            // 
            this.lbEmailConfigs.FormattingEnabled = true;
            this.lbEmailConfigs.ItemHeight = 12;
            this.lbEmailConfigs.Location = new System.Drawing.Point(19, 21);
            this.lbEmailConfigs.Name = "lbEmailConfigs";
            this.lbEmailConfigs.Size = new System.Drawing.Size(111, 220);
            this.lbEmailConfigs.TabIndex = 18;
            this.lbEmailConfigs.SelectedIndexChanged += new System.EventHandler(this.lbDBConfigs_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(344, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(252, 254);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // llbNew
            // 
            this.llbNew.AutoSize = true;
            this.llbNew.Location = new System.Drawing.Point(18, 257);
            this.llbNew.Name = "llbNew";
            this.llbNew.Size = new System.Drawing.Size(29, 12);
            this.llbNew.TabIndex = 20;
            this.llbNew.TabStop = true;
            this.llbNew.Text = "添加";
            this.llbNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbNew_LinkClicked);
            // 
            // llbEdit
            // 
            this.llbEdit.AutoSize = true;
            this.llbEdit.Location = new System.Drawing.Point(58, 257);
            this.llbEdit.Name = "llbEdit";
            this.llbEdit.Size = new System.Drawing.Size(29, 12);
            this.llbEdit.TabIndex = 20;
            this.llbEdit.TabStop = true;
            this.llbEdit.Text = "编辑";
            this.llbEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEdit_LinkClicked);
            // 
            // llbDelete
            // 
            this.llbDelete.AutoSize = true;
            this.llbDelete.Location = new System.Drawing.Point(100, 257);
            this.llbDelete.Name = "llbDelete";
            this.llbDelete.Size = new System.Drawing.Size(29, 12);
            this.llbDelete.TabIndex = 20;
            this.llbDelete.TabStop = true;
            this.llbDelete.Text = "删除";
            this.llbDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDelete_LinkClicked);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(214, 122);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(223, 21);
            this.tbPassword.TabIndex = 6;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(214, 91);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(223, 21);
            this.tbUserName.TabIndex = 5;
            // 
            // tbSMTPHost
            // 
            this.tbSMTPHost.Location = new System.Drawing.Point(214, 190);
            this.tbSMTPHost.Name = "tbSMTPHost";
            this.tbSMTPHost.Size = new System.Drawing.Size(124, 21);
            this.tbSMTPHost.TabIndex = 2;
            // 
            // cbEmailType
            // 
            this.cbEmailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmailType.FormattingEnabled = true;
            this.cbEmailType.Items.AddRange(new object[] {
            "POP3",
            "IMAP",
            "Exchange"});
            this.cbEmailType.Location = new System.Drawing.Point(214, 56);
            this.cbEmailType.Name = "cbEmailType";
            this.cbEmailType.Size = new System.Drawing.Size(223, 20);
            this.cbEmailType.TabIndex = 1;
            this.cbEmailType.SelectedIndexChanged += new System.EventHandler(this.cbDatabaseType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "SMTP服务器";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "端口";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "邮件帐号";
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Location = new System.Drawing.Point(151, 161);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(59, 12);
            this.lbHost.TabIndex = 28;
            this.lbHost.Text = "POP服务器";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "密码";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(158, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 26;
            this.label13.Text = "收件协议";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "配置名称";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(214, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(223, 21);
            this.tbName.TabIndex = 0;
            // 
            // tbPop3IMAPPort
            // 
            this.tbPop3IMAPPort.Location = new System.Drawing.Point(441, 156);
            this.tbPop3IMAPPort.Name = "tbPop3IMAPPort";
            this.tbPop3IMAPPort.Size = new System.Drawing.Size(30, 21);
            this.tbPop3IMAPPort.TabIndex = 3;
            this.tbPop3IMAPPort.Text = "110";
            // 
            // tbPop3IMAPHost
            // 
            this.tbPop3IMAPHost.Location = new System.Drawing.Point(214, 157);
            this.tbPop3IMAPHost.Name = "tbPop3IMAPHost";
            this.tbPop3IMAPHost.Size = new System.Drawing.Size(124, 21);
            this.tbPop3IMAPHost.TabIndex = 7;
            // 
            // ivpassword
            // 
            this.ivpassword.Location = new System.Drawing.Point(451, 122);
            this.ivpassword.Name = "ivpassword";
            this.ivpassword.Size = new System.Drawing.Size(20, 23);
            this.ivpassword.TabIndex = 12;
            // 
            // ivPOP3IMAPHost
            // 
            this.ivPOP3IMAPHost.Location = new System.Drawing.Point(344, 157);
            this.ivPOP3IMAPHost.Name = "ivPOP3IMAPHost";
            this.ivPOP3IMAPHost.Size = new System.Drawing.Size(20, 23);
            this.ivPOP3IMAPHost.TabIndex = 13;
            // 
            // ivSMTPHost
            // 
            this.ivSMTPHost.Location = new System.Drawing.Point(344, 190);
            this.ivSMTPHost.Name = "ivSMTPHost";
            this.ivSMTPHost.Size = new System.Drawing.Size(20, 23);
            this.ivSMTPHost.TabIndex = 14;
            // 
            // ivusername
            // 
            this.ivusername.Location = new System.Drawing.Point(451, 95);
            this.ivusername.Name = "ivusername";
            this.ivusername.Size = new System.Drawing.Size(20, 23);
            this.ivusername.TabIndex = 15;
            // 
            // cbPop3IMAPSSL
            // 
            this.cbPop3IMAPSSL.AutoSize = true;
            this.cbPop3IMAPSSL.Location = new System.Drawing.Point(370, 159);
            this.cbPop3IMAPSSL.Name = "cbPop3IMAPSSL";
            this.cbPop3IMAPSSL.Size = new System.Drawing.Size(42, 16);
            this.cbPop3IMAPSSL.TabIndex = 43;
            this.cbPop3IMAPSSL.Text = "SSL";
            this.cbPop3IMAPSSL.UseVisualStyleBackColor = true;
            // 
            // cbSMTPSSL
            // 
            this.cbSMTPSSL.AutoSize = true;
            this.cbSMTPSSL.Location = new System.Drawing.Point(370, 194);
            this.cbSMTPSSL.Name = "cbSMTPSSL";
            this.cbSMTPSSL.Size = new System.Drawing.Size(42, 16);
            this.cbSMTPSSL.TabIndex = 46;
            this.cbSMTPSSL.Text = "SSL";
            this.cbSMTPSSL.UseVisualStyleBackColor = true;
            // 
            // tbSMTPPort
            // 
            this.tbSMTPPort.Location = new System.Drawing.Point(441, 191);
            this.tbSMTPPort.Name = "tbSMTPPort";
            this.tbSMTPPort.Size = new System.Drawing.Size(30, 21);
            this.tbSMTPPort.TabIndex = 44;
            this.tbSMTPPort.Text = "110";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "端口";
            // 
            // cbSTARTTLS
            // 
            this.cbSTARTTLS.AutoSize = true;
            this.cbSTARTTLS.Location = new System.Drawing.Point(214, 224);
            this.cbSTARTTLS.Name = "cbSTARTTLS";
            this.cbSTARTTLS.Size = new System.Drawing.Size(228, 16);
            this.cbSTARTTLS.TabIndex = 47;
            this.cbSTARTTLS.Text = "如果服务器支持，用STARTTLS加密传输";
            this.cbSTARTTLS.UseVisualStyleBackColor = true;
            // 
            // FrEMailConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 289);
            this.Controls.Add(this.cbSTARTTLS);
            this.Controls.Add(this.cbSMTPSSL);
            this.Controls.Add(this.tbSMTPPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPop3IMAPSSL);
            this.Controls.Add(this.tbPop3IMAPPort);
            this.Controls.Add(this.tbPop3IMAPHost);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSMTPHost);
            this.Controls.Add(this.cbEmailType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbHost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.llbDelete);
            this.Controls.Add(this.llbEdit);
            this.Controls.Add(this.llbNew);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbEmailConfigs);
            this.Controls.Add(this.ivpassword);
            this.Controls.Add(this.ivPOP3IMAPHost);
            this.Controls.Add(this.ivSMTPHost);
            this.Controls.Add(this.ivusername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrEMailConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "邮箱配置";
            this.Load += new System.EventHandler(this.FrmMailConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private litsdk.InsertVarName ivpassword;
        private litsdk.InsertVarName ivPOP3IMAPHost;
        private litsdk.InsertVarName ivSMTPHost;
        private litsdk.InsertVarName ivusername;
        private System.Windows.Forms.ListBox lbEmailConfigs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.LinkLabel llbNew;
        private System.Windows.Forms.LinkLabel llbEdit;
        private System.Windows.Forms.LinkLabel llbDelete;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbSMTPHost;
        private System.Windows.Forms.ComboBox cbEmailType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPop3IMAPPort;
        private System.Windows.Forms.TextBox tbPop3IMAPHost;
        private System.Windows.Forms.CheckBox cbPop3IMAPSSL;
        private System.Windows.Forms.CheckBox cbSMTPSSL;
        private System.Windows.Forms.TextBox tbSMTPPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSTARTTLS;
    }
}