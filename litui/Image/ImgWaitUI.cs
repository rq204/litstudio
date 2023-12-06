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
    internal partial class ImgWaitUI : ImageBase
    {
        public ImgWaitUI()
        {
            InitializeComponent();

            this.SaveActivity = () =>
            {
                if (this.rbApper.Checked) wa.WaitType = WaitType.Apper;
                else if (this.rbDisApper.Checked) wa.WaitType = WaitType.Disapper;

                wa.Name = this.tbActivityName.Text;
                wa.TimeOutMillisecond = (int)this.nudTimeOut.Value;
                wa.ImgConfig = this.GetUIConfig();
            };
        }


        ImgWaitActivity wa = null;
        public override void SetActivity(Activity activity)
        {
            wa = activity as ImgWaitActivity;
            switch (wa.WaitType)
            {
                case WaitType.Apper:
                    this.rbApper.Checked = true;
                    break;
                case WaitType.Disapper:
                    this.rbDisApper.Checked = true;
                    break;
            }
            this.tbActivityName.Text = wa.Name;
            this.nudTimeOut.Value = wa.TimeOutMillisecond;
            this.SetUIConfig(wa.ImgConfig);
        }
    }
}
