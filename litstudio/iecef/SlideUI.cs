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
    internal partial class SlideUI : litsdk.ILitUI
    {
        private litcore.iecef.Slide sd = null;
        public SlideUI()
        {
            InitializeComponent();
            this.ivStartX.ShowVarName(true, false, true, this.tbStartX);
            this.ivStartY.ShowVarName(true, false, true, this.tbStartY);
            this.ivEndX.ShowVarName(true, false, true, this.tbEndX);
            this.ivEndY.ShowVarName(true, false, true, this.tbEndY);

            this.SaveActivity = () =>
            {
                sd.StartX = this.tbStartX.Text;
                sd.StartY = this.tbStartY.Text;
                sd.EndX = this.tbEndX.Text;
                sd.EndY = this.tbEndY.Text;
                sd.Name = this.tbActivityName.Text;
                sd.Relative = this.cbRelative.Checked;
                sd.FrameName = this.tbFrameName.Text;

                sd.StartXPath = this.tbStartXpath.Text;
                sd.EndXPath = this.tbEndXpath.Text;
                sd.UseStartXPath = this.cbStartUseXPath.Checked;
                sd.UseEndXpath = this.cbEndUseXPath.Checked;
            };

            litsdk.API.SetXPath = new Action<string, List<string>>(this.SetXPath);
        }

        private void SetXPath(string frameName, List<string> ls)
        {
            if (this.IsDisposed || this.Disposing) return;
            this.Invoke((EventHandler)delegate
            {
                if (this.xpathTextBox == null) this.xpathTextBox = this.tbStartXpath;
                this.xpathTextBox.Text = ls.Count == 0 ? "" : ls[0];
                this.tbFrameName.Text = frameName;
            });
        }

        public override void SetActivity(Activity activity)
        {
            sd = activity as litcore.iecef.Slide;
            this.tbStartX.Text = sd.StartX;
            this.tbStartY.Text = sd.StartY;
            this.tbEndX.Text = sd.EndX;
            this.tbEndY.Text = sd.EndY;
            this.tbActivityName.Text = sd.Name;
            this.cbRelative.Checked = sd.Relative;
            this.tbFrameName.Text = sd.FrameName;

            this.tbStartXpath.Text = sd.StartXPath;
            this.tbEndXpath.Text = sd.EndXPath;
            this.cbStartUseXPath.Checked = sd.UseStartXPath;
            this.cbEndUseXPath.Checked = sd.UseEndXpath;
        }

        private TextBox xpathTextBox = null;
        private void tbStartXpath_MouseClick(object sender, MouseEventArgs e)
        {
            this.xpathTextBox = this.tbStartXpath;
        }

        private void tbEndXpath_MouseClick(object sender, MouseEventArgs e)
        {
            this.xpathTextBox = this.tbEndXpath;
        }

        private void cbStartUseXPath_CheckedChanged(object sender, EventArgs e)
        {
            this.lbStart.Enabled = this.tbStartXpath.Enabled = cbStartUseXPath.Checked;
        }

        private void cbEndUseXPath_CheckedChanged(object sender, EventArgs e)
        {
            this.lbEnd.Enabled = this.tbEndXpath.Enabled = cbEndUseXPath.Checked;
        }
    }
}
