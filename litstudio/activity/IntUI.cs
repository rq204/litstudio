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
    internal class IntUI : ILitUI
    {
        public IntUI()
        {
            this.InitializeComponent();
            this.svIntVarName.ShowVarName(false, false, true);
            this.svSaveVarName.ShowVarName(false, false, true);
            this.svSetVarName.ShowVarName(false, false, true);
            base.SaveActivity = new Action(() =>
            {
                if (this.rbAdd.Checked) ia.IntType = IntType.Add;
                else if (this.rbMultiplied.Checked) ia.IntType = IntType.Multiplied;
                else if (this.rbMinus.Checked) ia.IntType = IntType.Minus;
                else if (this.rbRound.Checked) ia.IntType = IntType.Round;
                else if (this.rbRoundUp.Checked) ia.IntType = IntType.RoundUp;
                else if (this.rbRoundDown.Checked) ia.IntType = IntType.RoundDown;
                ia.SetValue = (int)this.nudSetValue.Value;
                ia.IntVarName = this.svIntVarName.VarName;
                ia.SaveVarMame = this.svSaveVarName.VarName;
                ia.SetVarName = this.svSetVarName.VarName;
                ia.Name = base.tbActivityName.Text;
            });
        }

        private SelectVarName svSaveVarName;
        private Label label4;
        private SelectVarName svSetVarName;
        private Label label5;
        IntActivity ia = null;
        public override void SetActivity(Activity activity)
        {
            ia = activity as IntActivity;
            switch (ia.IntType)
            {
                case IntType.Add:
                    this.rbAdd.Checked = true;
                    break;
                case IntType.Multiplied:
                    this.rbMultiplied.Checked = true;
                    break;
                case IntType.Minus:
                    this.rbMinus.Checked = true;
                    break;
                case IntType.Round:
                    this.rbRound.Checked = true;
                    break;
                case IntType.RoundDown:
                    this.rbRoundDown.Checked = true;
                    break;
                case IntType.RoundUp:
                    this.rbRoundUp.Checked = true;
                    break;
            }
            this.nudSetValue.Value = ia.SetValue;
            this.svIntVarName.VarName = ia.IntVarName;
            this.tbActivityName.Text = ia.Name;
            this.svSaveVarName.VarName = ia.SaveVarMame;
            this.svSetVarName.VarName = ia.SetVarName;
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton rbAdd;
        private RadioButton rbMultiplied;
        private SelectVarName svIntVarName;
        private RadioButton rbRoundDown;
        private RadioButton rbRoundUp;
        private RadioButton rbRound;
        private RadioButton rbMinus;
        private NumericUpDown nudSetValue;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbMultiplied = new System.Windows.Forms.RadioButton();
            this.nudSetValue = new System.Windows.Forms.NumericUpDown();
            this.svIntVarName = new litsdk.SelectVarName();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.rbRound = new System.Windows.Forms.RadioButton();
            this.rbRoundUp = new System.Windows.Forms.RadioButton();
            this.rbRoundDown = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.svSetVarName = new litsdk.SelectVarName();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetValue)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.svSetVarName);
            this.scActivityUI.Panel1.Controls.Add(this.rbMinus);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.svIntVarName);
            this.scActivityUI.Panel1.Controls.Add(this.nudSetValue);
            this.scActivityUI.Panel1.Controls.Add(this.rbMultiplied);
            this.scActivityUI.Panel1.Controls.Add(this.rbAdd);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label1);
            this.scActivityUI.Panel1.Controls.Add(this.rbRoundDown);
            this.scActivityUI.Panel1.Controls.Add(this.rbRoundUp);
            this.scActivityUI.Panel1.Controls.Add(this.rbRound);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原数值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "操作类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "操作数值";
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(121, 27);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(47, 16);
            this.rbAdd.TabIndex = 2;
            this.rbAdd.Text = "增加";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbMultiplied
            // 
            this.rbMultiplied.AutoSize = true;
            this.rbMultiplied.Location = new System.Drawing.Point(332, 29);
            this.rbMultiplied.Name = "rbMultiplied";
            this.rbMultiplied.Size = new System.Drawing.Size(47, 16);
            this.rbMultiplied.TabIndex = 2;
            this.rbMultiplied.Text = "乘以";
            this.rbMultiplied.UseVisualStyleBackColor = true;
            // 
            // nudSetValue
            // 
            this.nudSetValue.Location = new System.Drawing.Point(118, 140);
            this.nudSetValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudSetValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSetValue.Name = "nudSetValue";
            this.nudSetValue.Size = new System.Drawing.Size(129, 21);
            this.nudSetValue.TabIndex = 3;
            this.nudSetValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // svIntVarName
            // 
            this.svIntVarName.Location = new System.Drawing.Point(118, 103);
            this.svIntVarName.Name = "svIntVarName";
            this.svIntVarName.Size = new System.Drawing.Size(163, 23);
            this.svIntVarName.TabIndex = 4;
            this.svIntVarName.VarName = "";
            // 
            // rbMinus
            // 
            this.rbMinus.AutoSize = true;
            this.rbMinus.Location = new System.Drawing.Point(234, 27);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(47, 16);
            this.rbMinus.TabIndex = 5;
            this.rbMinus.TabStop = true;
            this.rbMinus.Text = "减少";
            this.rbMinus.UseVisualStyleBackColor = true;
            // 
            // rbRound
            // 
            this.rbRound.AutoSize = true;
            this.rbRound.Location = new System.Drawing.Point(121, 60);
            this.rbRound.Name = "rbRound";
            this.rbRound.Size = new System.Drawing.Size(95, 16);
            this.rbRound.TabIndex = 5;
            this.rbRound.TabStop = true;
            this.rbRound.Text = "除后四舍五入";
            this.rbRound.UseVisualStyleBackColor = true;
            // 
            // rbRoundUp
            // 
            this.rbRoundUp.AutoSize = true;
            this.rbRoundUp.Location = new System.Drawing.Point(234, 60);
            this.rbRoundUp.Name = "rbRoundUp";
            this.rbRoundUp.Size = new System.Drawing.Size(83, 16);
            this.rbRoundUp.TabIndex = 5;
            this.rbRoundUp.TabStop = true;
            this.rbRoundUp.Text = "除后上取整";
            this.rbRoundUp.UseVisualStyleBackColor = true;
            // 
            // rbRoundDown
            // 
            this.rbRoundDown.AutoSize = true;
            this.rbRoundDown.Location = new System.Drawing.Point(332, 60);
            this.rbRoundDown.Name = "rbRoundDown";
            this.rbRoundDown.Size = new System.Drawing.Size(83, 16);
            this.rbRoundDown.TabIndex = 5;
            this.rbRoundDown.TabStop = true;
            this.rbRoundDown.Text = "除后下取整";
            this.rbRoundDown.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "保存至变量";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(118, 177);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(163, 23);
            this.svSaveVarName.TabIndex = 4;
            this.svSaveVarName.VarName = "";
            // 
            // svSetVarName
            // 
            this.svSetVarName.Location = new System.Drawing.Point(325, 140);
            this.svSetVarName.Name = "svSetVarName";
            this.svSetVarName.Size = new System.Drawing.Size(146, 23);
            this.svSetVarName.TabIndex = 6;
            this.svSetVarName.VarName = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "使用变量";
            // 
            // IntUI
            // 
            this.Name = "IntUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSetValue)).EndInit();
            this.ResumeLayout(false);

        }

    }
}