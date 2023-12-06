namespace litstudio.iecef
{
    partial class NavigateUI
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ivUrl = new litsdk.InsertVarName();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReferer = new System.Windows.Forms.TextBox();
            this.ivReferer = new litsdk.InsertVarName();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbPopUpOff = new System.Windows.Forms.RadioButton();
            this.rbPopUpOn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTimeOutSenconds = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gbAuthCredentials = new System.Windows.Forms.GroupBox();
            this.ivPassword = new litsdk.InsertVarName();
            this.ivUserName = new litsdk.InsertVarName();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAcceptLanguage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbChrSetting = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOutSenconds)).BeginInit();
            this.gbAuthCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.lbChrSetting);
            this.scActivityUI.Panel1.Controls.Add(this.tbAcceptLanguage);
            this.scActivityUI.Panel1.Controls.Add(this.label10);
            this.scActivityUI.Panel1.Controls.Add(this.label9);
            this.scActivityUI.Panel1.Controls.Add(this.gbAuthCredentials);
            this.scActivityUI.Panel1.Controls.Add(this.nudTimeOutSenconds);
            this.scActivityUI.Panel1.Controls.Add(this.panel2);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.ivReferer);
            this.scActivityUI.Panel1.Controls.Add(this.tbReferer);
            this.scActivityUI.Panel1.Controls.Add(this.tbUrl);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.ivUrl);
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(73, 19);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(463, 21);
            this.tbUrl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "打开网址";
            // 
            // ivUrl
            // 
            this.ivUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivUrl.Location = new System.Drawing.Point(542, 19);
            this.ivUrl.Name = "ivUrl";
            this.ivUrl.Size = new System.Drawing.Size(20, 21);
            this.ivUrl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "来源网址";
            // 
            // tbReferer
            // 
            this.tbReferer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReferer.Location = new System.Drawing.Point(73, 56);
            this.tbReferer.Name = "tbReferer";
            this.tbReferer.Size = new System.Drawing.Size(463, 21);
            this.tbReferer.TabIndex = 0;
            // 
            // ivReferer
            // 
            this.ivReferer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivReferer.Location = new System.Drawing.Point(542, 59);
            this.ivReferer.Name = "ivReferer";
            this.ivReferer.Size = new System.Drawing.Size(16, 16);
            this.ivReferer.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbPopUpOff);
            this.panel2.Controls.Add(this.rbPopUpOn);
            this.panel2.Location = new System.Drawing.Point(71, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 21);
            this.panel2.TabIndex = 5;
            // 
            // rbPopUpOff
            // 
            this.rbPopUpOff.AutoSize = true;
            this.rbPopUpOff.Location = new System.Drawing.Point(63, 3);
            this.rbPopUpOff.Name = "rbPopUpOff";
            this.rbPopUpOff.Size = new System.Drawing.Size(47, 16);
            this.rbPopUpOff.TabIndex = 0;
            this.rbPopUpOff.TabStop = true;
            this.rbPopUpOff.Text = "关闭";
            this.rbPopUpOff.UseVisualStyleBackColor = true;
            // 
            // rbPopUpOn
            // 
            this.rbPopUpOn.AutoSize = true;
            this.rbPopUpOn.Location = new System.Drawing.Point(3, 3);
            this.rbPopUpOn.Name = "rbPopUpOn";
            this.rbPopUpOn.Size = new System.Drawing.Size(47, 16);
            this.rbPopUpOn.TabIndex = 0;
            this.rbPopUpOn.TabStop = true;
            this.rbPopUpOn.Text = "开启";
            this.rbPopUpOn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "弹出窗口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "打开超时";
            // 
            // nudTimeOutSenconds
            // 
            this.nudTimeOutSenconds.Location = new System.Drawing.Point(286, 94);
            this.nudTimeOutSenconds.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudTimeOutSenconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeOutSenconds.Name = "nudTimeOutSenconds";
            this.nudTimeOutSenconds.Size = new System.Drawing.Size(66, 21);
            this.nudTimeOutSenconds.TabIndex = 6;
            this.nudTimeOutSenconds.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "秒";
            // 
            // gbAuthCredentials
            // 
            this.gbAuthCredentials.Controls.Add(this.ivPassword);
            this.gbAuthCredentials.Controls.Add(this.ivUserName);
            this.gbAuthCredentials.Controls.Add(this.tbPassword);
            this.gbAuthCredentials.Controls.Add(this.tbUserName);
            this.gbAuthCredentials.Controls.Add(this.label8);
            this.gbAuthCredentials.Controls.Add(this.label7);
            this.gbAuthCredentials.Location = new System.Drawing.Point(121, 165);
            this.gbAuthCredentials.Name = "gbAuthCredentials";
            this.gbAuthCredentials.Size = new System.Drawing.Size(441, 38);
            this.gbAuthCredentials.TabIndex = 8;
            this.gbAuthCredentials.TabStop = false;
            // 
            // ivPassword
            // 
            this.ivPassword.Location = new System.Drawing.Point(415, 14);
            this.ivPassword.Name = "ivPassword";
            this.ivPassword.Size = new System.Drawing.Size(16, 16);
            this.ivPassword.TabIndex = 5;
            // 
            // ivUserName
            // 
            this.ivUserName.Location = new System.Drawing.Point(182, 15);
            this.ivUserName.Name = "ivUserName";
            this.ivUserName.Size = new System.Drawing.Size(16, 16);
            this.ivUserName.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(268, 12);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(141, 21);
            this.tbPassword.TabIndex = 3;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(53, 12);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(123, 21);
            this.tbUserName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "用户名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Accept-Language";
            // 
            // tbAcceptLanguage
            // 
            this.tbAcceptLanguage.Location = new System.Drawing.Point(121, 138);
            this.tbAcceptLanguage.Name = "tbAcceptLanguage";
            this.tbAcceptLanguage.Size = new System.Drawing.Size(115, 21);
            this.tbAcceptLanguage.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "HTTP基本身份认证";
            // 
            // lbChrSetting
            // 
            this.lbChrSetting.AutoSize = true;
            this.lbChrSetting.Location = new System.Drawing.Point(471, 97);
            this.lbChrSetting.Name = "lbChrSetting";
            this.lbChrSetting.Size = new System.Drawing.Size(65, 12);
            this.lbChrSetting.TabIndex = 11;
            this.lbChrSetting.TabStop = true;
            this.lbChrSetting.Text = "浏览器配置";
            this.lbChrSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbChrSetting_LinkClicked);
            // 
            // NavigateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NavigateUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOutSenconds)).EndInit();
            this.gbAuthCredentials.ResumeLayout(false);
            this.gbAuthCredentials.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private litsdk.InsertVarName ivUrl;
        private System.Windows.Forms.Label label2;
        private litsdk.InsertVarName ivReferer;
        private System.Windows.Forms.TextBox tbReferer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbPopUpOff;
        private System.Windows.Forms.RadioButton rbPopUpOn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudTimeOutSenconds;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbAuthCredentials;
        private litsdk.InsertVarName ivPassword;
        private litsdk.InsertVarName ivUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAcceptLanguage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lbChrSetting;
    }
}
