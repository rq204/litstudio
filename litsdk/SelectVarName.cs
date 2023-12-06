using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace litsdk
{
    /// <summary>
    /// 单个变量选择控件
    /// </summary>
    public partial class SelectVarName : UserControl
    {
        /// <summary>
        /// 单个变量名称选择
        /// </summary>
        public SelectVarName()
        {
            InitializeComponent();
            this.tsmiClear.Click += TsmiClear_Click;
        }

        private void TsmiClear_Click(object sender, EventArgs e)
        {
            this.tbVarName.Clear();
        }

        private bool showStr, showList, showInt, showTable;
        /// <summary>
        /// 显示哪些变量
        /// </summary>
        /// <param name="showStr"></param>
        /// <param name="showList"></param>
        /// <param name="showInt"></param>
        /// <param name="showTable"></param>
        public void ShowVarName(bool showStr, bool showList, bool showInt, bool showTable = false)
        {
            this.showInt = showInt;
            this.showList = showList;
            this.showStr = showStr;
            this.showTable = showTable;
            if (!string.IsNullOrEmpty(this.VarName))
            {
                litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
                litsdk.Variable variable = context.Variables.Find((m) => m.Name == this.VarName);
                if (variable == null) this.VarName = "";
                else
                {
                    switch (variable.VariableType)
                    {
                        case VariableType.String:
                            if (!this.showStr) this.VarName = "";
                            break;
                        case VariableType.Int:
                            if (!this.showInt) this.VarName = "";
                            break;
                        case VariableType.List:
                            if (!this.showList) this.VarName = "";
                            break;
                        case VariableType.Table:
                            if (!this.showTable) this.VarName = "";
                            break;
                    }
                }
            }
        }

        void tsi_Click(object sender, EventArgs e)
        {
            this.tbVarName.Text = ((ToolStripMenuItem)sender).Text;
        }

        private void pbImgPen_Click(object sender, EventArgs e)
        {
            this.cmsShowVarName.Show(this.pbImgPen, new Point(8, 8));
        }

        private void cmsShowVar_Opening(object sender, CancelEventArgs e)
        {
            cmsShowVarName.Items.Clear();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            if (showStr)
            {
                foreach (string n in context.StringKeys) this.addItems(n);
            }
            if (cmsShowVarName.Items.Count > 0 && ((showList && context.ListKeys.Count > 0) || (showInt && context.IntKeys.Count > 0))) cmsShowVarName.Items.Add(new ToolStripSeparator());

            if (showList)
            {
                foreach (string n in context.ListKeys) this.addItems(n);
            }

            if (cmsShowVarName.Items.Count > 0 && cmsShowVarName.Items[cmsShowVarName.Items.Count - 1].GetType() != typeof(ToolStripSeparator) && (showInt && context.IntKeys.Count > 0)) cmsShowVarName.Items.Add(new ToolStripSeparator());

            if (showInt)
            {
                foreach (string n in context.IntKeys) this.addItems(n);
            }

            if (cmsShowVarName.Items.Count > 0 && cmsShowVarName.Items[cmsShowVarName.Items.Count - 1].GetType() != typeof(ToolStripSeparator) && (showTable && context.TableKeys.Count > 0)) cmsShowVarName.Items.Add(new ToolStripSeparator());

            if (showTable)
            {
                foreach (string n in context.TableKeys) this.addItems(n);
            }

            SetEmptyItems(this.cmsShowVarName, this.showStr, this.showList, this.showInt, this.showTable, (b) => this.VarName = b);
        }

        private void addItems(string txt)
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem();
            tsmi.Text = txt;
            tsmi.Click += tsi_Click;
            this.cmsShowVarName.Items.Add(tsmi);
        }


        internal static void SetEmptyItems(ContextMenuStrip cms, bool showStr, bool showList, bool showInt, bool showTable, Action<string> action)
        {
            if (cms.Items.Count > 0) return;
            string txt = "添加变量";

            if (showStr && !showInt && !showList && !showTable)
            {
                txt = "添加字符变量";
            }
            else if (!showStr && showInt && !showList && !showTable)
            {
                txt = "添加数字变量";
            }
            else if (!showStr && !showInt && showList && !showTable)
            {
                txt = "添加列表变量";
            }
            else if (!showStr && !showInt && !showList && showTable)
            {
                txt = "添加表格变量";
            }
            ToolStripMenuItem tsmi = new ToolStripMenuItem() { Text = txt };
            tsmi.Click += (a, b) =>
            {
                List<litsdk.Variable> olds = litsdk.API.GetDesignActivityContext().Variables.ToArray().ToList();
                litsdk.API.ShowVariableForm();
                List<litsdk.Variable> adds = litsdk.API.GetDesignActivityContext().Variables;

                foreach (litsdk.Variable v in adds)
                {
                    if (olds.Find(f => f.Name == v.Name) != null) continue;

                    if (showStr && v.VariableType == VariableType.String)
                    {
                        action(v.Name); break;
                    }
                    else if (showInt && v.VariableType == VariableType.Int)
                    {
                        action(v.Name); break;
                    }
                    else if (showList && v.VariableType == VariableType.List)
                    {
                        action(v.Name); break;
                    }
                    else if (showTable && v.VariableType == VariableType.Table)
                    {
                        action(v.Name); break;
                    }
                }

            };
            cms.Items.Add(tsmi);
        }
    }
}
