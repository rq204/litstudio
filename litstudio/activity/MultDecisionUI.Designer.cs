
namespace litstudio
{
    partial class MultDecisionUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultDecisionUI));
            this.svVarNames = new litsdk.SelectMultVarName();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAllIsNotEmpty = new System.Windows.Forms.RadioButton();
            this.rbAllIsEmpty = new System.Windows.Forms.RadioButton();
            this.rbOneMoreEmpty = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbOneMoreEmpty);
            this.scActivityUI.Panel1.Controls.Add(this.rbAllIsEmpty);
            this.scActivityUI.Panel1.Controls.Add(this.rbAllIsNotEmpty);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.svVarNames);
            // 
            // svVarNames
            // 
            this.svVarNames.Location = new System.Drawing.Point(97, 20);
            this.svVarNames.Name = "svVarNames";
            this.svVarNames.Size = new System.Drawing.Size(366, 23);
            this.svVarNames.TabIndex = 0;
            this.svVarNames.VarNames = ((System.Collections.Generic.List<string>)(resources.GetObject("svVarNames.VarNames")));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择变量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "比较方式";
            // 
            // rbAllIsNotEmpty
            // 
            this.rbAllIsNotEmpty.AutoSize = true;
            this.rbAllIsNotEmpty.Location = new System.Drawing.Point(98, 62);
            this.rbAllIsNotEmpty.Name = "rbAllIsNotEmpty";
            this.rbAllIsNotEmpty.Size = new System.Drawing.Size(131, 16);
            this.rbAllIsNotEmpty.TabIndex = 26;
            this.rbAllIsNotEmpty.TabStop = true;
            this.rbAllIsNotEmpty.Text = "所有变量值都不为空";
            this.rbAllIsNotEmpty.UseVisualStyleBackColor = true;
            // 
            // rbAllIsEmpty
            // 
            this.rbAllIsEmpty.AutoSize = true;
            this.rbAllIsEmpty.Location = new System.Drawing.Point(244, 63);
            this.rbAllIsEmpty.Name = "rbAllIsEmpty";
            this.rbAllIsEmpty.Size = new System.Drawing.Size(119, 16);
            this.rbAllIsEmpty.TabIndex = 26;
            this.rbAllIsEmpty.TabStop = true;
            this.rbAllIsEmpty.Text = "所有变量值都为空";
            this.rbAllIsEmpty.UseVisualStyleBackColor = true;
            // 
            // rbOneMoreEmpty
            // 
            this.rbOneMoreEmpty.AutoSize = true;
            this.rbOneMoreEmpty.Location = new System.Drawing.Point(380, 62);
            this.rbOneMoreEmpty.Name = "rbOneMoreEmpty";
            this.rbOneMoreEmpty.Size = new System.Drawing.Size(107, 16);
            this.rbOneMoreEmpty.TabIndex = 26;
            this.rbOneMoreEmpty.TabStop = true;
            this.rbOneMoreEmpty.Text = "变量值不全为空";
            this.rbOneMoreEmpty.UseVisualStyleBackColor = true;
            // 
            // MultDecisionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MultDecisionUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private litsdk.SelectMultVarName svVarNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbOneMoreEmpty;
        private System.Windows.Forms.RadioButton rbAllIsEmpty;
        private System.Windows.Forms.RadioButton rbAllIsNotEmpty;
    }
}
