using litcore.activity;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace litstudio
{
    internal class TrimListUI : ILitUI
    {
        private CheckBox cbTrimEmpty;
        private CheckBox cbTrimRepeat;
        private Label label2;
        private Label label5;
        private RadioButton rbRandom;
        private RadioButton rbLast;
        private CheckBox cbDeleteWhenGet;
        private GroupBox groupBox1;
        private Label label3;
        private RadioButton rbFirst;
        private CheckBox cbDescList;
        private CheckBox cbAscList;
        private SelectVarName svListVarName;
        private SelectVarName svSaveVarName;
        private Label label6;
        private CheckBox cbListEmptyReturnEmpty;
        private CheckBox cbReverse;
        private NumericUpDown nudPosNum;
        private RadioButton rbFixed;
        private CheckBox cbClearAll;
        private CheckBox cbRandom;
        private Label label4;

        public TrimListUI()
        {
            this.InitializeComponent();
            this.svListVarName.ShowVarName(false, true, false);
            this.svSaveVarName.ShowVarName(true, false, false);
            base.SaveActivity = new Action(() =>
            {
                tla.TrimEmpty = this.cbTrimEmpty.Checked;
                tla.TrimRepeat = this.cbTrimRepeat.Checked;
                tla.AscList = this.cbAscList.Checked;
                tla.DescList = this.cbDescList.Checked;
                tla.RandomList = this.cbRandom.Checked;
                tla.ClearAll = this.cbClearAll.Checked;

                tla.SaveVarName = this.svSaveVarName.VarName;
                tla.ListVarName = this.svListVarName.VarName;
                tla.DeleteWhenGet = this.cbDeleteWhenGet.Checked;

                tla.GetFirst = this.rbFirst.Checked;
                tla.GetLast = this.rbLast.Checked;
                tla.GetRandom = this.rbRandom.Checked;
                tla.GetFixed = this.rbFixed.Checked;
                tla.Reverse = this.cbReverse.Checked;
                tla.PosNum = (int)this.nudPosNum.Value;
                tla.Name = this.tbActivityName.Text.Trim();

                tla.ListEmptyReturnEmpty = this.cbListEmptyReturnEmpty.Checked;
            });
        }

        TrimListActivity tla = null;
        public override void SetActivity(Activity activity)
        {
            tla = activity as TrimListActivity;
            if (!tla.GetFirst && !tla.GetLast && !tla.GetRandom && !tla.GetFixed) tla.GetFirst = true;

            this.cbTrimEmpty.Checked = tla.TrimEmpty;
            this.cbTrimRepeat.Checked = tla.TrimRepeat;
            this.cbAscList.Checked = tla.AscList;
            this.cbDescList.Checked = tla.DescList;
            this.cbRandom.Checked = tla.RandomList;
            this.cbReverse.Checked = tla.Reverse;

            this.svSaveVarName.VarName = tla.SaveVarName;
            this.svListVarName.VarName = tla.ListVarName;
            this.cbDeleteWhenGet.Checked = tla.DeleteWhenGet;
            this.cbClearAll.Checked = tla.ClearAll;

            this.rbFirst.Checked = tla.GetFirst;
            this.rbLast.Checked = tla.GetLast;
            this.rbRandom.Checked = tla.GetRandom;
            this.rbFixed.Checked = tla.GetFixed;
            this.nudPosNum.Value = tla.PosNum;

            this.cbListEmptyReturnEmpty.Checked = tla.ListEmptyReturnEmpty;
            this.tbActivityName.Text = tla.Name;
        }

        private void InitializeComponent()
        {
            this.cbTrimEmpty = new System.Windows.Forms.CheckBox();
            this.cbTrimRepeat = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDeleteWhenGet = new System.Windows.Forms.CheckBox();
            this.rbLast = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbFirst = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudPosNum = new System.Windows.Forms.NumericUpDown();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbFixed = new System.Windows.Forms.RadioButton();
            this.cbListEmptyReturnEmpty = new System.Windows.Forms.CheckBox();
            this.cbAscList = new System.Windows.Forms.CheckBox();
            this.cbDescList = new System.Windows.Forms.CheckBox();
            this.svListVarName = new litsdk.SelectVarName();
            this.cbReverse = new System.Windows.Forms.CheckBox();
            this.cbClearAll = new System.Windows.Forms.CheckBox();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosNum)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.cbRandom);
            this.scActivityUI.Panel1.Controls.Add(this.cbClearAll);
            this.scActivityUI.Panel1.Controls.Add(this.cbReverse);
            this.scActivityUI.Panel1.Controls.Add(this.svListVarName);
            this.scActivityUI.Panel1.Controls.Add(this.groupBox1);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.cbDescList);
            this.scActivityUI.Panel1.Controls.Add(this.cbAscList);
            this.scActivityUI.Panel1.Controls.Add(this.cbTrimRepeat);
            this.scActivityUI.Panel1.Controls.Add(this.cbTrimEmpty);
            // 
            // cbTrimEmpty
            // 
            this.cbTrimEmpty.AutoSize = true;
            this.cbTrimEmpty.Location = new System.Drawing.Point(87, 54);
            this.cbTrimEmpty.Name = "cbTrimEmpty";
            this.cbTrimEmpty.Size = new System.Drawing.Size(84, 16);
            this.cbTrimEmpty.TabIndex = 0;
            this.cbTrimEmpty.Text = "移除空数据";
            this.cbTrimEmpty.UseVisualStyleBackColor = true;
            // 
            // cbTrimRepeat
            // 
            this.cbTrimRepeat.AutoSize = true;
            this.cbTrimRepeat.Location = new System.Drawing.Point(177, 54);
            this.cbTrimRepeat.Name = "cbTrimRepeat";
            this.cbTrimRepeat.Size = new System.Drawing.Size(72, 16);
            this.cbTrimRepeat.TabIndex = 0;
            this.cbTrimRepeat.Text = "移除重复";
            this.cbTrimRepeat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "操作对象";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "筛选排序";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "保存至变量";
            // 
            // cbDeleteWhenGet
            // 
            this.cbDeleteWhenGet.AutoSize = true;
            this.cbDeleteWhenGet.Location = new System.Drawing.Point(281, 30);
            this.cbDeleteWhenGet.Name = "cbDeleteWhenGet";
            this.cbDeleteWhenGet.Size = new System.Drawing.Size(168, 16);
            this.cbDeleteWhenGet.TabIndex = 0;
            this.cbDeleteWhenGet.Text = "取值后从原记录删除该记录";
            this.cbDeleteWhenGet.UseVisualStyleBackColor = true;
            // 
            // rbLast
            // 
            this.rbLast.AutoSize = true;
            this.rbLast.Location = new System.Drawing.Point(169, 67);
            this.rbLast.Name = "rbLast";
            this.rbLast.Size = new System.Drawing.Size(71, 16);
            this.rbLast.TabIndex = 3;
            this.rbLast.TabStop = true;
            this.rbLast.Text = "最后一个";
            this.rbLast.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(245, 66);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(71, 16);
            this.rbRandom.TabIndex = 3;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "随机一个";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // rbFirst
            // 
            this.rbFirst.AutoSize = true;
            this.rbFirst.Location = new System.Drawing.Point(107, 67);
            this.rbFirst.Name = "rbFirst";
            this.rbFirst.Size = new System.Drawing.Size(59, 16);
            this.rbFirst.TabIndex = 3;
            this.rbFirst.TabStop = true;
            this.rbFirst.Text = "第一个";
            this.rbFirst.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudPosNum);
            this.groupBox1.Controls.Add(this.svSaveVarName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbFixed);
            this.groupBox1.Controls.Add(this.rbRandom);
            this.groupBox1.Controls.Add(this.cbListEmptyReturnEmpty);
            this.groupBox1.Controls.Add(this.cbDeleteWhenGet);
            this.groupBox1.Controls.Add(this.rbLast);
            this.groupBox1.Controls.Add(this.rbFirst);
            this.groupBox1.Location = new System.Drawing.Point(21, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "取值操作";
            // 
            // nudPosNum
            // 
            this.nudPosNum.Location = new System.Drawing.Point(401, 65);
            this.nudPosNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPosNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPosNum.Name = "nudPosNum";
            this.nudPosNum.Size = new System.Drawing.Size(56, 21);
            this.nudPosNum.TabIndex = 5;
            this.nudPosNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPosNum.Visible = false;
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(107, 28);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(168, 23);
            this.svSaveVarName.TabIndex = 4;
            this.svSaveVarName.VarName = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "取值方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "取值方式";
            // 
            // rbFixed
            // 
            this.rbFixed.AutoSize = true;
            this.rbFixed.Location = new System.Drawing.Point(324, 67);
            this.rbFixed.Name = "rbFixed";
            this.rbFixed.Size = new System.Drawing.Size(71, 16);
            this.rbFixed.TabIndex = 3;
            this.rbFixed.TabStop = true;
            this.rbFixed.Text = "指定位置";
            this.rbFixed.UseVisualStyleBackColor = true;
            this.rbFixed.CheckedChanged += new System.EventHandler(this.rbFixed_CheckedChanged);
            // 
            // cbListEmptyReturnEmpty
            // 
            this.cbListEmptyReturnEmpty.AutoSize = true;
            this.cbListEmptyReturnEmpty.Location = new System.Drawing.Point(107, 100);
            this.cbListEmptyReturnEmpty.Name = "cbListEmptyReturnEmpty";
            this.cbListEmptyReturnEmpty.Size = new System.Drawing.Size(348, 16);
            this.cbListEmptyReturnEmpty.TabIndex = 0;
            this.cbListEmptyReturnEmpty.Text = "列表元素数为空或指定位置不存在返回空值，否则该节点报错";
            this.cbListEmptyReturnEmpty.UseVisualStyleBackColor = true;
            // 
            // cbAscList
            // 
            this.cbAscList.AutoSize = true;
            this.cbAscList.Location = new System.Drawing.Point(265, 54);
            this.cbAscList.Name = "cbAscList";
            this.cbAscList.Size = new System.Drawing.Size(72, 16);
            this.cbAscList.TabIndex = 0;
            this.cbAscList.Text = "升序排序";
            this.cbAscList.UseVisualStyleBackColor = true;
            this.cbAscList.CheckedChanged += new System.EventHandler(this.cbAscList_CheckedChanged);
            // 
            // cbDescList
            // 
            this.cbDescList.AutoSize = true;
            this.cbDescList.Location = new System.Drawing.Point(343, 54);
            this.cbDescList.Name = "cbDescList";
            this.cbDescList.Size = new System.Drawing.Size(72, 16);
            this.cbDescList.TabIndex = 0;
            this.cbDescList.Text = "降序排序";
            this.cbDescList.UseVisualStyleBackColor = true;
            this.cbDescList.CheckedChanged += new System.EventHandler(this.cbDescList_CheckedChanged);
            // 
            // svListVarName
            // 
            this.svListVarName.Location = new System.Drawing.Point(87, 13);
            this.svListVarName.Name = "svListVarName";
            this.svListVarName.Size = new System.Drawing.Size(210, 23);
            this.svListVarName.TabIndex = 5;
            this.svListVarName.VarName = "";
            // 
            // cbReverse
            // 
            this.cbReverse.AutoSize = true;
            this.cbReverse.Location = new System.Drawing.Point(422, 54);
            this.cbReverse.Name = "cbReverse";
            this.cbReverse.Size = new System.Drawing.Size(72, 16);
            this.cbReverse.TabIndex = 6;
            this.cbReverse.Text = "顺序反转";
            this.cbReverse.UseVisualStyleBackColor = true;
            this.cbReverse.CheckedChanged += new System.EventHandler(this.cbReverse_CheckedChanged);
            // 
            // cbClearAll
            // 
            this.cbClearAll.AutoSize = true;
            this.cbClearAll.Location = new System.Drawing.Point(310, 18);
            this.cbClearAll.Name = "cbClearAll";
            this.cbClearAll.Size = new System.Drawing.Size(96, 16);
            this.cbClearAll.TabIndex = 7;
            this.cbClearAll.Text = "清空所有数据";
            this.cbClearAll.UseVisualStyleBackColor = true;
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(500, 54);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(72, 16);
            this.cbRandom.TabIndex = 8;
            this.cbRandom.Text = "乱序排序";
            this.cbRandom.UseVisualStyleBackColor = true;
            this.cbRandom.CheckedChanged += new System.EventHandler(this.cbRandom_CheckedChanged);
            // 
            // TrimListUI
            // 
            this.Name = "TrimListUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosNum)).EndInit();
            this.ResumeLayout(false);

        }

        private void cbAscList_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbAscList.Checked == true)
            {
                this.cbDescList.Checked = this.cbReverse.Checked = this.cbRandom.Checked = false;
            }
        }

        private void cbDescList_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbDescList.Checked == true)
            {
                this.cbAscList.Checked = this.cbReverse.Checked = this.cbRandom.Checked = false;
            }
        }

        private void cbReverse_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbReverse.Checked == true)
            {
                this.cbDescList.Checked = this.cbAscList.Checked = this.cbRandom.Checked = false;
            }
        }

        private void rbFixed_CheckedChanged(object sender, EventArgs e)
        {
            this.nudPosNum.Visible = this.rbFixed.Checked;
        }

        private void cbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbRandom.Checked == true)
            {
                this.cbDescList.Checked = this.cbAscList.Checked = this.cbReverse.Checked = false;
            }
        }
    }
}
