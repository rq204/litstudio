namespace litstudio.iecef
{
    partial class SwitchTabUI
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
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.rbSwitch = new System.Windows.Forms.RadioButton();
            this.rbClose = new System.Windows.Forms.RadioButton();
            this.rbCloseOther = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTabName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLastTab = new System.Windows.Forms.CheckBox();
            this.cbUseRegex = new System.Windows.Forms.CheckBox();
            this.cbDefault = new System.Windows.Forms.CheckBox();
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
            this.scActivityUI.Panel1.Controls.Add(this.cbUseRegex);
            this.scActivityUI.Panel1.Controls.Add(this.cbDefault);
            this.scActivityUI.Panel1.Controls.Add(this.cbLastTab);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.tbTabName);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.rbCloseOther);
            this.scActivityUI.Panel1.Controls.Add(this.rbClose);
            this.scActivityUI.Panel1.Controls.Add(this.rbSwitch);
            this.scActivityUI.Panel1.Controls.Add(this.rbCreate);
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Location = new System.Drawing.Point(93, 22);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(83, 16);
            this.rbCreate.TabIndex = 0;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "新建标签页";
            this.rbCreate.UseVisualStyleBackColor = true;
            this.rbCreate.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSwitch
            // 
            this.rbSwitch.AutoSize = true;
            this.rbSwitch.Location = new System.Drawing.Point(182, 22);
            this.rbSwitch.Name = "rbSwitch";
            this.rbSwitch.Size = new System.Drawing.Size(83, 16);
            this.rbSwitch.TabIndex = 0;
            this.rbSwitch.TabStop = true;
            this.rbSwitch.Text = "切换标签页";
            this.rbSwitch.UseVisualStyleBackColor = true;
            this.rbSwitch.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbClose
            // 
            this.rbClose.AutoSize = true;
            this.rbClose.Location = new System.Drawing.Point(271, 22);
            this.rbClose.Name = "rbClose";
            this.rbClose.Size = new System.Drawing.Size(83, 16);
            this.rbClose.TabIndex = 0;
            this.rbClose.TabStop = true;
            this.rbClose.Text = "关闭标签页";
            this.rbClose.UseVisualStyleBackColor = true;
            this.rbClose.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbCloseOther
            // 
            this.rbCloseOther.AutoSize = true;
            this.rbCloseOther.Location = new System.Drawing.Point(360, 22);
            this.rbCloseOther.Name = "rbCloseOther";
            this.rbCloseOther.Size = new System.Drawing.Size(107, 16);
            this.rbCloseOther.TabIndex = 0;
            this.rbCloseOther.TabStop = true;
            this.rbCloseOther.Text = "关闭其它标签页";
            this.rbCloseOther.UseVisualStyleBackColor = true;
            this.rbCloseOther.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "标签页名称";
            // 
            // tbTabName
            // 
            this.tbTabName.Location = new System.Drawing.Point(93, 61);
            this.tbTabName.Name = "tbTabName";
            this.tbTabName.Size = new System.Drawing.Size(261, 21);
            this.tbTabName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(91, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "注意\r\n1.默认页标签不能被关闭，弹出窗口自动生成的标签页以网址作为标签页名称\r\n2.新建标签页后，将会自动切换至新建标签页\r\n3.新建标签页时，如果存在同名标签" +
    "页，会切换至该标签页";
            // 
            // cbLastTab
            // 
            this.cbLastTab.AutoSize = true;
            this.cbLastTab.Location = new System.Drawing.Point(183, 102);
            this.cbLastTab.Name = "cbLastTab";
            this.cbLastTab.Size = new System.Drawing.Size(120, 16);
            this.cbLastTab.TabIndex = 5;
            this.cbLastTab.Text = "最近创建的标签页";
            this.cbLastTab.UseVisualStyleBackColor = true;
            this.cbLastTab.Visible = false;
            this.cbLastTab.CheckedChanged += new System.EventHandler(this.cbLastTab_CheckedChanged);
            // 
            // cbUseRegex
            // 
            this.cbUseRegex.AutoSize = true;
            this.cbUseRegex.Location = new System.Drawing.Point(360, 64);
            this.cbUseRegex.Name = "cbUseRegex";
            this.cbUseRegex.Size = new System.Drawing.Size(108, 16);
            this.cbUseRegex.TabIndex = 5;
            this.cbUseRegex.Text = "使用正则表达式";
            this.cbUseRegex.UseVisualStyleBackColor = true;
            this.cbUseRegex.Visible = false;
            // 
            // cbDefault
            // 
            this.cbDefault.AutoSize = true;
            this.cbDefault.Location = new System.Drawing.Point(93, 102);
            this.cbDefault.Name = "cbDefault";
            this.cbDefault.Size = new System.Drawing.Size(84, 16);
            this.cbDefault.TabIndex = 5;
            this.cbDefault.Text = "默认标签页";
            this.cbDefault.UseVisualStyleBackColor = true;
            this.cbDefault.Visible = false;
            this.cbDefault.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // SwitchTabUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SwitchTabUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCloseOther;
        private System.Windows.Forms.RadioButton rbClose;
        private System.Windows.Forms.RadioButton rbSwitch;
        private System.Windows.Forms.TextBox tbTabName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbUseRegex;
        private System.Windows.Forms.CheckBox cbLastTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbDefault;
    }
}
