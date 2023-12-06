namespace litstudio.iecef
{
    partial class FormStateUI
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
            this.rbShow = new System.Windows.Forms.RadioButton();
            this.rbHide = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbHide);
            this.scActivityUI.Panel1.Controls.Add(this.rbShow);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "界面状态";
            // 
            // rbShow
            // 
            this.rbShow.AutoSize = true;
            this.rbShow.Location = new System.Drawing.Point(82, 16);
            this.rbShow.Name = "rbShow";
            this.rbShow.Size = new System.Drawing.Size(47, 16);
            this.rbShow.TabIndex = 1;
            this.rbShow.TabStop = true;
            this.rbShow.Text = "显示";
            this.rbShow.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbShow.UseVisualStyleBackColor = true;
            // 
            // rbHide
            // 
            this.rbHide.AutoSize = true;
            this.rbHide.Location = new System.Drawing.Point(145, 16);
            this.rbHide.Name = "rbHide";
            this.rbHide.Size = new System.Drawing.Size(47, 16);
            this.rbHide.TabIndex = 1;
            this.rbHide.TabStop = true;
            this.rbHide.Text = "隐藏";
            this.rbHide.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbHide.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(22, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(549, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "内置浏览器单独运行时默认是隐藏在后台运行，如果需要一些界面操作，比如点击输入，可以临时将其显示出来，操作完成后再隐藏，就不会影响当前工作了。";
            // 
            // FormSetUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FormSetUI";
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
        private System.Windows.Forms.RadioButton rbHide;
        private System.Windows.Forms.RadioButton rbShow;
        private System.Windows.Forms.Label label3;
    }
}
