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
using litcore.iecef;

namespace litstudio.iecef
{
    internal partial class ToPdfUI : litsdk.ILitUI
    {
        public ToPdfUI()
        {
            InitializeComponent();
            this.ivFilePath.ShowVarName(true, false, true, this.tbPdfPath);
            this.SaveActivity = new Action(() =>
              {
                  pdfActivity.PdfPath = this.tbPdfPath.Text.Trim();
                  pdfActivity.Name = this.tbActivityName.Text;
                  pdfActivity.ScaleFactor = (int)this.nudScaleFactor.Value;
              });
        }

        ToPdf pdfActivity = null;
        public override void SetActivity(Activity activity)
        {
            pdfActivity = activity as ToPdf;
            this.tbPdfPath.Text = pdfActivity.PdfPath;
            this.tbActivityName.Text = pdfActivity.Name;
            this.nudScaleFactor.Value = pdfActivity.ScaleFactor;
        }

        private void llbCurDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbPdfPath, this.llbCurDir.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog openFile = new SaveFileDialog();
            openFile.Filter = "pdf文件|*.pdf";
            openFile.DefaultExt = ".pdf";
            if(openFile.ShowDialog()== DialogResult.OK)
            {
                this.tbPdfPath.Text = openFile.FileName;
            }
        }
    }
}
