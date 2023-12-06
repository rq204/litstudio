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
    internal partial class TypeIntoUI : litui.LitUiBase
    {
        public TypeIntoUI()
        {
            InitializeComponent();
            this.ivContent.ShowVarName(true, false, true, this.tbContent);
            this.SaveActivity = new Action(() =>
              {
                  ta.Content = this.tbContent.Text;
                  ta.Name = this.tbActivityName.Text;
                  ta.CurMousePosition = this.cbCurLocation.Checked;
                  ta.UIConfig = base.GetUIConfig();
              });
        }

        TypeIntoActivity ta = null;
        public override void SetActivity(Activity activity)
        {
            ta = activity as TypeIntoActivity;

            this.tbContent.Text = ta.Content;

            this.tbActivityName.Text = ta.Name;
            this.cbCurLocation.Checked = ta.CurMousePosition;
            base.SetUIConfig(ta.UIConfig);
        }
    }
}
