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
    internal partial class ImgClickUI : ImageBase
    {
        public ImgClickUI()
        {
            InitializeComponent();

            this.SaveActivity = () =>
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
                ca.ImgConfig = base.GetUIConfig();
            };

        }

        ImgClickActivity ca = null;
        public override void SetActivity(Activity activity)
        {
            ca = activity as ImgClickActivity;

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

            this.SetUIConfig(ca.ImgConfig);
        }

        private void rbHover_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
