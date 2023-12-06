namespace litstudio
{
    partial class StrLogicUI
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
            this.svVarName = new litsdk.SelectVarName();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbNumber = new System.Windows.Forms.RadioButton();
            this.rbPhone = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.rbDateTime = new System.Windows.Forms.RadioButton();
            this.rbLetter = new System.Windows.Forms.RadioButton();
            this.rbChinese = new System.Windows.Forms.RadioButton();
            this.tbRegexPattern = new System.Windows.Forms.TextBox();
            this.rbRegex = new System.Windows.Forms.RadioButton();
            this.rbUrl = new System.Windows.Forms.RadioButton();
            this.rbIP = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.tbRegexPattern);
            this.scActivityUI.Panel1.Controls.Add(this.rbRegex);
            this.scActivityUI.Panel1.Controls.Add(this.rbChinese);
            this.scActivityUI.Panel1.Controls.Add(this.rbIP);
            this.scActivityUI.Panel1.Controls.Add(this.rbUrl);
            this.scActivityUI.Panel1.Controls.Add(this.rbLetter);
            this.scActivityUI.Panel1.Controls.Add(this.rbDateTime);
            this.scActivityUI.Panel1.Controls.Add(this.rbEmail);
            this.scActivityUI.Panel1.Controls.Add(this.rbPhone);
            this.scActivityUI.Panel1.Controls.Add(this.rbNumber);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.svVarName);
            // 
            // svVarName
            // 
            this.svVarName.Location = new System.Drawing.Point(94, 188);
            this.svVarName.Name = "svVarName";
            this.svVarName.Size = new System.Drawing.Size(162, 23);
            this.svVarName.TabIndex = 0;
            this.svVarName.VarName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作变量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "判断类型";
            // 
            // rbNumber
            // 
            this.rbNumber.AutoSize = true;
            this.rbNumber.Location = new System.Drawing.Point(103, 21);
            this.rbNumber.Name = "rbNumber";
            this.rbNumber.Size = new System.Drawing.Size(47, 16);
            this.rbNumber.TabIndex = 2;
            this.rbNumber.TabStop = true;
            this.rbNumber.Text = "数字";
            this.rbNumber.UseVisualStyleBackColor = true;
            // 
            // rbPhone
            // 
            this.rbPhone.AutoSize = true;
            this.rbPhone.Location = new System.Drawing.Point(160, 21);
            this.rbPhone.Name = "rbPhone";
            this.rbPhone.Size = new System.Drawing.Size(59, 16);
            this.rbPhone.TabIndex = 2;
            this.rbPhone.TabStop = true;
            this.rbPhone.Text = "手机号";
            this.rbPhone.UseVisualStyleBackColor = true;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(225, 21);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(47, 16);
            this.rbEmail.TabIndex = 2;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "邮箱";
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // rbDateTime
            // 
            this.rbDateTime.AutoSize = true;
            this.rbDateTime.Location = new System.Drawing.Point(278, 21);
            this.rbDateTime.Name = "rbDateTime";
            this.rbDateTime.Size = new System.Drawing.Size(47, 16);
            this.rbDateTime.TabIndex = 2;
            this.rbDateTime.TabStop = true;
            this.rbDateTime.Text = "日期";
            this.rbDateTime.UseVisualStyleBackColor = true;
            // 
            // rbLetter
            // 
            this.rbLetter.AutoSize = true;
            this.rbLetter.Location = new System.Drawing.Point(331, 21);
            this.rbLetter.Name = "rbLetter";
            this.rbLetter.Size = new System.Drawing.Size(47, 16);
            this.rbLetter.TabIndex = 2;
            this.rbLetter.TabStop = true;
            this.rbLetter.Text = "字母";
            this.rbLetter.UseVisualStyleBackColor = true;
            // 
            // rbChinese
            // 
            this.rbChinese.AutoSize = true;
            this.rbChinese.Location = new System.Drawing.Point(103, 67);
            this.rbChinese.Name = "rbChinese";
            this.rbChinese.Size = new System.Drawing.Size(47, 16);
            this.rbChinese.TabIndex = 2;
            this.rbChinese.TabStop = true;
            this.rbChinese.Text = "汉字";
            this.rbChinese.UseVisualStyleBackColor = true;
            // 
            // tbRegexPattern
            // 
            this.tbRegexPattern.Location = new System.Drawing.Point(192, 111);
            this.tbRegexPattern.Name = "tbRegexPattern";
            this.tbRegexPattern.Size = new System.Drawing.Size(151, 21);
            this.tbRegexPattern.TabIndex = 3;
            this.tbRegexPattern.Visible = false;
            // 
            // rbRegex
            // 
            this.rbRegex.AutoSize = true;
            this.rbRegex.Location = new System.Drawing.Point(103, 113);
            this.rbRegex.Name = "rbRegex";
            this.rbRegex.Size = new System.Drawing.Size(83, 16);
            this.rbRegex.TabIndex = 2;
            this.rbRegex.TabStop = true;
            this.rbRegex.Text = "正则表达式";
            this.rbRegex.UseVisualStyleBackColor = true;
            this.rbRegex.CheckedChanged += new System.EventHandler(this.rbRegex_CheckedChanged);
            // 
            // rbUrl
            // 
            this.rbUrl.AutoSize = true;
            this.rbUrl.Location = new System.Drawing.Point(160, 67);
            this.rbUrl.Name = "rbUrl";
            this.rbUrl.Size = new System.Drawing.Size(47, 16);
            this.rbUrl.TabIndex = 2;
            this.rbUrl.TabStop = true;
            this.rbUrl.Text = "网址";
            this.rbUrl.UseVisualStyleBackColor = true;
            // 
            // rbIP
            // 
            this.rbIP.AutoSize = true;
            this.rbIP.Location = new System.Drawing.Point(225, 67);
            this.rbIP.Name = "rbIP";
            this.rbIP.Size = new System.Drawing.Size(59, 16);
            this.rbIP.TabIndex = 2;
            this.rbIP.TabStop = true;
            this.rbIP.Text = "IP地址";
            this.rbIP.UseVisualStyleBackColor = true;
            // 
            // StrLogicUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "StrLogicUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private litsdk.SelectVarName svVarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbPhone;
        private System.Windows.Forms.RadioButton rbNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDateTime;
        private System.Windows.Forms.TextBox tbRegexPattern;
        private System.Windows.Forms.RadioButton rbRegex;
        private System.Windows.Forms.RadioButton rbChinese;
        private System.Windows.Forms.RadioButton rbLetter;
        private System.Windows.Forms.RadioButton rbIP;
        private System.Windows.Forms.RadioButton rbUrl;
    }
}
