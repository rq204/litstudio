namespace litui
{
    partial class TypeIntoUI
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
            this.tbContent = new System.Windows.Forms.TextBox();
            this.ivContent = new litsdk.InsertVarName();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCurLocation = new System.Windows.Forms.CheckBox();
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
            this.scActivityUI.Panel1.Controls.Add(this.cbCurLocation);
            this.scActivityUI.Panel1.Controls.Add(this.ivContent);
            this.scActivityUI.Panel1.Controls.Add(this.tbContent);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "文本输入";
            // 
            // tbContent
            // 
            this.tbContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContent.Location = new System.Drawing.Point(68, 105);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(446, 101);
            this.tbContent.TabIndex = 8;
            // 
            // ivContent
            // 
            this.ivContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivContent.Location = new System.Drawing.Point(530, 105);
            this.ivContent.Name = "ivContent";
            this.ivContent.Size = new System.Drawing.Size(16, 16);
            this.ivContent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "输入选项";
            // 
            // cbCurLocation
            // 
            this.cbCurLocation.AutoSize = true;
            this.cbCurLocation.Location = new System.Drawing.Point(68, 212);
            this.cbCurLocation.Name = "cbCurLocation";
            this.cbCurLocation.Size = new System.Drawing.Size(216, 16);
            this.cbCurLocation.TabIndex = 15;
            this.cbCurLocation.Text = "使用当前光标位置（不用选择元素）";
            this.cbCurLocation.UseVisualStyleBackColor = true;
            // 
            // TypeIntoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TypeIntoUI";
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
        private System.Windows.Forms.TextBox tbContent;
        private litsdk.InsertVarName ivContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbCurLocation;
    }
}
