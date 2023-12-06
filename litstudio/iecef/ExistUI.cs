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
    internal partial class ExistUI : litsdk.ILitUI
    {
        public ExistUI()
        {
            InitializeComponent();
            this.svXPos.ShowVarName(false, false, true);
            this.svYPos.ShowVarName(false, false, true);
            this.ivXPath.ShowVarName(true, false, true, this.tbXPathStr);

            this.SaveActivity = new Action(() =>
              {
                  xp.XPathStr = this.tbXPathStr.Text.Trim();
                  xp.Name = this.tbActivityName.Text;
                  xp.FrameName = this.tbFrameName.Text.Trim();
                  xp.XPosVarName = this.svXPos.VarName;
                  xp.YPosVarName = this.svYPos.VarName;
              });
            litsdk.API.SetXPath = new Action<string,List<string>>(this.SetXPath);
        }

        private void SetXPath(string frameName,List<string> ls)
        {
            if (this.IsDisposed || this.Disposing) return;
            this.Invoke((EventHandler)delegate
            {
                this.tbXPathStr.Text = string.Join("\r\n", ls.ToArray());
                this.tbFrameName.Text = frameName;
            });
        }

        litcore.iecef.Exist xp = null;


        public override void SetActivity(Activity activity)
        {
            xp = activity as litcore.iecef.Exist;
            this.tbXPathStr.Text = xp.XPathStr;
            this.tbActivityName.Text = xp.Name;
            this.tbFrameName.Text = xp.FrameName;
            this.svXPos.VarName = xp.XPosVarName;
            this.svYPos.VarName = xp.YPosVarName;
        }
    }
}
