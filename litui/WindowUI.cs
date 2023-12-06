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
    internal partial class WindowUI : LitUiBase
    {
        public WindowUI()
        {
            InitializeComponent();

            this.SaveActivity = (() =>
            {
                if (this.rbClose.Checked)
                {
                    wa.WindowType = WindowType.Close;
                }
                else if (this.rbMin.Checked)
                {
                    wa.WindowType = WindowType.Min;
                }
                else if (this.rbMax.Checked)
                {
                    wa.WindowType = WindowType.Max;
                }
                else if (this.rbHide.Checked)
                {
                    wa.WindowType = WindowType.Hide;
                }
                else if (this.rbShow.Checked)
                {
                    wa.WindowType = WindowType.Show;
                }
                else if (this.rbForeground.Checked)
                {
                    wa.WindowType = WindowType.Foreground;
                }

                wa.Name = this.tbActivityName.Text;
                wa.UIConfig = base.GetUIConfig();
            });

            base.IsWindowHighlight = true;
        }

        WindowActivity wa = null;
        public override void SetActivity(Activity activity)
        {
            wa = activity as WindowActivity;
            switch (wa.WindowType)
            {
                case WindowType.Close:
                    this.rbClose.Checked = true;
                    break;
                case WindowType.Min:
                    this.rbMin.Checked = true;
                    break;
                case WindowType.Max:
                    this.rbMax.Checked = true;
                    break;
                case WindowType.Hide:
                    this.rbHide.Checked = true;
                    break;
                case WindowType.Show:
                    this.rbShow.Checked = true;
                    break;
                case WindowType.Foreground:
                    this.rbForeground.Checked = true;
                    break;
            }
            this.tbActivityName.Text = wa.Name;
            base.SetUIConfig(wa.UIConfig);
        }
    }
}
