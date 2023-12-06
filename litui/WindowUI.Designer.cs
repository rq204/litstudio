namespace litui
{
    partial class WindowUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.rbClose = new System.Windows.Forms.RadioButton();
            this.rbMax = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.rbHide = new System.Windows.Forms.RadioButton();
            this.rbShow = new System.Windows.Forms.RadioButton();
            this.rbForeground = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbForeground);
            this.scActivityUI.Panel1.Controls.Add(this.rbShow);
            this.scActivityUI.Panel1.Controls.Add(this.rbHide);
            this.scActivityUI.Panel1.Controls.Add(this.rbMin);
            this.scActivityUI.Panel1.Controls.Add(this.rbMax);
            this.scActivityUI.Panel1.Controls.Add(this.rbClose);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "操作类型";
            // 
            // rbClose
            // 
            this.rbClose.AutoSize = true;
            this.rbClose.Location = new System.Drawing.Point(69, 112);
            this.rbClose.Name = "rbClose";
            this.rbClose.Size = new System.Drawing.Size(47, 16);
            this.rbClose.TabIndex = 10;
            this.rbClose.TabStop = true;
            this.rbClose.Text = "关闭";
            this.rbClose.UseVisualStyleBackColor = true;
            // 
            // rbMax
            // 
            this.rbMax.AutoSize = true;
            this.rbMax.Location = new System.Drawing.Point(192, 112);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(59, 16);
            this.rbMax.TabIndex = 10;
            this.rbMax.TabStop = true;
            this.rbMax.Text = "最大化";
            this.rbMax.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Location = new System.Drawing.Point(127, 112);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(59, 16);
            this.rbMin.TabIndex = 10;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "最小化";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // rbHide
            // 
            this.rbHide.AutoSize = true;
            this.rbHide.Location = new System.Drawing.Point(369, 113);
            this.rbHide.Name = "rbHide";
            this.rbHide.Size = new System.Drawing.Size(47, 16);
            this.rbHide.TabIndex = 10;
            this.rbHide.TabStop = true;
            this.rbHide.Text = "隐藏";
            this.rbHide.UseVisualStyleBackColor = true;
            this.rbHide.Visible = false;
            // 
            // rbShow
            // 
            this.rbShow.AutoSize = true;
            this.rbShow.Location = new System.Drawing.Point(257, 112);
            this.rbShow.Name = "rbShow";
            this.rbShow.Size = new System.Drawing.Size(47, 16);
            this.rbShow.TabIndex = 10;
            this.rbShow.TabStop = true;
            this.rbShow.Text = "显示";
            this.rbShow.UseVisualStyleBackColor = true;
            // 
            // rbForeground
            // 
            this.rbForeground.AutoSize = true;
            this.rbForeground.Location = new System.Drawing.Point(312, 113);
            this.rbForeground.Name = "rbForeground";
            this.rbForeground.Size = new System.Drawing.Size(47, 16);
            this.rbForeground.TabIndex = 10;
            this.rbForeground.TabStop = true;
            this.rbForeground.Text = "前置";
            this.rbForeground.UseVisualStyleBackColor = true;
            // 
            // WindowUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "WindowUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbShow;
        private System.Windows.Forms.RadioButton rbHide;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.RadioButton rbMax;
        private System.Windows.Forms.RadioButton rbClose;
        private System.Windows.Forms.RadioButton rbForeground;
    }
}
