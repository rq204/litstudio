namespace litext
{
    partial class PHPUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PHPUI));
            this.label2 = new System.Windows.Forms.Label();
            this.smvVarList = new litsdk.SelectMultVarName();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.llbCheck = new System.Windows.Forms.Label();
            this.llbCreatePython = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.llbSetEnvPath = new System.Windows.Forms.LinkLabel();
            this.btnTest = new System.Windows.Forms.Button();
            this.cbPyFile = new System.Windows.Forms.ComboBox();
            this.llbOpenDir = new System.Windows.Forms.LinkLabel();
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
            this.scActivityUI.Panel1.Controls.Add(this.llbOpenDir);
            this.scActivityUI.Panel1.Controls.Add(this.cbPyFile);
            this.scActivityUI.Panel1.Controls.Add(this.btnTest);
            this.scActivityUI.Panel1.Controls.Add(this.llbSetEnvPath);
            this.scActivityUI.Panel1.Controls.Add(this.llbCreatePython);
            this.scActivityUI.Panel1.Controls.Add(this.smvVarList);
            this.scActivityUI.Panel1.Controls.Add(this.llbCheck);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "要操作的变量";
            // 
            // smvVarList
            // 
            this.smvVarList.Location = new System.Drawing.Point(106, 13);
            this.smvVarList.Name = "smvVarList";
            this.smvVarList.Size = new System.Drawing.Size(307, 23);
            this.smvVarList.TabIndex = 1;
            this.smvVarList.VarNames = ((System.Collections.Generic.List<string>)(resources.GetObject("smvVarList.VarNames")));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "PHP文件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "PHP.exe路径";
            // 
            // llbCheck
            // 
            this.llbCheck.ForeColor = System.Drawing.Color.Green;
            this.llbCheck.Location = new System.Drawing.Point(106, 96);
            this.llbCheck.Name = "llbCheck";
            this.llbCheck.Size = new System.Drawing.Size(353, 38);
            this.llbCheck.TabIndex = 0;
            this.llbCheck.Text = "当前环境变量中没有检测到PHP路径，请检查";
            // 
            // llbCreatePython
            // 
            this.llbCreatePython.AutoSize = true;
            this.llbCreatePython.Location = new System.Drawing.Point(464, 56);
            this.llbCreatePython.Name = "llbCreatePython";
            this.llbCreatePython.Size = new System.Drawing.Size(71, 12);
            this.llbCreatePython.TabIndex = 4;
            this.llbCreatePython.TabStop = true;
            this.llbCreatePython.Text = "创建PHP文件";
            this.llbCreatePython.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCreatePython_LinkClicked);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(531, 43);
            this.label5.TabIndex = 0;
            this.label5.Text = "执行PHP文件的原理是将变量转成json字符，通过命令行方式传送给PHP脚本，PHP在执行完后再以json格式输出，再反解回变量值。请使用创建PHP文件功能新建脚" +
    "本。PHP可执行程序优先判断当前PHP目录下有无php.exe文件，然后检查环境变量。";
            // 
            // llbSetEnvPath
            // 
            this.llbSetEnvPath.AutoSize = true;
            this.llbSetEnvPath.Location = new System.Drawing.Point(465, 94);
            this.llbSetEnvPath.Name = "llbSetEnvPath";
            this.llbSetEnvPath.Size = new System.Drawing.Size(77, 12);
            this.llbSetEnvPath.TabIndex = 7;
            this.llbSetEnvPath.TabStop = true;
            this.llbSetEnvPath.Text = "设置系统变量";
            this.llbSetEnvPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSetEnvPath_LinkClicked);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(106, 136);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "测试执行";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cbPyFile
            // 
            this.cbPyFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPyFile.FormattingEnabled = true;
            this.cbPyFile.Location = new System.Drawing.Point(108, 53);
            this.cbPyFile.Name = "cbPyFile";
            this.cbPyFile.Size = new System.Drawing.Size(284, 20);
            this.cbPyFile.TabIndex = 9;
            // 
            // llbOpenDir
            // 
            this.llbOpenDir.AutoSize = true;
            this.llbOpenDir.Location = new System.Drawing.Point(406, 57);
            this.llbOpenDir.Name = "llbOpenDir";
            this.llbOpenDir.Size = new System.Drawing.Size(53, 12);
            this.llbOpenDir.TabIndex = 10;
            this.llbOpenDir.TabStop = true;
            this.llbOpenDir.Text = "打开目录";
            this.llbOpenDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpenDir_LinkClicked);
            // 
            // PHPUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PHPUI";
            this.Load += new System.EventHandler(this.PHPUI_Load);
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
        private litsdk.SelectMultVarName smvVarList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label llbCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llbCreatePython;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel llbSetEnvPath;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.LinkLabel llbOpenDir;
        private System.Windows.Forms.ComboBox cbPyFile;
    }
}
