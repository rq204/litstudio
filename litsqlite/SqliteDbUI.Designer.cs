namespace litsqlite
{
    partial class SqlitedbUI
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
            this.svSaveVarName = new litsdk.SelectVarName();
            this.ivSql = new litsdk.InsertVarName();
            this.tbSql = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llbSave = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSqliteFile = new System.Windows.Forms.TextBox();
            this.ivSqliteFile = new litsdk.InsertVarName();
            this.llbCurrentDir = new System.Windows.Forms.LinkLabel();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.llbSelect = new System.Windows.Forms.LinkLabel();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.llbDelete = new System.Windows.Forms.LinkLabel();
            this.llbAdd = new System.Windows.Forms.LinkLabel();
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
            this.scActivityUI.Panel1.Controls.Add(this.llbSelect);
            this.scActivityUI.Panel1.Controls.Add(this.llbUpdate);
            this.scActivityUI.Panel1.Controls.Add(this.llbDelete);
            this.scActivityUI.Panel1.Controls.Add(this.llbAdd);
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.llbCurrentDir);
            this.scActivityUI.Panel1.Controls.Add(this.ivSqliteFile);
            this.scActivityUI.Panel1.Controls.Add(this.tbSqliteFile);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.ivSql);
            this.scActivityUI.Panel1.Controls.Add(this.tbSql);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.llbSave);
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(75, 200);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(163, 23);
            this.svSaveVarName.TabIndex = 10;
            this.svSaveVarName.VarName = "";
            // 
            // ivSql
            // 
            this.ivSql.Location = new System.Drawing.Point(539, 55);
            this.ivSql.Name = "ivSql";
            this.ivSql.Size = new System.Drawing.Size(20, 23);
            this.ivSql.TabIndex = 9;
            // 
            // tbSql
            // 
            this.tbSql.Location = new System.Drawing.Point(75, 52);
            this.tbSql.Multiline = true;
            this.tbSql.Name = "tbSql";
            this.tbSql.Size = new System.Drawing.Size(458, 134);
            this.tbSql.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sql语句";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(244, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "当使用Select查询时可以将结果保存至变量";
            // 
            // llbSave
            // 
            this.llbSave.AutoSize = true;
            this.llbSave.Location = new System.Drawing.Point(5, 204);
            this.llbSave.Name = "llbSave";
            this.llbSave.Size = new System.Drawing.Size(65, 12);
            this.llbSave.TabIndex = 7;
            this.llbSave.Text = "保存结果至";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "选择文件";
            // 
            // tbSqliteFile
            // 
            this.tbSqliteFile.Location = new System.Drawing.Point(75, 15);
            this.tbSqliteFile.Name = "tbSqliteFile";
            this.tbSqliteFile.Size = new System.Drawing.Size(342, 21);
            this.tbSqliteFile.TabIndex = 11;
            // 
            // ivSqliteFile
            // 
            this.ivSqliteFile.Location = new System.Drawing.Point(427, 17);
            this.ivSqliteFile.Name = "ivSqliteFile";
            this.ivSqliteFile.Size = new System.Drawing.Size(16, 16);
            this.ivSqliteFile.TabIndex = 12;
            // 
            // llbCurrentDir
            // 
            this.llbCurrentDir.AutoSize = true;
            this.llbCurrentDir.Location = new System.Drawing.Point(449, 19);
            this.llbCurrentDir.Name = "llbCurrentDir";
            this.llbCurrentDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurrentDir.TabIndex = 13;
            this.llbCurrentDir.TabStop = true;
            this.llbCurrentDir.Text = "[当前目录]";
            this.llbCurrentDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurrentDir_LinkClicked);
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(518, 19);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 16;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // llbSelect
            // 
            this.llbSelect.AutoSize = true;
            this.llbSelect.Location = new System.Drawing.Point(539, 174);
            this.llbSelect.Name = "llbSelect";
            this.llbSelect.Size = new System.Drawing.Size(29, 12);
            this.llbSelect.TabIndex = 17;
            this.llbSelect.TabStop = true;
            this.llbSelect.Text = "[查]";
            this.llbSelect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSelect_LinkClicked);
            // 
            // llbUpdate
            // 
            this.llbUpdate.AutoSize = true;
            this.llbUpdate.Location = new System.Drawing.Point(539, 153);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(29, 12);
            this.llbUpdate.TabIndex = 18;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "[改]";
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // llbDelete
            // 
            this.llbDelete.AutoSize = true;
            this.llbDelete.Location = new System.Drawing.Point(539, 132);
            this.llbDelete.Name = "llbDelete";
            this.llbDelete.Size = new System.Drawing.Size(29, 12);
            this.llbDelete.TabIndex = 19;
            this.llbDelete.TabStop = true;
            this.llbDelete.Text = "[删]";
            this.llbDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDelete_LinkClicked);
            // 
            // llbAdd
            // 
            this.llbAdd.AutoSize = true;
            this.llbAdd.Location = new System.Drawing.Point(539, 112);
            this.llbAdd.Name = "llbAdd";
            this.llbAdd.Size = new System.Drawing.Size(29, 12);
            this.llbAdd.TabIndex = 20;
            this.llbAdd.TabStop = true;
            this.llbAdd.Text = "[增]";
            this.llbAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAdd_LinkClicked);
            // 
            // SqlitedbUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SqlitedbUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private litsdk.SelectVarName svSaveVarName;
        private litsdk.InsertVarName ivSql;
        private System.Windows.Forms.TextBox tbSql;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label llbSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSqliteFile;
        private System.Windows.Forms.LinkLabel llbCurrentDir;
        private litsdk.InsertVarName ivSqliteFile;
        private System.Windows.Forms.LinkLabel llbOpen;
        private System.Windows.Forms.LinkLabel llbSelect;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.LinkLabel llbDelete;
        private System.Windows.Forms.LinkLabel llbAdd;
    }
}
