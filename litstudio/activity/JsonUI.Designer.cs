namespace litstudio
{
    partial class JsonUI
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
            this.svSourceVarName = new litsdk.SelectVarName();
            this.lsvData = new System.Windows.Forms.ListView();
            this.chJsonPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVarName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbJsonPath = new System.Windows.Forms.TextBox();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lldoc = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.llbDelete = new System.Windows.Forms.LinkLabel();
            this.llbEdit = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.ivJsonPath = new litsdk.InsertVarName();
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
            this.scActivityUI.Panel1.Controls.Add(this.ivJsonPath);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.llbEdit);
            this.scActivityUI.Panel1.Controls.Add(this.llbDelete);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.lldoc);
            this.scActivityUI.Panel1.Controls.Add(this.btnAdd);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.tbJsonPath);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.lsvData);
            this.scActivityUI.Panel1.Controls.Add(this.svSourceVarName);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Json数据源";
            // 
            // svSourceVarName
            // 
            this.svSourceVarName.Location = new System.Drawing.Point(91, 10);
            this.svSourceVarName.Name = "svSourceVarName";
            this.svSourceVarName.Size = new System.Drawing.Size(195, 23);
            this.svSourceVarName.TabIndex = 1;
            this.svSourceVarName.VarName = "";
            // 
            // lsvData
            // 
            this.lsvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chJsonPath,
            this.chVarName});
            this.lsvData.FullRowSelect = true;
            this.lsvData.HideSelection = false;
            this.lsvData.Location = new System.Drawing.Point(91, 41);
            this.lsvData.Name = "lsvData";
            this.lsvData.Size = new System.Drawing.Size(426, 104);
            this.lsvData.TabIndex = 2;
            this.lsvData.UseCompatibleStateImageBehavior = false;
            this.lsvData.View = System.Windows.Forms.View.Details;
            this.lsvData.SelectedIndexChanged += new System.EventHandler(this.lsvData_SelectedIndexChanged);
            this.lsvData.DoubleClick += new System.EventHandler(this.lsvData_DoubleClick);
            // 
            // chJsonPath
            // 
            this.chJsonPath.Text = "JsonPath";
            this.chJsonPath.Width = 188;
            // 
            // chVarName
            // 
            this.chVarName.Text = "保存至变量";
            this.chVarName.Width = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "提取配置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "JsonPath";
            // 
            // tbJsonPath
            // 
            this.tbJsonPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJsonPath.Location = new System.Drawing.Point(91, 154);
            this.tbJsonPath.Name = "tbJsonPath";
            this.tbJsonPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbJsonPath.Size = new System.Drawing.Size(426, 21);
            this.tbJsonPath.TabIndex = 4;
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(91, 187);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(195, 23);
            this.svSaveVarName.TabIndex = 5;
            this.svSaveVarName.VarName = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "保存至";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(299, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lldoc
            // 
            this.lldoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lldoc.AutoSize = true;
            this.lldoc.Location = new System.Drawing.Point(490, 218);
            this.lldoc.Name = "lldoc";
            this.lldoc.Size = new System.Drawing.Size(29, 12);
            this.lldoc.TabIndex = 7;
            this.lldoc.TabStop = true;
            this.lldoc.Text = "用法";
            this.lldoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldoc_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(70, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "JsonPath格式为$.store.book[0].title或$[\'store\'][\'book\'][0][\'title\']";
            // 
            // llbDelete
            // 
            this.llbDelete.AutoSize = true;
            this.llbDelete.Location = new System.Drawing.Point(523, 127);
            this.llbDelete.Name = "llbDelete";
            this.llbDelete.Size = new System.Drawing.Size(29, 12);
            this.llbDelete.TabIndex = 9;
            this.llbDelete.TabStop = true;
            this.llbDelete.Text = "删除";
            this.llbDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDelete_LinkClicked);
            // 
            // llbEdit
            // 
            this.llbEdit.AutoSize = true;
            this.llbEdit.Location = new System.Drawing.Point(523, 97);
            this.llbEdit.Name = "llbEdit";
            this.llbEdit.Size = new System.Drawing.Size(29, 12);
            this.llbEdit.TabIndex = 9;
            this.llbEdit.TabStop = true;
            this.llbEdit.Text = "编辑";
            this.llbEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEdit_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(292, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "源数据非Json或提取错误，则提取值都为空";
            // 
            // ivJsonPath
            // 
            this.ivJsonPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivJsonPath.Location = new System.Drawing.Point(524, 157);
            this.ivJsonPath.Name = "ivJsonPath";
            this.ivJsonPath.Size = new System.Drawing.Size(16, 16);
            this.ivJsonPath.TabIndex = 11;
            // 
            // JsonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "JsonUI";
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
        private litsdk.SelectVarName svSourceVarName;
        private System.Windows.Forms.ListView lsvData;
        private System.Windows.Forms.ColumnHeader chJsonPath;
        private System.Windows.Forms.ColumnHeader chVarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private litsdk.SelectVarName svSaveVarName;
        private System.Windows.Forms.TextBox tbJsonPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lldoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llbEdit;
        private System.Windows.Forms.LinkLabel llbDelete;
        private System.Windows.Forms.Label label7;
        private litsdk.InsertVarName ivJsonPath;
    }
}
