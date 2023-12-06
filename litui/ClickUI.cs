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
    internal partial class ClickUI : LitUiBase
    {
        public ClickUI()
        {
            InitializeComponent();

            this.SaveActivity = new Action(() =>
              {
                  if (this.rbClick.Checked)
                  {
                      ca.ClickType = ClickType.Click;
                  }
                  else if (this.rbDoubleClick.Checked)
                  {
                      ca.ClickType = ClickType.DoubleClick;
                  }
                  else if (this.rbDown.Checked)
                  {
                      ca.ClickType = ClickType.Down;
                  }
                  else if (this.rbUp.Checked)
                  {
                      ca.ClickType = ClickType.Up;
                  }
                  else if (this.rbHover.Checked)
                  {
                      ca.ClickType = ClickType.Hover;
                  }

                  if (this.rbLeft.Checked)
                  {
                      ca.MouseButton = FlaUI.Core.Input.MouseButton.Left;
                  }
                  else if (this.rbRight.Checked)
                  {
                      ca.MouseButton = FlaUI.Core.Input.MouseButton.Right;
                  }
                  else if (this.rbMiddle.Checked)
                  {
                      ca.MouseButton = FlaUI.Core.Input.MouseButton.Middle;
                  }

                  ca.Name = this.tbActivityName.Text;
                  ca.CurMousePosition = this.cbCurLocation.Checked;
                  ca.InterFaceClick = this.cbInterFaceClick.Checked;
                  ca.UIConfig = base.GetUIConfig();

              });
        }

        ClickActivity ca = null;
        public override void SetActivity(Activity activity)
        {
            ca = activity as ClickActivity;
            switch (ca.ClickType)
            {
                case ClickType.Click:
                    this.rbClick.Checked = true;
                    break;
                case ClickType.DoubleClick:
                    this.rbDoubleClick.Checked = true;
                    break;
                case ClickType.Down:
                    this.rbDown.Checked = true;
                    break;
                case ClickType.Up:
                    this.rbUp.Checked = true;
                    break;
                case ClickType.Hover:
                    this.rbHover.Checked = true;
                    break;
            }
            switch (ca.MouseButton)
            {
                case FlaUI.Core.Input.MouseButton.Left:
                    this.rbLeft.Checked = true;
                    break;
                case FlaUI.Core.Input.MouseButton.Right:
                    this.rbRight.Checked = true;
                    break;
                case FlaUI.Core.Input.MouseButton.Middle:
                    this.rbMiddle.Checked = true;
                    break;
            }
            this.tbActivityName.Text = ca.Name;
            this.cbCurLocation.Checked = ca.CurMousePosition;
            this.cbInterFaceClick.Checked = ca.InterFaceClick;
            base.SetUIConfig(ca.UIConfig);
        }

        private void rbHover_CheckedChanged(object sender, EventArgs e)
        {
            this.lbPos.Visible = this.pPos.Visible = !this.rbHover.Checked;
            if (this.rbHover.Checked) this.cbInterFaceClick.Checked = false;
        }

        private void rbDown_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDown.Checked) this.cbInterFaceClick.Visible = this.cbInterFaceClick.Checked = false;
        }

        private void rbUp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUp.Checked) this.cbInterFaceClick.Visible = this.cbInterFaceClick.Checked = false;
        }

        private void rbMiddle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMiddle.Checked) this.cbInterFaceClick.Visible = this.cbInterFaceClick.Checked = false;
        }

        private void cbCurLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbCurLocation.Checked) this.cbInterFaceClick.Checked = false;
        }

        private void rbClick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbClick.Checked) this.cbInterFaceClick.Visible = true;
        }

        private void rbDoubleClick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDoubleClick.Checked) this.cbInterFaceClick.Visible = true;
        }
    }
}
