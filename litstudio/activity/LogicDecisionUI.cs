using litcore.activity;
using litcore.type;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace litstudio
{
    internal class LogicUI : ILitUI
    {
        private RadioButton rbStrAIndexOfStrB;
        private RadioButton rbIntAEqualsIntB;
        private Label label1;
        private SelectVarName svBSetting;
        private SelectVarName svASetting;
        private RadioButton rbStrAEqualsStrB;
        private RadioButton rbStrANotEmpty;
        private RadioButton rbIntABigerIntB;
        private RadioButton rbListAContainsStrB;
        private RadioButton rbTableAEqualsTableB;
        private Label lbB;
        private Label label2;
        private RadioButton rbIntAIsZero;
        private Label label4;
        private Label label3;
        private RadioButton rbListACountBiger0;
        private RadioButton rbTableARowsBiger0;
        private RadioButton rbListACountBigerIntB;
        private RadioButton rbStrAContainListBItem;
        private RadioButton rbListACountEqualsIntB;
        private RadioButton rbListACountBigerEqualIntB;
        private Label label5;
        private CheckBox cbReverse;
        private RadioButton rbTableARowsBigerIntB;
        LogicDecideActivity la = null;
        public override void SetActivity(Activity activity)
        {
            la = activity as LogicDecideActivity;
            this.svASetting.VarName = la.ASetting;
            this.svBSetting.VarName = la.BSetting;

            switch (la.LogicType)
            {
                case LogicType.StrAIndexOfStrB:
                    this.rbStrAIndexOfStrB.Checked = true;
                    break;
                case LogicType.StrAEqualsStrB:
                    this.rbStrAEqualsStrB.Checked = true;
                    break;
                case LogicType.ListAContainsStrB:
                    this.rbListAContainsStrB.Checked = true;
                    break;
                case LogicType.ListANotContainsStrB:
                    this.rbListAContainsStrB.Checked = true;
                    this.cbReverse.Checked = true;
                    break;
                case LogicType.IntAEqualsIntB:
                    this.rbIntAEqualsIntB.Checked = true;
                    break;
                case LogicType.IntABigerIntB:
                    this.rbIntABigerIntB.Checked = true;
                    break;
                case LogicType.TableAEqualsTableB:
                    this.rbTableAEqualsTableB.Checked = true;
                    break;
                case LogicType.IntAIsZero:
                    this.rbIntAIsZero.Checked = true;
                    break;
                case LogicType.StrANotEmpty:
                    this.rbStrANotEmpty.Checked = true;
                    break;
                case LogicType.StrAContainsListBItem:
                    this.rbStrAContainListBItem.Checked = true;
                    break;
                case LogicType.TableARowsBiger0:
                    this.rbTableARowsBiger0.Checked = true;
                    break;
                case LogicType.ListACountBiger0:
                    this.rbListACountBiger0.Checked = true;
                    break;
                case LogicType.ListACountBigerIntB:
                    this.rbListACountBigerIntB.Checked = true;
                    break;
                case LogicType.ListACountEqualsIntB:
                    this.rbListACountEqualsIntB.Checked = true;
                    break;
                case LogicType.ListACountLessIntB:
                    this.rbListACountBigerEqualIntB.Checked = true;
                    this.cbReverse.Checked = true;
                    break;
                case LogicType.ListACountBigerEqualIntB:
                    this.rbListACountBigerEqualIntB.Checked = true;
                    break;
                case LogicType.TableARowsBigerIntB:
                    this.rbTableARowsBigerIntB.Checked = true;
                    break;
            }

            this.cbReverse.Checked = la.Reverse;
            this.tbActivityName.Text = la.Name;
        }

        public LogicUI()
        {
            this.InitializeComponent();
            this.svASetting.ShowVarName(true, false, false);
            this.svBSetting.ShowVarName(true, false, false);
            base.SaveActivity = new Action(() =>
            {
                la.ASetting = this.svASetting.VarName;
                la.BSetting = this.svBSetting.VarName;
                if (this.rbStrAIndexOfStrB.Checked)
                {
                    la.LogicType = LogicType.StrAIndexOfStrB;
                }
                else if (this.rbStrAEqualsStrB.Checked)
                {
                    la.LogicType = LogicType.StrAEqualsStrB;
                }
                else if (this.rbStrANotEmpty.Checked)
                {
                    la.LogicType = LogicType.StrANotEmpty;
                }
                else if (this.rbListAContainsStrB.Checked)
                {
                    la.LogicType = LogicType.ListAContainsStrB;
                }
                else if (this.rbIntAEqualsIntB.Checked)
                {
                    la.LogicType = LogicType.IntAEqualsIntB;
                }
                else if (this.rbIntABigerIntB.Checked)
                {
                    la.LogicType = LogicType.IntABigerIntB;
                }
                else if (this.rbTableAEqualsTableB.Checked)
                {
                    la.LogicType = LogicType.TableAEqualsTableB;
                }
                else if (this.rbIntAIsZero.Checked)
                {
                    la.LogicType = LogicType.IntAIsZero;
                }
                else if (this.rbStrAContainListBItem.Checked)
                {
                    la.LogicType = LogicType.StrAContainsListBItem;
                }
                else if (this.rbListACountBiger0.Checked)
                {
                    la.LogicType = LogicType.ListACountBiger0;
                }
                else if (this.rbTableARowsBiger0.Checked)
                {
                    la.LogicType = LogicType.TableARowsBiger0;
                }
                else if (this.rbListACountBigerIntB.Checked)
                {
                    la.LogicType = LogicType.ListACountBigerIntB;
                }
                else if (this.rbListACountEqualsIntB.Checked)
                {
                    la.LogicType = LogicType.ListACountEqualsIntB;
                }
                else if (this.rbListACountBigerEqualIntB.Checked)
                {
                    la.LogicType = LogicType.ListACountBigerEqualIntB;
                }
                else if (this.rbTableARowsBigerIntB.Checked)
                {
                    la.LogicType = LogicType.TableARowsBigerIntB;
                }
                la.Name = base.tbActivityName.Text;
                la.Reverse = this.cbReverse.Checked;
            });

            foreach (Control c in this.scActivityUI.Panel1.Controls)
            {
                if (c is RadioButton rb) rb.CheckedChanged += this.rb_CheckedChanged;
            }
        }


        private void InitializeComponent()
        {
            this.rbStrAIndexOfStrB = new System.Windows.Forms.RadioButton();
            this.rbIntAEqualsIntB = new System.Windows.Forms.RadioButton();
            this.rbListAContainsStrB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.svASetting = new litsdk.SelectVarName();
            this.svBSetting = new litsdk.SelectVarName();
            this.rbStrAEqualsStrB = new System.Windows.Forms.RadioButton();
            this.rbStrANotEmpty = new System.Windows.Forms.RadioButton();
            this.rbIntABigerIntB = new System.Windows.Forms.RadioButton();
            this.rbTableAEqualsTableB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.rbIntAIsZero = new System.Windows.Forms.RadioButton();
            this.rbTableARowsBiger0 = new System.Windows.Forms.RadioButton();
            this.rbListACountBiger0 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbStrAContainListBItem = new System.Windows.Forms.RadioButton();
            this.rbListACountBigerIntB = new System.Windows.Forms.RadioButton();
            this.rbListACountEqualsIntB = new System.Windows.Forms.RadioButton();
            this.cbReverse = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbListACountBigerEqualIntB = new System.Windows.Forms.RadioButton();
            this.rbTableARowsBigerIntB = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbTableARowsBigerIntB);
            this.scActivityUI.Panel1.Controls.Add(this.rbListACountBigerEqualIntB);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.cbReverse);
            this.scActivityUI.Panel1.Controls.Add(this.rbListACountEqualsIntB);
            this.scActivityUI.Panel1.Controls.Add(this.rbListACountBigerIntB);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.rbListACountBiger0);
            this.scActivityUI.Panel1.Controls.Add(this.rbTableARowsBiger0);
            this.scActivityUI.Panel1.Controls.Add(this.rbStrAContainListBItem);
            this.scActivityUI.Panel1.Controls.Add(this.rbIntAIsZero);
            this.scActivityUI.Panel1.Controls.Add(this.lbB);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.rbTableAEqualsTableB);
            this.scActivityUI.Panel1.Controls.Add(this.rbStrANotEmpty);
            this.scActivityUI.Panel1.Controls.Add(this.rbStrAEqualsStrB);
            this.scActivityUI.Panel1.Controls.Add(this.rbListAContainsStrB);
            this.scActivityUI.Panel1.Controls.Add(this.rbIntABigerIntB);
            this.scActivityUI.Panel1.Controls.Add(this.rbIntAEqualsIntB);
            this.scActivityUI.Panel1.Controls.Add(this.rbStrAIndexOfStrB);
            this.scActivityUI.Panel1.Controls.Add(this.svBSetting);
            this.scActivityUI.Panel1.Controls.Add(this.svASetting);
            // 
            // rbStrAIndexOfStrB
            // 
            this.rbStrAIndexOfStrB.AutoSize = true;
            this.rbStrAIndexOfStrB.Location = new System.Drawing.Point(87, 54);
            this.rbStrAIndexOfStrB.Name = "rbStrAIndexOfStrB";
            this.rbStrAIndexOfStrB.Size = new System.Drawing.Size(107, 16);
            this.rbStrAIndexOfStrB.TabIndex = 0;
            this.rbStrAIndexOfStrB.Text = "字符A包含字符B";
            this.rbStrAIndexOfStrB.UseVisualStyleBackColor = true;
            // 
            // rbIntAEqualsIntB
            // 
            this.rbIntAEqualsIntB.AutoSize = true;
            this.rbIntAEqualsIntB.Location = new System.Drawing.Point(87, 84);
            this.rbIntAEqualsIntB.Name = "rbIntAEqualsIntB";
            this.rbIntAEqualsIntB.Size = new System.Drawing.Size(107, 16);
            this.rbIntAEqualsIntB.TabIndex = 0;
            this.rbIntAEqualsIntB.Text = "数字A等于数字B";
            this.rbIntAEqualsIntB.UseVisualStyleBackColor = true;
            // 
            // rbListAContainsStrB
            // 
            this.rbListAContainsStrB.AutoSize = true;
            this.rbListAContainsStrB.Location = new System.Drawing.Point(87, 114);
            this.rbListAContainsStrB.Name = "rbListAContainsStrB";
            this.rbListAContainsStrB.Size = new System.Drawing.Size(119, 16);
            this.rbListAContainsStrB.TabIndex = 0;
            this.rbListAContainsStrB.Text = "列表A包含项字符B";
            this.rbListAContainsStrB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "比较对像A";
            // 
            // svASetting
            // 
            this.svASetting.Location = new System.Drawing.Point(127, 16);
            this.svASetting.Name = "svASetting";
            this.svASetting.Size = new System.Drawing.Size(145, 21);
            this.svASetting.TabIndex = 5;
            this.svASetting.VarName = "";
            // 
            // svBSetting
            // 
            this.svBSetting.Location = new System.Drawing.Point(372, 16);
            this.svBSetting.Name = "svBSetting";
            this.svBSetting.Size = new System.Drawing.Size(145, 21);
            this.svBSetting.TabIndex = 6;
            this.svBSetting.VarName = "";
            // 
            // rbStrAEqualsStrB
            // 
            this.rbStrAEqualsStrB.AutoSize = true;
            this.rbStrAEqualsStrB.Location = new System.Drawing.Point(240, 53);
            this.rbStrAEqualsStrB.Name = "rbStrAEqualsStrB";
            this.rbStrAEqualsStrB.Size = new System.Drawing.Size(107, 16);
            this.rbStrAEqualsStrB.TabIndex = 8;
            this.rbStrAEqualsStrB.Text = "字符A等于字符B";
            this.rbStrAEqualsStrB.UseVisualStyleBackColor = true;
            // 
            // rbStrANotEmpty
            // 
            this.rbStrANotEmpty.AutoSize = true;
            this.rbStrANotEmpty.Location = new System.Drawing.Point(399, 51);
            this.rbStrANotEmpty.Name = "rbStrANotEmpty";
            this.rbStrANotEmpty.Size = new System.Drawing.Size(113, 16);
            this.rbStrANotEmpty.TabIndex = 10;
            this.rbStrANotEmpty.Text = "字符A的值不为空";
            this.rbStrANotEmpty.UseVisualStyleBackColor = true;
            // 
            // rbIntABigerIntB
            // 
            this.rbIntABigerIntB.AutoSize = true;
            this.rbIntABigerIntB.Location = new System.Drawing.Point(240, 84);
            this.rbIntABigerIntB.Name = "rbIntABigerIntB";
            this.rbIntABigerIntB.Size = new System.Drawing.Size(107, 16);
            this.rbIntABigerIntB.TabIndex = 0;
            this.rbIntABigerIntB.Text = "数字A大于数字B";
            this.rbIntABigerIntB.UseVisualStyleBackColor = true;
            // 
            // rbTableAEqualsTableB
            // 
            this.rbTableAEqualsTableB.AutoSize = true;
            this.rbTableAEqualsTableB.Location = new System.Drawing.Point(87, 174);
            this.rbTableAEqualsTableB.Name = "rbTableAEqualsTableB";
            this.rbTableAEqualsTableB.Size = new System.Drawing.Size(107, 16);
            this.rbTableAEqualsTableB.TabIndex = 11;
            this.rbTableAEqualsTableB.Text = "表格A等于表格B";
            this.rbTableAEqualsTableB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "变量A";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(330, 21);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(35, 12);
            this.lbB.TabIndex = 13;
            this.lbB.Text = "变量B";
            // 
            // rbIntAIsZero
            // 
            this.rbIntAIsZero.AutoSize = true;
            this.rbIntAIsZero.Location = new System.Drawing.Point(399, 84);
            this.rbIntAIsZero.Name = "rbIntAIsZero";
            this.rbIntAIsZero.Size = new System.Drawing.Size(107, 16);
            this.rbIntAIsZero.TabIndex = 14;
            this.rbIntAIsZero.Text = "数字A的值等于0";
            this.rbIntAIsZero.UseVisualStyleBackColor = true;
            // 
            // rbTableARowsBiger0
            // 
            this.rbTableARowsBiger0.AutoSize = true;
            this.rbTableARowsBiger0.Location = new System.Drawing.Point(399, 174);
            this.rbTableARowsBiger0.Name = "rbTableARowsBiger0";
            this.rbTableARowsBiger0.Size = new System.Drawing.Size(107, 16);
            this.rbTableARowsBiger0.TabIndex = 16;
            this.rbTableARowsBiger0.TabStop = true;
            this.rbTableARowsBiger0.Text = "表格A行数大于0";
            this.rbTableARowsBiger0.UseVisualStyleBackColor = true;
            // 
            // rbListACountBiger0
            // 
            this.rbListACountBiger0.AutoSize = true;
            this.rbListACountBiger0.Location = new System.Drawing.Point(399, 114);
            this.rbListACountBiger0.Name = "rbListACountBiger0";
            this.rbListACountBiger0.Size = new System.Drawing.Size(107, 16);
            this.rbListACountBiger0.TabIndex = 16;
            this.rbListACountBiger0.TabStop = true;
            this.rbListACountBiger0.Text = "列表A行数大于0";
            this.rbListACountBiger0.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "比较方式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "比较对象";
            // 
            // rbStrAContainListBItem
            // 
            this.rbStrAContainListBItem.AutoSize = true;
            this.rbStrAContainListBItem.Location = new System.Drawing.Point(399, 144);
            this.rbStrAContainListBItem.Name = "rbStrAContainListBItem";
            this.rbStrAContainListBItem.Size = new System.Drawing.Size(143, 16);
            this.rbStrAContainListBItem.TabIndex = 15;
            this.rbStrAContainListBItem.TabStop = true;
            this.rbStrAContainListBItem.Text = "字符A包含列表B中某项";
            this.rbStrAContainListBItem.UseVisualStyleBackColor = true;
            // 
            // rbListACountBigerIntB
            // 
            this.rbListACountBigerIntB.AutoSize = true;
            this.rbListACountBigerIntB.Location = new System.Drawing.Point(240, 114);
            this.rbListACountBigerIntB.Name = "rbListACountBigerIntB";
            this.rbListACountBigerIntB.Size = new System.Drawing.Size(131, 16);
            this.rbListACountBigerIntB.TabIndex = 19;
            this.rbListACountBigerIntB.TabStop = true;
            this.rbListACountBigerIntB.Text = "列表A行数大于数字B";
            this.rbListACountBigerIntB.UseVisualStyleBackColor = true;
            // 
            // rbListACountEqualsIntB
            // 
            this.rbListACountEqualsIntB.AutoSize = true;
            this.rbListACountEqualsIntB.Location = new System.Drawing.Point(87, 144);
            this.rbListACountEqualsIntB.Name = "rbListACountEqualsIntB";
            this.rbListACountEqualsIntB.Size = new System.Drawing.Size(131, 16);
            this.rbListACountEqualsIntB.TabIndex = 20;
            this.rbListACountEqualsIntB.TabStop = true;
            this.rbListACountEqualsIntB.Text = "列表A行数等于数字B";
            this.rbListACountEqualsIntB.UseVisualStyleBackColor = true;
            // 
            // cbReverse
            // 
            this.cbReverse.AutoSize = true;
            this.cbReverse.Location = new System.Drawing.Point(87, 209);
            this.cbReverse.Name = "cbReverse";
            this.cbReverse.Size = new System.Drawing.Size(72, 16);
            this.cbReverse.TabIndex = 22;
            this.cbReverse.Text = "取相反值";
            this.cbReverse.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "其它选项";
            // 
            // rbListACountBigerEqualIntB
            // 
            this.rbListACountBigerEqualIntB.AutoSize = true;
            this.rbListACountBigerEqualIntB.Location = new System.Drawing.Point(240, 144);
            this.rbListACountBigerEqualIntB.Name = "rbListACountBigerEqualIntB";
            this.rbListACountBigerEqualIntB.Size = new System.Drawing.Size(143, 16);
            this.rbListACountBigerEqualIntB.TabIndex = 24;
            this.rbListACountBigerEqualIntB.TabStop = true;
            this.rbListACountBigerEqualIntB.Text = "列表A行数大等于数字B";
            this.rbListACountBigerEqualIntB.UseVisualStyleBackColor = true;
            // 
            // rbTableARowsBigerIntB
            // 
            this.rbTableARowsBigerIntB.AutoSize = true;
            this.rbTableARowsBigerIntB.Location = new System.Drawing.Point(240, 174);
            this.rbTableARowsBigerIntB.Name = "rbTableARowsBigerIntB";
            this.rbTableARowsBigerIntB.Size = new System.Drawing.Size(131, 16);
            this.rbTableARowsBigerIntB.TabIndex = 25;
            this.rbTableARowsBigerIntB.Text = "表格A行数大于数字B";
            this.rbTableARowsBigerIntB.UseVisualStyleBackColor = true;
            // 
            // LogicUI
            // 
            this.Name = "LogicUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbStrAIndexOfStrB.Checked || this.rbStrAEqualsStrB.Checked)
            {
                this.svASetting.ShowVarName(true, false, false);
                this.svBSetting.ShowVarName(true, false, false);
            }
            else if (this.rbListAContainsStrB.Checked)
            {
                this.svASetting.ShowVarName(false, true, false);
                this.svBSetting.ShowVarName(true, false, false);
            }
            else if (this.rbIntAEqualsIntB.Checked || this.rbIntABigerIntB.Checked)
            {
                this.svASetting.ShowVarName(false, false, true);
                this.svBSetting.ShowVarName(false, false, true);
            }

            if (this.rbTableAEqualsTableB.Checked)
            {
                this.svASetting.ShowVarName(false, false, false, true);
                this.svBSetting.ShowVarName(false, false, false, true);
            }
            if (this.rbTableARowsBigerIntB.Checked)
            {
                this.svASetting.ShowVarName(false, false, false, true);
                this.svBSetting.ShowVarName(false, false, true, false);
            }

            if (this.rbStrANotEmpty.Checked || this.rbIntAIsZero.Checked || this.rbTableARowsBiger0.Checked || this.rbListACountBiger0.Checked)
            {
                if (this.rbStrANotEmpty.Checked)
                {
                    this.svASetting.ShowVarName(true, false, false);
                }
                else if (this.rbTableARowsBiger0.Checked)
                {
                    this.svASetting.ShowVarName(false, false, false, true);
                }
                else if (this.rbListACountBiger0.Checked)
                {
                    this.svASetting.ShowVarName(false, true, false);
                }
                else if (this.rbIntAIsZero.Checked)
                {
                    this.svASetting.ShowVarName(false, false, true);
                }
                this.svBSetting.Visible = this.lbB.Visible = false;
            }
            else
            {
                this.svBSetting.Visible = this.lbB.Visible = true;
            }

            if (this.rbStrAContainListBItem.Checked)
            {
                this.svASetting.ShowVarName(true, false, false);
                this.svBSetting.ShowVarName(false, true, false);
            }
            else if (this.rbListACountBigerIntB.Checked || this.rbListACountBigerEqualIntB.Checked || this.rbListACountEqualsIntB.Checked)
            {
                this.svASetting.ShowVarName(false, true, false);
                this.svBSetting.ShowVarName(false, false, true);
            }

        }
    }
}