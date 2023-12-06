namespace litsdk
{
    partial class InsertVarName
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
            this.cmsShowVarName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImgPen = new System.Windows.Forms.PictureBox();
            this.cmsShowVarName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPen)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsShowVar
            // 
            this.cmsShowVarName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsShowVarName.Name = "cmsShowVar";
            this.cmsShowVarName.Size = new System.Drawing.Size(193, 26);
            this.cmsShowVarName.Opening += new System.ComponentModel.CancelEventHandler(this.cmsShowVarName_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // pbImg
            // 
            this.pbImgPen.ContextMenuStrip = this.cmsShowVarName;
            this.pbImgPen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImgPen.Image = global::litsdk.Resource.edit;
            this.pbImgPen.Location = new System.Drawing.Point(0, 0);
            this.pbImgPen.Name = "pbImg";
            this.pbImgPen.Size = new System.Drawing.Size(16, 16);
            this.pbImgPen.TabIndex = 1;
            this.pbImgPen.TabStop = false;
            this.pbImgPen.Click += new System.EventHandler(this.pbImgShow_Click);
            // 
            // InsertVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbImgPen);
            this.Name = "InsertVar";
            this.Size = new System.Drawing.Size(16, 16);
            this.cmsShowVarName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgPen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImgPen;
        private System.Windows.Forms.ContextMenuStrip cmsShowVarName;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
