using litsdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace litstudio
{
    internal partial class FrmVarEditor : Form
    {
        private ActivityContext varInfo = null;
        public FrmVarEditor(ActivityContext varInfo)
        {
            InitializeComponent();
            this.varInfo = varInfo;
            this.tcVar.ItemSize = new System.Drawing.Size(0, 1);

            //将所有变量值放在界面上
            tsbtnShowAllVar.PerformClick();
        }

        private void lsvAllVar_DoubleClick(object sender, EventArgs e)
        {
            ///列表变量双击显示所有记录，字符或数字太长的，用文本显示
            if (lsvAllVar.SelectedItems.Count == 1)
            {
                Variable select = this.varInfo.Variables.Find((f) => f.Name == lsvAllVar.SelectedItems[0].Text);
                switch (select.VariableType)
                {
                    case VariableType.List:
                        this.dgvVarListData.DataSource = null;
                        this.dgvVarListData.Columns.Clear();
                        this.dgvVarListData.Columns.Add("Id", "Id");
                        this.dgvVarListData.Columns.Add("列表变量值", "列表变量值");
                        this.dgvVarListData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        List<string> rows = select.ListValue;
                        if (rows.Count > 0)
                        {
                            this.dgvVarListData.Visible = true;
                            this.dgvVarListData.BringToFront();
                            this.dgvVarListData.Rows.Clear();
                            int start = 1;
                            foreach (string r in this.varInfo.GetList(lsvAllVar.SelectedItems[0].Text))
                            {
                                DataGridViewRow dr = new DataGridViewRow();
                                dr.CreateCells(dgvVarListData);
                                dr.Cells[0].Value = start;
                                start++;
                                dr.Cells[1].Value = r;
                                this.dgvVarListData.Rows.Add(dr);
                            }
                        }
                        break;
                    case VariableType.Table:
                        this.dgvVarListData.DataSource = null;
                        this.dgvVarListData.Columns.Clear();
                        if (select.TableValue != null)
                        {
                            List<string> headse = select.TableColumns;
                            if (select.TableValue.Columns.Count == 0)
                            {
                                foreach (string hname in headse)
                                {
                                    DataColumn dc = new DataColumn() { ColumnName = hname };
                                    select.TableValue.Columns.Add(dc);
                                }
                            }
                            else
                            {
                                if (headse.Count > 0)
                                {
                                    List<string> removes = new List<string>();
                                    foreach (DataColumn d in select.TableValue.Columns)
                                    {
                                        if (!headse.Contains(d.ColumnName)) removes.Add(d.ColumnName);
                                    }
                                    foreach (string hname in removes)
                                    {
                                        select.TableValue.Columns.Remove(hname);
                                    }
                                    foreach (string d in headse)
                                    {
                                        if (!select.TableValue.Columns.Contains(d))
                                        {
                                            DataColumn dc = new DataColumn() { ColumnName = d };
                                            select.TableValue.Columns.Add(dc);
                                        }
                                    }
                                }
                            }
                            this.dgvVarListData.Visible = true;
                            this.dgvVarListData.BringToFront();
                            this.dgvVarListData.DataSource = select.TableValue;
                        }
                        break;
                    case VariableType.String:
                    case VariableType.Int:
                        this.tcVar.SelectedTab = tpVarStr;
                        this.lbInitValue.Text = "初始值";
                        this.lbVarValue.Text = "变量值";
                        this.tbVarValue.Visible = true;

                        this.tbVarName.Text = select.Name;
                        if (select.VariableType == VariableType.String)
                        {
                            this.tbVarValue.Text = select.StrValue;
                            this.tbInitVarValue.Text = select.InitStrValue;
                        }
                        else
                        {
                            this.tbVarValue.Text = select.IntValue.ToString();
                            this.tbInitVarValue.Text = select.InitIntValue.ToString();
                        }

                        this.btnSaveVar.Tag = lsvAllVar.SelectedItems[0].SubItems[2].Text;
                        break;
                }
            }
        }

        private void lsvAllVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tsbtnDeleteVar.Enabled = this.tsbtnClearVar.Enabled = this.lsvAllVar.SelectedItems.Count > 0;
        }

        private void tssbtnAddVarStr_ButtonClick(object sender, EventArgs e)
        {
            List<string> vars = this.getVarNames();
            if (vars != null)
            {
                foreach (string s in vars)
                {
                    if (!this.varInfo.Contains(s))
                    {
                        Variable old = this.varInfo.Variables.Find((a) => a.Name == s && a.VariableType == VariableType.String);
                        if (old == null) this.varInfo.Variables.Add(new Variable() { VariableType = VariableType.String, StrValue = "", InitStrValue = "", Name = s });
                    }
                }
                int pos = Convert.ToInt32(this.tsVarGroup.Tag);
                if (pos != 0 && pos != 1) this.tsVarGroup.Tag = 1;
                this.refreshList();
            }
            this.tstbVarName.Clear();
        }

        private void tsmiAddVarList_Click(object sender, EventArgs e)
        {
            List<string> vars = this.getVarNames();
            if (vars != null)
            {
                foreach (string s in vars)
                {
                    if (!this.varInfo.Contains(s))
                    {
                        Variable old = this.varInfo.Variables.Find((a) => a.Name == s && a.VariableType == VariableType.List);
                        if (old == null) this.varInfo.Variables.Add(new Variable() { VariableType = VariableType.List, Name = s, ListValue = new List<string>(), InitListValue = new List<string>() });
                    }
                }
                int pos = Convert.ToInt32(this.tsVarGroup.Tag);
                if (pos != 0 && pos != 2) this.tsVarGroup.Tag = 2;
                this.refreshList();
            }
            this.tstbVarName.Clear();
        }

        private void tsmiAddVarInt_Click(object sender, EventArgs e)
        {
            List<string> vars = this.getVarNames();
            if (vars != null)
            {
                foreach (string s in vars)
                {
                    if (!this.varInfo.Contains(s))
                    {
                        Variable old = this.varInfo.Variables.Find((a) => a.Name == s && a.VariableType == VariableType.Int);
                        if (old == null) this.varInfo.Variables.Add(new Variable() { Name = s, VariableType = VariableType.Int, IntValue = 0, InitIntValue = 0 });
                    }
                }
                int pos = Convert.ToInt32(this.tsVarGroup.Tag);
                if (pos != 0 && pos != 3) this.tsVarGroup.Tag = 3;
                this.refreshList();
            }
            this.tstbVarName.Clear();
        }

        /// <summary>
        /// 删除变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnDeleteVar_Click(object sender, EventArgs e)
        {
            Dictionary<string, ListViewItem> del = new Dictionary<string, ListViewItem>();
            foreach (ListViewItem lvi in lsvAllVar.SelectedItems)
            {
                del.Add(lvi.Text, lvi);
            }
            if (del.Count == 0) return;
            foreach (KeyValuePair<string, ListViewItem> kv in del)
            {
                this.varInfo.Remove(kv.Key);
                this.lsvAllVar.Items.Remove(kv.Value);
            }
        }

        /// <summary>
        /// 得到变量名称，如为null则表示错误
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private List<string> getVarNames()
        {
            string text = this.tstbVarName.Text;
            List<string> ls = new List<string>();
            if (string.IsNullOrWhiteSpace(text)) return null;
            text = text.Trim();
            if (text == ",") return null;
            string[] arr = text.Split(',');
            foreach (string s in arr)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(s, "^[\\w（）\\(\\)\\-]*?$") && !this.varInfo.Contains(s)) ls.Add(s);
            }
            if (ls.Count == 0) return null;
            return ls;
        }


        /// <summary>
        /// 保存字符和数字变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveVar_Click(object sender, EventArgs e)
        {
            switch (btnSaveVar.Tag.ToString())
            {
                case "字符变量":
                    this.varInfo.SetVarStr(this.tbVarName.Text, this.tbVarValue.Text);

                    Variable vf3 = this.varInfo.Variables.Find((a) => a.Name == this.tbVarName.Text && a.VariableType == VariableType.String);
                    if (vf3 != null)
                    {
                        vf3.InitStrValue = this.tbInitVarValue.Text;
                    }

                    this.tsbtnShowStrVar.PerformClick();
                    break;
                case "列表变量":
                    List<string> dataInit = new List<string>();
                    string dataTrim = this.tbInitVarValue.Text.Trim();
                    if (!string.IsNullOrEmpty(dataTrim))
                    {
                        dataInit = System.Text.RegularExpressions.Regex.Split(dataTrim, "\r\n").ToList();
                    }

                    Variable vf = this.varInfo.Variables.Find((a) => a.Name == this.tbVarName.Text && a.VariableType == VariableType.List);
                    if (vf != null) vf.InitListValue = dataInit;

                    this.tsbtnShowListVar.PerformClick();
                    break;
                case "数字变量":
                    if (System.Text.RegularExpressions.Regex.IsMatch(this.tbVarValue.Text, "^\\d+$") && System.Text.RegularExpressions.Regex.IsMatch(this.tbInitVarValue.Text, "^\\d+$"))
                    {
                        this.varInfo.SetVarInt(this.tbVarName.Text, int.Parse(this.tbVarValue.Text));

                        Variable vf2 = this.varInfo.Variables.Find((a) => a.Name == this.tbVarName.Text && a.VariableType == VariableType.Int);
                        if (vf2 != null)
                        {
                            vf2.InitIntValue = int.Parse(this.tbInitVarValue.Text);
                        }

                        this.tsbtnShowIntVar.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("数字变量及初始值必须为整数");
                    }
                    break;
                case "表格变量":
                    List<string> headers = System.Text.RegularExpressions.Regex.Split(this.tbInitVarValue.Text.Trim(), "\r\n").ToList();
                    this.varInfo.Variables.Find((m) => m.Name == this.tbVarName.Text).TableColumns = headers;
                    this.tsbtnShowTableVar.PerformClick();
                    break;
            }
        }

        /// <summary>
        /// 显示所有变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnShowAllVar_Click(object sender, EventArgs e)
        {
            this.tsVarGroup.Tag = 0;
            this.lsvAllVar.Items.Clear();
            this.showVar(true, true, true, true);
        }

        /// <summary>
        /// 显示变量
        /// </summary>
        /// <param name="showStr"></param>
        /// <param name="showList"></param>
        /// <param name="showInt"></param>
        private void showVar(bool showStr, bool showList, bool showInt, bool showTable = false)
        {
            this.lsvAllVar.Items.Clear();
            this.tcVar.SelectedTab = this.tpVarLsv;
            this.tcVar.BringToFront();
            this.dgvVarListData.Visible = false;
            if (showStr)
            {
                foreach (Variable vb in this.varInfo.Variables.FindAll((f) => f.VariableType == VariableType.String))
                {
                    ListViewItem lvi = new ListViewItem(vb.Name);
                    lvi.SubItems.Add(vb.StrValue);
                    lvi.SubItems.Add("字符变量");
                    this.lsvAllVar.Items.Add(lvi);
                }
            }
            if (showList)
            {
                foreach (Variable vb in this.varInfo.Variables.FindAll((f) => f.VariableType == VariableType.List))
                {
                    ListViewItem lvi = new ListViewItem(vb.Name);
                    lvi.SubItems.Add(vb.ListValue.Count.ToString() + "条记录");
                    lvi.SubItems.Add("列表变量");
                    this.lsvAllVar.Items.Add(lvi);
                }
            }
            if (showInt)
            {
                foreach (Variable vb in this.varInfo.Variables.FindAll((f) => f.VariableType == VariableType.Int))
                {
                    ListViewItem lvi = new ListViewItem(vb.Name);
                    lvi.SubItems.Add(vb.IntValue.ToString());
                    lvi.SubItems.Add("数字变量");
                    this.lsvAllVar.Items.Add(lvi);
                }
            }
            if (showTable)
            {
                foreach (Variable vb in this.varInfo.Variables.FindAll((f) => f.VariableType == VariableType.Table))
                {
                    ListViewItem lvi = new ListViewItem(vb.Name);
                    lvi.SubItems.Add(vb.TableValue != null ? vb.TableValue.Rows.Count.ToString() + "条记录" : "0条记录");
                    lvi.SubItems.Add("表格变量");
                    this.lsvAllVar.Items.Add(lvi);
                }
            }
        }

        private void tsbtnShowStrVar_Click(object sender, EventArgs e)
        {
            this.lsvAllVar.Items.Clear();
            this.tsVarGroup.Tag = 1;
            this.showVar(true, false, false);
        }

        private void tsbtnShowListVar_Click(object sender, EventArgs e)
        {
            this.tsVarGroup.Tag = 2;
            this.lsvAllVar.Items.Clear();
            this.showVar(false, true, false);
        }

        private void tsbtnShowIntVar_Click(object sender, EventArgs e)
        {
            this.tsVarGroup.Tag = 3;
            this.lsvAllVar.Items.Clear();
            this.showVar(false, false, true);
        }

        /// <summary>
        /// 清空变量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnEmptyVar_Click(object sender, EventArgs e)
        {
            Dictionary<string, ListViewItem> del = new Dictionary<string, ListViewItem>();
            foreach (ListViewItem lvi in lsvAllVar.SelectedItems)
            {
                del.Add(lvi.Text, lvi);
            }
            if (del.Count == 0) return;
            foreach (KeyValuePair<string, ListViewItem> kv in del)
            {
                this.varInfo.Clear(kv.Key);
            }
            this.refreshList();
        }

        /// <summary>
        /// 重新加载列表界面
        /// </summary>
        private void refreshList()
        {
            switch (Convert.ToInt32(this.tsVarGroup.Tag))
            {
                case 0:
                    this.tsbtnShowAllVar.PerformClick();
                    break;
                case 1:
                    this.tsbtnShowStrVar.PerformClick();
                    break;
                case 2:
                    this.tsbtnShowListVar.PerformClick();
                    break;
                case 3:
                    this.tsbtnShowIntVar.PerformClick();
                    break;
                case 4:
                    this.tsbtnShowTableVar.PerformClick();
                    break;
            }
        }

        private void tsmiCopyVarName_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem lvi in this.lsvAllVar.SelectedItems)
            {
                sb.Append(lvi.Text).Append(",");
            }
            Clipboard.SetText(sb.ToString().TrimEnd(','));
        }

        private void cmsVar_Opening(object sender, CancelEventArgs e)
        {
            this.tsmiCopyVarName.Enabled = this.tsmiEditVarName.Enabled = this.lsvAllVar.SelectedItems.Count > 0;
            this.tsmiCopyVarValue.Enabled = this.lsvAllVar.SelectedItems.Count == 1;
            this.tsmiMoveLine.Visible = this.tsmiMoveUp.Visible = this.tsmiMoveDown.Visible = this.tsmiMoveTop.Visible = this.tsmiMoveBotton.Visible = (int)this.tsVarGroup.Tag != 0 && this.lsvAllVar.SelectedItems.Count == 1;
            this.tsmiMoveUp.Enabled = this.tsmiMoveDown.Enabled = this.tsmiMoveTop.Enabled = this.tsmiMoveBotton.Enabled = false;
            if (this.lsvAllVar.SelectedItems.Count == 1 && this.lsvAllVar.Items.Count > 1)
            {
                this.tsmiMoveTop.Enabled = this.lsvAllVar.SelectedItems[0] != this.lsvAllVar.Items[0] && this.lsvAllVar.Items.Count > 2;
                this.tsmiMoveBotton.Enabled = this.lsvAllVar.SelectedItems[0] != this.lsvAllVar.Items[this.lsvAllVar.Items.Count - 1] && this.lsvAllVar.Items.Count > 2;
                this.tsmiMoveUp.Enabled = this.lsvAllVar.SelectedItems[0] != this.lsvAllVar.Items[0];
                this.tsmiMoveDown.Enabled = this.lsvAllVar.SelectedItems[0] != this.lsvAllVar.Items[this.lsvAllVar.Items.Count - 1];
            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".json";
            sfd.AddExtension = true;
            sfd.Filter = "*.json|*.json";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, Newtonsoft.Json.JsonConvert.SerializeObject(this.varInfo.Variables), System.Text.Encoding.UTF8);
            }
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".json";
            ofd.Filter = "*.json|*.json";
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string json = System.IO.File.ReadAllText(ofd.FileName, System.Text.Encoding.UTF8);
                try
                {
                    List<Variable> datas = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Variable>>(json);
                    foreach (Variable v in datas)
                    {
                        if (this.varInfo.Contains(v.Name))
                        {
                            this.varInfo.Remove(v.Name);
                        }
                        this.varInfo.Variables.Add(v);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "导入出错"); return;
                }
                tsbtnShowAllVar.PerformClick();
            }
        }

        private void VarEditor_Load(object sender, EventArgs e)
        {

        }

        private void tsmiCopyVarValue_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ListViewItem lvi = this.lsvAllVar.SelectedItems[0];
            string varname = lvi.Text;
            if (this.varInfo.ContainsStr(varname))
            {
                sb.Append(this.varInfo.GetStr(varname));
            }
            else if (this.varInfo.ContainsInt(varname))
            {
                sb.Append(this.varInfo.GetInt(varname));
            }
            else if (this.varInfo.ContainsList(varname))
            {
                sb.Append(string.Join("\r\n---变量分隔线---\r\n", this.varInfo.GetList(varname)));
            }
            string txt = sb.ToString();
            if (string.IsNullOrEmpty(txt))
            {
                Clipboard.SetText(txt);
            }
        }

        private void tsbtnShowTableVar_Click(object sender, EventArgs e)
        {
            this.tsVarGroup.Tag = 4;
            this.lsvAllVar.Items.Clear();
            this.showVar(false, false, false, true);
        }

        private void tsmiAddVarTable_Click(object sender, EventArgs e)
        {
            List<string> vars = this.getVarNames();
            if (vars != null)
            {
                foreach (string s in vars)
                {
                    if (!this.varInfo.Contains(s))
                    {
                        Variable old = this.varInfo.Variables.Find((a) => a.Name == s && a.VariableType == VariableType.Table);
                        if (old == null) this.varInfo.Variables.Add(new Variable() { VariableType = VariableType.Table, Name = s, TableValue = new DataTable() });
                    }
                }
                int pos = Convert.ToInt32(this.tsVarGroup.Tag);
                if (pos != 0 && pos != 4) this.tsVarGroup.Tag = 4;
                this.refreshList();
            }
            this.tstbVarName.Clear();
        }

        private void tsmiEditVarName_Click(object sender, EventArgs e)
        {
            this.tcVar.SelectedTab = tpVarStr;
            this.lbInitValue.Text = "初始值";
            this.lbVarValue.Text = "变量值";
            this.lbVarValue.Visible = false;
            this.tbVarValue.Visible = true;
            this.tbVarName.Text = lsvAllVar.SelectedItems[0].Text;
            this.btnSaveVar.Tag = lsvAllVar.SelectedItems[0].SubItems[2].Text;

            Variable v = this.varInfo.Variables.Find((f) => f.Name == lsvAllVar.SelectedItems[0].SubItems[0].Text);
            switch (v.VariableType)
            {
                case VariableType.String:
                    this.tbVarValue.Text = v.StrValue;
                    this.tbInitVarValue.Text = v.InitStrValue;
                    break;
                case VariableType.Int:
                    this.tbVarValue.Text = v.IntValue.ToString();
                    this.tbInitVarValue.Text = v.InitIntValue.ToString();
                    break;
                case VariableType.List:
                    this.tbVarValue.Visible = false;
                    this.lbVarValue.Visible = false;
                    this.tbInitVarValue.Text = string.Join("\r\n", v.InitListValue.ToArray());
                    break;
                case VariableType.Table:
                    this.tbVarValue.Visible = false;
                    this.lbVarValue.Visible = false;
                    this.tbInitVarValue.Text = string.Join("\r\n", v.TableColumns.ToArray());
                    this.lbInitValue.Text = "表  头";
                    break;
            }

        }

        private void tsmiIportClip_Click(object sender, EventArgs e)
        {
            string txt = Clipboard.GetText();
            try
            {
                if (txt == "") throw new Exception("剪贴板为空");
                List<string> ls = txt.Split('&').ToList();

                foreach (string s in ls)
                {
                    int pos = s.IndexOf("=");
                    if (pos > 0)
                    {
                        string name = s.Substring(0, pos);
                        string value = s.Substring(pos + 1, s.Length - 1 - pos);
                        value = System.Web.HttpUtility.UrlDecode(value, System.Text.Encoding.UTF8);

                        if (!this.varInfo.Contains(name))
                        {
                            Variable old = this.varInfo.Variables.Find((a) => a.Name == s && a.VariableType == VariableType.String);
                            if (old == null) this.varInfo.Variables.Add(new Variable() { VariableType = VariableType.String, StrValue = value, Name = name });
                        }
                    }
                }
                int posg = Convert.ToInt32(this.tsVarGroup.Tag);
                if (posg != 0 && posg != 1) this.tsVarGroup.Tag = 1;
                this.refreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
        }

        private void tsmiExportSelectVar_Click(object sender, EventArgs e)
        {
            List<litsdk.Variable> list = new List<Variable>();
            foreach (ListViewItem lvi in lsvAllVar.SelectedItems)
            {
                Variable v = this.varInfo.Variables.Find((f) => f.Name == lvi.Text);
                if (v != null) list.Add(v);
            }
            if (list.Count == 0) return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".json";
            sfd.AddExtension = true;
            sfd.Filter = "*.json|*.json";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, Newtonsoft.Json.JsonConvert.SerializeObject(list), System.Text.Encoding.UTF8);
            }
        }

        private void tsmiValueToInit_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lsvAllVar.SelectedItems)
            {
                Variable v = this.varInfo.Variables.Find((f) => f.Name == lvi.Text);
                if (v != null && v.VariableType != VariableType.Table)
                {
                    switch (v.VariableType)
                    {
                        case VariableType.String:
                            v.InitStrValue = v.StrValue;
                            break;
                        case VariableType.Int:
                            v.InitIntValue = v.IntValue;
                            break;
                        case VariableType.List:
                            v.InitListValue = v.ListValue;
                            break;
                    }
                }
            }
        }

        private void tsmiMoveTop_Click(object sender, EventArgs e)
        {
            string name = this.lsvAllVar.SelectedItems[0].Text;
            litsdk.Variable v = this.varInfo.Variables.Find((f) => f.Name == name);
            this.varInfo.Variables.Remove(v);
            this.varInfo.Variables.Insert(0, v);
            this.refreshList();
        }

        private void tsmiMoveUp_Click(object sender, EventArgs e)
        {
            string name = this.lsvAllVar.SelectedItems[0].Text;
            litsdk.Variable v = this.varInfo.Variables.Find((f) => f.Name == name);
            int pos = 0;
            for (int i = this.varInfo.Variables.IndexOf(v) - 1; i >= 0; i--)
            {
                if (this.varInfo.Variables[i].VariableType == v.VariableType)
                {
                    pos = i; break;
                }
            }
            this.varInfo.Variables.Remove(v);
            this.varInfo.Variables.Insert(pos, v);
            this.refreshList();
        }

        private void tsmiMoveDown_Click(object sender, EventArgs e)
        {
            string name = this.lsvAllVar.SelectedItems[0].Text;
            litsdk.Variable v = this.varInfo.Variables.Find((f) => f.Name == name);
            int pos = this.varInfo.Variables.Count - 1;
            for (int i = this.varInfo.Variables.IndexOf(v) + 1; i < this.varInfo.Variables.Count; i++)
            {
                if (this.varInfo.Variables[i].VariableType == v.VariableType)
                {
                    pos = i; break;
                }
            }
            this.varInfo.Variables.Remove(v);
            this.varInfo.Variables.Insert(pos, v);
            this.refreshList();
        }

        private void tsmiMoveBotton_Click(object sender, EventArgs e)
        {
            string name = this.lsvAllVar.SelectedItems[0].Text;
            litsdk.Variable v = this.varInfo.Variables.Find((f) => f.Name == name);
            this.varInfo.Variables.Remove(v);
            this.varInfo.Variables.Add(v);
            this.refreshList();
        }
    }
}