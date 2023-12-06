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

namespace litstudio
{
    internal partial class FormUI : litsdk.ILitUI
    {
        public FormUI()
        {
            InitializeComponent();

            this.ivFormName.ShowVarName(true, false, false, this.tbFormName);
            this.svSourceVarName.ShowVarName(true, false, false);
            this.svTableVarName.ShowVarName(false, false, false, true);

            this.SaveActivity = () =>
            {
                if (this.rbAll.Checked) fa.FormType = litcore.type.FormType.All;
                else if (this.rbInput.Checked) fa.FormType = litcore.type.FormType.Input;
                else if (this.rbFirstTable.Checked) fa.FormType = litcore.type.FormType.FirstTable;
                else if (this.rbLastTable.Checked) fa.FormType = litcore.type.FormType.LastTable;

                fa.FormName = this.tbFormName.Text;
                fa.SourceVarName = this.svSourceVarName.VarName;
                fa.TableVarName = this.svTableVarName.VarName;
                fa.Name = this.tbActivityName.Text;
                fa.OnlyNameValue = this.cbOnlyNameValue.Checked;
                fa.ClearTable = this.cbClearTable.Checked;
                fa.RemoveAspNetInput = this.cbRemoveAspNetInput.Checked;
                fa.RemoveSubmit = this.cbRemoveSubmit.Checked;
            };
        }

        litcore.activity.FormActivity fa = null;
        public override void SetActivity(Activity activity)
        {
            fa = activity as litcore.activity.FormActivity;
            switch (fa.FormType)
            {
                case litcore.type.FormType.All:
                    this.rbAll.Checked = true;
                    break;
                case litcore.type.FormType.Input:
                    this.rbInput.Checked = true;
                    break;
                case litcore.type.FormType.FirstTable:
                    this.rbFirstTable.Checked = true;
                    break;
                case litcore.type.FormType.LastTable:
                    this.rbLastTable.Checked = true;
                    break;
            }
            this.tbFormName.Text = fa.FormName;
            this.svSourceVarName.VarName = fa.SourceVarName;
            this.svTableVarName.VarName = fa.TableVarName;
            this.tbActivityName.Text = fa.Name;
            this.cbOnlyNameValue.Checked = fa.OnlyNameValue;
            this.cbClearTable.Checked = fa.ClearTable;
            this.cbRemoveAspNetInput.Checked = fa.RemoveAspNetInput;
            this.cbRemoveSubmit.Checked = fa.RemoveSubmit;
        }
    }
}
