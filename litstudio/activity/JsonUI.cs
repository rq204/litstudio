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

namespace litstudio
{
    internal partial class JsonUI : litsdk.ILitUI
    {
        public JsonUI()
        {
            InitializeComponent();
            this.svSourceVarName.ShowVarName(true, false, false);
            this.svSaveVarName.ShowVarName(true, true, true, true);
            this.ivJsonPath.ShowVarName(true, false, true, this.tbJsonPath);

            base.SaveActivity = new Action(() =>
            {
                ja.Name = this.tbActivityName.Text.Trim();
                ja.SourceVarName = this.svSourceVarName.VarName;
                ja.VarNameJsonPaths.Clear();
                foreach (ListViewItem lvi in this.lsvData.Items)
                {
                    ja.VarNameJsonPaths.Add(lvi.SubItems[1].Text, lvi.Text);
                }

            });
        }

        private void lldoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://goessner.net/articles/JsonPath/");
        }

        litcore.activity.JsonActivity ja = null;
        public override void SetActivity(Activity activity)
        {
            ja = activity as litcore.activity.JsonActivity;
            this.svSourceVarName.VarName = ja.SourceVarName;
            foreach (KeyValuePair<string, string> kv in ja.VarNameJsonPaths)
            {
                ListViewItem lvi = new ListViewItem(kv.Value);
                lvi.SubItems.Add(kv.Key);
                this.lsvData.Items.Add(lvi);
            }
            this.tbActivityName.Text = ja.Name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.tbJsonPath.Text.Trim() == "")
            {
                MessageBox.Show("JsonPath不能为空");return;
            }
            if(this.svSaveVarName.VarName=="")
            {
                MessageBox.Show("保存变量名不能为空"); return;
            }
            string json = this.tbJsonPath.Text.Trim();
            string varname = this.svSaveVarName.VarName;
            foreach(ListViewItem lvi in this.lsvData.Items)
            {
                if (lvi.SubItems[1].Text == varname)
                {
                    lvi.Text = json;
                    return;
                }
            }
            ListViewItem item = new ListViewItem(json);
            item.SubItems.Add(varname);
            this.lsvData.Items.Add(item);
        }

        private void lsvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.llbDelete.Enabled = this.llbEdit.Enabled = this.lsvData.SelectedItems.Count == 1;
        }

        private void lsvData_DoubleClick(object sender, EventArgs e)
        {
            llbEdit_LinkClicked(null, null);
        }

        private void llbEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lsvData.SelectedItems.Count == 1)
            {
                this.tbJsonPath.Text = this.lsvData.SelectedItems[0].Text;
                this.svSaveVarName.VarName= this.lsvData.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void llbDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.lsvData.SelectedItems.Count == 1)
            {
                this.lsvData.SelectedItems[0].Remove();
            }
        }
    }
}
