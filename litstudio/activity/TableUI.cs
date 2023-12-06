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
using litcore.type;

namespace litstudio
{
    internal partial class TableUI : litsdk.ILitUI
    {
        public TableUI()
        {
            InitializeComponent();
            this.svTableVarName.ShowVarName(false, false, false, true);
            this.smvSelectFields.ShowVarName(true, false, true);
            this.svmEditFields.ShowVarName(true, false, true);

            base.SaveActivity = new Action(() =>
            {
                ta.TableVarName = this.svTableVarName.VarName;

                if (this.rbAdd.Checked == true) ta.TableType = TableType.Add;
                else if (this.rbDeleteAll.Checked) ta.TableType = TableType.DeleteAll;
                else if (this.rbDeleteMore.Checked) ta.TableType = TableType.DeleteMore;
                else if (this.rbDeleteOne.Checked) ta.TableType = TableType.DeleteOne;
                else if (this.rbEditMore.Checked) ta.TableType = TableType.EditMore;
                else if (this.rbEditOne.Checked) ta.TableType = TableType.EditOne;
                else if (this.rbDistinct.Checked) ta.TableType = TableType.Distinct;
                else if (this.rbSort.Checked) ta.TableType = TableType.Sort;
                else if (this.rbCellData.Checked) ta.TableType = TableType.CellData;
                else if (this.rbRowSave.Checked) ta.TableType = TableType.Rows2Table;

                ta.SeletFields = this.smvSelectFields.VarNames;
                ta.EditFields = this.svmEditFields.VarNames;
                ta.Name = this.tbActivityName.Text;
            });
        }


        litcore.activity.TableActivity ta = null;
        public override void SetActivity(Activity activity)
        {
            ta = activity as litcore.activity.TableActivity;
            this.svTableVarName.VarName = ta.TableVarName;
            switch (ta.TableType)
            {
                case TableType.Add:
                    this.rbAdd.Checked = true;
                    break;
                case TableType.DeleteAll:
                    this.rbDeleteAll.Checked = true;
                    break;
                case TableType.DeleteMore:
                    this.rbDeleteMore.Checked = true;
                    break;
                case TableType.DeleteOne:
                    this.rbDeleteOne.Checked = true;
                    break;
                case TableType.EditMore:
                    this.rbEditMore.Checked = true;
                    break;
                case TableType.EditOne:
                    this.rbEditOne.Checked = true;
                    break;
                case TableType.Distinct:
                    this.rbDistinct.Checked = true;
                    break;
                case TableType.Sort:
                    this.rbSort.Checked = true;
                    break;
                case TableType.CellData:
                    this.rbCellData.Checked = true;
                    break;
                case TableType.Rows2Table:
                    this.rbRowSave.Checked = true;
                    break;
            }
            this.smvSelectFields.VarNames = ta.SeletFields;
            this.svmEditFields.VarNames = ta.EditFields;
            this.tbActivityName.Text = ta.Name;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            this.lbEditFields.Visible = this.svmEditFields.Visible = this.rbEditMore.Checked || this.rbEditOne.Checked || this.rbCellData.Checked || this.rbRowSave.Checked;
            this.lbSelectFields.Text = this.rbAdd.Checked ? "添加字段" : "匹配字段";

            this.lbEditFields.Text = (this.rbCellData.Checked || this.rbRowSave.Checked) ? "保存字段" : "编辑字段";

            this.lbSelectFields.Visible = this.smvSelectFields.Visible = !(this.rbDeleteAll.Checked || this.rbDistinct.Checked);

            if (this.rbRowSave.Checked) this.svmEditFields.ShowVarName(false, false, false, true);
            else this.svmEditFields.ShowVarName(true, false, false);
        }
    }
}
