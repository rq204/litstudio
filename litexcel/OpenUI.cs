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
    internal partial class OpenUI : litsdk.ILitUI
    {
        public OpenUI()
        {
            InitializeComponent();
            this.ivExcelPath.ShowVarName(true, false, true, this.tbExcelPath);
            this.ivExcelName.ShowVarName(true, false, true, this.tbExcelName);

            this.SaveActivity = () =>
            {
                oa.ExcelPath = this.tbExcelPath.Text.Trim();
                oa.ExcelName = this.tbExcelName.Text.Trim();
                oa.SheetName = this.tbSheetName.Text.Trim();
                oa.Name = this.tbActivityName.Text;
            };
        }

        public override string ActivityType => "litexcel.OpenActivity";
        OpenActivity oa = null;
        public override void SetActivity(Activity activity)
        {
            oa = activity as OpenActivity;
            this.tbExcelPath.Text = oa.ExcelPath;
            this.tbExcelName.Text = oa.ExcelName;
            this.tbActivityName.Text = oa.Name;
            this.tbSheetName.Text = oa.SheetName;
        }

        private void llbCurDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbExcelPath, this.llbCurDir.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel文件|*.xls;*.xlsx";
            if(openFileDialog.ShowDialog()== DialogResult.OK)
            {
                this.tbExcelPath.Text = openFileDialog.FileName;
            }
        }
    }
}
