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
    internal partial class ScreenShotUI : LitUiBase
    {
        public ScreenShotUI()
        {
            InitializeComponent();
            this.svImgSaveVarName.ShowVarName(true, false, false);
            this.SaveActivity = new Action(() =>
              {
                  sa.ImgSaveVarName = this.svImgSaveVarName.VarName;
                  sa.UIConfig = base.GetUIConfig();
                  sa.Name = this.tbActivityName.Text;

                  if (this.rbPng.Checked) sa.ImageFormat = "png";
                  else if (this.rbJpg.Checked) sa.ImageFormat = "jpg";
                  else if (this.rbBmp.Checked) sa.ImageFormat = "bmp";

                  sa.UseTempPath = this.cbUseTempPath.Checked;
                  sa.SaveToClipboard = this.cbSaveToClipboard.Checked;
                  sa.FullScreen = this.cbFullScreen.Checked;
              });
        }

        ScreenShotActivity sa = null;
        public override void SetActivity(Activity activity)
        {
            sa = activity as ScreenShotActivity;
            this.svImgSaveVarName.VarName = sa.ImgSaveVarName;
            base.SetUIConfig(sa.UIConfig);
            this.tbActivityName.Text = sa.Name;

            switch (sa.ImageFormat)
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
            this.cbUseTempPath.Checked = sa.UseTempPath;
            this.cbSaveToClipboard.Checked = sa.SaveToClipboard;
            this.cbFullScreen.Checked = sa.FullScreen;
        }

        private void cbSaveToClipboard_CheckedChanged(object sender, EventArgs e)
        {
            this.lbSavePath.Visible = this.svImgSaveVarName.Visible = this.cbUseTempPath.Visible = !cbSaveToClipboard.Checked;
        }
    }
}
