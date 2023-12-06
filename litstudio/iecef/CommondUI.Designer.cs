namespace litstudio.iecef
{
    partial class CommondUI
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
            this.rbGo = new System.Windows.Forms.RadioButton();
            this.rbBack = new System.Windows.Forms.RadioButton();
            this.rbStop = new System.Windows.Forms.RadioButton();
            this.rbRefresh = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbRefresh);
            this.scActivityUI.Panel1.Controls.Add(this.rbStop);
            this.scActivityUI.Panel1.Controls.Add(this.rbBack);
            this.scActivityUI.Panel1.Controls.Add(this.rbGo);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "操作类型";
            // 
            // rbGo
            // 
            this.rbGo.AutoSize = true;
            this.rbGo.Location = new System.Drawing.Point(102, 28);
            this.rbGo.Name = "rbGo";
            this.rbGo.Size = new System.Drawing.Size(47, 16);
            this.rbGo.TabIndex = 1;
            this.rbGo.TabStop = true;
            this.rbGo.Text = "前进";
            this.rbGo.UseVisualStyleBackColor = true;
            // 
            // rbBack
            // 
            this.rbBack.AutoSize = true;
            this.rbBack.Location = new System.Drawing.Point(168, 28);
            this.rbBack.Name = "rbBack";
            this.rbBack.Size = new System.Drawing.Size(47, 16);
            this.rbBack.TabIndex = 1;
            this.rbBack.TabStop = true;
            this.rbBack.Text = "后退";
            this.rbBack.UseVisualStyleBackColor = true;
            // 
            // rbStop
            // 
            this.rbStop.AutoSize = true;
            this.rbStop.Location = new System.Drawing.Point(236, 28);
            this.rbStop.Name = "rbStop";
            this.rbStop.Size = new System.Drawing.Size(47, 16);
            this.rbStop.TabIndex = 1;
            this.rbStop.TabStop = true;
            this.rbStop.Text = "停止";
            this.rbStop.UseVisualStyleBackColor = true;
            // 
            // rbRefresh
            // 
            this.rbRefresh.AutoSize = true;
            this.rbRefresh.Location = new System.Drawing.Point(305, 28);
            this.rbRefresh.Name = "rbRefresh";
            this.rbRefresh.Size = new System.Drawing.Size(47, 16);
            this.rbRefresh.TabIndex = 1;
            this.rbRefresh.TabStop = true;
            this.rbRefresh.Text = "刷新";
            this.rbRefresh.UseVisualStyleBackColor = true;
            // 
            // CommondUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CommondUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRefresh;
        private System.Windows.Forms.RadioButton rbStop;
        private System.Windows.Forms.RadioButton rbBack;
        private System.Windows.Forms.RadioButton rbGo;
        private System.Windows.Forms.Label label2;
    }
}
