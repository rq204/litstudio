namespace litstudio
{
    partial class TableUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableUI));
            this.label2 = new System.Windows.Forms.Label();
            this.smvSelectFields = new litsdk.SelectMultVarName();
            this.label3 = new System.Windows.Forms.Label();
            this.svTableVarName = new litsdk.SelectVarName();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbDeleteOne = new System.Windows.Forms.RadioButton();
            this.rbDeleteMore = new System.Windows.Forms.RadioButton();
            this.rbDeleteAll = new System.Windows.Forms.RadioButton();
            this.rbEditOne = new System.Windows.Forms.RadioButton();
            this.rbEditMore = new System.Windows.Forms.RadioButton();
            this.lbSelectFields = new System.Windows.Forms.Label();
            this.svmEditFields = new litsdk.SelectMultVarName();
            this.lbEditFields = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbDistinct = new System.Windows.Forms.RadioButton();
            this.rbSort = new System.Windows.Forms.RadioButton();
            this.rbCellData = new System.Windows.Forms.RadioButton();
            this.rbRowSave = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbRowSave);
            this.scActivityUI.Panel1.Controls.Add(this.rbCellData);
            this.scActivityUI.Panel1.Controls.Add(this.rbSort);
            this.scActivityUI.Panel1.Controls.Add(this.rbDistinct);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.rbEditMore);
            this.scActivityUI.Panel1.Controls.Add(this.rbEditOne);
            this.scActivityUI.Panel1.Controls.Add(this.rbDeleteAll);
            this.scActivityUI.Panel1.Controls.Add(this.rbDeleteMore);
            this.scActivityUI.Panel1.Controls.Add(this.rbDeleteOne);
            this.scActivityUI.Panel1.Controls.Add(this.rbAdd);
            this.scActivityUI.Panel1.Controls.Add(this.svTableVarName);
            this.scActivityUI.Panel1.Controls.Add(this.svmEditFields);
            this.scActivityUI.Panel1.Controls.Add(this.smvSelectFields);
            this.scActivityUI.Panel1.Controls.Add(this.lbEditFields);
            this.scActivityUI.Panel1.Controls.Add(this.lbSelectFields);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "选择表格";
            // 
            // smvSelectFields
            // 
            this.smvSelectFields.Location = new System.Drawing.Point(103, 113);
            this.smvSelectFields.Name = "smvSelectFields";
            this.smvSelectFields.Size = new System.Drawing.Size(397, 23);
            this.smvSelectFields.TabIndex = 1;
            this.smvSelectFields.VarNames = ((System.Collections.Generic.List<string>)(resources.GetObject("smvSelectFields.VarNames")));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "操作类型";
            // 
            // svTableVarName
            // 
            this.svTableVarName.Location = new System.Drawing.Point(103, 17);
            this.svTableVarName.Name = "svTableVarName";
            this.svTableVarName.Size = new System.Drawing.Size(187, 23);
            this.svTableVarName.TabIndex = 2;
            this.svTableVarName.VarName = "";
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(103, 54);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(71, 16);
            this.rbAdd.TabIndex = 3;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "添加一行";
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDeleteOne
            // 
            this.rbDeleteOne.AutoSize = true;
            this.rbDeleteOne.Location = new System.Drawing.Point(180, 54);
            this.rbDeleteOne.Name = "rbDeleteOne";
            this.rbDeleteOne.Size = new System.Drawing.Size(71, 16);
            this.rbDeleteOne.TabIndex = 3;
            this.rbDeleteOne.TabStop = true;
            this.rbDeleteOne.Text = "删除一行";
            this.rbDeleteOne.UseVisualStyleBackColor = true;
            this.rbDeleteOne.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDeleteMore
            // 
            this.rbDeleteMore.AutoSize = true;
            this.rbDeleteMore.Location = new System.Drawing.Point(263, 54);
            this.rbDeleteMore.Name = "rbDeleteMore";
            this.rbDeleteMore.Size = new System.Drawing.Size(71, 16);
            this.rbDeleteMore.TabIndex = 3;
            this.rbDeleteMore.TabStop = true;
            this.rbDeleteMore.Text = "删除多行";
            this.rbDeleteMore.UseVisualStyleBackColor = true;
            this.rbDeleteMore.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbDeleteAll
            // 
            this.rbDeleteAll.AutoSize = true;
            this.rbDeleteAll.Location = new System.Drawing.Point(263, 81);
            this.rbDeleteAll.Name = "rbDeleteAll";
            this.rbDeleteAll.Size = new System.Drawing.Size(71, 16);
            this.rbDeleteAll.TabIndex = 3;
            this.rbDeleteAll.TabStop = true;
            this.rbDeleteAll.Text = "删除所有";
            this.rbDeleteAll.UseVisualStyleBackColor = true;
            this.rbDeleteAll.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbEditOne
            // 
            this.rbEditOne.AutoSize = true;
            this.rbEditOne.Location = new System.Drawing.Point(103, 81);
            this.rbEditOne.Name = "rbEditOne";
            this.rbEditOne.Size = new System.Drawing.Size(71, 16);
            this.rbEditOne.TabIndex = 3;
            this.rbEditOne.TabStop = true;
            this.rbEditOne.Text = "编辑一行";
            this.rbEditOne.UseVisualStyleBackColor = true;
            this.rbEditOne.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbEditMore
            // 
            this.rbEditMore.AutoSize = true;
            this.rbEditMore.Location = new System.Drawing.Point(180, 81);
            this.rbEditMore.Name = "rbEditMore";
            this.rbEditMore.Size = new System.Drawing.Size(71, 16);
            this.rbEditMore.TabIndex = 3;
            this.rbEditMore.TabStop = true;
            this.rbEditMore.Text = "编辑多行";
            this.rbEditMore.UseVisualStyleBackColor = true;
            this.rbEditMore.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // lbSelectFields
            // 
            this.lbSelectFields.AutoSize = true;
            this.lbSelectFields.Location = new System.Drawing.Point(44, 116);
            this.lbSelectFields.Name = "lbSelectFields";
            this.lbSelectFields.Size = new System.Drawing.Size(53, 12);
            this.lbSelectFields.TabIndex = 0;
            this.lbSelectFields.Text = "添加字段";
            // 
            // svmEditFields
            // 
            this.svmEditFields.Location = new System.Drawing.Point(103, 150);
            this.svmEditFields.Name = "svmEditFields";
            this.svmEditFields.Size = new System.Drawing.Size(397, 23);
            this.svmEditFields.TabIndex = 1;
            this.svmEditFields.VarNames = ((System.Collections.Generic.List<string>)(resources.GetObject("svmEditFields.VarNames")));
            // 
            // lbEditFields
            // 
            this.lbEditFields.AutoSize = true;
            this.lbEditFields.Location = new System.Drawing.Point(44, 154);
            this.lbEditFields.Name = "lbEditFields";
            this.lbEditFields.Size = new System.Drawing.Size(53, 12);
            this.lbEditFields.TabIndex = 0;
            this.lbEditFields.Text = "编辑字段";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(44, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(499, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "编辑和删除，都是按匹配字段的值，在表格中查找匹配结果，一行是结果的第一行，多行是所有匹配结果，要对所有数据进行查看处理请使用循环组件中循环表格功能";
            // 
            // rbDistinct
            // 
            this.rbDistinct.AutoSize = true;
            this.rbDistinct.Location = new System.Drawing.Point(344, 81);
            this.rbDistinct.Name = "rbDistinct";
            this.rbDistinct.Size = new System.Drawing.Size(71, 16);
            this.rbDistinct.TabIndex = 5;
            this.rbDistinct.TabStop = true;
            this.rbDistinct.Text = "排除重复";
            this.rbDistinct.UseVisualStyleBackColor = true;
            this.rbDistinct.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSort
            // 
            this.rbSort.AutoSize = true;
            this.rbSort.Location = new System.Drawing.Point(344, 54);
            this.rbSort.Name = "rbSort";
            this.rbSort.Size = new System.Drawing.Size(71, 16);
            this.rbSort.TabIndex = 5;
            this.rbSort.TabStop = true;
            this.rbSort.Text = "内容排序";
            this.rbSort.UseVisualStyleBackColor = true;
            this.rbSort.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbCellData
            // 
            this.rbCellData.AutoSize = true;
            this.rbCellData.Location = new System.Drawing.Point(429, 56);
            this.rbCellData.Name = "rbCellData";
            this.rbCellData.Size = new System.Drawing.Size(71, 16);
            this.rbCellData.TabIndex = 6;
            this.rbCellData.TabStop = true;
            this.rbCellData.Text = "单元取值";
            this.rbCellData.UseVisualStyleBackColor = true;
            this.rbCellData.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbRowSave
            // 
            this.rbRowSave.AutoSize = true;
            this.rbRowSave.Location = new System.Drawing.Point(429, 81);
            this.rbRowSave.Name = "rbRowSave";
            this.rbRowSave.Size = new System.Drawing.Size(71, 16);
            this.rbRowSave.TabIndex = 6;
            this.rbRowSave.TabStop = true;
            this.rbRowSave.Text = "多行另存";
            this.rbRowSave.UseVisualStyleBackColor = true;
            this.rbRowSave.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // TableUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TableUI";
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
        private System.Windows.Forms.RadioButton rbEditMore;
        private System.Windows.Forms.RadioButton rbEditOne;
        private System.Windows.Forms.RadioButton rbDeleteAll;
        private System.Windows.Forms.RadioButton rbDeleteMore;
        private System.Windows.Forms.RadioButton rbDeleteOne;
        private System.Windows.Forms.RadioButton rbAdd;
        private litsdk.SelectVarName svTableVarName;
        private litsdk.SelectMultVarName svmEditFields;
        private litsdk.SelectMultVarName smvSelectFields;
        private System.Windows.Forms.Label lbEditFields;
        private System.Windows.Forms.Label lbSelectFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbDistinct;
        private System.Windows.Forms.RadioButton rbSort;
        private System.Windows.Forms.RadioButton rbCellData;
        private System.Windows.Forms.RadioButton rbRowSave;
    }
}
