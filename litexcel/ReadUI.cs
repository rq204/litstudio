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
    internal partial class ReadUI : litsdk.ILitUI
    {
        public ReadUI()
        {
            InitializeComponent();
            this.ivRowStart.ShowVarName(true, false, true, this.tbRowStart);
            this.ivRowEnd.ShowVarName(true, false, true, this.tbRowEnd);
            this.ivColStart.ShowVarName(true, false, true, this.tbColStart);
            this.ivColEnd.ShowVarName(true, false, true, this.tbColEnd);

            ExcelLoadW.SetComboBox(this.cbExcelName);

            this.SaveActivity = () =>
            {
                ra.ExcelName = this.cbExcelName.Text;

                if (this.rbCell.Checked) ra.ReadType = ReadType.Cell;
                else if (this.rbCol.Checked) ra.ReadType = ReadType.Col;
                else if (this.rbRegion.Checked) ra.ReadType = ReadType.Region;
                else if (this.rbRow.Checked) ra.ReadType = ReadType.Row;

                ra.RowStart = this.tbRowStart.Text;
                ra.RowEnd = this.tbRowEnd.Text;
                ra.ColStart = this.tbColStart.Text;
                ra.ColEnd = this.tbColEnd.Text;
                ra.FromHref = this.cbFromHref.Checked;

                ra.LastCol = this.cbLastCol.Checked;
                ra.LastRow = this.cbLastRow.Checked;

                ra.SaveVarName = this.svSaveVarName.VarName;
                ra.Name = this.tbActivityName.Text;

                ra.SelectFirstIsHeader = this.cbSelectFirstIsHeader.Checked;
            };
        }

        public override string ActivityType => "litexcel.ReadActivity";
        ReadActivity ra = null;
        public override void SetActivity(Activity activity)
        {
            ra = activity as ReadActivity;
            this.cbExcelName.Text = ra.ExcelName;
            switch (ra.ReadType)
            {
                case ReadType.Cell:
                    this.rbCell.Checked = true;
                    break;
                case ReadType.Col:
                    this.rbCol.Checked = true;
                    break;
                case ReadType.Region:
                    this.rbRegion.Checked = true;
                    break;
                case ReadType.Row:
                    this.rbRow.Checked = true;
                    break;
            }

            this.tbRowStart.Text = ra.RowStart;
            this.tbRowEnd.Text = ra.RowEnd;
            this.tbColStart.Text = ra.ColStart;
            this.tbColEnd.Text = ra.ColEnd;
            this.cbLastCol.Checked = ra.LastCol;
            this.cbLastRow.Checked = ra.LastRow;
            this.cbFromHref.Checked = ra.FromHref;

            this.svSaveVarName.VarName = ra.SaveVarName;
            this.tbActivityName.Text = ra.Name;
            this.cbSelectFirstIsHeader.Checked = ra.SelectFirstIsHeader;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            this.lbStart.Visible = this.lbRowStart.Visible = this.tbRowStart.Visible = this.lbColStart.Visible = this.tbColStart.Visible = this.ivRowStart.Visible = this.ivColStart.Visible = true;

            if (this.rbCell.Checked)
            {
                this.lbStart.Text = "单元格位置";
                this.pEnd.Visible = false;
                this.svSaveVarName.ShowVarName(true, false, true, false);
            }
            else if (this.rbRegion.Checked)
            {
                this.lbStart.Text = "起始单元格";
                this.pEnd.Visible = true;
                this.svSaveVarName.ShowVarName(false, false, false, true);
            }
            else if (this.rbRow.Checked)
            {
                this.lbStart.Visible = false;
                this.lbColStart.Visible = this.ivColStart.Visible = this.tbColStart.Visible = false;
                this.pEnd.Visible = false;
                this.svSaveVarName.ShowVarName(false, true, false, false);
            }
            else if (this.rbCol.Checked)
            {
                this.lbStart.Visible = false;
                this.lbRowStart.Visible = this.ivRowStart.Visible = this.tbRowStart.Visible = false;
                this.pEnd.Visible = false;
                this.svSaveVarName.ShowVarName(false, true, false, false);
            }
        }
    }
}
