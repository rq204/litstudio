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

namespace litapps
{
    internal partial class SelectIOUI : litsdk.ILitUI
    {
        public SelectIOUI()
        {
            InitializeComponent();
            this.ivTitle.ShowVarName(true, false, true, this.tbTitle);
            this.svSaveVarName.ShowVarName(true, false, false);

            this.SaveActivity = () =>
            {
                sa.SelectFile = this.rbSelectFile.Checked;

                sa.Title = this.tbTitle.Text;
                sa.Filter = this.tbFilter.Text;
                sa.SaveVarName = this.svSaveVarName.VarName;

                sa.FileCanMultSelect = this.cbFileCanMultSelect.Checked;
                sa.FileMustMultSelect = this.cbFileMustMultSelect.Checked;
                sa.MustSelect = this.cbMustSelect.Checked;

                sa.Name = this.tbActivityName.Text;
            };
        }

        SelectIOActivity sa = null;

        public override void SetActivity(Activity activity)
        {
            sa = activity as SelectIOActivity;
            this.rbSelectFile.Checked = sa.SelectFile;
            this.rbSelectDir.Checked = !sa.SelectFile;

            this.tbTitle.Text = sa.Title;
            this.tbFilter.Text = sa.Filter;
            this.svSaveVarName.VarName = sa.SaveVarName;

            this.cbFileCanMultSelect.Checked = sa.FileCanMultSelect;
            this.cbFileMustMultSelect.Checked = sa.FileMustMultSelect;
            this.cbMustSelect.Checked = sa.MustSelect;

            this.tbActivityName.Text = sa.Name;
        }

        private void rbSelectFile_CheckedChanged(object sender, EventArgs e)
        {
            this.cbFileCanMultSelect.Visible = this.cbFileMustMultSelect.Visible = this.rbSelectFile.Checked;
        }

        private void cbMultSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbFileCanMultSelect.Checked || this.cbFileCanMultSelect.Checked)
            {
                this.svSaveVarName.ShowVarName(false, true, false);
            }
            else
            {
                this.svSaveVarName.ShowVarName(true, false, false);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbFilter, "|");
        }
    }
}
