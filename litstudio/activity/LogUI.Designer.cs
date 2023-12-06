namespace litstudio
{
    partial class LogUI
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
            this.tbLogFormat = new System.Windows.Forms.TextBox();
            this.ivLog = new litsdk.InsertVarName();
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
            this.scActivityUI.Panel1.Controls.Add(this.ivLog);
            this.scActivityUI.Panel1.Controls.Add(this.tbLogFormat);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "设置如何输出一条日志";
            // 
            // tbLogFormat
            // 
            this.tbLogFormat.Location = new System.Drawing.Point(21, 50);
            this.tbLogFormat.Multiline = true;
            this.tbLogFormat.Name = "tbLogFormat";
            this.tbLogFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogFormat.Size = new System.Drawing.Size(489, 140);
            this.tbLogFormat.TabIndex = 1;
            // 
            // ivLog
            // 
            this.ivLog.Location = new System.Drawing.Point(516, 50);
            this.ivLog.Name = "ivLog";
            this.ivLog.Size = new System.Drawing.Size(16, 16);
            this.ivLog.TabIndex = 2;
            // 
            // LogUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LogUI";
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
        private litsdk.InsertVarName ivLog;
        private System.Windows.Forms.TextBox tbLogFormat;
    }
}
