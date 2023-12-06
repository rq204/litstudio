namespace litsqldb
{
    partial class FrmSqlDBConfig
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
            this.lbDBConfigs = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.llbNew = new System.Windows.Forms.LinkLabel();
            this.llbEdit = new System.Windows.Forms.LinkLabel();
            this.llbDelete = new System.Windows.Forms.LinkLabel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.cbDatabaseType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCharSet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.ivPort = new litsdk.InsertVarName();
            this.ivpassword = new litsdk.InsertVarName();
            this.ivDatabase = new litsdk.InsertVarName();
            this.ivhost = new litsdk.InsertVarName();
            this.ivusername = new litsdk.InsertVarName();
            this.SuspendLayout();
            // 
            // lbDBConfigs
            // 
            this.lbDBConfigs.FormattingEnabled = true;
            this.lbDBConfigs.ItemHeight = 12;
            this.lbDBConfigs.Location = new System.Drawing.Point(19, 21);
            this.lbDBConfigs.Name = "lbDBConfigs";
            this.lbDBConfigs.Size = new System.Drawing.Size(111, 196);
            this.lbDBConfigs.TabIndex = 18;
            this.lbDBConfigs.SelectedIndexChanged += new System.EventHandler(this.lbDBConfigs_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(311, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(219, 219);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // llbNew
            // 
            this.llbNew.AutoSize = true;
            this.llbNew.Location = new System.Drawing.Point(18, 229);
            this.llbNew.Name = "llbNew";
            this.llbNew.Size = new System.Drawing.Size(29, 12);
            this.llbNew.TabIndex = 20;
            this.llbNew.TabStop = true;
            this.llbNew.Text = "添加";
            this.llbNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbNew_LinkClicked);
            // 
            // llbEdit
            // 
            this.llbEdit.AutoSize = true;
            this.llbEdit.Location = new System.Drawing.Point(58, 229);
            this.llbEdit.Name = "llbEdit";
            this.llbEdit.Size = new System.Drawing.Size(29, 12);
            this.llbEdit.TabIndex = 20;
            this.llbEdit.TabStop = true;
            this.llbEdit.Text = "编辑";
            this.llbEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEdit_LinkClicked);
            // 
            // llbDelete
            // 
            this.llbDelete.AutoSize = true;
            this.llbDelete.Location = new System.Drawing.Point(100, 229);
            this.llbDelete.Name = "llbDelete";
            this.llbDelete.Size = new System.Drawing.Size(29, 12);
            this.llbDelete.TabIndex = 20;
            this.llbDelete.TabStop = true;
            this.llbDelete.Text = "删除";
            this.llbDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDelete_LinkClicked);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(198, 152);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(223, 21);
            this.tbPassword.TabIndex = 6;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(198, 121);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(223, 21);
            this.tbUserName.TabIndex = 5;
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(198, 57);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(223, 21);
            this.tbHost.TabIndex = 2;
            // 
            // cbDatabaseType
            // 
            this.cbDatabaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabaseType.FormattingEnabled = true;
            this.cbDatabaseType.Items.AddRange(new object[] {
            "MySQL(TCP/IP)",
            "SQLSERVER",
            "PostgreSQL",
            "Oracle",
            "Dameng",
            "ShenTong",
            "KingbaseES"});
            this.cbDatabaseType.Location = new System.Drawing.Point(602, 55);
            this.cbDatabaseType.Name = "cbDatabaseType";
            this.cbDatabaseType.Size = new System.Drawing.Size(223, 20);
            this.cbDatabaseType.TabIndex = 1;
            this.cbDatabaseType.SelectedIndexChanged += new System.EventHandler(this.cbDatabaseType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "数据库";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "端口";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "用户名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "主机IP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(163, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "密码";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(546, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 26;
            this.label13.Text = "网络类型";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(309, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "编码";
            // 
            // cbCharSet
            // 
            this.cbCharSet.FormattingEnabled = true;
            this.cbCharSet.Items.AddRange(new object[] {
            "utf8",
            "utf8mb4",
            "gbk",
            "gb2312"});
            this.cbCharSet.Location = new System.Drawing.Point(342, 90);
            this.cbCharSet.Name = "cbCharSet";
            this.cbCharSet.Size = new System.Drawing.Size(79, 20);
            this.cbCharSet.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "配置名称";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(198, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(223, 21);
            this.tbName.TabIndex = 0;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(198, 90);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(70, 21);
            this.tbPort.TabIndex = 3;
            // 
            // tbDatabase
            // 
            this.tbDatabase.Location = new System.Drawing.Point(198, 185);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(223, 21);
            this.tbDatabase.TabIndex = 7;
            // 
            // ivPort
            // 
            this.ivPort.Location = new System.Drawing.Point(274, 92);
            this.ivPort.Name = "ivPort";
            this.ivPort.Size = new System.Drawing.Size(20, 23);
            this.ivPort.TabIndex = 42;
            // 
            // ivpassword
            // 
            this.ivpassword.Location = new System.Drawing.Point(427, 155);
            this.ivpassword.Name = "ivpassword";
            this.ivpassword.Size = new System.Drawing.Size(20, 23);
            this.ivpassword.TabIndex = 12;
            // 
            // ivDatabase
            // 
            this.ivDatabase.Location = new System.Drawing.Point(427, 186);
            this.ivDatabase.Name = "ivDatabase";
            this.ivDatabase.Size = new System.Drawing.Size(20, 23);
            this.ivDatabase.TabIndex = 13;
            // 
            // ivhost
            // 
            this.ivhost.Location = new System.Drawing.Point(427, 60);
            this.ivhost.Name = "ivhost";
            this.ivhost.Size = new System.Drawing.Size(20, 23);
            this.ivhost.TabIndex = 14;
            // 
            // ivusername
            // 
            this.ivusername.Location = new System.Drawing.Point(427, 126);
            this.ivusername.Name = "ivusername";
            this.ivusername.Size = new System.Drawing.Size(20, 23);
            this.ivusername.TabIndex = 15;
            // 
            // FrmSqlDBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 256);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.ivPort);
            this.Controls.Add(this.cbCharSet);
            this.Controls.Add(this.tbDatabase);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.cbDatabaseType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.llbDelete);
            this.Controls.Add(this.llbEdit);
            this.Controls.Add(this.llbNew);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbDBConfigs);
            this.Controls.Add(this.ivpassword);
            this.Controls.Add(this.ivDatabase);
            this.Controls.Add(this.ivhost);
            this.Controls.Add(this.ivusername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSqlDBConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据库配置";
            this.Load += new System.EventHandler(this.FrmSqlDBConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private litsdk.InsertVarName ivpassword;
        private litsdk.InsertVarName ivDatabase;
        private litsdk.InsertVarName ivhost;
        private litsdk.InsertVarName ivusername;
        private System.Windows.Forms.ListBox lbDBConfigs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.LinkLabel llbNew;
        private System.Windows.Forms.LinkLabel llbEdit;
        private System.Windows.Forms.LinkLabel llbDelete;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.ComboBox cbDatabaseType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbCharSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private litsdk.InsertVarName ivPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbDatabase;
    }
}