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
    internal partial class WriteUI : litsdk.ILitUI
    {
        public WriteUI()
        {
            InitializeComponent();
            this.svWriteVarName.ShowVarName(true, false, false);
            this.ivRowStart.ShowVarName(true, false, true, this.tbRowStart);
            this.ivColStart.ShowVarName(true, false, true, this.tbColStart);
            this.ivRowHeight.ShowVarName(true, false, true, this.tbRowHeight);
            this.ivColWidth.ShowVarName(true, false, true, this.tbColWidth);

            ExcelLoadW.SetComboBox(this.cbExcelName);

            this.SaveActivity = () =>
            {
                wa.ExcelName = this.cbExcelName.Text;
                wa.RowStart = this.tbRowStart.Text;
                wa.ColStart = this.tbColStart.Text;

                wa.RowHeight = this.tbRowHeight.Text;
                wa.ColWidth = this.tbColWidth.Text;

                wa.WriteVarName = this.svWriteVarName.VarName;
                wa.IsImage = this.cbIsImage.Checked;
                wa.Name = this.tbActivityName.Text;

                if (this.rbDontMoveAndResize.Checked) wa.AnchorType = AnchorType.DontMoveAndResize; 
                else if (this.rbMoveAndResize.Checked) wa.AnchorType = AnchorType.MoveAndResize; 
                else if (this.rbMoveDontResize.Checked) wa.AnchorType = AnchorType.MoveDontResize; 
            };
        }

        public override string ActivityType => "litexcel.WriteActivity";
        private WriteActivity wa = null;

        public override void SetActivity(Activity activity)
        {
            wa = activity as WriteActivity;

            this.cbExcelName.Text = wa.ExcelName;
            this.tbRowStart.Text = wa.RowStart;
            this.tbColStart.Text = wa.ColStart;

            this.tbRowHeight.Text = wa.RowHeight;
            this.tbColWidth.Text = wa.ColWidth;

            this.svWriteVarName.VarName = wa.WriteVarName;
            this.cbIsImage.Checked = wa.IsImage;
            this.tbActivityName.Text = wa.Name;

            switch (wa.AnchorType)
            {
                case AnchorType.DontMoveAndResize:
                    this.rbDontMoveAndResize.Checked = true;
                    break;
                case AnchorType.MoveAndResize:
                    this.rbMoveAndResize.Checked = true;
                    break;
                case AnchorType.MoveDontResize:
                    this.rbMoveDontResize.Checked = true;
                    break;
            }
        }

        private void cbIsImage_CheckedChanged(object sender, EventArgs e)
        {
            this.pImage.Visible = this.cbIsImage.Checked;
        }
    }
}
