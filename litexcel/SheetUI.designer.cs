namespace litexcel
{
    partial class SheetUI
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
            this.rbAddNew = new System.Windows.Forms.RadioButton();
            this.rbDeleteCur = new System.Windows.Forms.RadioButton();
            this.rbSwitch = new System.Windows.Forms.RadioButton();
            this.tbSheetName = new System.Windows.Forms.TextBox();
            this.cbExcelName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.ivSheetName = new litsdk.InsertVarName();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.cbSwitchAfterChange = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.cbSwitchAfterChange);
            this.scActivityUI.Panel1.Controls.Add(this.ivSheetName);
            this.scActivityUI.Panel1.Controls.Add(this.rbCopy);
            this.scActivityUI.Panel1.Controls.Add(this.cbExcelName);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.tbSheetName);
            this.scActivityUI.Panel1.Controls.Add(this.rbSwitch);
            this.scActivityUI.Panel1.Controls.Add(this.rbDelete);
            this.scActivityUI.Panel1.Controls.Add(this.rbDeleteCur);
            this.scActivityUI.Panel1.Controls.Add(this.rbAddNew);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "操作方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "工作表名称";
            // 
            // rbAddNew
            // 
            this.rbAddNew.AutoSize = true;
            this.rbAddNew.Location = new System.Drawing.Point(90, 60);
            this.rbAddNew.Name = "rbAddNew";
            this.rbAddNew.Size = new System.Drawing.Size(95, 16);
            this.rbAddNew.TabIndex = 1;
            this.rbAddNew.TabStop = true;
            this.rbAddNew.Text = "添加新工作表";
            this.rbAddNew.UseVisualStyleBackColor = true;
            // 
            // rbDeleteCur
            // 
            this.rbDeleteCur.AutoSize = true;
            this.rbDeleteCur.Location = new System.Drawing.Point(340, 61);
            this.rbDeleteCur.Name = "rbDeleteCur";
            this.rbDeleteCur.Size = new System.Drawing.Size(107, 16);
            this.rbDeleteCur.TabIndex = 1;
            this.rbDeleteCur.TabStop = true;
            this.rbDeleteCur.Text = "删除当前工作表";
            this.rbDeleteCur.UseVisualStyleBackColor = true;
            // 
            // rbSwitch
            // 
            this.rbSwitch.AutoSize = true;
            this.rbSwitch.Location = new System.Drawing.Point(90, 97);
            this.rbSwitch.Name = "rbSwitch";
            this.rbSwitch.Size = new System.Drawing.Size(95, 16);
            this.rbSwitch.TabIndex = 1;
            this.rbSwitch.TabStop = true;
            this.rbSwitch.Text = "切换至工作表";
            this.rbSwitch.UseVisualStyleBackColor = true;
            // 
            // tbSheetName
            // 
            this.tbSheetName.Location = new System.Drawing.Point(90, 132);
            this.tbSheetName.Name = "tbSheetName";
            this.tbSheetName.Size = new System.Drawing.Size(148, 21);
            this.tbSheetName.TabIndex = 2;
            // 
            // cbExcelName
            // 
            this.cbExcelName.FormattingEnabled = true;
            this.cbExcelName.Location = new System.Drawing.Point(90, 23);
            this.cbExcelName.Name = "cbExcelName";
            this.cbExcelName.Size = new System.Drawing.Size(148, 20);
            this.cbExcelName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Excel对象";
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Location = new System.Drawing.Point(211, 97);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(107, 16);
            this.rbCopy.TabIndex = 5;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "复制当前工作表";
            this.rbCopy.UseVisualStyleBackColor = true;
            this.rbCopy.Visible = false;
            // 
            // ivSheetName
            // 
            this.ivSheetName.Location = new System.Drawing.Point(244, 133);
            this.ivSheetName.Name = "ivSheetName";
            this.ivSheetName.Size = new System.Drawing.Size(16, 16);
            this.ivSheetName.TabIndex = 6;
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(211, 61);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(107, 16);
            this.rbDelete.TabIndex = 1;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "删除指定工作表";
            this.rbDelete.UseVisualStyleBackColor = true;
            // 
            // cbSwitchAfterChange
            // 
            this.cbSwitchAfterChange.AutoSize = true;
            this.cbSwitchAfterChange.Location = new System.Drawing.Point(285, 134);
            this.cbSwitchAfterChange.Name = "cbSwitchAfterChange";
            this.cbSwitchAfterChange.Size = new System.Drawing.Size(156, 16);
            this.cbSwitchAfterChange.TabIndex = 7;
            this.cbSwitchAfterChange.Text = "添加或复制后切换工作表";
            this.cbSwitchAfterChange.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(253, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "Excel对象为空时，请先新建打开Excel流程";
            // 
            // SheetUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SheetUI";
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
        private System.Windows.Forms.RadioButton rbSwitch;
        private System.Windows.Forms.RadioButton rbDeleteCur;
        private System.Windows.Forms.RadioButton rbAddNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSheetName;
        private System.Windows.Forms.ComboBox cbExcelName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCopy;
        private litsdk.InsertVarName ivSheetName;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.CheckBox cbSwitchAfterChange;
        private System.Windows.Forms.Label label7;
    }
}
