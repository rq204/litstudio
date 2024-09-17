
namespace litapps
{
    partial class UserInputUI
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
            this.lsvConfigs = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUIType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCanNull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDefault = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.svDefaultVarName = new litsdk.SelectVarName();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFormTitle = new System.Windows.Forms.TextBox();
            this.ivFormTitle = new litsdk.InsertVarName();
            this.cbCanEmpty = new System.Windows.Forms.CheckBox();
            this.cbTimeOutClose = new System.Windows.Forms.CheckBox();
            this.nudTimeOutSenconds = new System.Windows.Forms.NumericUpDown();
            this.lbmiao = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.llbUp = new System.Windows.Forms.LinkLabel();
            this.llbDown = new System.Windows.Forms.LinkLabel();
            this.llbEdit = new System.Windows.Forms.LinkLabel();
            this.llbDelete = new System.Windows.Forms.LinkLabel();
            this.cbCanCloseForm = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOutSenconds)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.cbCanCloseForm);
            this.scActivityUI.Panel1.Controls.Add(this.llbDelete);
            this.scActivityUI.Panel1.Controls.Add(this.llbEdit);
            this.scActivityUI.Panel1.Controls.Add(this.llbDown);
            this.scActivityUI.Panel1.Controls.Add(this.llbUp);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.nudTimeOutSenconds);
            this.scActivityUI.Panel1.Controls.Add(this.cbTimeOutClose);
            this.scActivityUI.Panel1.Controls.Add(this.cbCanEmpty);
            this.scActivityUI.Panel1.Controls.Add(this.ivFormTitle);
            this.scActivityUI.Panel1.Controls.Add(this.btnSave);
            this.scActivityUI.Panel1.Controls.Add(this.cbType);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.svDefaultVarName);
            this.scActivityUI.Panel1.Controls.Add(this.tbFormTitle);
            this.scActivityUI.Panel1.Controls.Add(this.tbTitle);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.lbDefault);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.lbmiao);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.lsvConfigs);
            // 
            // lsvConfigs
            // 
            this.lsvConfigs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvConfigs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chUIType,
            this.chValue,
            this.chSave,
            this.chCanNull});
            this.lsvConfigs.FullRowSelect = true;
            this.lsvConfigs.HideSelection = false;
            this.lsvConfigs.Location = new System.Drawing.Point(70, 51);
            this.lsvConfigs.MultiSelect = false;
            this.lsvConfigs.Name = "lsvConfigs";
            this.lsvConfigs.Size = new System.Drawing.Size(407, 105);
            this.lsvConfigs.TabIndex = 0;
            this.lsvConfigs.UseCompatibleStateImageBehavior = false;
            this.lsvConfigs.View = System.Windows.Forms.View.Details;
            this.lsvConfigs.SelectedIndexChanged += new System.EventHandler(this.lsvConfigs_SelectedIndexChanged);
            this.lsvConfigs.DoubleClick += new System.EventHandler(this.lsvConfigs_DoubleClick);
            // 
            // chName
            // 
            this.chName.Text = "操作名称";
            this.chName.Width = 78;
            // 
            // chUIType
            // 
            this.chUIType.Text = "控件类型";
            this.chUIType.Width = 78;
            // 
            // chValue
            // 
            this.chValue.Text = "默认值";
            this.chValue.Width = 91;
            // 
            // chSave
            // 
            this.chSave.Text = "保存至";
            this.chSave.Width = 76;
            // 
            // chCanNull
            // 
            this.chCanNull.Text = "可以空值";
            this.chCanNull.Width = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "控件类型";
            // 
            // lbDefault
            // 
            this.lbDefault.AutoSize = true;
            this.lbDefault.Location = new System.Drawing.Point(240, 177);
            this.lbDefault.Name = "lbDefault";
            this.lbDefault.Size = new System.Drawing.Size(41, 12);
            this.lbDefault.TabIndex = 1;
            this.lbDefault.Text = "默认值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "保存至";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(71, 173);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(155, 21);
            this.tbTitle.TabIndex = 3;
            // 
            // svDefaultVarName
            // 
            this.svDefaultVarName.Location = new System.Drawing.Point(288, 173);
            this.svDefaultVarName.Name = "svDefaultVarName";
            this.svDefaultVarName.Size = new System.Drawing.Size(180, 23);
            this.svDefaultVarName.TabIndex = 5;
            this.svDefaultVarName.VarName = "";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(288, 204);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(180, 23);
            this.svSaveVarName.TabIndex = 6;
            this.svSaveVarName.VarName = "";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "文本框",
            "多行文本框",
            "数字输入框",
            "下拉框",
            "单选",
            "复选"});
            this.cbType.Location = new System.Drawing.Point(70, 206);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(156, 20);
            this.cbType.TabIndex = 7;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(485, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "窗口标题";
            // 
            // tbFormTitle
            // 
            this.tbFormTitle.Location = new System.Drawing.Point(70, 11);
            this.tbFormTitle.Name = "tbFormTitle";
            this.tbFormTitle.Size = new System.Drawing.Size(156, 21);
            this.tbFormTitle.TabIndex = 3;
            // 
            // ivFormTitle
            // 
            this.ivFormTitle.Location = new System.Drawing.Point(234, 14);
            this.ivFormTitle.Name = "ivFormTitle";
            this.ivFormTitle.Size = new System.Drawing.Size(16, 16);
            this.ivFormTitle.TabIndex = 9;
            // 
            // cbCanEmpty
            // 
            this.cbCanEmpty.AutoSize = true;
            this.cbCanEmpty.Location = new System.Drawing.Point(485, 174);
            this.cbCanEmpty.Name = "cbCanEmpty";
            this.cbCanEmpty.Size = new System.Drawing.Size(72, 16);
            this.cbCanEmpty.TabIndex = 10;
            this.cbCanEmpty.Text = "可以空值";
            this.cbCanEmpty.UseVisualStyleBackColor = true;
            // 
            // cbTimeOutClose
            // 
            this.cbTimeOutClose.AutoSize = true;
            this.cbTimeOutClose.Enabled = false;
            this.cbTimeOutClose.Location = new System.Drawing.Point(347, 15);
            this.cbTimeOutClose.Name = "cbTimeOutClose";
            this.cbTimeOutClose.Size = new System.Drawing.Size(96, 16);
            this.cbTimeOutClose.TabIndex = 10;
            this.cbTimeOutClose.Text = "超时关闭窗口";
            this.cbTimeOutClose.UseVisualStyleBackColor = true;
            this.cbTimeOutClose.CheckedChanged += new System.EventHandler(this.cbTimeOutClose_CheckedChanged);
            // 
            // nudTimeOutSenconds
            // 
            this.nudTimeOutSenconds.Location = new System.Drawing.Point(450, 13);
            this.nudTimeOutSenconds.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.nudTimeOutSenconds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTimeOutSenconds.Name = "nudTimeOutSenconds";
            this.nudTimeOutSenconds.Size = new System.Drawing.Size(55, 21);
            this.nudTimeOutSenconds.TabIndex = 11;
            this.nudTimeOutSenconds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbmiao
            // 
            this.lbmiao.AutoSize = true;
            this.lbmiao.Location = new System.Drawing.Point(511, 18);
            this.lbmiao.Name = "lbmiao";
            this.lbmiao.Size = new System.Drawing.Size(17, 12);
            this.lbmiao.TabIndex = 1;
            this.lbmiao.Text = "秒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "配置列表";
            // 
            // llbUp
            // 
            this.llbUp.AutoSize = true;
            this.llbUp.Location = new System.Drawing.Point(495, 51);
            this.llbUp.Name = "llbUp";
            this.llbUp.Size = new System.Drawing.Size(29, 12);
            this.llbUp.TabIndex = 13;
            this.llbUp.TabStop = true;
            this.llbUp.Text = "上移";
            this.llbUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUp_LinkClicked);
            // 
            // llbDown
            // 
            this.llbDown.AutoSize = true;
            this.llbDown.Location = new System.Drawing.Point(495, 78);
            this.llbDown.Name = "llbDown";
            this.llbDown.Size = new System.Drawing.Size(29, 12);
            this.llbDown.TabIndex = 13;
            this.llbDown.TabStop = true;
            this.llbDown.Text = "下移";
            this.llbDown.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDown_LinkClicked);
            // 
            // llbEdit
            // 
            this.llbEdit.AutoSize = true;
            this.llbEdit.Location = new System.Drawing.Point(495, 109);
            this.llbEdit.Name = "llbEdit";
            this.llbEdit.Size = new System.Drawing.Size(29, 12);
            this.llbEdit.TabIndex = 13;
            this.llbEdit.TabStop = true;
            this.llbEdit.Text = "编辑";
            this.llbEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEdit_LinkClicked);
            // 
            // llbDelete
            // 
            this.llbDelete.AutoSize = true;
            this.llbDelete.Location = new System.Drawing.Point(495, 135);
            this.llbDelete.Name = "llbDelete";
            this.llbDelete.Size = new System.Drawing.Size(29, 12);
            this.llbDelete.TabIndex = 13;
            this.llbDelete.TabStop = true;
            this.llbDelete.Text = "删除";
            this.llbDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDelete_LinkClicked);
            // 
            // cbCanCloseForm
            // 
            this.cbCanCloseForm.AutoSize = true;
            this.cbCanCloseForm.Location = new System.Drawing.Point(257, 15);
            this.cbCanCloseForm.Name = "cbCanCloseForm";
            this.cbCanCloseForm.Size = new System.Drawing.Size(84, 16);
            this.cbCanCloseForm.TabIndex = 14;
            this.cbCanCloseForm.Text = "可关闭窗口";
            this.cbCanCloseForm.UseVisualStyleBackColor = true;
            this.cbCanCloseForm.CheckedChanged += new System.EventHandler(this.cbCanCloseForm_CheckedChanged);
            // 
            // UserInputUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UserInputUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOutSenconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvConfigs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDefault;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chUIType;
        private System.Windows.Forms.ColumnHeader chValue;
        private System.Windows.Forms.ColumnHeader chSave;
        private System.Windows.Forms.ComboBox cbType;
        private litsdk.SelectVarName svSaveVarName;
        private litsdk.SelectVarName svDefaultVarName;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTimeOutSenconds;
        private System.Windows.Forms.CheckBox cbTimeOutClose;
        private System.Windows.Forms.CheckBox cbCanEmpty;
        private litsdk.InsertVarName ivFormTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbFormTitle;
        private System.Windows.Forms.Label lbmiao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader chCanNull;
        private System.Windows.Forms.LinkLabel llbDelete;
        private System.Windows.Forms.LinkLabel llbEdit;
        private System.Windows.Forms.LinkLabel llbDown;
        private System.Windows.Forms.LinkLabel llbUp;
        private System.Windows.Forms.CheckBox cbCanCloseForm;
    }
}
