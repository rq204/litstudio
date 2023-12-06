namespace litstudio.iecef
{
    partial class ProxyUI
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
            this.tbProxySetting = new System.Windows.Forms.TextBox();
            this.ivProxySetting = new litsdk.InsertVarName();
            this.label3 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.ivProxySetting);
            this.scActivityUI.Panel1.Controls.Add(this.tbProxySetting);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "代理设置";
            // 
            // tbProxySetting
            // 
            this.tbProxySetting.Location = new System.Drawing.Point(81, 25);
            this.tbProxySetting.Name = "tbProxySetting";
            this.tbProxySetting.Size = new System.Drawing.Size(294, 21);
            this.tbProxySetting.TabIndex = 1;
            // 
            // ivProxySetting
            // 
            this.ivProxySetting.Location = new System.Drawing.Point(381, 27);
            this.ivProxySetting.Name = "ivProxySetting";
            this.ivProxySetting.Size = new System.Drawing.Size(16, 16);
            this.ivProxySetting.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(79, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "代理格式如下：\r\nsocks5://127.0.0.1:9190\r\nhttp://127.0.0.1:9190\r\n值设置为空为取消代理";
            // 
            // ProxyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ProxyUI";
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
        private litsdk.InsertVarName ivProxySetting;
        private System.Windows.Forms.TextBox tbProxySetting;
        private System.Windows.Forms.Label label3;
    }
}
