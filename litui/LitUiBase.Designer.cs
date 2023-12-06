namespace litui
{
    partial class LitUiBase
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
            this.components = new System.ComponentModel.Container();
            this.llbSelectUI = new System.Windows.Forms.LinkLabel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbXPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ivProcessName = new litsdk.InsertVarName();
            this.ivXPath = new litsdk.InsertVarName();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEngine = new System.Windows.Forms.Label();
            this.cmsEngine = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFlaUI3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlaUI2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.cmsEngine.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.lbEngine);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.ivXPath);
            this.scActivityUI.Panel1.Controls.Add(this.ivProcessName);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.tbProcessName);
            this.scActivityUI.Panel1.Controls.Add(this.tbXPath);
            this.scActivityUI.Panel1.Controls.Add(this.llbSelectUI);
            this.scActivityUI.Panel1.Controls.Add(this.pbImage);
            // 
            // llbSelectUI
            // 
            this.llbSelectUI.AutoSize = true;
            this.llbSelectUI.Location = new System.Drawing.Point(89, 43);
            this.llbSelectUI.Name = "llbSelectUI";
            this.llbSelectUI.Size = new System.Drawing.Size(53, 12);
            this.llbSelectUI.TabIndex = 2;
            this.llbSelectUI.TabStop = true;
            this.llbSelectUI.Text = "选择元素";
            this.llbSelectUI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSelectUI_LinkClicked);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(3, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(212, 95);
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // tbXPath
            // 
            this.tbXPath.Location = new System.Drawing.Point(292, 44);
            this.tbXPath.Multiline = true;
            this.tbXPath.Name = "tbXPath";
            this.tbXPath.Size = new System.Drawing.Size(222, 54);
            this.tbXPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "进程名称";
            // 
            // tbProcessName
            // 
            this.tbProcessName.Location = new System.Drawing.Point(292, 12);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.Size = new System.Drawing.Size(146, 21);
            this.tbProcessName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "控件XPath";
            // 
            // ivProcessName
            // 
            this.ivProcessName.Location = new System.Drawing.Point(444, 15);
            this.ivProcessName.Name = "ivProcessName";
            this.ivProcessName.Size = new System.Drawing.Size(16, 16);
            this.ivProcessName.TabIndex = 8;
            // 
            // ivXPath
            // 
            this.ivXPath.Location = new System.Drawing.Point(520, 47);
            this.ivXPath.Name = "ivXPath";
            this.ivXPath.Size = new System.Drawing.Size(16, 16);
            this.ivXPath.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "引擎:";
            // 
            // lbEngine
            // 
            this.lbEngine.AutoSize = true;
            this.lbEngine.ContextMenuStrip = this.cmsEngine;
            this.lbEngine.Location = new System.Drawing.Point(518, 17);
            this.lbEngine.Name = "lbEngine";
            this.lbEngine.Size = new System.Drawing.Size(41, 12);
            this.lbEngine.TabIndex = 9;
            this.lbEngine.Text = "FlaUI3";
            // 
            // cmsEngine
            // 
            this.cmsEngine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFlaUI3,
            this.tsmiFlaUI2});
            this.cmsEngine.Name = "cmsEngine";
            this.cmsEngine.Size = new System.Drawing.Size(181, 70);
            // 
            // tsmiFlaUI3
            // 
            this.tsmiFlaUI3.Name = "tsmiFlaUI3";
            this.tsmiFlaUI3.Size = new System.Drawing.Size(180, 22);
            this.tsmiFlaUI3.Text = "FlaUI3";
            this.tsmiFlaUI3.Click += new System.EventHandler(this.tsmiFlaUI3_Click);
            // 
            // tsmiFlaUI2
            // 
            this.tsmiFlaUI2.Name = "tsmiFlaUI2";
            this.tsmiFlaUI2.Size = new System.Drawing.Size(180, 22);
            this.tsmiFlaUI2.Text = "FlaUI2";
            this.tsmiFlaUI2.Click += new System.EventHandler(this.tsmiFlaUI2_Click);
            // 
            // LitUiBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LitUiBase";
            this.Controls.SetChildIndex(this.scActivityUI, 0);
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.cmsEngine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel llbSelectUI;
        internal System.Windows.Forms.PictureBox pbImage;
        internal System.Windows.Forms.TextBox tbXPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox tbProcessName;
        private litsdk.InsertVarName ivXPath;
        private litsdk.InsertVarName ivProcessName;
        private System.Windows.Forms.Label lbEngine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cmsEngine;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlaUI3;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlaUI2;
    }
}
