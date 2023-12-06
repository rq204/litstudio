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
    internal partial class ImgExistUI : ImageBase
    {
        public ImgExistUI()
        {
            InitializeComponent();
            this.svSaveX.ShowVarName(false, false, true);
            this.svSaveY.ShowVarName(false, false, true);

            this.SaveActivity = () =>
            {
                ea.SaveX = this.svSaveX.VarName;
                ea.SaveY = this.svSaveY.VarName;
                ea.Name = this.tbActivityName.Text;
                ea.ImgConfig = this.GetUIConfig();
                ea.Reverse = this.cbReverse.Checked;
            };
        }


        ImgExistActivity ea = null;
        public override void SetActivity(Activity activity)
        {
            ea = activity as ImgExistActivity;
            this.svSaveX.VarName = ea.SaveX;
            this.svSaveY.VarName = ea.SaveY;
            this.tbActivityName.Text = ea.Name;
            this.cbReverse.Checked = ea.Reverse;
            this.SetUIConfig(ea.ImgConfig);
        }
    }
}
