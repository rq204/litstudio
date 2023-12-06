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

namespace litui
{
    internal partial class SendHotkeyUI : LitUiBase
    {
        public SendHotkeyUI()
        {
            InitializeComponent();

            this.SaveActivity = new Action(() =>
              {
                  sa.Alt = this.cbAlt.Checked;
                  sa.Ctrl = this.cbCtrl.Checked;
                  sa.Shift = this.cbShift.Checked;
                  sa.Win = this.cbWin.Checked;
                  sa.Key = this.cbKey.Text;
                  sa.UIConfig = base.GetUIConfig();
                  sa.Name = this.tbActivityName.Text;
                  sa.CurMousePosition = this.cbCurLocation.Checked;
              });
        }

        SendHotkeyActivity sa = null;

        public override void SetActivity(Activity activity)
        {
            sa = activity as SendHotkeyActivity;
            this.cbAlt.Checked = sa.Alt;
            this.cbCtrl.Checked = sa.Ctrl;
            this.cbShift.Checked = sa.Shift;
            this.cbWin.Checked = sa.Win;
            this.cbKey.Text = sa.Key;
            base.SetUIConfig(sa.UIConfig);
            this.tbActivityName.Text = sa.Name;
            this.cbCurLocation.Checked = sa.CurMousePosition;
        }
    }
}
