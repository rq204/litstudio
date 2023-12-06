
namespace litstudio.iecef
{
    partial class FrmChrSetting
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
            this.lbPath = new System.Windows.Forms.Label();
            this.tbChromePath = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbArguments = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbUserData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.cbUserDefaultUserData = new System.Windows.Forms.CheckBox();
            this.ivPath = new litsdk.InsertVarName();
            this.ivUserData = new litsdk.InsertVarName();
            this.ivArge = new litsdk.InsertVarName();
            this.cbRemoteDebugging = new System.Windows.Forms.CheckBox();
            this.ivDriverPath = new litsdk.InsertVarName();
            this.btnDriverPath = new System.Windows.Forms.Button();
            this.tbDriverPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.svCrxVarName = new litsdk.SelectVarName();
            this.cbMobile = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(26, 56);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(53, 12);
            this.lbPath.TabIndex = 0;
            this.lbPath.Text = "谷歌路径";
            // 
            // tbChromePath
            // 
            this.tbChromePath.Location = new System.Drawing.Point(83, 52);
            this.tbChromePath.Name = "tbChromePath";
            this.tbChromePath.Size = new System.Drawing.Size(400, 21);
            this.tbChromePath.TabIndex = 1;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(513, 51);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "启动参数";
            // 
            // tbArguments
            // 
            this.tbArguments.Location = new System.Drawing.Point(83, 143);
            this.tbArguments.Multiline = true;
            this.tbArguments.Name = "tbArguments";
            this.tbArguments.Size = new System.Drawing.Size(400, 82);
            this.tbArguments.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbUserData
            // 
            this.tbUserData.Location = new System.Drawing.Point(83, 84);
            this.tbUserData.Name = "tbUserData";
            this.tbUserData.Size = new System.Drawing.Size(400, 21);
            this.tbUserData.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "用户配置";
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(513, 83);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDir.TabIndex = 7;
            this.btnOpenDir.Text = "浏览";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // cbUserDefaultUserData
            // 
            this.cbUserDefaultUserData.AutoSize = true;
            this.cbUserDefaultUserData.Location = new System.Drawing.Point(83, 114);
            this.cbUserDefaultUserData.Name = "cbUserDefaultUserData";
            this.cbUserDefaultUserData.Size = new System.Drawing.Size(120, 16);
            this.cbUserDefaultUserData.TabIndex = 8;
            this.cbUserDefaultUserData.Text = "使用默认用户配置";
            this.cbUserDefaultUserData.UseVisualStyleBackColor = true;
            // 
            // ivPath
            // 
            this.ivPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivPath.Location = new System.Drawing.Point(491, 56);
            this.ivPath.Name = "ivPath";
            this.ivPath.Size = new System.Drawing.Size(16, 16);
            this.ivPath.TabIndex = 9;
            // 
            // ivUserData
            // 
            this.ivUserData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivUserData.Location = new System.Drawing.Point(489, 87);
            this.ivUserData.Name = "ivUserData";
            this.ivUserData.Size = new System.Drawing.Size(16, 16);
            this.ivUserData.TabIndex = 10;
            // 
            // ivArge
            // 
            this.ivArge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivArge.Location = new System.Drawing.Point(491, 145);
            this.ivArge.Name = "ivArge";
            this.ivArge.Size = new System.Drawing.Size(16, 16);
            this.ivArge.TabIndex = 11;
            // 
            // cbRemoteDebugging
            // 
            this.cbRemoteDebugging.AutoSize = true;
            this.cbRemoteDebugging.Location = new System.Drawing.Point(228, 114);
            this.cbRemoteDebugging.Name = "cbRemoteDebugging";
            this.cbRemoteDebugging.Size = new System.Drawing.Size(132, 16);
            this.cbRemoteDebugging.TabIndex = 12;
            this.cbRemoteDebugging.Text = "附加到已打开浏览器";
            this.cbRemoteDebugging.UseVisualStyleBackColor = true;
            this.cbRemoteDebugging.CheckedChanged += new System.EventHandler(this.cbRemoteDebugging_CheckedChanged);
            // 
            // ivDriverPath
            // 
            this.ivDriverPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivDriverPath.Location = new System.Drawing.Point(491, 22);
            this.ivDriverPath.Name = "ivDriverPath";
            this.ivDriverPath.Size = new System.Drawing.Size(16, 16);
            this.ivDriverPath.TabIndex = 16;
            // 
            // btnDriverPath
            // 
            this.btnDriverPath.Location = new System.Drawing.Point(513, 18);
            this.btnDriverPath.Name = "btnDriverPath";
            this.btnDriverPath.Size = new System.Drawing.Size(75, 23);
            this.btnDriverPath.TabIndex = 15;
            this.btnDriverPath.Text = "浏览";
            this.btnDriverPath.UseVisualStyleBackColor = true;
            this.btnDriverPath.Click += new System.EventHandler(this.btnDirverPath_Click);
            // 
            // tbDriverPath
            // 
            this.tbDriverPath.Location = new System.Drawing.Point(83, 19);
            this.tbDriverPath.Name = "tbDriverPath";
            this.tbDriverPath.Size = new System.Drawing.Size(400, 21);
            this.tbDriverPath.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "驱动路径";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Crx扩展";
            // 
            // svCrxVarName
            // 
            this.svCrxVarName.Location = new System.Drawing.Point(83, 240);
            this.svCrxVarName.Name = "svCrxVarName";
            this.svCrxVarName.Size = new System.Drawing.Size(153, 23);
            this.svCrxVarName.TabIndex = 18;
            this.svCrxVarName.VarName = "";
            // 
            // cbMobile
            // 
            this.cbMobile.AutoSize = true;
            this.cbMobile.Location = new System.Drawing.Point(388, 114);
            this.cbMobile.Name = "cbMobile";
            this.cbMobile.Size = new System.Drawing.Size(72, 16);
            this.cbMobile.TabIndex = 19;
            this.cbMobile.Text = "移动仿真";
            this.cbMobile.UseVisualStyleBackColor = true;
            // 
            // FrmChrSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 293);
            this.Controls.Add(this.cbMobile);
            this.Controls.Add(this.svCrxVarName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ivDriverPath);
            this.Controls.Add(this.btnDriverPath);
            this.Controls.Add(this.tbDriverPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRemoteDebugging);
            this.Controls.Add(this.ivArge);
            this.Controls.Add(this.ivUserData);
            this.Controls.Add(this.ivPath);
            this.Controls.Add(this.cbUserDefaultUserData);
            this.Controls.Add(this.btnOpenDir);
            this.Controls.Add(this.tbUserData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbArguments);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.tbChromePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPath);
            this.Name = "FrmChrSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "谷歌浏览器设置";
            this.Load += new System.EventHandler(this.FrmChrSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.TextBox tbChromePath;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbArguments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbUserData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.CheckBox cbUserDefaultUserData;
        private litsdk.InsertVarName ivPath;
        private litsdk.InsertVarName ivUserData;
        private litsdk.InsertVarName ivArge;
        private System.Windows.Forms.CheckBox cbRemoteDebugging;
        private litsdk.InsertVarName ivDriverPath;
        private System.Windows.Forms.Button btnDriverPath;
        private System.Windows.Forms.TextBox tbDriverPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private litsdk.SelectVarName svCrxVarName;
        private System.Windows.Forms.CheckBox cbMobile;
    }
}