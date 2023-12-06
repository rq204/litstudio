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
    /// 多个变量选择控件
    /// </summary>
    public partial class SelectMultVarName : UserControl
    {
        /// <summary>
        /// 同时选择多个变量
        /// </summary>
        public SelectMultVarName()
        {
            InitializeComponent();
            this.tsmiClear.Click += TsmiClear_Click;
            this.tsmiClearNot.Click += TsmiClearNot_Click;
        }

        private void TsmiClearNot_Click(object sender, EventArgs e)
        {
            if (this.tbVarName.Text == "") return;
            List<string> ls = this.tbVarName.Text.Split(',').ToList();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            foreach (string s in ls.ToArray())
            {
                if (!context.Contains(s)) ls.Remove(s);
            }
            this.tbVarName.Text = string.Join(",", ls.ToArray());
        }

        private void TsmiClear_Click(object sender, EventArgs e)
        {
            this.tbVarName.Clear();
        }

        private bool showStr = true, showList = true, showInt = true, showTable = false;

        /// <summary>
        /// 显示哪些变量
        /// </summary>
        /// <param name="showStr"></param>
        /// <param name="showList"></param>
        /// <param name="showInt"></param>
        /// <param name="showTable"></param>
        public void ShowVarName(bool showStr, bool showList, bool showInt,bool showTable=false)
        {
            this.showInt = showInt;
            this.showList = showList;
            this.showStr = showStr;
            this.showTable = showTable;
        }

        void tsi_Click(object sender, EventArgs e)
        {
            List<string> old = this.VarNames;
            ToolStripMenuItem toolStrip = (ToolStripMenuItem)sender;
            string txt = toolStrip.Text;
            if(toolStrip.Checked)
            {
                old.Remove(txt);
                toolStrip.Checked = false;
            }
            else
            {
                old.Add(txt);
                toolStrip.Checked = true;
            }
            this.tbVarName.Text = string.Join(",", old);
        }

        private void pbImgPen_Click(object sender, EventArgs e)
        {
            this.cmsShowVarName.Show(this.pbImgPen, new Point(8, 8));
        }

        private void cmsShowVar_Opening(object sender, CancelEventArgs e)
        {
            List<string> old = this.VarNames;
            cmsShowVarName.Items.Clear();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            List<string> adds = new List<string>();
            if (this.showStr) adds.AddRange(context.StringKeys.ToArray());
            if (this.showList) adds.AddRange(context.ListKeys.ToArray());
            if (this.showInt) adds.AddRange(context.IntKeys.ToArray());
            if (this.showTable) adds.AddRange(context.TableKeys.ToArray());
            foreach (string n in adds) this.addItems(n, old);

            SelectVarName.SetEmptyItems(this.cmsShowVarName, this.showStr, this.showList, this.showInt, this.showTable, (b) => { if (this.tbVarName.Text == "") this.tbVarName.Text = b; });
        }

        private void addItems(string txt,List<string> old)
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem();
            tsmi.Text = txt;
            tsmi.Click += tsi_Click;
            if (old.Contains(txt)) tsmi.Checked = true;
            this.cmsShowVarName.Items.Add(tsmi);
        }
    }
}
