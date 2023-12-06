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
    internal partial class ExcelToTableUI : litsdk.ILitUI
    {
        public ExcelToTableUI()
        {
            InitializeComponent();
            this.ivExcelFilePath.ShowVarName(true, false, true, this.tbExcelFilePath);
            this.ivSheetName.ShowVarName(true, false, true, this.tbSheetName);
            this.svTableVarName.ShowVarName(false, false, false, true);
            this.SaveActivity = new Action(() =>
              {
                  et.ExcelFilePath = this.tbExcelFilePath.Text.Trim();
                  et.SheetName = this.tbSheetName.Text.Trim();
                  et.TableVarName = this.svTableVarName.VarName;
                  et.Name = this.tbActivityName.Text;
                  et.OverWrite = this.cbOverWrite.Checked;
                  if (this.rbExcelDataToTable.Checked) et.ExcelToTableType = ExcelToTableType.ExcelDataToTable;
                  else if (this.rbTableDataToExcel.Checked) et.ExcelToTableType = ExcelToTableType.TableDataToExcel;
              });
        }

        public override string ActivityType => "litexcel.ExcelToTableActivity";
        ExcelToTableActivity et = null;
        public override void SetActivity(Activity activity)
        {
            et = activity as ExcelToTableActivity;
            this.tbExcelFilePath.Text = et.ExcelFilePath;
            this.tbSheetName.Text = et.SheetName;
            this.svTableVarName.VarName = et.TableVarName;
            this.tbActivityName.Text = et.Name;
            switch (et.ExcelToTableType)
            {
                case ExcelToTableType.ExcelDataToTable:
                    this.rbExcelDataToTable.Checked = true;
                    break;
                case ExcelToTableType.TableDataToExcel:
                    this.rbTableDataToExcel.Checked = true;
                    break;

            }
            this.cbOverWrite.Checked = et.OverWrite;
        }

        private void llbCurrentDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbExcelFilePath, this.llbCurrentDir.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.rbExcelDataToTable.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel文件|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.tbExcelFilePath.Text = openFileDialog.FileName;
                }
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter= "Excel文件|*.xls;*.xlsx";
                save.DefaultExt = ".xlsx";
                if (save.ShowDialog()== DialogResult.OK)
                {
                    this.tbExcelFilePath.Text = save.FileName;
                }
            }
        }
    }
}
