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
    internal partial class ScrollUI : litsdk.ILitUI
    {
        public ScrollUI()
        {
            InitializeComponent();

            foreach (Control c in this.scActivityUI.Panel1.Controls)
            {
                if (c is RadioButton rb) rb.CheckedChanged += rb_CheckedChanged;
            }

            this.SaveActivity = new Action(() =>
              {
                  if (this.rbTop.Checked)
                  {
                      sc.ScrollType = litcore.ictype.ScrollType.Top;
                  }
                  else if (this.rbBotton.Checked)
                  {
                      sc.ScrollType = litcore.ictype.ScrollType.Botton;
                  }
                  else if (this.rbDownBy.Checked)
                  {
                      sc.ScrollType = litcore.ictype.ScrollType.DownBy;
                  }
                  else if (this.rbUpBy.Checked)
                  {
                      sc.ScrollType = litcore.ictype.ScrollType.UpBy;
                  }
                  else if (this.rbXpath.Checked)
                  {
                      sc.ScrollType = litcore.ictype.ScrollType.Xpath;
                  }
                  sc.Name = this.tbActivityName.Text;
                  sc.ScrollBy = this.tbScrollBy.Text.Trim();
                  sc.XpathStr = this.tbXpathStr.Text;
              });
            litsdk.API.SetXPath = new Action<string, List<string>>(this.SetXPath);
        }

        private void SetXPath(string frameName, List<string> ls)
        {
            if (this.IsDisposed || this.Disposing) return;
            this.Invoke((EventHandler)delegate
            {
                this.tbXpathStr.Text = string.Join("\r\n", ls.ToArray());
            });
        }


        private litcore.iecef.Scroll sc = null;
        public override void SetActivity(Activity activity)
        {
            sc = activity as litcore.iecef.Scroll;
            switch (sc.ScrollType)
            {
                case litcore.ictype.ScrollType.Botton:
                    this.rbBotton.Checked = true;
                    break;
                case litcore.ictype.ScrollType.Top:
                    this.rbTop.Checked = true;
                    break;
                case litcore.ictype.ScrollType.DownBy:
                    this.rbDownBy.Checked = true;
                    break;
                case litcore.ictype.ScrollType.UpBy:
                    this.rbUpBy.Checked = true;
                    break;
                case litcore.ictype.ScrollType.Xpath:
                    this.rbXpath.Checked = true;
                    break;
            }
            this.tbActivityName.Text = sc.Name;
            this.tbXpathStr.Text = sc.XpathStr;
            this.tbScrollBy.Text = sc.ScrollBy;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            this.tbScrollBy.Visible = this.ivScrollBy.Visible = this.rbDownBy.Checked || this.rbUpBy.Checked;
        }

        private void rbXpath_CheckedChanged(object sender, EventArgs e)
        {
            this.tbXpathStr.Visible = this.rbXpath.Checked;
        }
    }
}
