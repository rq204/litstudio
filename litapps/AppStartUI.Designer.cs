namespace litapps
{
    partial class AppStartUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAppPath = new System.Windows.Forms.TextBox();
            this.tbArguments = new System.Windows.Forms.TextBox();
            this.tbWorkingDirectory = new System.Windows.Forms.TextBox();
            this.ivAppPath = new litsdk.InsertVarName();
            this.ivArguments = new litsdk.InsertVarName();
            this.ivWorkingDirectory = new litsdk.InsertVarName();
            this.cbWaitProcess = new System.Windows.Forms.CheckBox();
            this.llbOutResult = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.llbCurrentDir = new System.Windows.Forms.LinkLabel();
            this.lbOutEncoding = new System.Windows.Forms.Label();
            this.cbOutputEncoding = new System.Windows.Forms.ComboBox();
            this.lbTimeOut = new System.Windows.Forms.Label();
            this.nudTimeOutSeconds = new System.Windows.Forms.NumericUpDown();
            this.cbDefaultApp = new System.Windows.Forms.CheckBox();
            this.cbHide = new System.Windows.Forms.CheckBox();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOutSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.cbHide);
            this.scActivityUI.Panel1.Controls.Add(this.cbDefaultApp);
            this.scActivityUI.Panel1.Controls.Add(this.nudTimeOutSeconds);
            this.scActivityUI.Panel1.Controls.Add(this.cbOutputEncoding);
            this.scActivityUI.Panel1.Controls.Add(this.llbCurrentDir);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.llbOutResult);
            this.scActivityUI.Panel1.Controls.Add(this.cbWaitProcess);
            this.scActivityUI.Panel1.Controls.Add(this.ivWorkingDirectory);
            this.scActivityUI.Panel1.Controls.Add(this.ivArguments);
            this.scActivityUI.Panel1.Controls.Add(this.ivAppPath);
            this.scActivityUI.Panel1.Controls.Add(this.tbWorkingDirectory);
            this.scActivityUI.Panel1.Controls.Add(this.tbArguments);
            this.scActivityUI.Panel1.Controls.Add(this.tbAppPath);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.lbTimeOut);
            this.scActivityUI.Panel1.Controls.Add(this.lbOutEncoding);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "程序路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "工作目录";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "启动参数";
            // 
            // tbAppPath
            // 
            this.tbAppPath.Location = new System.Drawing.Point(89, 16);
            this.tbAppPath.Name = "tbAppPath";
            this.tbAppPath.Size = new System.Drawing.Size(343, 21);
            this.tbAppPath.TabIndex = 0;
            // 
            // tbArguments
            // 
            this.tbArguments.Location = new System.Drawing.Point(89, 51);
            this.tbArguments.Name = "tbArguments";
            this.tbArguments.Size = new System.Drawing.Size(343, 21);
            this.tbArguments.TabIndex = 1;
            // 
            // tbWorkingDirectory
            // 
            this.tbWorkingDirectory.Location = new System.Drawing.Point(89, 86);
            this.tbWorkingDirectory.Name = "tbWorkingDirectory";
            this.tbWorkingDirectory.Size = new System.Drawing.Size(343, 21);
            this.tbWorkingDirectory.TabIndex = 2;
            // 
            // ivAppPath
            // 
            this.ivAppPath.Location = new System.Drawing.Point(439, 16);
            this.ivAppPath.Name = "ivAppPath";
            this.ivAppPath.Size = new System.Drawing.Size(20, 23);
            this.ivAppPath.TabIndex = 2;
            // 
            // ivArguments
            // 
            this.ivArguments.Location = new System.Drawing.Point(439, 51);
            this.ivArguments.Name = "ivArguments";
            this.ivArguments.Size = new System.Drawing.Size(20, 23);
            this.ivArguments.TabIndex = 2;
            // 
            // ivWorkingDirectory
            // 
            this.ivWorkingDirectory.Location = new System.Drawing.Point(438, 86);
            this.ivWorkingDirectory.Name = "ivWorkingDirectory";
            this.ivWorkingDirectory.Size = new System.Drawing.Size(20, 23);
            this.ivWorkingDirectory.TabIndex = 2;
            // 
            // cbWaitProcess
            // 
            this.cbWaitProcess.AutoSize = true;
            this.cbWaitProcess.Location = new System.Drawing.Point(88, 131);
            this.cbWaitProcess.Name = "cbWaitProcess";
            this.cbWaitProcess.Size = new System.Drawing.Size(120, 16);
            this.cbWaitProcess.TabIndex = 3;
            this.cbWaitProcess.Text = "等待程序执行完毕";
            this.cbWaitProcess.UseVisualStyleBackColor = true;
            this.cbWaitProcess.CheckedChanged += new System.EventHandler(this.cbWaitProcess_CheckedChanged);
            // 
            // llbOutResult
            // 
            this.llbOutResult.AutoSize = true;
            this.llbOutResult.Location = new System.Drawing.Point(26, 171);
            this.llbOutResult.Name = "llbOutResult";
            this.llbOutResult.Size = new System.Drawing.Size(53, 12);
            this.llbOutResult.TabIndex = 4;
            this.llbOutResult.Text = "输出结果";
            this.llbOutResult.Visible = false;
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(89, 168);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(132, 23);
            this.svSaveVarName.TabIndex = 5;
            this.svSaveVarName.VarName = "";
            this.svSaveVarName.Visible = false;
            // 
            // llbCurrentDir
            // 
            this.llbCurrentDir.AutoSize = true;
            this.llbCurrentDir.Location = new System.Drawing.Point(464, 20);
            this.llbCurrentDir.Name = "llbCurrentDir";
            this.llbCurrentDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurrentDir.TabIndex = 6;
            this.llbCurrentDir.TabStop = true;
            this.llbCurrentDir.Text = "[当前目录]";
            this.llbCurrentDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurrentDir_LinkClicked);
            // 
            // lbOutEncoding
            // 
            this.lbOutEncoding.AutoSize = true;
            this.lbOutEncoding.Location = new System.Drawing.Point(266, 173);
            this.lbOutEncoding.Name = "lbOutEncoding";
            this.lbOutEncoding.Size = new System.Drawing.Size(53, 12);
            this.lbOutEncoding.TabIndex = 0;
            this.lbOutEncoding.Text = "输出编码";
            this.lbOutEncoding.Visible = false;
            // 
            // cbOutputEncoding
            // 
            this.cbOutputEncoding.FormattingEnabled = true;
            this.cbOutputEncoding.Items.AddRange(new object[] {
            "GB2312",
            "UTF-8"});
            this.cbOutputEncoding.Location = new System.Drawing.Point(334, 168);
            this.cbOutputEncoding.Name = "cbOutputEncoding";
            this.cbOutputEncoding.Size = new System.Drawing.Size(98, 20);
            this.cbOutputEncoding.TabIndex = 7;
            this.cbOutputEncoding.Visible = false;
            // 
            // lbTimeOut
            // 
            this.lbTimeOut.AutoSize = true;
            this.lbTimeOut.Location = new System.Drawing.Point(250, 131);
            this.lbTimeOut.Name = "lbTimeOut";
            this.lbTimeOut.Size = new System.Drawing.Size(77, 12);
            this.lbTimeOut.TabIndex = 0;
            this.lbTimeOut.Text = "运行超时(秒)";
            this.lbTimeOut.Visible = false;
            // 
            // nudTimeOutSeconds
            // 
            this.nudTimeOutSeconds.Location = new System.Drawing.Point(334, 127);
            this.nudTimeOutSeconds.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTimeOutSeconds.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudTimeOutSeconds.Name = "nudTimeOutSeconds";
            this.nudTimeOutSeconds.Size = new System.Drawing.Size(98, 21);
            this.nudTimeOutSeconds.TabIndex = 8;
            this.nudTimeOutSeconds.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTimeOutSeconds.Visible = false;
            // 
            // cbDefaultApp
            // 
            this.cbDefaultApp.AutoSize = true;
            this.cbDefaultApp.Location = new System.Drawing.Point(466, 53);
            this.cbDefaultApp.Name = "cbDefaultApp";
            this.cbDefaultApp.Size = new System.Drawing.Size(96, 16);
            this.cbDefaultApp.TabIndex = 9;
            this.cbDefaultApp.Text = "使用默认程序";
            this.cbDefaultApp.UseVisualStyleBackColor = true;
            this.cbDefaultApp.CheckedChanged += new System.EventHandler(this.cbDefaultApp_CheckedChanged);
            // 
            // cbHide
            // 
            this.cbHide.AutoSize = true;
            this.cbHide.Location = new System.Drawing.Point(466, 86);
            this.cbHide.Name = "cbHide";
            this.cbHide.Size = new System.Drawing.Size(72, 16);
            this.cbHide.TabIndex = 10;
            this.cbHide.Text = "隐藏启动";
            this.cbHide.UseVisualStyleBackColor = true;
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(530, 20);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 14;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // AppStartUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AppStartUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOutSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private litsdk.InsertVarName ivWorkingDirectory;
        private litsdk.InsertVarName ivArguments;
        private litsdk.InsertVarName ivAppPath;
        private System.Windows.Forms.TextBox tbWorkingDirectory;
        private System.Windows.Forms.TextBox tbArguments;
        private System.Windows.Forms.TextBox tbAppPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private litsdk.SelectVarName svSaveVarName;
        private System.Windows.Forms.Label llbOutResult;
        private System.Windows.Forms.CheckBox cbWaitProcess;
        private System.Windows.Forms.LinkLabel llbCurrentDir;
        private System.Windows.Forms.Label lbOutEncoding;
        private System.Windows.Forms.ComboBox cbOutputEncoding;
        private System.Windows.Forms.NumericUpDown nudTimeOutSeconds;
        private System.Windows.Forms.Label lbTimeOut;
        private System.Windows.Forms.CheckBox cbDefaultApp;
        private System.Windows.Forms.CheckBox cbHide;
        private System.Windows.Forms.LinkLabel llbOpen;
    }
}
