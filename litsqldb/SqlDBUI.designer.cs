namespace litsqldb
{
    partial class SqlDBUI
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
            this.cbDbConfigName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSql = new System.Windows.Forms.TextBox();
            this.ivSql = new litsdk.InsertVarName();
            this.llbSave = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.llbShowDatabase = new System.Windows.Forms.LinkLabel();
            this.cbNoAddslashes = new System.Windows.Forms.CheckBox();
            this.llbAdd = new System.Windows.Forms.LinkLabel();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.llbSelect = new System.Windows.Forms.LinkLabel();
            this.llbDelete = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.llbSelect);
            this.scActivityUI.Panel1.Controls.Add(this.llbUpdate);
            this.scActivityUI.Panel1.Controls.Add(this.llbDelete);
            this.scActivityUI.Panel1.Controls.Add(this.llbAdd);
            this.scActivityUI.Panel1.Controls.Add(this.cbNoAddslashes);
            this.scActivityUI.Panel1.Controls.Add(this.llbShowDatabase);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.ivSql);
            this.scActivityUI.Panel1.Controls.Add(this.tbSql);
            this.scActivityUI.Panel1.Controls.Add(this.cbDbConfigName);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.llbSave);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "数据库配置";
            // 
            // cbDbConfigName
            // 
            this.cbDbConfigName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDbConfigName.FormattingEnabled = true;
            this.cbDbConfigName.Items.AddRange(new object[] {
            "MySql",
            "SqlServer"});
            this.cbDbConfigName.Location = new System.Drawing.Point(97, 14);
            this.cbDbConfigName.Name = "cbDbConfigName";
            this.cbDbConfigName.Size = new System.Drawing.Size(197, 20);
            this.cbDbConfigName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sql语句";
            // 
            // tbSql
            // 
            this.tbSql.Location = new System.Drawing.Point(97, 52);
            this.tbSql.Multiline = true;
            this.tbSql.Name = "tbSql";
            this.tbSql.Size = new System.Drawing.Size(411, 131);
            this.tbSql.TabIndex = 2;
            this.tbSql.TextChanged += new System.EventHandler(this.tbSql_TextChanged);
            // 
            // ivSql
            // 
            this.ivSql.Location = new System.Drawing.Point(515, 55);
            this.ivSql.Name = "ivSql";
            this.ivSql.Size = new System.Drawing.Size(20, 23);
            this.ivSql.TabIndex = 3;
            // 
            // llbSave
            // 
            this.llbSave.AutoSize = true;
            this.llbSave.Location = new System.Drawing.Point(22, 202);
            this.llbSave.Name = "llbSave";
            this.llbSave.Size = new System.Drawing.Size(65, 12);
            this.llbSave.TabIndex = 0;
            this.llbSave.Text = "保存结果至";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(97, 198);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(163, 23);
            this.svSaveVarName.TabIndex = 4;
            this.svSaveVarName.VarName = "";
            // 
            // llbShowDatabase
            // 
            this.llbShowDatabase.AutoSize = true;
            this.llbShowDatabase.Location = new System.Drawing.Point(303, 18);
            this.llbShowDatabase.Name = "llbShowDatabase";
            this.llbShowDatabase.Size = new System.Drawing.Size(29, 12);
            this.llbShowDatabase.TabIndex = 5;
            this.llbShowDatabase.TabStop = true;
            this.llbShowDatabase.Text = "管理";
            this.llbShowDatabase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbShowDatabase_LinkClicked);
            // 
            // cbNoAddslashes
            // 
            this.cbNoAddslashes.AutoSize = true;
            this.cbNoAddslashes.Location = new System.Drawing.Point(382, 14);
            this.cbNoAddslashes.Name = "cbNoAddslashes";
            this.cbNoAddslashes.Size = new System.Drawing.Size(162, 16);
            this.cbNoAddslashes.TabIndex = 6;
            this.cbNoAddslashes.Text = "Sql语句中变量不进行转义";
            this.cbNoAddslashes.UseVisualStyleBackColor = true;
            // 
            // llbAdd
            // 
            this.llbAdd.AutoSize = true;
            this.llbAdd.Location = new System.Drawing.Point(515, 109);
            this.llbAdd.Name = "llbAdd";
            this.llbAdd.Size = new System.Drawing.Size(29, 12);
            this.llbAdd.TabIndex = 7;
            this.llbAdd.TabStop = true;
            this.llbAdd.Text = "[增]";
            this.llbAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAdd_LinkClicked);
            // 
            // llbUpdate
            // 
            this.llbUpdate.AutoSize = true;
            this.llbUpdate.Location = new System.Drawing.Point(515, 150);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(29, 12);
            this.llbUpdate.TabIndex = 7;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "[改]";
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // llbSelect
            // 
            this.llbSelect.AutoSize = true;
            this.llbSelect.Location = new System.Drawing.Point(515, 171);
            this.llbSelect.Name = "llbSelect";
            this.llbSelect.Size = new System.Drawing.Size(29, 12);
            this.llbSelect.TabIndex = 7;
            this.llbSelect.TabStop = true;
            this.llbSelect.Text = "[查]";
            this.llbSelect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSelect_LinkClicked);
            // 
            // llbDelete
            // 
            this.llbDelete.AutoSize = true;
            this.llbDelete.Location = new System.Drawing.Point(515, 129);
            this.llbDelete.Name = "llbDelete";
            this.llbDelete.Size = new System.Drawing.Size(29, 12);
            this.llbDelete.TabIndex = 7;
            this.llbDelete.TabStop = true;
            this.llbDelete.Text = "[删]";
            this.llbDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDelete_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(266, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "当使用Select查询时可以将结果保存至变量";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(36, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 76);
            this.label4.TabIndex = 8;
            this.label4.Text = "当数据库错误会报异常，请使用异常捕获";
            // 
            // SqlDBUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SqlDBUI";
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
        private System.Windows.Forms.ComboBox cbDbConfigName;
        private litsdk.InsertVarName ivSql;
        private System.Windows.Forms.TextBox tbSql;
        private System.Windows.Forms.Label label8;
        private litsdk.SelectVarName svSaveVarName;
        private System.Windows.Forms.Label llbSave;
        private System.Windows.Forms.LinkLabel llbShowDatabase;
        private System.Windows.Forms.CheckBox cbNoAddslashes;
        private System.Windows.Forms.LinkLabel llbSelect;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.LinkLabel llbDelete;
        private System.Windows.Forms.LinkLabel llbAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
