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

namespace litapps
{
    public partial class WinBeepUI : litsdk.ILitUI
    {
        public WinBeepUI()
        {
            InitializeComponent();
            this.SaveActivity = new Action(() =>
            {
                if (this.rbBeep.Checked) wb.WinBeepType = WinBeepType.Beep;
                else if (this.rbAsterisk.Checked) wb.WinBeepType = WinBeepType.Asterisk;
                wb.Name = this.tbActivityName.Text;
                wb.PlayTimes = (int)this.nudPlayTimes.Value;
            });
        }

        WinBeepActivity wb = null;
        public override void SetActivity(Activity activity)
        {
            wb = activity as WinBeepActivity;
            switch (wb.WinBeepType)
            {
                case WinBeepType.Beep:
                    this.rbBeep.Checked = true;
                    break;
                case WinBeepType.Asterisk:
                    this.rbAsterisk.Checked = true;
                    break;
            }
            this.tbActivityName.Text = wb.Name;
            this.nudPlayTimes.Value = wb.PlayTimes;
        }
    }
}
