namespace litmail
{
    partial class SendMailUI
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
            this.标题 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.svAttachments = new litsdk.SelectVarName();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.ivSubject = new litsdk.InsertVarName();
            this.tbMailTo = new System.Windows.Forms.TextBox();
            this.ivMailTo = new litsdk.InsertVarName();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.ivBody = new litsdk.InsertVarName();
            this.llbShowDatabase = new System.Windows.Forms.LinkLabel();
            this.cbConfigName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSenderNick = new System.Windows.Forms.TextBox();
            this.tbReceiverNick = new System.Windows.Forms.TextBox();
            this.ivSenderNick = new litsdk.InsertVarName();
            this.ivReceiverNick = new litsdk.InsertVarName();
            this.label8 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.ivReceiverNick);
            this.scActivityUI.Panel1.Controls.Add(this.ivSenderNick);
            this.scActivityUI.Panel1.Controls.Add(this.tbReceiverNick);
            this.scActivityUI.Panel1.Controls.Add(this.tbSenderNick);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.llbShowDatabase);
            this.scActivityUI.Panel1.Controls.Add(this.cbConfigName);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.ivBody);
            this.scActivityUI.Panel1.Controls.Add(this.ivMailTo);
            this.scActivityUI.Panel1.Controls.Add(this.ivSubject);
            this.scActivityUI.Panel1.Controls.Add(this.tbBody);
            this.scActivityUI.Panel1.Controls.Add(this.tbMailTo);
            this.scActivityUI.Panel1.Controls.Add(this.tbSubject);
            this.scActivityUI.Panel1.Controls.Add(this.svAttachments);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.标题);
            // 
            // 标题
            // 
            this.标题.AutoSize = true;
            this.标题.Location = new System.Drawing.Point(34, 113);
            this.标题.Name = "标题";
            this.标题.Size = new System.Drawing.Size(53, 12);
            this.标题.TabIndex = 0;
            this.标题.Text = "邮件标题";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "邮件内容";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "邮件附件";
            // 
            // svAttachments
            // 
            this.svAttachments.Location = new System.Drawing.Point(362, 43);
            this.svAttachments.Name = "svAttachments";
            this.svAttachments.Size = new System.Drawing.Size(173, 23);
            this.svAttachments.TabIndex = 2;
            this.svAttachments.VarName = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "收件人邮箱";
            // 
            // tbSubject
            // 
            this.tbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSubject.Location = new System.Drawing.Point(95, 109);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(418, 21);
            this.tbSubject.TabIndex = 3;
            // 
            // ivSubject
            // 
            this.ivSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivSubject.Location = new System.Drawing.Point(516, 110);
            this.ivSubject.Name = "ivSubject";
            this.ivSubject.Size = new System.Drawing.Size(16, 16);
            this.ivSubject.TabIndex = 4;
            // 
            // tbMailTo
            // 
            this.tbMailTo.Location = new System.Drawing.Point(95, 45);
            this.tbMailTo.Name = "tbMailTo";
            this.tbMailTo.Size = new System.Drawing.Size(149, 21);
            this.tbMailTo.TabIndex = 3;
            // 
            // ivMailTo
            // 
            this.ivMailTo.Location = new System.Drawing.Point(249, 45);
            this.ivMailTo.Name = "ivMailTo";
            this.ivMailTo.Size = new System.Drawing.Size(16, 16);
            this.ivMailTo.TabIndex = 4;
            // 
            // tbBody
            // 
            this.tbBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBody.Location = new System.Drawing.Point(95, 145);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(418, 77);
            this.tbBody.TabIndex = 3;
            // 
            // ivBody
            // 
            this.ivBody.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivBody.Location = new System.Drawing.Point(515, 147);
            this.ivBody.Name = "ivBody";
            this.ivBody.Size = new System.Drawing.Size(16, 16);
            this.ivBody.TabIndex = 8;
            // 
            // llbShowDatabase
            // 
            this.llbShowDatabase.AutoSize = true;
            this.llbShowDatabase.Location = new System.Drawing.Point(247, 18);
            this.llbShowDatabase.Name = "llbShowDatabase";
            this.llbShowDatabase.Size = new System.Drawing.Size(29, 12);
            this.llbShowDatabase.TabIndex = 61;
            this.llbShowDatabase.TabStop = true;
            this.llbShowDatabase.Text = "管理";
            this.llbShowDatabase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowDatabase_LinkClicked);
            // 
            // cbConfigName
            // 
            this.cbConfigName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConfigName.FormattingEnabled = true;
            this.cbConfigName.Location = new System.Drawing.Point(95, 14);
            this.cbConfigName.Name = "cbConfigName";
            this.cbConfigName.Size = new System.Drawing.Size(149, 20);
            this.cbConfigName.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 59;
            this.label7.Text = "选择邮箱配置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 62;
            this.label2.Text = "发件人昵称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 63;
            this.label5.Text = "收件人昵称";
            // 
            // tbSenderNick
            // 
            this.tbSenderNick.Location = new System.Drawing.Point(95, 77);
            this.tbSenderNick.Name = "tbSenderNick";
            this.tbSenderNick.Size = new System.Drawing.Size(149, 21);
            this.tbSenderNick.TabIndex = 64;
            // 
            // tbReceiverNick
            // 
            this.tbReceiverNick.Location = new System.Drawing.Point(362, 74);
            this.tbReceiverNick.Name = "tbReceiverNick";
            this.tbReceiverNick.Size = new System.Drawing.Size(149, 21);
            this.tbReceiverNick.TabIndex = 65;
            // 
            // ivSenderNick
            // 
            this.ivSenderNick.Location = new System.Drawing.Point(248, 79);
            this.ivSenderNick.Name = "ivSenderNick";
            this.ivSenderNick.Size = new System.Drawing.Size(16, 16);
            this.ivSenderNick.TabIndex = 66;
            // 
            // ivReceiverNick
            // 
            this.ivReceiverNick.Location = new System.Drawing.Point(514, 74);
            this.ivReceiverNick.Name = "ivReceiverNick";
            this.ivReceiverNick.Size = new System.Drawing.Size(16, 16);
            this.ivReceiverNick.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(294, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 12);
            this.label8.TabIndex = 68;
            this.label8.Text = "邮件内容为纯文本，有附件就不能附件为空";
            // 
            // SendMailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SendMailUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label 标题;
        private System.Windows.Forms.Label label4;
        private litsdk.InsertVarName ivMailTo;
        private litsdk.InsertVarName ivSubject;
        private System.Windows.Forms.TextBox tbMailTo;
        private System.Windows.Forms.TextBox tbSubject;
        private litsdk.SelectVarName svAttachments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private litsdk.InsertVarName ivBody;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.LinkLabel llbShowDatabase;
        private System.Windows.Forms.ComboBox cbConfigName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private litsdk.InsertVarName ivReceiverNick;
        private litsdk.InsertVarName ivSenderNick;
        private System.Windows.Forms.TextBox tbReceiverNick;
        private System.Windows.Forms.TextBox tbSenderNick;
        private System.Windows.Forms.Label label8;
    }
}
