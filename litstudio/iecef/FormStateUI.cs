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

namespace litstudio.iecef
{
    internal partial class FormStateUI : litsdk.ILitUI
    {
        public FormStateUI()
        {
            InitializeComponent();

            this.SaveActivity = () =>
            {
                fs.Show = this.rbShow.Checked;
                fs.Name = this.tbActivityName.Text;
            };
        }

        litcore.iecef.FormState fs = null;
        public override void SetActivity(Activity activity)
        {
            fs = activity as litcore.iecef.FormState;
            this.rbShow.Checked = fs.Show;
            this.rbHide.Checked = !fs.Show;
            this.tbActivityName.Text = fs.Name;
        }
    }
}
