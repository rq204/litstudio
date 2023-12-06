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
using litcore.activity;

namespace litstudio
{
    internal partial class CSVUI : litsdk.ILitUI
    {
        public CSVUI()
        {
            InitializeComponent();
            this.svTableVarName.ShowVarName(false, false, false, true);
            this.svFileVarName.ShowVarName(true, false, false);
            this.SaveActivity = new Action(() =>
              {
                  this.ca.Read = this.rbRead.Checked;
                  this.ca.TableVarName = this.svTableVarName.VarName;
                  this.ca.FileVarName = this.svFileVarName.VarName;
                  this.ca.OverWrite = this.rbOverWritte.Checked;
                  this.ca.Name = this.tbActivityName.Text.Trim();
              });
        }

        CSVActivity ca = null;
        public override void SetActivity(Activity activity)
        {
            ca = activity as CSVActivity;
            this.rbRead.Checked = ca.Read;
            this.rbWrite.Checked = !ca.Read;

            this.rbOverWritte.Checked = ca.OverWrite;
            this.rbAppend.Checked = !ca.OverWrite;

            this.svTableVarName.VarName = ca.TableVarName;
            this.svFileVarName.VarName = ca.FileVarName;

            this.tbActivityName.Text = ca.Name;
        }

    }
}
