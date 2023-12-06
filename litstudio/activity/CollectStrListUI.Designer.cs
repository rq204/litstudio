namespace litstudio
{
    partial class CollectStrListUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.lbRegex = new System.Windows.Forms.Label();
            this.llbRegex = new System.Windows.Forms.LinkLabel();
            this.svStrVarName = new litsdk.SelectVarName();
            this.lbInfo = new System.Windows.Forms.Label();
            this.cbCollectList = new System.Windows.Forms.CheckBox();
            this.cbTrim = new System.Windows.Forms.CheckBox();
            this.cbTrimBlank = new System.Windows.Forms.CheckBox();
            this.cbTrimHtml = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRegexString = new System.Windows.Forms.TextBox();
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
            this.scActivityUI.Panel1.Controls.Add(this.cbTrimHtml);
            this.scActivityUI.Panel1.Controls.Add(this.cbTrimBlank);
            this.scActivityUI.Panel1.Controls.Add(this.cbTrim);
            this.scActivityUI.Panel1.Controls.Add(this.tbRegexString);
            this.scActivityUI.Panel1.Controls.Add(this.cbCollectList);
            this.scActivityUI.Panel1.Controls.Add(this.svStrVarName);
            this.scActivityUI.Panel1.Controls.Add(this.lbInfo);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.lbRegex);
            this.scActivityUI.Panel1.Controls.Add(this.llbRegex);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "提取变量";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(326, 170);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(114, 23);
            this.svSaveVarName.TabIndex = 107;
            this.svSaveVarName.VarName = "";
            // 
            // lbRegex
            // 
            this.lbRegex.AutoSize = true;
            this.lbRegex.Location = new System.Drawing.Point(214, 139);
            this.lbRegex.Name = "lbRegex";
            this.lbRegex.Size = new System.Drawing.Size(65, 12);
            this.lbRegex.TabIndex = 106;
            this.lbRegex.Text = "正则表达式";
            // 
            // llbRegex
            // 
            this.llbRegex.AutoSize = true;
            this.llbRegex.Font = new System.Drawing.Font("宋体", 9F);
            this.llbRegex.Location = new System.Drawing.Point(277, 139);
            this.llbRegex.Name = "llbRegex";
            this.llbRegex.Size = new System.Drawing.Size(107, 12);
            this.llbRegex.TabIndex = 103;
            this.llbRegex.TabStop = true;
            this.llbRegex.Text = "(?<data>[\\s\\S]*?)";
            this.llbRegex.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRegex_LinkClicked);
            // 
            // svStrVarName
            // 
            this.svStrVarName.Location = new System.Drawing.Point(82, 170);
            this.svStrVarName.Name = "svStrVarName";
            this.svStrVarName.Size = new System.Drawing.Size(130, 23);
            this.svStrVarName.TabIndex = 109;
            this.svStrVarName.VarName = "";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(222, 174);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(101, 12);
            this.lbInfo.TabIndex = 108;
            this.lbInfo.Text = "保存或添加至变量";
            // 
            // cbCollectList
            // 
            this.cbCollectList.AutoSize = true;
            this.cbCollectList.Location = new System.Drawing.Point(443, 172);
            this.cbCollectList.Name = "cbCollectList";
            this.cbCollectList.Size = new System.Drawing.Size(96, 16);
            this.cbCollectList.TabIndex = 110;
            this.cbCollectList.Text = "提取多条结果";
            this.cbCollectList.UseVisualStyleBackColor = true;
            // 
            // cbTrim
            // 
            this.cbTrim.AutoSize = true;
            this.cbTrim.Location = new System.Drawing.Point(317, 206);
            this.cbTrim.Name = "cbTrim";
            this.cbTrim.Size = new System.Drawing.Size(108, 16);
            this.cbTrim.TabIndex = 112;
            this.cbTrim.Text = "去两端空白字符";
            this.cbTrim.UseVisualStyleBackColor = true;
            // 
            // cbTrimBlank
            // 
            this.cbTrimBlank.AutoSize = true;
            this.cbTrimBlank.Location = new System.Drawing.Point(189, 206);
            this.cbTrimBlank.Name = "cbTrimBlank";
            this.cbTrimBlank.Size = new System.Drawing.Size(108, 16);
            this.cbTrimBlank.TabIndex = 112;
            this.cbTrimBlank.Text = "去所有空白字符";
            this.cbTrimBlank.UseVisualStyleBackColor = true;
            // 
            // cbTrimHtml
            // 
            this.cbTrimHtml.AutoSize = true;
            this.cbTrimHtml.Location = new System.Drawing.Point(81, 207);
            this.cbTrimHtml.Name = "cbTrimHtml";
            this.cbTrimHtml.Size = new System.Drawing.Size(84, 16);
            this.cbTrimHtml.TabIndex = 112;
            this.cbTrimHtml.Text = "去Html代码";
            this.cbTrimHtml.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "数据清洗";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "提取配置";
            // 
            // tbRegexString
            // 
            this.tbRegexString.Location = new System.Drawing.Point(86, 16);
            this.tbRegexString.MaxLength = 327670;
            this.tbRegexString.Multiline = true;
            this.tbRegexString.Name = "tbRegexString";
            this.tbRegexString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRegexString.Size = new System.Drawing.Size(467, 113);
            this.tbRegexString.TabIndex = 111;
            // 
            // CollectStrListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CollectStrListUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private litsdk.SelectVarName svSaveVarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRegex;
        private System.Windows.Forms.LinkLabel llbRegex;
        private litsdk.SelectVarName svStrVarName;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.CheckBox cbCollectList;
        private System.Windows.Forms.CheckBox cbTrimHtml;
        private System.Windows.Forms.CheckBox cbTrimBlank;
        private System.Windows.Forms.CheckBox cbTrim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRegexString;
        private System.Windows.Forms.Label label4;
    }
}
