using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using litsdk;

namespace litexcel
{
    internal partial class ExcelInfoUI : litsdk.ILitUI
    {
        public ExcelInfoUI()
        {
            InitializeComponent();

            ExcelLoadW.SetComboBox(this.cbExcelName);
            this.svSheetNames.ShowVarName(false, true, false);
            this.svSheetRowCount.ShowVarName(false, false, true);
            this.svSheetHeaders.ShowVarName(false, true, false);

            this.SaveActivity = () =>
            {
                ea.ExcelName = this.cbExcelName.Text;

                ea.SheetHeaderVarName = this.svSheetHeaders.VarName;
                ea.SheetNamesVarName = this.svSheetNames.VarName;
                ea.SheetRowCountVarName = this.svSheetRowCount.VarName;

                ea.Name = this.tbActivityName.Text;
            };
        }

        ExcelInfoActivity ea = null;

        public override string ActivityType => "litexcel.ExcelInfoActivity";

        public override void SetActivity(Activity activity)
        {
            ea = activity as ExcelInfoActivity;
            this.cbExcelName.Text = ea.ExcelName;

            this.svSheetHeaders.VarName = ea.SheetHeaderVarName;
            this.svSheetNames.VarName = ea.SheetNamesVarName;
            this.svSheetRowCount.VarName = ea.SheetRowCountVarName;

            this.tbActivityName.Text = ea.Name;
        }
    }
}
