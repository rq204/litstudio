namespace litui
{
    partial class GetTextUI
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
            this.svSaveVarName = new litsdk.SelectVarName();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAttName = new System.Windows.Forms.TextBox();
            this.cbNoFindEmpty = new System.Windows.Forms.CheckBox();
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
            this.scActivityUI.Panel1.Controls.Add(this.cbNoFindEmpty);
            this.scActivityUI.Panel1.Controls.Add(this.tbAttName);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(95, 148);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(201, 23);
            this.svSaveVarName.TabIndex = 10;
            this.svSaveVarName.VarName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "文本结果存入";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "元素属性名称";
            this.label4.Visible = false;
            // 
            // tbAttName
            // 
            this.tbAttName.Location = new System.Drawing.Point(96, 114);
            this.tbAttName.Name = "tbAttName";
            this.tbAttName.Size = new System.Drawing.Size(174, 21);
            this.tbAttName.TabIndex = 11;
            this.tbAttName.Visible = false;
            // 
            // cbNoFindEmpty
            // 
            this.cbNoFindEmpty.AutoSize = true;
            this.cbNoFindEmpty.Location = new System.Drawing.Point(317, 152);
            this.cbNoFindEmpty.Name = "cbNoFindEmpty";
            this.cbNoFindEmpty.Size = new System.Drawing.Size(240, 16);
            this.cbNoFindEmpty.TabIndex = 12;
            this.cbNoFindEmpty.Text = "没有找到元素时返回空值，否则异常报错";
            this.cbNoFindEmpty.UseVisualStyleBackColor = true;
            // 
            // GetTextUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GetTextUI";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAttName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbNoFindEmpty;
    }
}
