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
    internal partial class ScrollUI : LitUiBase
    {
        public ScrollUI()
        {
            InitializeComponent();
            this.svScrollVarName.ShowVarName(false, false, true);
            this.SaveActivity = (() =>
            {
                sa.ScrollLines = (int)this.nudScrollLine.Value;
                sa.ScrollVarName = this.svScrollVarName.VarName;
                sa.UIConfig = base.GetUIConfig();
                sa.Name = this.tbActivityName.Text;
                sa.Reverse = this.cbReverse.Checked;
                sa.CurMousePosition = this.cbCurLocation.Checked;
            });
        }

        ScrollActivity sa = null;
        public override void SetActivity(Activity activity)
        {
            sa = activity as ScrollActivity;
            this.nudScrollLine.Value = sa.ScrollLines;
            this.svScrollVarName.VarName = sa.ScrollVarName;
            this.tbActivityName.Text = sa.Name;
            this.cbReverse.Checked = sa.Reverse;
            this.cbCurLocation.Checked = sa.CurMousePosition;
            base.SetUIConfig(sa.UIConfig);
        }
    }
}
