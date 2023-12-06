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

namespace litexcel
{
    internal partial class SheetUI : litsdk.ILitUI
    {
        public SheetUI()
        {
            InitializeComponent();
            this.ivSheetName.ShowVarName(true, false, true, this.tbSheetName);

            ExcelLoadW.SetComboBox(this.cbExcelName);

            this.SaveActivity = () =>
            {
                sa.ExcelName = this.cbExcelName.Text;
                if (this.rbAddNew.Checked) sa.SheetType = SheetType.AddNew;
                else if (this.rbCopy.Checked) sa.SheetType = SheetType.Copy;
                else if (this.rbDelete.Checked) sa.SheetType = SheetType.Delete;
                else if (this.rbDeleteCur.Checked) sa.SheetType = SheetType.DeleteCur;
                else if (this.rbSwitch.Checked) sa.SheetType = SheetType.Switch;

                sa.SheetName = this.tbSheetName.Text;
                sa.SwitchAfterChange = this.cbSwitchAfterChange.Checked;
                sa.Name = this.tbActivityName.Text;
            };
        }

        public override string ActivityType => "litexcel.SheetActivity";
        SheetActivity sa = null;
        public override void SetActivity(Activity activity)
        {
            sa = activity as SheetActivity;
            this.cbExcelName.Text = sa.ExcelName;
            switch (sa.SheetType)
            {
                case SheetType.AddNew:
                    this.rbAddNew.Checked = true;
                    break;
                case SheetType.Copy:
                    this.rbCopy.Checked = true;
                    break;
                case SheetType.Delete:
                    this.rbDelete.Checked = true;
                    break;
                case SheetType.DeleteCur:
                    this.rbDeleteCur.Checked = true;
                    break;
                case SheetType.Switch:
                    this.rbSwitch.Checked = true;
                    break;
            }
            this.tbSheetName.Text = sa.SheetName;
            this.cbSwitchAfterChange.Checked = sa.SwitchAfterChange;
            this.tbActivityName.Text = sa.Name;
        }
    }
}