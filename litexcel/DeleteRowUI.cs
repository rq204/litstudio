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
    internal partial class DeleteRowUI : litsdk.ILitUI
    {
        public DeleteRowUI()
        {
            InitializeComponent();
            this.ivRowStart.ShowVarName(true, false, true, this.tbRowStart);
            this.ivRowEnd.ShowVarName(true, false, true, this.tbRowEnd);

            ExcelLoadW.SetComboBox(this.cbExcelName);

            this.SaveActivity = () =>
            {
                da.ExcelName = this.cbExcelName.Text;

                if (this.rbDeleteAll.Checked) da.DeleteRowType = DeleteRowType.All;
                else if (this.rbDeleteRange.Checked) da.DeleteRowType = DeleteRowType.Range;
                else if (this.rbFirst.Checked) da.DeleteRowType = DeleteRowType.First;
                else if (this.rbLast.Checked) da.DeleteRowType = DeleteRowType.Last;

                da.RowStart = this.tbRowStart.Text;
                da.RowEnd = this.tbRowEnd.Text;
                da.LastRowNum = this.cbLastRow.Checked;

                da.Name = this.tbActivityName.Text;
            };
        }

        public override string ActivityType => "litexcel.DeleteRowActivity";
        DeleteRowActivity da = null;
        public override void SetActivity(Activity activity)
        {
            da = activity as DeleteRowActivity;
            this.cbExcelName.Text = da.ExcelName;

            switch (da.DeleteRowType)
            {
                case DeleteRowType.All:
                    this.rbDeleteAll.Checked = true;
                    break;
                case DeleteRowType.First:
                    this.rbFirst.Checked = true;
                    break;
                case DeleteRowType.Last:
                    this.rbLast.Checked = true;
                    break;
                case DeleteRowType.Range:
                    this.rbDeleteRange.Checked = true;
                    break;
            }

            this.tbRowStart.Text = da.RowStart;
            this.tbRowEnd.Text = da.RowEnd;
            this.cbLastRow.Checked = da.LastRowNum;

            this.tbActivityName.Text = da.Name;
        }


        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            this.pRowNum.Visible = this.rbDeleteRange.Checked;
        }
    }
}
