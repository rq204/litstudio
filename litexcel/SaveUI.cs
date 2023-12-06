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
    internal partial class SaveUI : litsdk.ILitUI
    {
        public SaveUI()
        {
            InitializeComponent();
            this.ivSaveAs.ShowVarName(true, true, false, this.tbSaveAsPath);

            ExcelLoadW.SetComboBox(this.cbExcelName);

            this.SaveActivity = () =>
            {
                sa.ExcelName = this.cbExcelName.Text;
                sa.CloseAfterSave = this.cbCloseAfterSave.Checked;
                if (this.rbSave.Checked) sa.SaveType = SaveType.Save;
                else if (this.rbSaveAs.Checked) sa.SaveType = SaveType.SaveAs;
                else if (this.rbOnlyClose.Checked) sa.SaveType = SaveType.OnlyClose;

                sa.SaveAsPath = this.tbSaveAsPath.Text;
                sa.Name = this.tbActivityName.Text;
            };
        }

        public override string ActivityType => "litexcel.SaveActivity";
        litexcel.SaveActivity sa = null;

        public override void SetActivity(Activity activity)
        {
            sa = activity as litexcel.SaveActivity;
            this.cbExcelName.Text = sa.ExcelName;
            this.cbCloseAfterSave.Checked = sa.CloseAfterSave;
            switch (sa.SaveType)
            {
                case SaveType.Save:
                    this.rbSave.Checked = true;
                    break;
                case SaveType.SaveAs:
                    this.rbSaveAs.Checked = true;
                    break;
                case SaveType.OnlyClose:
                    this.rbOnlyClose.Checked = true;
                    break;
            }
            this.tbSaveAsPath.Text = sa.SaveAsPath;
            this.tbActivityName.Text = sa.Name;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            this.lbSaveAs.Visible = this.tbSaveAsPath.Visible = this.ivSaveAs.Visible = this.rbSaveAs.Checked;
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel文件|*.xls;*.xlsx";
            save.DefaultExt = ".xlsx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                this.tbSaveAsPath.Text = save.FileName;
            }
        }

        private void llbCurrentDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbSaveAsPath, this.llbCurrentDir.Text);
        }
    }
}
