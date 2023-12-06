using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using litcore.activity;
using litsdk;

namespace litstudio
{
    internal partial class RandomUI : litsdk.ILitUI
    {
        public RandomUI()
        {
            InitializeComponent();
            this.svVarName.ShowVarName(true, true, true);
            base.SaveActivity = new Action(() =>
            {
                ra.LetterLower = this.cbLetterLower.Checked;
                ra.LetterUpper = this.cbLetterUpper.Checked;
                ra.Number = this.cbNumber.Checked;
                ra.Other = this.cbOther.Checked;
                ra.Length = (int)this.nudLength.Value;
                ra.ListCount = (int)this.numListCount.Value;
                ra.SaveVarName = this.svVarName.VarName;
                ra.Name = this.tbActivityName.Text;
            });
        }

        RandomActivity ra = null;
        public override void SetActivity(Activity activity)
        {
            ra = activity as RandomActivity;
            this.cbLetterLower.Checked = ra.LetterLower;
            this.cbLetterUpper.Checked = ra.LetterUpper;
            this.cbNumber.Checked = ra.Number;
            this.cbOther.Checked = ra.Other;
            this.nudLength.Value = ra.Length;
            this.numListCount.Value = ra.ListCount;
            this.svVarName.VarName = ra.SaveVarName;
            this.tbActivityName.Text = ra.Name;
        }

    }
}
