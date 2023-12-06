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
    internal partial class ScreenShotUI : litsdk.ILitUI
    {
        public ScreenShotUI()
        {
            InitializeComponent();
            this.rbFull.Visible = litcore.iecef.ScreenShot.FullSupport;
            this.svSavePathVarName.ShowVarName(true, false, false);
            this.ivXPath.ShowVarName(true, false, true, this.tbXPathStr);

            this.SaveActivity = new Action(() =>
              {
                  if (this.rbXPath.Checked)
                  {
                      ss.ScreenShotType = litcore.ictype.ScreenShotType.XPath;
                  }
                  else if (this.rbFull.Checked)
                  {
                      ss.ScreenShotType = litcore.ictype.ScreenShotType.Full;
                  }

                  ss.XPathStr = this.tbXPathStr.Text.Trim();
                  if (this.rbPng.Checked) ss.ImageFormat = "png";
                  else if (this.rbJpg.Checked) ss.ImageFormat = "jpg";
                  else if (this.rbBmp.Checked) ss.ImageFormat = "bmp";

                  ss.SaveFilePathVarName = this.svSavePathVarName.VarName;
                  ss.UseTempPath = this.cbUseTempPath.Checked;
                  ss.Name = this.tbActivityName.Text.Trim();
                  ss.FrameName = this.tbFrameName.Text.Trim();
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

        litcore.iecef.ScreenShot ss = null;
        public override void SetActivity(Activity activity)
        {
            ss = activity as litcore.iecef.ScreenShot;
            switch (ss.ScreenShotType)
            {
                case litcore.ictype.ScreenShotType.XPath:
                    this.rbXPath.Checked = true;
                    break;
                case litcore.ictype.ScreenShotType.Full:
                    this.rbFull.Checked = true;
                    break;
            }
            this.tbXPathStr.Text = ss.XPathStr;
            switch (ss.ImageFormat)
            {
                case "png":
                    this.rbPng.Checked = true;
                    break;
                case "jpg":
                    this.rbJpg.Checked = true;
                    break;
                case "bmp":
                    this.rbBmp.Checked = true;
                    break;
            }
            this.svSavePathVarName.VarName = ss.SaveFilePathVarName;
            this.cbUseTempPath.Checked = ss.UseTempPath;
            this.tbActivityName.Text = ss.Name;
            this.tbFrameName.Text = ss.FrameName;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            this.tbXPathStr.Enabled = this.rbXPath.Checked;
        }

        //private void tmXPath_Tick(object sender, EventArgs e)
        //{
        //    if (litsdk.API.SelectXPath == null) return;
        //    litsdk.API.SelectXPath(new Action<List<string>>((ls) =>
        //    {
        //        this.tbXpath.Text = string.Join("\r\n", ls.ToArray());
        //    }));
        //}
    }
}