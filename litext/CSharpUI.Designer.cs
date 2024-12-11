namespace litext
{
    partial class CSharpUI
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
            this.tbCode = new System.Windows.Forms.TextBox();
            this.ivCode = new litsdk.InsertVarName();
            this.lbget = new System.Windows.Forms.LinkLabel();
            this.lbSet = new System.Windows.Forms.LinkLabel();
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
            this.scActivityUI.Panel1.Controls.Add(this.lbSet);
            this.scActivityUI.Panel1.Controls.Add(this.lbget);
            this.scActivityUI.Panel1.Controls.Add(this.ivCode);
            this.scActivityUI.Panel1.Controls.Add(this.tbCode);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "C#代码";
            // 
            // tbCode
            // 
            this.tbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCode.Location = new System.Drawing.Point(58, 15);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCode.Size = new System.Drawing.Size(480, 186);
            this.tbCode.TabIndex = 1;
            // 
            // ivCode
            // 
            this.ivCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivCode.Location = new System.Drawing.Point(544, 19);
            this.ivCode.Name = "ivCode";
            this.ivCode.Size = new System.Drawing.Size(16, 16);
            this.ivCode.TabIndex = 2;
            // 
            // lbget
            // 
            this.lbget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbget.AutoSize = true;
            this.lbget.Location = new System.Drawing.Point(56, 211);
            this.lbget.Name = "lbget";
            this.lbget.Size = new System.Drawing.Size(167, 12);
            this.lbget.TabIndex = 3;
            this.lbget.TabStop = true;
            this.lbget.Text = "context.GetStr(\"变量名称\");";
            this.lbget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbget_LinkClicked);
            // 
            // lbSet
            // 
            this.lbSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSet.AutoSize = true;
            this.lbSet.Location = new System.Drawing.Point(232, 211);
            this.lbSet.Name = "lbSet";
            this.lbSet.Size = new System.Drawing.Size(239, 12);
            this.lbSet.TabIndex = 3;
            this.lbSet.TabStop = true;
            this.lbSet.Text = "context.SetVarStr(\"变量名称\",\"变量值\");";
            this.lbSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSet_LinkClicked);
            // 
            // CSharpUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CSharpUI";
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
        private System.Windows.Forms.TextBox tbCode;
        private litsdk.InsertVarName ivCode;
        private System.Windows.Forms.LinkLabel lbget;
        private System.Windows.Forms.LinkLabel lbSet;
    }
}
