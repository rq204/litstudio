using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using litcore.activity;
using litcore.type;
using litsdk;

namespace litstudio
{
    internal class ConvertUI : litsdk.ILitUI
    {
        private RadioButton rbStrAddToList;
        private Label label1;
        private Label label2;
        private litsdk.SelectVarName svVarNameA;
        private litsdk.SelectVarName svVarNameB;
        private RadioButton rbCopyListToList;
        private RadioButton rbStrLenghToInt;
        private RadioButton rbListCountToInt;
        private RadioButton rbTableAToJsonB;
        private RadioButton rbListAJoinToB;
        private Label lbJoinStr;
        private TextBox tbJoinStr;
        private RadioButton rbTableACountToB;
        private RadioButton rbStrASplit2ListB;
        private Label label5;
        private Label label4;
        private Label label3;
        private RadioButton rbListARemoveStrB;
        private RadioButton rbTableAAdd2TableB;
        private RadioButton rbJsonStrAToTableB;
        private RadioButton rbStrToInt;

        public ConvertUI()
        {
            this.InitializeComponent();

            foreach (Control c in this.scActivityUI.Panel1.Controls)
            {
                if (c is RadioButton rb) rb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            }

            base.SaveActivity = new Action(() =>
              {
                  if (this.rbStrAddToList.Checked) ca.ConvertType = ConvertType.StrAddToList;
                  else if (this.rbStrToInt.Checked) ca.ConvertType = ConvertType.StrToInt;
                  else if (this.rbCopyListToList.Checked) ca.ConvertType = ConvertType.CopyListToList;
                  else if (this.rbListCountToInt.Checked) ca.ConvertType = ConvertType.ListCountToInt;
                  else if (this.rbStrLenghToInt.Checked) ca.ConvertType = ConvertType.StrLenghToInt;
                  else if (this.rbTableAToJsonB.Checked) ca.ConvertType = ConvertType.TableAToJsonB;
                  else if (this.rbListAJoinToB.Checked) ca.ConvertType = ConvertType.ListJoinToStr;
                  else if (this.rbTableACountToB.Checked) ca.ConvertType = ConvertType.TableACountToIntB;
                  else if (this.rbStrASplit2ListB.Checked) ca.ConvertType = ConvertType.StrSplitToList;
                  else if (this.rbTableAAdd2TableB.Checked) ca.ConvertType = ConvertType.TableAAdd2TableB;
                  else if (this.rbListARemoveStrB.Checked) ca.ConvertType = ConvertType.ListARemoveStrB;
                  else if (this.rbJsonStrAToTableB.Checked) ca.ConvertType = ConvertType.JsonStrAToTableB;
                  
                  ca.VarNameA = this.svVarNameA.VarName;
                  ca.VarNameB = this.svVarNameB.VarName;
                  ca.Name = this.tbActivityName.Text;
                  ca.JoinStr = this.tbJoinStr.Text;
              });
        }

        private ConvertActivity ca = null;
        public override void SetActivity(litsdk.Activity activity)
        {
            ca = activity as ConvertActivity;
            switch (ca.ConvertType)
            {
                case ConvertType.StrAddToList:
                    this.rbStrAddToList.Checked = true;
                    break;
                case ConvertType.StrToInt:
                    this.rbStrToInt.Checked = true;
                    break;
                case ConvertType.CopyListToList:
                    this.rbCopyListToList.Checked = true;
                    break;
                case ConvertType.ListCountToInt:
                    this.rbListCountToInt.Checked = true;
                    break;
                case ConvertType.StrLenghToInt:
                    this.rbStrLenghToInt.Checked = true;
                    break;
                case ConvertType.TableAToJsonB:
                    this.rbTableAToJsonB.Checked = true;
                    break;
                case ConvertType.ListJoinToStr:
                    this.rbListAJoinToB.Checked = true;
                    break;
                case ConvertType.TableACountToIntB:
                    this.rbTableACountToB.Checked = true;
                    break;
                case ConvertType.StrSplitToList:
                    this.rbStrASplit2ListB.Checked = true;
                    break;
                case ConvertType.TableAAdd2TableB:
                    this.rbTableAAdd2TableB.Checked = true;
                    break;
                case ConvertType.ListARemoveStrB:
                    this.rbListARemoveStrB.Checked = true;
                    break;
                case ConvertType.JsonStrAToTableB:
                    this.rbJsonStrAToTableB.Checked = true;
                    break;
            }

            this.svVarNameA.VarName = ca.VarNameA;
            this.svVarNameB.VarName = ca.VarNameB;
            this.tbJoinStr.Text = ca.JoinStr;
            this.tbActivityName.Text = ca.Name;
        }


