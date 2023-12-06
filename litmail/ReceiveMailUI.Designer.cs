namespace litmail
{
    partial class ReceiveMailUI
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
            this.ivSenderContains = new litsdk.InsertVarName();
            this.tbSenderContains = new System.Windows.Forms.TextBox();
            this.svVarAttachments = new litsdk.SelectVarName();
            this.svVarBody = new litsdk.SelectVarName();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAttachments = new System.Windows.Forms.Label();
            this.lbBody = new System.Windows.Forms.Label();
            this.标题 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBodyContains = new System.Windows.Forms.TextBox();
            this.ivSubjectContains = new litsdk.InsertVarName();
            this.tbSubjectContains = new System.Windows.Forms.TextBox();
            this.ivBodyContains = new litsdk.InsertVarName();
            this.ivLaterThan = new litsdk.InsertVarName();
            this.tbLaterThan = new System.Windows.Forms.TextBox();
            this.svVarSender = new litsdk.SelectVarName();
            this.svVarSubject = new litsdk.SelectVarName();
            this.lbSender = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbConfigName = new System.Windows.Forms.ComboBox();
            this.llbShowDatabase = new System.Windows.Forms.LinkLabel();
            this.lbAllEmail = new System.Windows.Forms.Label();
            this.svVarAllMail = new litsdk.SelectVarName();
            this.lbNotice = new System.Windows.Forms.Label();
            this.cbSaveAllEmail = new System.Windows.Forms.CheckBox();
            this.ckDeleteAfterGet = new System.Windows.Forms.CheckBox();
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
            this.scActivityUI.Panel1.Controls.Add(this.ckDeleteAfterGet);
            this.scActivityUI.Panel1.Controls.Add(this.cbSaveAllEmail);
            this.scActivityUI.Panel1.Controls.Add(this.lbNotice);
            this.scActivityUI.Panel1.Controls.Add(this.svVarAllMail);
            this.scActivityUI.Panel1.Controls.Add(this.lbAllEmail);
            this.scActivityUI.Panel1.Controls.Add(this.llbShowDatabase);
            this.scActivityUI.Panel1.Controls.Add(this.cbConfigName);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.svVarSender);
            this.scActivityUI.Panel1.Controls.Add(this.svVarSubject);
            this.scActivityUI.Panel1.Controls.Add(this.lbSender);
            this.scActivityUI.Panel1.Controls.Add(this.lbSubject);
            this.scActivityUI.Panel1.Controls.Add(this.ivLaterThan);
            this.scActivityUI.Panel1.Controls.Add(this.tbLaterThan);
            this.scActivityUI.Panel1.Controls.Add(this.ivBodyContains);
            this.scActivityUI.Panel1.Controls.Add(this.ivSubjectContains);
            this.scActivityUI.Panel1.Controls.Add(this.tbSubjectContains);
            this.scActivityUI.Panel1.Controls.Add(this.ivSenderContains);
            this.scActivityUI.Panel1.Controls.Add(this.tbBodyContains);
            this.scActivityUI.Panel1.Controls.Add(this.tbSenderContains);
            this.scActivityUI.Panel1.Controls.Add(this.svVarAttachments);
            this.scActivityUI.Panel1.Controls.Add(this.svVarBody);
            this.scActivityUI.Panel1.Controls.Add(this.label11);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.lbAttachments);
            this.scActivityUI.Panel1.Controls.Add(this.lbBody);
            this.scActivityUI.Panel1.Controls.Add(this.标题);
            // 
            // ivSenderContains
            // 
            this.ivSenderContains.Location = new System.Drawing.Point(529, 52);
            this.ivSenderContains.Name = "ivSenderContains";
            this.ivSenderContains.Size = new System.Drawing.Size(16, 16);
            this.ivSenderContains.TabIndex = 27;
            // 
            // tbSenderContains
            // 
            this.tbSenderContains.Location = new System.Drawing.Point(389, 51);
            this.tbSenderContains.Name = "tbSenderContains";
            this.tbSenderContains.Size = new System.Drawing.Size(134, 21);
            this.tbSenderContains.TabIndex = 23;
            // 
            // svVarAttachments
            // 
            this.svVarAttachments.Location = new System.Drawing.Point(391, 159);
            this.svVarAttachments.Name = "svVarAttachments";
            this.svVarAttachments.Size = new System.Drawing.Size(160, 23);
            this.svVarAttachments.TabIndex = 18;
            this.svVarAttachments.VarName = "";
            this.svVarAttachments.Visible = false;
            // 
            // svVarBody
            // 
            this.svVarBody.Location = new System.Drawing.Point(108, 159);
            this.svVarBody.Name = "svVarBody";
            this.svVarBody.Size = new System.Drawing.Size(160, 23);
            this.svVarBody.TabIndex = 17;
            this.svVarBody.VarName = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "收件时间晚于";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "发件人包含";
            // 
            // lbAttachments
            // 
            this.lbAttachments.AutoSize = true;
            this.lbAttachments.Location = new System.Drawing.Point(304, 164);
            this.lbAttachments.Name = "lbAttachments";
            this.lbAttachments.Size = new System.Drawing.Size(77, 12);
            this.lbAttachments.TabIndex = 13;
            this.lbAttachments.Text = "邮件附件存入";
            this.lbAttachments.Visible = false;
            // 
            // lbBody
            // 
            this.lbBody.AutoSize = true;
            this.lbBody.Location = new System.Drawing.Point(23, 165);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(77, 12);
            this.lbBody.TabIndex = 12;
            this.lbBody.Text = "邮件内容存入";
            // 
            // 标题
            // 
            this.标题.AutoSize = true;
            this.标题.Location = new System.Drawing.Point(24, 59);
            this.标题.Name = "标题";
            this.标题.Size = new System.Drawing.Size(77, 12);
            this.标题.TabIndex = 8;
            this.标题.Text = "邮件标题包含";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "收件内容包含";
            // 
            // tbBodyContains
            // 
            this.tbBodyContains.Location = new System.Drawing.Point(107, 89);
            this.tbBodyContains.Name = "tbBodyContains";
            this.tbBodyContains.Size = new System.Drawing.Size(134, 21);
            this.tbBodyContains.TabIndex = 23;
            // 
            // ivSubjectContains
            // 
            this.ivSubjectContains.Location = new System.Drawing.Point(247, 56);
            this.ivSubjectContains.Name = "ivSubjectContains";
            this.ivSubjectContains.Size = new System.Drawing.Size(16, 16);
            this.ivSubjectContains.TabIndex = 44;
            // 
            // tbSubjectContains
            // 
            this.tbSubjectContains.Location = new System.Drawing.Point(107, 54);
            this.tbSubjectContains.Name = "tbSubjectContains";
            this.tbSubjectContains.Size = new System.Drawing.Size(134, 21);
            this.tbSubjectContains.TabIndex = 43;
            // 
            // ivBodyContains
            // 
            this.ivBodyContains.Location = new System.Drawing.Point(244, 92);
            this.ivBodyContains.Name = "ivBodyContains";
            this.ivBodyContains.Size = new System.Drawing.Size(16, 16);
            this.ivBodyContains.TabIndex = 45;
            // 
            // ivLaterThan
            // 
            this.ivLaterThan.Location = new System.Drawing.Point(530, 89);
            this.ivLaterThan.Name = "ivLaterThan";
            this.ivLaterThan.Size = new System.Drawing.Size(16, 16);
            this.ivLaterThan.TabIndex = 47;
            // 
            // tbLaterThan
            // 
            this.tbLaterThan.Location = new System.Drawing.Point(389, 87);
            this.tbLaterThan.Name = "tbLaterThan";
            this.tbLaterThan.Size = new System.Drawing.Size(134, 21);
            this.tbLaterThan.TabIndex = 46;
            // 
            // svVarSender
            // 
            this.svVarSender.Location = new System.Drawing.Point(389, 123);
            this.svVarSender.Name = "svVarSender";
            this.svVarSender.Size = new System.Drawing.Size(160, 23);
            this.svVarSender.TabIndex = 51;
            this.svVarSender.VarName = "";
            // 
            // svVarSubject
            // 
            this.svVarSubject.Location = new System.Drawing.Point(107, 125);
            this.svVarSubject.Name = "svVarSubject";
            this.svVarSubject.Size = new System.Drawing.Size(160, 23);
            this.svVarSubject.TabIndex = 50;
            this.svVarSubject.VarName = "";
            // 
            // lbSender
            // 
            this.lbSender.AutoSize = true;
            this.lbSender.Location = new System.Drawing.Point(318, 129);
            this.lbSender.Name = "lbSender";
            this.lbSender.Size = new System.Drawing.Size(65, 12);
            this.lbSender.TabIndex = 49;
            this.lbSender.Text = "发件人存入";
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(24, 129);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(77, 12);
            this.lbSubject.TabIndex = 48;
            this.lbSubject.Text = "邮件标题存入";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 52;
            this.label2.Text = "选择邮箱配置";
            // 
            // cbConfigName
            // 
            this.cbConfigName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConfigName.FormattingEnabled = true;
            this.cbConfigName.Location = new System.Drawing.Point(108, 18);
            this.cbConfigName.Name = "cbConfigName";
            this.cbConfigName.Size = new System.Drawing.Size(133, 20);
            this.cbConfigName.TabIndex = 53;
            // 
            // llbShowDatabase
            // 
            this.llbShowDatabase.AutoSize = true;
            this.llbShowDatabase.Location = new System.Drawing.Point(250, 22);
            this.llbShowDatabase.Name = "llbShowDatabase";
            this.llbShowDatabase.Size = new System.Drawing.Size(29, 12);
            this.llbShowDatabase.TabIndex = 54;
            this.llbShowDatabase.TabStop = true;
            this.llbShowDatabase.Text = "管理";
            this.llbShowDatabase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowDatabase_LinkClicked);
            // 
            // lbAllEmail
            // 
            this.lbAllEmail.AutoSize = true;
            this.lbAllEmail.Location = new System.Drawing.Point(24, 198);
            this.lbAllEmail.Name = "lbAllEmail";
            this.lbAllEmail.Size = new System.Drawing.Size(77, 12);
            this.lbAllEmail.TabIndex = 55;
            this.lbAllEmail.Text = "所有邮件存入";
            this.lbAllEmail.Visible = false;
            // 
            // svVarAllMail
            // 
            this.svVarAllMail.Location = new System.Drawing.Point(108, 194);
            this.svVarAllMail.Name = "svVarAllMail";
            this.svVarAllMail.Size = new System.Drawing.Size(160, 23);
            this.svVarAllMail.TabIndex = 56;
            this.svVarAllMail.VarName = "";
            this.svVarAllMail.Visible = false;
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.ForeColor = System.Drawing.Color.Green;
            this.lbNotice.Location = new System.Drawing.Point(105, 220);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(377, 12);
            this.lbNotice.TabIndex = 57;
            this.lbNotice.Text = "所有邮件存入表格，表头为 Subject Sender Body。只选最近10条邮件";
            // 
            // cbSaveAllEmail
            // 
            this.cbSaveAllEmail.AutoSize = true;
            this.cbSaveAllEmail.Location = new System.Drawing.Point(308, 22);
            this.cbSaveAllEmail.Name = "cbSaveAllEmail";
            this.cbSaveAllEmail.Size = new System.Drawing.Size(252, 16);
            this.cbSaveAllEmail.TabIndex = 58;
            this.cbSaveAllEmail.Text = "将符合条件邮件存入表格变量，反之单邮件";
            this.cbSaveAllEmail.UseVisualStyleBackColor = true;
            this.cbSaveAllEmail.CheckedChanged += new System.EventHandler(this.cbSaveAllEmail_CheckedChanged);
            // 
            // ckDeleteAfterGet
            // 
            this.ckDeleteAfterGet.AutoSize = true;
            this.ckDeleteAfterGet.Location = new System.Drawing.Point(308, 194);
            this.ckDeleteAfterGet.Name = "ckDeleteAfterGet";
            this.ckDeleteAfterGet.Size = new System.Drawing.Size(192, 16);
            this.ckDeleteAfterGet.TabIndex = 59;
            this.ckDeleteAfterGet.Text = "提取到邮件后删除服务器上邮件";
            this.ckDeleteAfterGet.UseVisualStyleBackColor = true;
            // 
            // ReceiveMailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ReceiveMailUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private litsdk.InsertVarName ivSenderContains;
        private System.Windows.Forms.TextBox tbSenderContains;
        private litsdk.SelectVarName svVarAttachments;
        private litsdk.SelectVarName svVarBody;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAttachments;
        private System.Windows.Forms.Label lbBody;
        private System.Windows.Forms.Label 标题;
        private litsdk.SelectVarName svVarSender;
        private litsdk.SelectVarName svVarSubject;
        private System.Windows.Forms.Label lbSender;
        private System.Windows.Forms.Label lbSubject;
        private litsdk.InsertVarName ivLaterThan;
        private System.Windows.Forms.TextBox tbLaterThan;
        private litsdk.InsertVarName ivBodyContains;
        private litsdk.InsertVarName ivSubjectContains;
        private System.Windows.Forms.TextBox tbSubjectContains;
        private System.Windows.Forms.TextBox tbBodyContains;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbConfigName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llbShowDatabase;
        private System.Windows.Forms.Label lbNotice;
        private litsdk.SelectVarName svVarAllMail;
        private System.Windows.Forms.Label lbAllEmail;
        private System.Windows.Forms.CheckBox cbSaveAllEmail;
        private System.Windows.Forms.CheckBox ckDeleteAfterGet;
    }
}
