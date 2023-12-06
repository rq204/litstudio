namespace litstudio.iecef
{
    partial class RunJsUI
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
            this.tbJsCode = new System.Windows.Forms.TextBox();
            this.ivJsCode = new litsdk.InsertVarName();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFrameName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSave = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.lbSave2 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.lbSave2);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.tbFrameName);
            this.scActivityUI.Panel1.Controls.Add(this.lbSave);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.tbJsCode);
            this.scActivityUI.Panel1.Controls.Add(this.ivJsCode);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "JS代码";
            // 
            // tbJsCode
            // 
            this.tbJsCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJsCode.Location = new System.Drawing.Point(70, 17);
            this.tbJsCode.Multiline = true;
            this.tbJsCode.Name = "tbJsCode";
            this.tbJsCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbJsCode.Size = new System.Drawing.Size(463, 131);
            this.tbJsCode.TabIndex = 1;
            // 
            // ivJsCode
            // 
            this.ivJsCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivJsCode.Location = new System.Drawing.Point(544, 17);
            this.ivJsCode.Name = "ivJsCode";
            this.ivJsCode.Size = new System.Drawing.Size(16, 16);
            this.ivJsCode.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(336, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "空为主页面，可为框架名或框架网址";
            // 
            // tbFrameName
            // 
            this.tbFrameName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFrameName.Location = new System.Drawing.Point(70, 163);
            this.tbFrameName.Name = "tbFrameName";
            this.tbFrameName.Size = new System.Drawing.Size(264, 21);
            this.tbFrameName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "指定Frame";
            // 
            // lbSave
            // 
            this.lbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSave.AutoSize = true;
            this.lbSave.Location = new System.Drawing.Point(7, 202);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(53, 12);
            this.lbSave.TabIndex = 22;
            this.lbSave.Text = "保存结果";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.svSaveVarName.Location = new System.Drawing.Point(70, 198);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(147, 23);
            this.svSaveVarName.TabIndex = 25;
            this.svSaveVarName.VarName = "";
            // 
            // lbSave2
            // 
            this.lbSave2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSave2.AutoSize = true;
            this.lbSave2.ForeColor = System.Drawing.Color.Green;
            this.lbSave2.Location = new System.Drawing.Point(227, 202);
            this.lbSave2.Name = "lbSave2";
            this.lbSave2.Size = new System.Drawing.Size(329, 12);
            this.lbSave2.TabIndex = 24;
            this.lbSave2.Text = "保存JS执行代码结果至字符变量当中，结构可考虑json序列化";
            // 
            // RunJsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RunJsUI";
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
        private litsdk.InsertVarName ivJsCode;
        private System.Windows.Forms.TextBox tbJsCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFrameName;
        private System.Windows.Forms.Label label7;
        private litsdk.SelectVarName svSaveVarName;
        private System.Windows.Forms.Label lbSave2;
        private System.Windows.Forms.Label lbSave;
    }
}
