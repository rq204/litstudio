using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using litsdk;

namespace litstudio
{
    internal partial class TimeUI : litsdk.ILitUI
    {
        public TimeUI()
        {
            InitializeComponent();

            this.svTimeVarName.ShowVarName(true, false, true);
            this.svSaveVarName.ShowVarName(true, false, false);

            this.cbDayOfWeek.SelectedIndex = 0;

            this.SaveActivity = new Action(() =>
            {
                //ta.IsTimeNow = this.rbTimeNow.Checked;
                if (this.rbTimeNow.Checked) ta.TimeType = litcore.ictype.TimeType.TimeNow;
                else if (this.rbSpecailTime.Checked) ta.TimeType = litcore.ictype.TimeType.SpecialTime;
                else if (this.rbLastDayOfWeek.Checked) ta.TimeType = litcore.ictype.TimeType.LastDayOfWeek;

                ta.DayOfWeek = this.cbDayOfWeek.SelectedIndex;

                ta.TimeVarName = this.svTimeVarName.VarName;
                ta.TimeIsTimeStamp = this.cbTimeIsTimeStamp.Checked;

                ta.Month = (int)this.nudMonth.Value;
                ta.Day = (int)this.nudDay.Value;
                ta.Hour = (int)this.nudHour.Value;
                ta.Minite = (int)this.nudminite.Value;
                ta.Sencond = (int)this.nudSecond.Value;
                ta.UseMinus = this.cbUseMinus.Checked;

                ta.TimeFormat = this.tbTimeFormat.Text;
                if (this.rbTimeFormat.Checked)
                {
                    ta.TimeSaveType = litcore.type.TimeSaveType.TimeFormat;
                }
                else if (this.rbTimeStamp10.Checked)
                {
                    ta.TimeSaveType = litcore.type.TimeSaveType.TimeStamp10;
                }
                else if (this.rbTimeStamp13.Checked)
                {
                    ta.TimeSaveType = litcore.type.TimeSaveType.TimeStamp13;
                }

                ta.SaveVarName = this.svSaveVarName.VarName;
                ta.Name = this.tbActivityName.Text.Trim();
            });
        }


        public litcore.activity.TimeActivity ta = null;
        public override void SetActivity(Activity activity)
        {
            ta = activity as litcore.activity.TimeActivity;

            if (ta.TimeType == litcore.ictype.TimeType.None)
            {
                if (ta.IsTimeNow) ta.TimeType = litcore.ictype.TimeType.TimeNow;
                else ta.TimeType = litcore.ictype.TimeType.SpecialTime;
            }

            this.cbDayOfWeek.SelectedIndex = ta.DayOfWeek;

            switch (ta.TimeType)
            {
                case litcore.ictype.TimeType.TimeNow:
                    this.rbTimeNow.Checked = true;
                    break;
                case litcore.ictype.TimeType.SpecialTime:
                    this.rbSpecailTime.Checked = true;
                    break;
                case litcore.ictype.TimeType.LastDayOfWeek:
                    this.rbLastDayOfWeek.Checked = true;
                    break;
            }

            //this.rbTimeNow.Checked = ta.IsTimeNow;
            //this.rbSpecailTime.Checked = !ta.IsTimeNow;
            this.svTimeVarName.VarName = ta.TimeVarName;
            this.cbTimeIsTimeStamp.Checked = ta.TimeIsTimeStamp;

            this.nudMonth.Value = ta.Month;
            this.nudDay.Value = ta.Day;
            this.nudHour.Value = ta.Hour;
            this.nudminite.Value = ta.Minite;
            this.nudSecond.Value = ta.Sencond;
            this.cbUseMinus.Checked = ta.UseMinus;

            this.tbTimeFormat.Text = ta.TimeFormat;
            switch (ta.TimeSaveType)
            {
                case litcore.type.TimeSaveType.TimeFormat:
                    this.rbTimeFormat.Checked = true;
                    break;
                case litcore.type.TimeSaveType.TimeStamp10:
                    this.rbTimeStamp10.Checked = true;
                    break;
                case litcore.type.TimeSaveType.TimeStamp13:
                    this.rbTimeStamp13.Checked = true;
                    break;
            }

            this.svSaveVarName.VarName = ta.SaveVarName;
            this.tbActivityName.Text = ta.Name;

        }

        private void llbFormat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cnblogs.com/polk6/p/5465088.html");
        }
    }
}
