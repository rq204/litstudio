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
    internal class LoopUI :  ILitUI
    {
        public LoopUI()
        {
            this.InitializeComponent();
            this.svIntVar.ShowVarName(false, false, true);
            this.svListVar.ShowVarName(false, true, false);
       
            foreach (Control c in this.scActivityUI.Panel1.Controls)
            {
                if (c is RadioButton rb)
                {
                    rb.CheckedChanged += Rb_CheckedChanged;
                }
            }

            this.svTableVar.ShowVarName(false, false, false, true);

            base.SaveActivity = new Action(() =>
              {
                  if (this.rbForever.Checked) la.LoopType = LoopType.Forever;
                  else if (this.rbNumber.Checked) la.LoopType = LoopType.Number;
                  else if (this.rbList.Checked) la.LoopType = LoopType.List;
                  else if (this.rbIntVar.Checked) la.LoopType = LoopType.IntVar;
                  else if (this.rbTable.Checked) la.LoopType = LoopType.Table;
                  la.Number = (int)this.nudNumber.Value;
                  la.ListVarName = this.svListVar.VarName;
                  la.SaveVarName = this.svSaveToVar.VarName;
                  la.IntVarName = this.svIntVar.VarName;
                  la.TableVarName = this.svTableVar.VarName;
                  la.Name = this.tbActivityName.Text.Trim();

              });


            this.lbPoint = this.lbSaveToVar.Location;
            this.svPoint = this.svSaveToVar.Location;
        }

        System.Drawing.Point lbPoint = new System.Drawing.Point();
        System.Drawing.Point svPoint = new System.Drawing.Point();
        private void Rb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbTable.Checked)
            {
                this.lbSaveToVar.Visible = this.svSaveToVar.Visible = false;
            }
            else
            {
                this.lbSaveToVar.Visible = this.svSaveToVar.Visible = true;
                if (rbList.Checked)
                {
                    this.lbSaveToVar.Text = "保存字符到变量";
                    this.lbSaveToVar.Location = this.lbPoint;
                    this.svSaveToVar.Location = this.svPoint;
                    this.svSaveToVar.ShowVarName(true, false, false);
                }
                else
                {
                    this.lbSaveToVar.Text = "保存次数到变量";
                    this.svSaveToVar.ShowVarName(false, false, true);
                    int offset = 0;
                    if (this.rbNumber.Checked)
                    {
                        this.lbSaveToVar.Location = new System.Drawing.Point(this.lbPoint.X, this.rbNumber.Location.Y + offset + 4);
                        this.svSaveToVar.Location = new System.Drawing.Point(this.svPoint.X, this.rbNumber.Location.Y + offset);
                    }
                    else if (this.rbForever.Checked)
                    {
                        this.lbSaveToVar.Location = new System.Drawing.Point(this.lbPoint.X, this.rbForever.Location.Y + offset + 4);
                        this.svSaveToVar.Location = new System.Drawing.Point(this.svPoint.X, this.rbForever.Location.Y + offset);
                    }
                    else
                    {
                        this.lbSaveToVar.Location = new System.Drawing.Point(this.lbPoint.X, this.rbIntVar.Location.Y + offset + 4);
                        this.svSaveToVar.Location = new System.Drawing.Point(this.svPoint.X, this.rbIntVar.Location.Y + offset);
                    }
                }
            }
        }

        private Label lbSaveToVar;
        private RadioButton rbForever;
        private RadioButton rbNumber;
        private NumericUpDown nudNumber;
        private SelectVarName svSaveToVar;
        private SelectVarName svListVar;
        private SelectVarName svIntVar;
        private RadioButton rbIntVar;
        private RadioButton rbList;
        private SelectVarName svTableVar;
        private RadioButton rbTable;
        private Label label2;
        LoopStartActivity la = null;
        public override void SetActivity(Activity activity)
        {
            la = activity as LoopStartActivity;
            switch (la.LoopType)
            {
                case LoopType.Forever:
                    this.rbForever.Checked = true;
                    break;
                case LoopType.List:
                    this.rbList.Checked = true;
                    break;
                case LoopType.Number:
                    this.rbNumber.Checked = true;
                    break;
                case LoopType.IntVar:
                    this.rbIntVar.Checked = true;
                    break;
                case LoopType.Table:
                    this.rbTable.Checked = true;
                    break;
            }
            this.nudNumber.Value = la.Number;
            this.svListVar.VarName = la.ListVarName;
            this.svSaveToVar.VarName = la.SaveVarName;
            this.svIntVar.VarName = la.IntVarName;
            this.svTableVar.VarName = la.TableVarName;
            this.tbActivityName.Text = la.Name;
        }

        private void InitializeComponent()
        {
            this.lbSaveToVar = new System.Windows.Forms.Label();
            this.rbForever = new System.Windows.Forms.RadioButton();
            this.rbNumber = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.svListVar = new litsdk.SelectVarName();
            this.svSaveToVar = new litsdk.SelectVarName();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.rbIntVar = new System.Windows.Forms.RadioButton();
            this.svIntVar = new litsdk.SelectVarName();
            this.rbTable = new System.Windows.Forms.RadioButton();
            this.svTableVar = new litsdk.SelectVarName();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.svTableVar);
            this.scActivityUI.Panel1.Controls.Add(this.nudNumber);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveToVar);
            this.scActivityUI.Panel1.Controls.Add(this.svIntVar);
            this.scActivityUI.Panel1.Controls.Add(this.svListVar);
            this.scActivityUI.Panel1.Controls.Add(this.rbTable);
            this.scActivityUI.Panel1.Controls.Add(this.rbList);
            this.scActivityUI.Panel1.Controls.Add(this.rbNumber);
            this.scActivityUI.Panel1.Controls.Add(this.rbIntVar);
            this.scActivityUI.Panel1.Controls.Add(this.rbForever);
            this.scActivityUI.Panel1.Controls.Add(this.lbSaveToVar);
            // 
            // lbSaveToVar
            // 
            this.lbSaveToVar.AutoSize = true;
            this.lbSaveToVar.Location = new System.Drawing.Point(309, 142);
            this.lbSaveToVar.Name = "lbSaveToVar";
            this.lbSaveToVar.Size = new System.Drawing.Size(89, 12);
            this.lbSaveToVar.TabIndex = 3;
            this.lbSaveToVar.Text = "保存字符到变量";
            // 
            // rbForever
            // 
            this.rbForever.AutoSize = true;
            this.rbForever.Location = new System.Drawing.Point(33, 22);
            this.rbForever.Name = "rbForever";
            this.rbForever.Size = new System.Drawing.Size(71, 16);
            this.rbForever.TabIndex = 4;
            this.rbForever.TabStop = true;
            this.rbForever.Text = "无限循环";
            this.rbForever.UseVisualStyleBackColor = true;
            // 
            // rbNumber
            // 
            this.rbNumber.AutoSize = true;
            this.rbNumber.Location = new System.Drawing.Point(33, 61);
            this.rbNumber.Name = "rbNumber";
            this.rbNumber.Size = new System.Drawing.Size(95, 16);
            this.rbNumber.TabIndex = 4;
            this.rbNumber.TabStop = true;
            this.rbNumber.Text = "循环指定次数";
            this.rbNumber.UseVisualStyleBackColor = true;
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(33, 141);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(95, 16);
            this.rbList.TabIndex = 4;
            this.rbList.TabStop = true;
            this.rbList.Text = "循环指定列表";
            this.rbList.UseVisualStyleBackColor = true;
            // 
            // svListVar
            // 
            this.svListVar.Location = new System.Drawing.Point(158, 138);
            this.svListVar.Name = "svListVar";
            this.svListVar.Size = new System.Drawing.Size(145, 23);
            this.svListVar.TabIndex = 5;
            this.svListVar.VarName = "";
            // 
            // svSaveToVar
            // 
            this.svSaveToVar.Location = new System.Drawing.Point(403, 137);
            this.svSaveToVar.Name = "svSaveToVar";
            this.svSaveToVar.Size = new System.Drawing.Size(145, 23);
            this.svSaveToVar.TabIndex = 5;
            this.svSaveToVar.VarName = "";
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(158, 61);
            this.nudNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(118, 21);
            this.nudNumber.TabIndex = 6;
            this.nudNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rbIntVar
            // 
            this.rbIntVar.AutoSize = true;
            this.rbIntVar.Location = new System.Drawing.Point(33, 101);
            this.rbIntVar.Name = "rbIntVar";
            this.rbIntVar.Size = new System.Drawing.Size(119, 16);
            this.rbIntVar.TabIndex = 4;
            this.rbIntVar.TabStop = true;
            this.rbIntVar.Text = "按数字变量值循环";
            this.rbIntVar.UseVisualStyleBackColor = true;
            // 
            // svIntVar
            // 
            this.svIntVar.Location = new System.Drawing.Point(158, 99);
            this.svIntVar.Name = "svIntVar";
            this.svIntVar.Size = new System.Drawing.Size(144, 23);
            this.svIntVar.TabIndex = 5;
            this.svIntVar.VarName = "";
            // 
            // rbTable
            // 
            this.rbTable.AutoSize = true;
            this.rbTable.Location = new System.Drawing.Point(33, 181);
            this.rbTable.Name = "rbTable";
            this.rbTable.Size = new System.Drawing.Size(95, 16);
            this.rbTable.TabIndex = 4;
            this.rbTable.TabStop = true;
            this.rbTable.Text = "循环指定表格";
            this.rbTable.UseVisualStyleBackColor = true;
            // 
            // svTableVar
            // 
            this.svTableVar.Location = new System.Drawing.Point(158, 177);
            this.svTableVar.Name = "svTableVar";
            this.svTableVar.Size = new System.Drawing.Size(145, 23);
            this.svTableVar.TabIndex = 7;
            this.svTableVar.VarName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(313, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "将表格中值写入对应表头的变量当中";
            // 
            // LoopUI
            // 
            this.Name = "LoopUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);

        }
    }
}