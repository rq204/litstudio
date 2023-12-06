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

namespace litstudio.iecef
{
    internal partial class CookiesUI : litsdk.ILitUI
    {
        public CookiesUI()
        {
            InitializeComponent();
            this.ivFilePath.ShowVarName(true, false, true, this.tbFilePath);
            this.svSaveVarName.ShowVarName(true, false, false);

            this.SaveActivity = new Action(() =>
              {
                  if (this.rbExportFile.Checked)
                  {
                      ck.CookieType = litcore.ictype.CookieType.ExportFile;
                  }
                  else if (this.rbExportVar.Checked)
                  {
                      ck.CookieType = litcore.ictype.CookieType.ExportVar;
                  }
                  else if (this.rbImportFile.Checked)
                  {
                      ck.CookieType = litcore.ictype.CookieType.ImportFile;
                  }
                  else if (this.rbImportVar.Checked)
                  {
                      ck.CookieType = litcore.ictype.CookieType.ImportVar;
                  }
                  else if (this.rbClearUrl.Checked)
                  {
                      ck.CookieType = litcore.ictype.CookieType.ClearUrl;
                  }
                  else if (this.rbClearAll.Checked)
                  {
                      ck.CookieType = litcore.ictype.CookieType.ClearAll;
                  }
                  else if (this.rbClearOtherUrl.Checked)
                  {
                      ck.CookieType = litcore.ictype.CookieType.ClearOther;
                  }
                  else if (this.rbExportABVar.Checked)
                  {
                      ck.CookieType = litcore.ictype.CookieType.ExportAbVar;
                  }

                  ck.FilePath = this.tbFilePath.Text.Trim();
                  ck.SaveVarName = this.svSaveVarName.VarName;
                  ck.Name = this.tbActivityName.Text;
                  ck.ExportHost = this.tbExportHost.Text.Trim();
              });
        }

        litcore.iecef.Cookies ck = null;
        public override void SetActivity(Activity activity)
        {
            ck = activity as litcore.iecef.Cookies;
            switch (ck.CookieType)
            {
                case litcore.ictype.CookieType.ExportFile:
                    this.rbExportFile.Checked = true;
                    break;
                case litcore.ictype.CookieType.ExportVar:
                    this.rbExportVar.Checked = true;
                    break;
                case litcore.ictype.CookieType.ImportFile:
                    this.rbImportFile.Checked = true;
                    break;
                case litcore.ictype.CookieType.ImportVar:
                    this.rbImportVar.Checked = true;
                    break;
                case litcore.ictype.CookieType.ClearUrl:
                    this.rbClearUrl.Checked = true;
                    break;
                case litcore.ictype.CookieType.ClearAll:
                    this.rbClearAll.Checked = true;
                    break;
                case litcore.ictype.CookieType.ExportAbVar:
                    this.rbExportABVar.Checked = true;
                    break;
                case litcore.ictype.CookieType.ClearOther:
                    this.rbClearOtherUrl.Checked = true;
                    break;
            }
            this.tbFilePath.Text = ck.FilePath;
            this.svSaveVarName.VarName = ck.SaveVarName;
            this.tbActivityName.Text = ck.Name;
            this.tbExportHost.Text = ck.ExportHost;
            this.rb_CheckedChanged(null, null);
        }

        private void llbCurDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbFilePath, this.llbCurDir.Text);
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbExportFile.Checked || this.rbImportFile.Checked)
            {
                this.pFilePath.Visible = true;
                this.lbvarName.Visible = this.svSaveVarName.Visible = false;
            }
            else if (this.rbExportVar.Checked || this.rbImportVar.Checked || this.rbExportABVar.Checked)
            {
                this.pFilePath.Visible = false;
                this.lbvarName.Visible = this.svSaveVarName.Visible = true;

            }
            else
            {
                this.pFilePath.Visible = this.lbvarName.Visible = this.svSaveVarName.Visible = false;
            }
            this.lbExportHost.Visible = this.tbExportHost.Visible = this.rbExportABVar.Checked || this.rbExportFile.Checked || this.rbExportVar.Checked;
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) this.tbFilePath.Text = saveFileDialog.FileName;
        }
    }
}