        private void InitializeComponent()
        {
            this.rbStrToInt = new System.Windows.Forms.RadioButton();
            this.rbStrAddToList = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.svVarNameA = new litsdk.SelectVarName();
            this.svVarNameB = new litsdk.SelectVarName();
            this.rbCopyListToList = new System.Windows.Forms.RadioButton();
            this.rbListCountToInt = new System.Windows.Forms.RadioButton();
            this.rbStrLenghToInt = new System.Windows.Forms.RadioButton();
            this.rbTableAToJsonB = new System.Windows.Forms.RadioButton();
            this.rbListAJoinToB = new System.Windows.Forms.RadioButton();
            this.lbJoinStr = new System.Windows.Forms.Label();
            this.tbJoinStr = new System.Windows.Forms.TextBox();
            this.rbTableACountToB = new System.Windows.Forms.RadioButton();
            this.rbStrASplit2ListB = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbTableAAdd2TableB = new System.Windows.Forms.RadioButton();
            this.rbListARemoveStrB = new System.Windows.Forms.RadioButton();
            this.rbJsonStrAToTableB = new System.Windows.Forms.RadioButton();
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
            this.scActivityUI.Panel1.Controls.Add(this.rbJsonStrAToTableB);
            this.scActivityUI.Panel1.Controls.Add(this.rbListARemoveStrB);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.rbTableAAdd2TableB);
            this.scActivityUI.Panel1.Controls.Add(this.rbStrASplit2ListB);
            this.scActivityUI.Panel1.Controls.Add(this.rbTableACountToB);
            this.scActivityUI.Panel1.Controls.Add(this.tbJoinStr);
            this.scActivityUI.Panel1.Controls.Add(this.lbJoinStr);
            this.scActivityUI.Panel1.Controls.Add(this.rbListAJoinToB);
            this.scActivityUI.Panel1.Controls.Add(this.rbTableAToJsonB);
            this.scActivityUI.Panel1.Controls.Add(this.rbCopyListToList);
            this.scActivityUI.Panel1.Controls.Add(this.rbStrLenghToInt);
            this.scActivityUI.Panel1.Controls.Add(this.rbListCountToInt);
            this.scActivityUI.Panel1.Controls.Add(this.svVarNameB);
            this.scActivityUI.Panel1.Controls.Add(this.svVarNameA);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.rbStrAddToList);
            this.scActivityUI.Panel1.Controls.Add(this.rbStrToInt);
            this.scActivityUI.Size = new System.Drawing.Size(600, 270);
            // 
            // rbStrToInt
            // 
            this.rbStrToInt.AutoSize = true;
            this.rbStrToInt.Location = new System.Drawing.Point(92, 61);
            this.rbStrToInt.Name = "rbStrToInt";
            this.rbStrToInt.Size = new System.Drawing.Size(119, 16);
            this.rbStrToInt.TabIndex = 1;
            this.rbStrToInt.TabStop = true;
            this.rbStrToInt.Text = "字符A转化为数字B";
            this.rbStrToInt.UseVisualStyleBackColor = true;
            // 
            // rbStrAddToList
            // 
            this.rbStrAddToList.AutoSize = true;
            this.rbStrAddToList.Location = new System.Drawing.Point(422, 61);
            this.rbStrAddToList.Name = "rbStrAddToList";
            this.rbStrAddToList.Size = new System.Drawing.Size(119, 16);
            this.rbStrAddToList.TabIndex = 1;
            this.rbStrAddToList.TabStop = true;
            this.rbStrAddToList.Text = "字符A添加到列表B";
            this.rbStrAddToList.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "变量A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "变量B";
            // 
            // svVarNameA
            // 
            this.svVarNameA.Location = new System.Drawing.Point(129, 20);
            this.svVarNameA.Name = "svVarNameA";
            this.svVarNameA.Size = new System.Drawing.Size(155, 23);
            this.svVarNameA.TabIndex = 3;
            this.svVarNameA.VarName = "";
            this.svVarNameA.Load += new System.EventHandler(this.svVarNameA_Load);
            // 
            // svVarNameB
            // 
            this.svVarNameB.Location = new System.Drawing.Point(352, 18);
            this.svVarNameB.Name = "svVarNameB";
            this.svVarNameB.Size = new System.Drawing.Size(155, 23);
            this.svVarNameB.TabIndex = 3;
            this.svVarNameB.VarName = "";
            this.svVarNameB.Load += new System.EventHandler(this.svVarNameB_Load);
            // 
            // rbCopyListToList
            // 
            this.rbCopyListToList.AutoSize = true;
            this.rbCopyListToList.Location = new System.Drawing.Point(253, 90);
            this.rbCopyListToList.Name = "rbCopyListToList";
            this.rbCopyListToList.Size = new System.Drawing.Size(119, 16);
            this.rbCopyListToList.TabIndex = 8;
            this.rbCopyListToList.TabStop = true;
            this.rbCopyListToList.Text = "复制列表A到列表B";
            this.rbCopyListToList.UseVisualStyleBackColor = true;
            // 
            // rbListCountToInt
            // 
            this.rbListCountToInt.AutoSize = true;
            this.rbListCountToInt.Location = new System.Drawing.Point(92, 90);
            this.rbListCountToInt.Name = "rbListCountToInt";
            this.rbListCountToInt.Size = new System.Drawing.Size(131, 16);
            this.rbListCountToInt.TabIndex = 5;
            this.rbListCountToInt.TabStop = true;
            this.rbListCountToInt.Text = "列表A长度转为数字B";
            this.rbListCountToInt.UseVisualStyleBackColor = true;
            // 
            // rbStrLenghToInt
            // 
            this.rbStrLenghToInt.AutoSize = true;
            this.rbStrLenghToInt.Location = new System.Drawing.Point(253, 62);
            this.rbStrLenghToInt.Name = "rbStrLenghToInt";
            this.rbStrLenghToInt.Size = new System.Drawing.Size(131, 16);
            this.rbStrLenghToInt.TabIndex = 5;
            this.rbStrLenghToInt.TabStop = true;
            this.rbStrLenghToInt.Text = "字符A长度转为数字B";
            this.rbStrLenghToInt.UseVisualStyleBackColor = true;
            // 
            // rbTableAToJsonB
            // 
            this.rbTableAToJsonB.AutoSize = true;
            this.rbTableAToJsonB.Location = new System.Drawing.Point(92, 155);
            this.rbTableAToJsonB.Name = "rbTableAToJsonB";
            this.rbTableAToJsonB.Size = new System.Drawing.Size(131, 16);
            this.rbTableAToJsonB.TabIndex = 14;
            this.rbTableAToJsonB.TabStop = true;
            this.rbTableAToJsonB.Text = "表格A转为Json字符B";
            this.rbTableAToJsonB.UseVisualStyleBackColor = true;
            // 
            // rbListAJoinToB
            // 
            this.rbListAJoinToB.AutoSize = true;
            this.rbListAJoinToB.Location = new System.Drawing.Point(253, 122);
            this.rbListAJoinToB.Name = "rbListAJoinToB";
            this.rbListAJoinToB.Size = new System.Drawing.Size(155, 16);
            this.rbListAJoinToB.TabIndex = 15;
            this.rbListAJoinToB.TabStop = true;
            this.rbListAJoinToB.Text = "列表A用字符合并至字符B";
            this.rbListAJoinToB.UseVisualStyleBackColor = true;
            // 
            // lbJoinStr
            // 
            this.lbJoinStr.AutoSize = true;
            this.lbJoinStr.Location = new System.Drawing.Point(422, 124);
            this.lbJoinStr.Name = "lbJoinStr";
            this.lbJoinStr.Size = new System.Drawing.Size(53, 12);
            this.lbJoinStr.TabIndex = 16;
            this.lbJoinStr.Text = "操作字符";
            this.lbJoinStr.Visible = false;
            // 
            // tbJoinStr
            // 
            this.tbJoinStr.Location = new System.Drawing.Point(481, 120);
            this.tbJoinStr.Name = "tbJoinStr";
            this.tbJoinStr.Size = new System.Drawing.Size(60, 21);
            this.tbJoinStr.TabIndex = 17;
            this.tbJoinStr.Visible = false;
            // 
            // rbTableACountToB
            // 
            this.rbTableACountToB.AutoSize = true;
            this.rbTableACountToB.Location = new System.Drawing.Point(251, 155);
            this.rbTableACountToB.Name = "rbTableACountToB";
            this.rbTableACountToB.Size = new System.Drawing.Size(131, 16);
            this.rbTableACountToB.TabIndex = 18;
            this.rbTableACountToB.TabStop = true;
            this.rbTableACountToB.Text = "表格A行数转为数字B";
            this.rbTableACountToB.UseVisualStyleBackColor = true;
            // 
            // rbStrASplit2ListB
            // 
            this.rbStrASplit2ListB.AutoSize = true;
            this.rbStrASplit2ListB.Location = new System.Drawing.Point(92, 123);
            this.rbStrASplit2ListB.Name = "rbStrASplit2ListB";
            this.rbStrASplit2ListB.Size = new System.Drawing.Size(155, 16);
            this.rbStrASplit2ListB.TabIndex = 19;
            this.rbStrASplit2ListB.TabStop = true;
            this.rbStrASplit2ListB.Text = "字符A用正则分割为列表B";
            this.rbStrASplit2ListB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "变量A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "转化对象";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "转化方式";
            // 
            // rbTableAAdd2TableB
            // 
            this.rbTableAAdd2TableB.AutoSize = true;
            this.rbTableAAdd2TableB.Location = new System.Drawing.Point(422, 155);
            this.rbTableAAdd2TableB.Name = "rbTableAAdd2TableB";
            this.rbTableAAdd2TableB.Size = new System.Drawing.Size(143, 16);
            this.rbTableAAdd2TableB.TabIndex = 20;
            this.rbTableAAdd2TableB.TabStop = true;
            this.rbTableAAdd2TableB.Text = "表格A数据添加到表格B";
            this.rbTableAAdd2TableB.UseVisualStyleBackColor = true;
            // 
            // rbListARemoveStrB
            // 
            this.rbListARemoveStrB.AutoSize = true;
            this.rbListARemoveStrB.Location = new System.Drawing.Point(422, 90);
            this.rbListARemoveStrB.Name = "rbListARemoveStrB";
            this.rbListARemoveStrB.Size = new System.Drawing.Size(119, 16);
            this.rbListARemoveStrB.TabIndex = 24;
            this.rbListARemoveStrB.TabStop = true;
            this.rbListARemoveStrB.Text = "列表A移除字符B项";
            this.rbListARemoveStrB.UseVisualStyleBackColor = true;
            // 
            // rbJsonStrAToTableB
            // 
            this.rbJsonStrAToTableB.AutoSize = true;
            this.rbJsonStrAToTableB.Location = new System.Drawing.Point(92, 187);
            this.rbJsonStrAToTableB.Name = "rbJsonStrAToTableB";
            this.rbJsonStrAToTableB.Size = new System.Drawing.Size(131, 16);
            this.rbJsonStrAToTableB.TabIndex = 25;
            this.rbJsonStrAToTableB.TabStop = true;
            this.rbJsonStrAToTableB.Text = "Json字符A转为表格B";
            this.rbJsonStrAToTableB.UseVisualStyleBackColor = true;
            // 
            // ConvertUI
            // 
            this.Name = "ConvertUI";
            this.Size = new System.Drawing.Size(600, 270);
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
            if (rbStrAddToList.Checked)
            {
                this.svVarNameA.ShowVarName(true, false, false);
                this.svVarNameB.ShowVarName(false, true, false);
            }
            else if (rbStrToInt.Checked)
            {
                this.svVarNameA.ShowVarName(true, false, false);
                this.svVarNameB.ShowVarName(false, false, true);
            }
            else if (this.rbStrLenghToInt.Checked)
            {
                this.svVarNameA.ShowVarName(true, false, false);
                this.svVarNameB.ShowVarName(false, false, true);
            }
            else if (rbListCountToInt.Checked)
            {
                this.svVarNameA.ShowVarName(false, true, false);
                this.svVarNameB.ShowVarName(false, false, true);
            }
            else if (rbCopyListToList.Checked)
            {
                this.svVarNameA.ShowVarName(false, true, false);
                this.svVarNameB.ShowVarName(false, true, false);
            }
            else if (this.rbTableAToJsonB.Checked)
            {
                this.svVarNameA.ShowVarName(false, false, false, true);
                this.svVarNameB.ShowVarName(true, false, false);
            }
            else if (this.rbListAJoinToB.Checked)
            {
                this.svVarNameA.ShowVarName(false, true, false, false);
                this.svVarNameB.ShowVarName(true, false, false);
            }
            else if (this.rbTableACountToB.Checked)
            {
                this.svVarNameA.ShowVarName(false, false, false, true);
                this.svVarNameB.ShowVarName(false, false, true);
            }
            else if (this.rbStrASplit2ListB.Checked)
            {
                this.svVarNameA.ShowVarName(true, false, false, false);
                this.svVarNameB.ShowVarName(false, true, false);
            }
            else if (this.rbTableAAdd2TableB.Checked)
            {
                this.svVarNameA.ShowVarName(false, false, false, true);
                this.svVarNameB.ShowVarName(false, false, false, true);
            }
            else if (this.rbListARemoveStrB.Checked)
            {
                this.svVarNameA.ShowVarName(false, true, false, false);
                this.svVarNameB.ShowVarName(true, false, false);
            }
            else if (this.rbJsonStrAToTableB.Checked)
            {
                this.svVarNameA.ShowVarName(true, false, false, false);
                this.svVarNameB.ShowVarName(false, false, false, true);
            }
            this.lbJoinStr.Visible = this.tbJoinStr.Visible = this.rbListAJoinToB.Checked || this.rbStrASplit2ListB.Checked;
        }

        //private void llrn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //   litsdk.InsertVar.InsertSelected(this.tbJoinStr, llrn.Text);
        //}

        private void svVarNameA_Load(object sender, EventArgs e)
        {

        }

        private void svVarNameB_Load(object sender, EventArgs e)
        {

        }
    }
}