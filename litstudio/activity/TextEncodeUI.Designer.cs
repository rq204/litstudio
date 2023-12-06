namespace litstudio
{
    partial class TextEncodeUI
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
            this.lbEncoding = new System.Windows.Forms.Label();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.rbdURLDecode = new System.Windows.Forms.RadioButton();
            this.rbdURLEncode = new System.Windows.Forms.RadioButton();
            this.rbdFromJsString = new System.Windows.Forms.RadioButton();
            this.rbdToJsString = new System.Windows.Forms.RadioButton();
            this.rbdHtmlEncode = new System.Windows.Forms.RadioButton();
            this.rbdFromBase64 = new System.Windows.Forms.RadioButton();
            this.rbdToBase64 = new System.Windows.Forms.RadioButton();
            this.rbdHtmlDecode = new System.Windows.Forms.RadioButton();
            this.svStrVarName = new litsdk.SelectVarName();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.label5 = new System.Windows.Forms.Label();
            this.rbdToMD5 = new System.Windows.Forms.RadioButton();
            this.rbdToSha256 = new System.Windows.Forms.RadioButton();
            this.rbToLower = new System.Windows.Forms.RadioButton();
            this.rbToUpper = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbToUpper);
            this.scActivityUI.Panel1.Controls.Add(this.rbToLower);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.svStrVarName);
            this.scActivityUI.Panel1.Controls.Add(this.lbEncoding);
            this.scActivityUI.Panel1.Controls.Add(this.cbEncoding);
            this.scActivityUI.Panel1.Controls.Add(this.rbdURLDecode);
            this.scActivityUI.Panel1.Controls.Add(this.rbdToSha256);
            this.scActivityUI.Panel1.Controls.Add(this.rbdToMD5);
            this.scActivityUI.Panel1.Controls.Add(this.rbdURLEncode);
            this.scActivityUI.Panel1.Controls.Add(this.rbdFromJsString);
            this.scActivityUI.Panel1.Controls.Add(this.rbdToJsString);
            this.scActivityUI.Panel1.Controls.Add(this.rbdHtmlEncode);
            this.scActivityUI.Panel1.Controls.Add(this.rbdFromBase64);
            this.scActivityUI.Panel1.Controls.Add(this.rbdToBase64);
            this.scActivityUI.Panel1.Controls.Add(this.rbdHtmlDecode);
            // 
            // lbEncoding
            // 
            this.lbEncoding.AutoSize = true;
            this.lbEncoding.Location = new System.Drawing.Point(337, 148);
            this.lbEncoding.Name = "lbEncoding";
            this.lbEncoding.Size = new System.Drawing.Size(89, 12);
            this.lbEncoding.TabIndex = 37;
            this.lbEncoding.Text = "URLEncode编码:";
            this.lbEncoding.Visible = false;
            // 
            // cbEncoding
            // 
            this.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.ItemHeight = 12;
            this.cbEncoding.Items.AddRange(new object[] {
            "GB2312",
            "GBK",
            "UTF-8",
            "Big5"});
            this.cbEncoding.Location = new System.Drawing.Point(433, 144);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(85, 20);
            this.cbEncoding.TabIndex = 36;
            this.cbEncoding.Visible = false;
            // 
            // rbdURLDecode
            // 
            this.rbdURLDecode.AutoSize = true;
            this.rbdURLDecode.Location = new System.Drawing.Point(239, 144);
            this.rbdURLDecode.Name = "rbdURLDecode";
            this.rbdURLDecode.Size = new System.Drawing.Size(77, 16);
            this.rbdURLDecode.TabIndex = 34;
            this.rbdURLDecode.Text = "URLDecode";
            this.rbdURLDecode.UseVisualStyleBackColor = true;
            this.rbdURLDecode.CheckedChanged += new System.EventHandler(this.rbdURLDecode_CheckedChanged);
            // 
            // rbdURLEncode
            // 
            this.rbdURLEncode.AutoSize = true;
            this.rbdURLEncode.Location = new System.Drawing.Point(127, 143);
            this.rbdURLEncode.Name = "rbdURLEncode";
            this.rbdURLEncode.Size = new System.Drawing.Size(77, 16);
            this.rbdURLEncode.TabIndex = 35;
            this.rbdURLEncode.Text = "URLEncode";
            this.rbdURLEncode.UseVisualStyleBackColor = true;
            this.rbdURLEncode.CheckedChanged += new System.EventHandler(this.rbdURLEncode_CheckedChanged);
            // 
            // rbdFromJsString
            // 
            this.rbdFromJsString.AutoSize = true;
            this.rbdFromJsString.Location = new System.Drawing.Point(239, 92);
            this.rbdFromJsString.Name = "rbdFromJsString";
            this.rbdFromJsString.Size = new System.Drawing.Size(107, 16);
            this.rbdFromJsString.TabIndex = 31;
            this.rbdFromJsString.Text = "From JS String";
            this.rbdFromJsString.UseVisualStyleBackColor = true;
            // 
            // rbdToJsString
            // 
            this.rbdToJsString.AutoSize = true;
            this.rbdToJsString.Location = new System.Drawing.Point(127, 92);
            this.rbdToJsString.Name = "rbdToJsString";
            this.rbdToJsString.Size = new System.Drawing.Size(95, 16);
            this.rbdToJsString.TabIndex = 32;
            this.rbdToJsString.Text = "To JS String";
            this.rbdToJsString.UseVisualStyleBackColor = true;
            // 
            // rbdHtmlEncode
            // 
            this.rbdHtmlEncode.AutoSize = true;
            this.rbdHtmlEncode.Location = new System.Drawing.Point(127, 68);
            this.rbdHtmlEncode.Name = "rbdHtmlEncode";
            this.rbdHtmlEncode.Size = new System.Drawing.Size(89, 16);
            this.rbdHtmlEncode.TabIndex = 30;
            this.rbdHtmlEncode.Text = "HTML Encode";
            this.rbdHtmlEncode.UseVisualStyleBackColor = true;
            // 
            // rbdFromBase64
            // 
            this.rbdFromBase64.AutoSize = true;
            this.rbdFromBase64.Location = new System.Drawing.Point(239, 116);
            this.rbdFromBase64.Name = "rbdFromBase64";
            this.rbdFromBase64.Size = new System.Drawing.Size(89, 16);
            this.rbdFromBase64.TabIndex = 27;
            this.rbdFromBase64.Text = "From Base64";
            this.rbdFromBase64.UseVisualStyleBackColor = true;
            // 
            // rbdToBase64
            // 
            this.rbdToBase64.AutoSize = true;
            this.rbdToBase64.Location = new System.Drawing.Point(127, 116);
            this.rbdToBase64.Name = "rbdToBase64";
            this.rbdToBase64.Size = new System.Drawing.Size(77, 16);
            this.rbdToBase64.TabIndex = 28;
            this.rbdToBase64.Text = "To Base64";
            this.rbdToBase64.UseVisualStyleBackColor = true;
            // 
            // rbdHtmlDecode
            // 
            this.rbdHtmlDecode.AutoSize = true;
            this.rbdHtmlDecode.Location = new System.Drawing.Point(239, 68);
            this.rbdHtmlDecode.Name = "rbdHtmlDecode";
            this.rbdHtmlDecode.Size = new System.Drawing.Size(89, 16);
            this.rbdHtmlDecode.TabIndex = 29;
            this.rbdHtmlDecode.Text = "HTML Decode";
            this.rbdHtmlDecode.UseVisualStyleBackColor = true;
            // 
            // svStrVarName
            // 
            this.svStrVarName.Location = new System.Drawing.Point(125, 25);
            this.svStrVarName.Name = "svStrVarName";
            this.svStrVarName.Size = new System.Drawing.Size(146, 23);
            this.svStrVarName.TabIndex = 38;
            this.svStrVarName.VarName = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "操作字符变量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "保存至字符变量";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(125, 181);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(146, 23);
            this.svSaveVarName.TabIndex = 40;
            this.svSaveVarName.VarName = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 39;
            this.label5.Text = "字符编码类型";
            // 
            // rbdToMD5
            // 
            this.rbdToMD5.AutoSize = true;
            this.rbdToMD5.Location = new System.Drawing.Point(378, 68);
            this.rbdToMD5.Name = "rbdToMD5";
            this.rbdToMD5.Size = new System.Drawing.Size(59, 16);
            this.rbdToMD5.TabIndex = 35;
            this.rbdToMD5.Text = "To MD5";
            this.rbdToMD5.UseVisualStyleBackColor = true;
            // 
            // rbdToSha256
            // 
            this.rbdToSha256.AutoSize = true;
            this.rbdToSha256.Location = new System.Drawing.Point(378, 92);
            this.rbdToSha256.Name = "rbdToSha256";
            this.rbdToSha256.Size = new System.Drawing.Size(77, 16);
            this.rbdToSha256.TabIndex = 35;
            this.rbdToSha256.Text = "To Sha256";
            this.rbdToSha256.UseVisualStyleBackColor = true;
            // 
            // rbToLower
            // 
            this.rbToLower.AutoSize = true;
            this.rbToLower.Location = new System.Drawing.Point(478, 66);
            this.rbToLower.Name = "rbToLower";
            this.rbToLower.Size = new System.Drawing.Size(71, 16);
            this.rbToLower.TabIndex = 42;
            this.rbToLower.TabStop = true;
            this.rbToLower.Text = "To Lower";
            this.rbToLower.UseVisualStyleBackColor = true;
            // 
            // rbToUpper
            // 
            this.rbToUpper.AutoSize = true;
            this.rbToUpper.Location = new System.Drawing.Point(479, 92);
            this.rbToUpper.Name = "rbToUpper";
            this.rbToUpper.Size = new System.Drawing.Size(71, 16);
            this.rbToUpper.TabIndex = 42;
            this.rbToUpper.TabStop = true;
            this.rbToUpper.Text = "To Upper";
            this.rbToUpper.UseVisualStyleBackColor = true;
            // 
            // TextEncodeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TextEncodeUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEncoding;
        private System.Windows.Forms.ComboBox cbEncoding;
        private System.Windows.Forms.RadioButton rbdURLDecode;
        private System.Windows.Forms.RadioButton rbdURLEncode;
        private System.Windows.Forms.RadioButton rbdFromJsString;
        private System.Windows.Forms.RadioButton rbdToJsString;
        private System.Windows.Forms.RadioButton rbdHtmlEncode;
        private System.Windows.Forms.RadioButton rbdFromBase64;
        private System.Windows.Forms.RadioButton rbdToBase64;
        private System.Windows.Forms.RadioButton rbdHtmlDecode;
        private System.Windows.Forms.Label label3;
        private litsdk.SelectVarName svStrVarName;
        private System.Windows.Forms.Label label4;
        private litsdk.SelectVarName svSaveVarName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbdToMD5;
        private System.Windows.Forms.RadioButton rbdToSha256;
        private System.Windows.Forms.RadioButton rbToUpper;
        private System.Windows.Forms.RadioButton rbToLower;
    }
}
