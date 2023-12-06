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
    public partial class MouseMoveUI : litsdk.ILitUI
    {
        public MouseMoveUI()
        {
            InitializeComponent();

            this.ivXLocation.ShowVarName(true, false, true, this.tbXLocation);
            this.ivYLocation.ShowVarName(true, false, true, this.tbYLocation);

            this.SaveActivity = () =>
            {
                if (this.rbActivityForm.Checked) ma.MouseMoveType = MouseMoveType.ActivityForm;
                if (this.rbCurLocation.Checked) ma.MouseMoveType = MouseMoveType.CurLocation;
                if (this.rbFullScreen.Checked) ma.MouseMoveType = MouseMoveType.FullScreen;

                ma.XLocation = this.tbXLocation.Text;
                ma.YLocation = this.tbYLocation.Text;
                ma.Name = this.tbActivityName.Text;
            };
        }

        MouseMoveActivity ma = null;
        public override void SetActivity(Activity activity)
        {
            ma = activity as MouseMoveActivity;
            switch (ma.MouseMoveType)
            {
                case MouseMoveType.ActivityForm:
                    this.rbActivityForm.Checked = true;
                    break;
                case MouseMoveType.CurLocation:
                    this.rbCurLocation.Checked = true;
                    break;
                case MouseMoveType.FullScreen:
                    this.rbFullScreen.Checked = true;
                    break;
            }
            this.tbXLocation.Text = ma.XLocation;
            this.tbYLocation.Text = ma.YLocation;
            this.tbActivityName.Text = ma.Name;
        }
    }
}
