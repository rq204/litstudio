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
    internal partial class MouseUI : litsdk.ILitUI
    {
        public MouseUI()
        {
            InitializeComponent();

            this.ivPosX.ShowVarName(true, false, true, this.tbPosX);
            this.ivPosY.ShowVarName(true, false, true, this.tbPoxY);
            this.ivTextInPut.ShowVarName(true, false, true, this.tbTextInPut);

            this.SaveActivity = new Action(() =>
              {
                  if (this.rbHotKey.Checked) wt.MouseType = litcore.ictype.MouseType.HotKey;
                  else if (this.rbPosClick.Checked) wt.MouseType = litcore.ictype.MouseType.PosClick;
                  else if (this.rbTextInPut.Checked) wt.MouseType = litcore.ictype.MouseType.TextInPut;

                  wt.PosX = this.tbPosX.Text.Trim();
                  wt.PosY = this.tbPoxY.Text.Trim();
                  wt.HotKey = this.cbHotKey.Text;
                  wt.TextInPut = this.tbTextInPut.Text;
                  wt.Name = this.tbActivityName.Text;

              });
        }

        litcore.iecef.Mouse wt = null;


        public override void SetActivity(Activity activity)
        {
            wt = activity as litcore.iecef.Mouse;

            switch (wt.MouseType)
            {
                case litcore.ictype.MouseType.PosClick:
                    this.rbPosClick.Checked = true;
                    break;
                case litcore.ictype.MouseType.HotKey:
                    this.rbHotKey.Checked = true;
                    break;
                case litcore.ictype.MouseType.TextInPut:
                    this.rbTextInPut.Checked = true;
                    break;
            }

            this.tbPosX.Text = wt.PosX;
            this.tbPoxY.Text = wt.PosY;
            this.cbHotKey.Text = wt.HotKey;
            this.tbTextInPut.Text = wt.TextInPut;
            this.tbActivityName.Text = wt.Name;
        }
    }
}
