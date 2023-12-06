namespace litstudio
{
    partial class TimeUI
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
            this.rbTimeNow = new System.Windows.Forms.RadioButton();
            this.rbSpecailTime = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.svTimeVarName = new litsdk.SelectVarName();
            this.cbTimeIsTimeStamp = new System.Windows.Forms.CheckBox();
            this.svSaveVarName = new litsdk.SelectVarName();
            this.rbTimeStamp10 = new System.Windows.Forms.RadioButton();
            this.rbTimeStamp13 = new System.Windows.Forms.RadioButton();
            this.rbTimeFormat = new System.Windows.Forms.RadioButton();
            this.tbTimeFormat = new System.Windows.Forms.TextBox();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.cbUseMinus = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudminite = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.rbLastDayOfWeek = new System.Windows.Forms.RadioButton();
            this.cbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.llbFormat = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudminite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.llbFormat);
            this.scActivityUI.Panel1.Controls.Add(this.label12);
            this.scActivityUI.Panel1.Controls.Add(this.cbDayOfWeek);
            this.scActivityUI.Panel1.Controls.Add(this.rbLastDayOfWeek);
            this.scActivityUI.Panel1.Controls.Add(this.label11);
            this.scActivityUI.Panel1.Controls.Add(this.nudMonth);
            this.scActivityUI.Panel1.Controls.Add(this.label10);
            this.scActivityUI.Panel1.Controls.Add(this.panel1);
            this.scActivityUI.Panel1.Controls.Add(this.label9);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.nudSecond);
            this.scActivityUI.Panel1.Controls.Add(this.nudminite);
            this.scActivityUI.Panel1.Controls.Add(this.nudHour);
            this.scActivityUI.Panel1.Controls.Add(this.nudDay);
            this.scActivityUI.Panel1.Controls.Add(this.cbUseMinus);
            this.scActivityUI.Panel1.Controls.Add(this.cbTimeIsTimeStamp);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.svTimeVarName);
            this.scActivityUI.Panel1.Controls.Add(this.rbSpecailTime);
            this.scActivityUI.Panel1.Controls.Add(this.rbTimeNow);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "时间来源";
            // 
            // rbTimeNow
            // 
            this.rbTimeNow.AutoSize = true;
            this.rbTimeNow.Location = new System.Drawing.Point(100, 18);
            this.rbTimeNow.Name = "rbTimeNow";
            this.rbTimeNow.Size = new System.Drawing.Size(71, 16);
            this.rbTimeNow.TabIndex = 1;
            this.rbTimeNow.TabStop = true;
            this.rbTimeNow.Text = "当前时间";
            this.rbTimeNow.UseVisualStyleBackColor = true;
            // 
            // rbSpecailTime
            // 
            this.rbSpecailTime.AutoSize = true;
            this.rbSpecailTime.Location = new System.Drawing.Point(100, 49);
            this.rbSpecailTime.Name = "rbSpecailTime";
            this.rbSpecailTime.Size = new System.Drawing.Size(71, 16);
            this.rbSpecailTime.TabIndex = 1;
            this.rbSpecailTime.TabStop = true;
            this.rbSpecailTime.Text = "指定变量";
            this.rbSpecailTime.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "增加时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "保存格式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "保存为";
            // 
            // svTimeVarName
            // 
            this.svTimeVarName.Location = new System.Drawing.Point(177, 46);
            this.svTimeVarName.Name = "svTimeVarName";
            this.svTimeVarName.Size = new System.Drawing.Size(174, 23);
            this.svTimeVarName.TabIndex = 2;
            this.svTimeVarName.VarName = "";
            // 
            // cbTimeIsTimeStamp
            // 
            this.cbTimeIsTimeStamp.AutoSize = true;
            this.cbTimeIsTimeStamp.Location = new System.Drawing.Point(364, 48);
            this.cbTimeIsTimeStamp.Name = "cbTimeIsTimeStamp";
            this.cbTimeIsTimeStamp.Size = new System.Drawing.Size(120, 16);
            this.cbTimeIsTimeStamp.TabIndex = 3;
            this.cbTimeIsTimeStamp.Text = "指定时间为时间戳";
            this.cbTimeIsTimeStamp.UseVisualStyleBackColor = true;
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(100, 198);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(174, 23);
            this.svSaveVarName.TabIndex = 2;
            this.svSaveVarName.VarName = "";
            // 
            // rbTimeStamp10
            // 
            this.rbTimeStamp10.AutoSize = true;
            this.rbTimeStamp10.Location = new System.Drawing.Point(3, 7);
            this.rbTimeStamp10.Name = "rbTimeStamp10";
            this.rbTimeStamp10.Size = new System.Drawing.Size(83, 16);
            this.rbTimeStamp10.TabIndex = 1;
            this.rbTimeStamp10.TabStop = true;
            this.rbTimeStamp10.Text = "10位时间戳";
            this.rbTimeStamp10.UseVisualStyleBackColor = true;
            // 
            // rbTimeStamp13
            // 
            this.rbTimeStamp13.AutoSize = true;
            this.rbTimeStamp13.Location = new System.Drawing.Point(92, 7);
            this.rbTimeStamp13.Name = "rbTimeStamp13";
            this.rbTimeStamp13.Size = new System.Drawing.Size(83, 16);
            this.rbTimeStamp13.TabIndex = 1;
            this.rbTimeStamp13.TabStop = true;
            this.rbTimeStamp13.Text = "13位时间戳";
            this.rbTimeStamp13.UseVisualStyleBackColor = true;
            // 
            // rbTimeFormat
            // 
            this.rbTimeFormat.AutoSize = true;
            this.rbTimeFormat.Location = new System.Drawing.Point(181, 7);
            this.rbTimeFormat.Name = "rbTimeFormat";
            this.rbTimeFormat.Size = new System.Drawing.Size(71, 16);
            this.rbTimeFormat.TabIndex = 1;
            this.rbTimeFormat.TabStop = true;
            this.rbTimeFormat.Text = "指定格式";
            this.rbTimeFormat.UseVisualStyleBackColor = true;
            // 
            // tbTimeFormat
            // 
            this.tbTimeFormat.Location = new System.Drawing.Point(262, 5);
            this.tbTimeFormat.Name = "tbTimeFormat";
            this.tbTimeFormat.Size = new System.Drawing.Size(142, 21);
            this.tbTimeFormat.TabIndex = 5;
            this.tbTimeFormat.Text = "yyyy-MM-dd HH:mm:ss";
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(173, 117);
            this.nudDay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(50, 21);
            this.nudDay.TabIndex = 6;
            // 
            // cbUseMinus
            // 
            this.cbUseMinus.AutoSize = true;
            this.cbUseMinus.Location = new System.Drawing.Point(476, 121);
            this.cbUseMinus.Name = "cbUseMinus";
            this.cbUseMinus.Size = new System.Drawing.Size(72, 16);
            this.cbUseMinus.TabIndex = 3;
            this.cbUseMinus.Text = "使用减法";
            this.cbUseMinus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "天";
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(249, 117);
            this.nudHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(50, 21);
            this.nudHour.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "时";
            // 
            // nudminite
            // 
            this.nudminite.Location = new System.Drawing.Point(323, 117);
            this.nudminite.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudminite.Name = "nudminite";
            this.nudminite.Size = new System.Drawing.Size(50, 21);
            this.nudminite.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "分";
            // 
            // nudSecond
            // 
            this.nudSecond.Location = new System.Drawing.Point(399, 118);
            this.nudSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(50, 21);
            this.nudSecond.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "秒";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTimeFormat);
            this.panel1.Controls.Add(this.rbTimeStamp10);
            this.panel1.Controls.Add(this.rbTimeStamp13);
            this.panel1.Controls.Add(this.rbTimeFormat);
            this.panel1.Location = new System.Drawing.Point(99, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 31);
            this.panel1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(286, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "时间转化错误会报异常，请使用异常处理";
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(99, 117);
            this.nudMonth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(50, 21);
            this.nudMonth.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "月";
            // 
            // rbLastDayOfWeek
            // 
            this.rbLastDayOfWeek.AutoSize = true;
            this.rbLastDayOfWeek.Location = new System.Drawing.Point(100, 80);
            this.rbLastDayOfWeek.Name = "rbLastDayOfWeek";
            this.rbLastDayOfWeek.Size = new System.Drawing.Size(71, 16);
            this.rbLastDayOfWeek.TabIndex = 12;
            this.rbLastDayOfWeek.TabStop = true;
            this.rbLastDayOfWeek.Text = "最近周几";
            this.rbLastDayOfWeek.UseVisualStyleBackColor = true;
            // 
            // cbDayOfWeek
            // 
            this.cbDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDayOfWeek.FormattingEnabled = true;
            this.cbDayOfWeek.Items.AddRange(new object[] {
            "星期天",
            "星期一",
            "星期二",
            "星期三",
            "星期四",
            "星期五",
            "星期六"});
            this.cbDayOfWeek.Location = new System.Drawing.Point(177, 80);
            this.cbDayOfWeek.Name = "cbDayOfWeek";
            this.cbDayOfWeek.Size = new System.Drawing.Size(154, 20);
            this.cbDayOfWeek.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(362, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "今日或最近已逝去的周几";
            // 
            // llbFormat
            // 
            this.llbFormat.AutoSize = true;
            this.llbFormat.Location = new System.Drawing.Point(518, 162);
            this.llbFormat.Name = "llbFormat";
            this.llbFormat.Size = new System.Drawing.Size(53, 12);
            this.llbFormat.TabIndex = 15;
            this.llbFormat.TabStop = true;
            this.llbFormat.Text = "格式说明";
            this.llbFormat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbFormat_LinkClicked);
            // 
            // TimeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TimeUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudminite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSpecailTime;
        private System.Windows.Forms.RadioButton rbTimeNow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTimeFormat;
        private System.Windows.Forms.CheckBox cbTimeIsTimeStamp;
        private litsdk.SelectVarName svSaveVarName;
        private litsdk.SelectVarName svTimeVarName;
        private System.Windows.Forms.RadioButton rbTimeFormat;
        private System.Windows.Forms.RadioButton rbTimeStamp13;
        private System.Windows.Forms.RadioButton rbTimeStamp10;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.CheckBox cbUseMinus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.NumericUpDown nudminite;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.ComboBox cbDayOfWeek;
        private System.Windows.Forms.RadioButton rbLastDayOfWeek;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel llbFormat;
    }
}
