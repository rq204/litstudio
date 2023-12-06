namespace litstudio.iecef
{
    partial class ScrollUI
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
            this.rbBotton = new System.Windows.Forms.RadioButton();
            this.rbTop = new System.Windows.Forms.RadioButton();
            this.rbDownBy = new System.Windows.Forms.RadioButton();
            this.rbUpBy = new System.Windows.Forms.RadioButton();
            this.tbScrollBy = new System.Windows.Forms.TextBox();
            this.ivScrollBy = new litsdk.InsertVarName();
            this.rbXpath = new System.Windows.Forms.RadioButton();
            this.tbXpathStr = new System.Windows.Forms.TextBox();
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
            this.scActivityUI.Panel1.Controls.Add(this.tbXpathStr);
            this.scActivityUI.Panel1.Controls.Add(this.rbXpath);
            this.scActivityUI.Panel1.Controls.Add(this.ivScrollBy);
            this.scActivityUI.Panel1.Controls.Add(this.tbScrollBy);
            this.scActivityUI.Panel1.Controls.Add(this.rbUpBy);
            this.scActivityUI.Panel1.Controls.Add(this.rbDownBy);
            this.scActivityUI.Panel1.Controls.Add(this.rbTop);
            this.scActivityUI.Panel1.Controls.Add(this.rbBotton);
            // 
            // rbBotton
            // 
            this.rbBotton.AutoSize = true;
            this.rbBotton.Location = new System.Drawing.Point(48, 29);
            this.rbBotton.Name = "rbBotton";
            this.rbBotton.Size = new System.Drawing.Size(83, 16);
            this.rbBotton.TabIndex = 0;
            this.rbBotton.TabStop = true;
            this.rbBotton.Text = "滚动至底部";
            this.rbBotton.UseVisualStyleBackColor = true;
            // 
            // rbTop
            // 
            this.rbTop.AutoSize = true;
            this.rbTop.Location = new System.Drawing.Point(48, 63);
            this.rbTop.Name = "rbTop";
            this.rbTop.Size = new System.Drawing.Size(83, 16);
            this.rbTop.TabIndex = 0;
            this.rbTop.TabStop = true;
            this.rbTop.Text = "滚动至顶部";
            this.rbTop.UseVisualStyleBackColor = true;
            // 
            // rbDownBy
            // 
            this.rbDownBy.AutoSize = true;
            this.rbDownBy.Location = new System.Drawing.Point(48, 96);
            this.rbDownBy.Name = "rbDownBy";
            this.rbDownBy.Size = new System.Drawing.Size(95, 16);
            this.rbDownBy.TabIndex = 1;
            this.rbDownBy.TabStop = true;
            this.rbDownBy.Text = "向下滚动像素";
            this.rbDownBy.UseVisualStyleBackColor = true;
            this.rbDownBy.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbUpBy
            // 
            this.rbUpBy.AutoSize = true;
            this.rbUpBy.Location = new System.Drawing.Point(48, 128);
            this.rbUpBy.Name = "rbUpBy";
            this.rbUpBy.Size = new System.Drawing.Size(95, 16);
            this.rbUpBy.TabIndex = 1;
            this.rbUpBy.TabStop = true;
            this.rbUpBy.Text = "向上滚动像素";
            this.rbUpBy.UseVisualStyleBackColor = true;
            // 
            // tbScrollBy
            // 
            this.tbScrollBy.Location = new System.Drawing.Point(160, 107);
            this.tbScrollBy.Name = "tbScrollBy";
            this.tbScrollBy.Size = new System.Drawing.Size(100, 21);
            this.tbScrollBy.TabIndex = 2;
            // 
            // ivScrollBy
            // 
            this.ivScrollBy.Location = new System.Drawing.Point(267, 110);
            this.ivScrollBy.Name = "ivScrollBy";
            this.ivScrollBy.Size = new System.Drawing.Size(16, 16);
            this.ivScrollBy.TabIndex = 3;
            // 
            // rbXpath
            // 
            this.rbXpath.AutoSize = true;
            this.rbXpath.Location = new System.Drawing.Point(48, 160);
            this.rbXpath.Name = "rbXpath";
            this.rbXpath.Size = new System.Drawing.Size(107, 16);
            this.rbXpath.TabIndex = 4;
            this.rbXpath.TabStop = true;
            this.rbXpath.Text = "滚动至指定元素";
            this.rbXpath.UseVisualStyleBackColor = true;
            this.rbXpath.CheckedChanged += new System.EventHandler(this.rbXpath_CheckedChanged);
            // 
            // tbXpathStr
            // 
            this.tbXpathStr.Location = new System.Drawing.Point(162, 157);
            this.tbXpathStr.Name = "tbXpathStr";
            this.tbXpathStr.Size = new System.Drawing.Size(347, 21);
            this.tbXpathStr.TabIndex = 5;
            // 
            // ScrollUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ScrollUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBotton;
        private System.Windows.Forms.RadioButton rbTop;
        private System.Windows.Forms.RadioButton rbUpBy;
        private System.Windows.Forms.RadioButton rbDownBy;
        private litsdk.InsertVarName ivScrollBy;
        private System.Windows.Forms.TextBox tbScrollBy;
        private System.Windows.Forms.RadioButton rbXpath;
        private System.Windows.Forms.TextBox tbXpathStr;
    }
}
