namespace litsdk
{
    partial class SelectVarName
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbVarName = new System.Windows.Forms.TextBox();
            this.cmsTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsShowVarName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImgPen = new System.Windows.Forms.PictureBox();
            this.cmsTextBox.SuspendLayout();
            this.cmsShowVarName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPen)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVarName
            // 
            this.tbVarName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVarName.ContextMenuStrip = this.cmsTextBox;
            this.tbVarName.Location = new System.Drawing.Point(0, 0);
            this.tbVarName.Name = "tbVarName";
            this.tbVarName.ReadOnly = true;
            this.tbVarName.Size = new System.Drawing.Size(50, 21);
            this.tbVarName.TabIndex = 0;
            // 
            // cmsTextBox
            // 
            this.cmsTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClear});
            this.cmsTextBox.Name = "cmsTextBox";
            this.cmsTextBox.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(124, 22);
            this.tsmiClear.Text = "清空变量";
            // 
            // cmsShowVarName
            // 
            this.cmsShowVarName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsShowVarName.Name = "cmsShowVar";
            this.cmsShowVarName.Size = new System.Drawing.Size(193, 26);
            this.cmsShowVarName.Opening += new System.ComponentModel.CancelEventHandler(this.cmsShowVar_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // pbImgPen
            // 
            this.pbImgPen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImgPen.ContextMenuStrip = this.cmsShowVarName;
            this.pbImgPen.Image = global::litsdk.Resource.edit;
            this.pbImgPen.Location = new System.Drawing.Point(55, 3);
            this.pbImgPen.Name = "pbImgPen";
            this.pbImgPen.Size = new System.Drawing.Size(16, 16);
            this.pbImgPen.TabIndex = 1;
            this.pbImgPen.TabStop = false;
            this.pbImgPen.Click += new System.EventHandler(this.pbImgPen_Click);
            // 
            // SelectVarName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbImgPen);
            this.Controls.Add(this.tbVarName);
            this.Name = "SelectVarName";
            this.Size = new System.Drawing.Size(76, 23);
            this.cmsTextBox.ResumeLayout(false);
            this.cmsShowVarName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// 变量名称
        /// </summary>
        public string VarName
        {
            get { return this.tbVarName.Text; }
            set { this.tbVarName.Text = value; }
        }
        private System.Windows.Forms.TextBox tbVarName;
        private System.Windows.Forms.PictureBox pbImgPen;
        private System.Windows.Forms.ContextMenuStrip cmsShowVarName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmsTextBox;
        private System.Windows.Forms.ToolStripMenuItem tsmiClear;
    }
}
