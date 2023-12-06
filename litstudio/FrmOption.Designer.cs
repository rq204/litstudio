namespace litstudio
{
    partial class FrmOption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpShotCut = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConfig = new System.Windows.Forms.TabPage();
            this.cbAutoSave = new System.Windows.Forms.CheckBox();
            this.tcMain.SuspendLayout();
            this.tpShotCut.SuspendLayout();
            this.tpConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpShotCut);
            this.tcMain.Controls.Add(this.tpConfig);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(323, 147);
            this.tcMain.TabIndex = 0;
            // 
            // tpShotCut
            // 
            this.tpShotCut.Controls.Add(this.linkLabel2);
            this.tpShotCut.Controls.Add(this.linkLabel1);
            this.tpShotCut.Controls.Add(this.label2);
            this.tpShotCut.Controls.Add(this.label1);
            this.tpShotCut.Location = new System.Drawing.Point(4, 22);
            this.tpShotCut.Name = "tpShotCut";
            this.tpShotCut.Padding = new System.Windows.Forms.Padding(3);
            this.tpShotCut.Size = new System.Drawing.Size(315, 121);
            this.tpShotCut.TabIndex = 0;
            this.tpShotCut.Text = "快捷键";
            this.tpShotCut.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(103, 29);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 12);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Alt+F11";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(103, 65);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 12);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Shift+F11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "暂停";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始/停止";
            // 
            // tpConfig
            // 
            this.tpConfig.Controls.Add(this.cbAutoSave);
            this.tpConfig.Location = new System.Drawing.Point(4, 22);
            this.tpConfig.Name = "tpConfig";
            this.tpConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfig.Size = new System.Drawing.Size(315, 121);
            this.tpConfig.TabIndex = 1;
            this.tpConfig.Text = "设置";
            this.tpConfig.UseVisualStyleBackColor = true;
            // 
            // cbAutoSave
            // 
            this.cbAutoSave.AutoSize = true;
            this.cbAutoSave.Location = new System.Drawing.Point(13, 15);
            this.cbAutoSave.Name = "cbAutoSave";
            this.cbAutoSave.Size = new System.Drawing.Size(228, 16);
            this.cbAutoSave.TabIndex = 0;
            this.cbAutoSave.Text = "启用自动保存，每一分钟保存一次流程";
            this.cbAutoSave.UseVisualStyleBackColor = true;
            this.cbAutoSave.CheckedChanged += new System.EventHandler(this.cbAutoSave_CheckedChanged);
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 147);
            this.Controls.Add(this.tcMain);
            this.Name = "FrmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选项";
            this.tcMain.ResumeLayout(false);
            this.tpShotCut.ResumeLayout(false);
            this.tpShotCut.PerformLayout();
            this.tpConfig.ResumeLayout(false);
            this.tpConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpShotCut;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpConfig;
        private System.Windows.Forms.CheckBox cbAutoSave;
    }
}