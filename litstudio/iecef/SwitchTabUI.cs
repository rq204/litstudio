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
    internal partial class SwitchTabUI : litsdk.ILitUI
    {
        public SwitchTabUI()
        {
            InitializeComponent();
            this.SaveActivity = new Action(() =>
              {
                  if (this.rbCreate.Checked)
                  {
                      wt.SwitchTabType = litcore.ictype.SwitchTabType.Create;
                  }
                  else if (this.rbSwitch.Checked)
                  {
                      wt.SwitchTabType = litcore.ictype.SwitchTabType.Switch;
                  }
                  else if (this.rbClose.Checked)
                  {
                      wt.SwitchTabType = litcore.ictype.SwitchTabType.Close;
                  }
                  else if (this.rbCloseOther.Checked)
                  {
                      wt.SwitchTabType = litcore.ictype.SwitchTabType.CloseOther;
                  }
                  wt.TabName = this.tbTabName.Text.Trim();
                  wt.LastTab = this.cbLastTab.Checked;
                  wt.UseRegex = this.cbUseRegex.Checked;
                  wt.DefaultTab = this.cbDefault.Checked;
                  wt.Name = this.tbActivityName.Text.Trim();
              });
        }

        litcore.iecef.SwitchTab wt = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="activity"></param>
        public override void SetActivity(Activity activity)
        {
            wt = activity as litcore.iecef.SwitchTab;
            switch (wt.SwitchTabType)
            {
                case litcore.ictype.SwitchTabType.Create:
                    this.rbCreate.Checked = true;
                    break;
                case litcore.ictype.SwitchTabType.Switch:
                    this.rbSwitch.Checked = true;
                    break;
                case litcore.ictype.SwitchTabType.Close:
                    this.rbClose.Checked = true;
                    break;
                case litcore.ictype.SwitchTabType.CloseOther:
                    this.rbCloseOther.Checked = true;
                    break;
            }
            this.tbTabName.Text = wt.TabName;
            this.cbLastTab.Checked = wt.LastTab;
            this.cbDefault.Checked = wt.DefaultTab;
            this.cbUseRegex.Checked = wt.UseRegex;
            this.tbActivityName.Text = wt.Name;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            this.cbUseRegex.Visible = this.cbLastTab.Visible = !this.rbCreate.Checked;
            this.cbDefault.Visible = !this.rbCreate.Checked && !this.rbClose.Checked;
            if (this.rbClose.Checked) this.cbDefault.Checked = false;
        }

        private void cbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbDefault.Checked && this.rbClose.Checked)
            {
                this.cbDefault.CheckedChanged -= cbDefault_CheckedChanged;
                this.cbDefault.Checked = false;
                this.cbDefault.CheckedChanged += cbDefault_CheckedChanged;
            }
            if (this.cbDefault.Checked) this.cbLastTab.Checked = this.cbUseRegex.Checked = false;
        }

        private void cbLastTab_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbLastTab.Checked) this.cbDefault.Checked = this.cbUseRegex.Checked = false;
        }
    }
}
