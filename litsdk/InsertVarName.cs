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
    /// 向TextBox写入变量名控件
    /// </summary>
    public partial class InsertVarName : UserControl
    {
        private TextBox textBox = null;

        /// <summary>
        /// 右键选择变量控件
        /// </summary>
        public InsertVarName()
        {
            InitializeComponent();
        }

        private bool showStr, showList, showInt;

        /// <summary>
        /// 显示哪些变量
        /// </summary>
        /// <param name="showStr"></param>
        /// <param name="showList"></param>
        /// <param name="showInt"></param>
        /// <param name="tb"></param>
        public void ShowVarName(bool showStr, bool showList, bool showInt, TextBox tb)
        {
            this.showInt = showInt;
            this.showList = showList;
            this.showStr = showStr;
            this.textBox = tb;
        }

        private void pbImgShow_Click(object sender, EventArgs e)
        {
            this.cmsShowVarName.Show(this.pbImgPen, new Point(8, 8));
        }

        private void cmsShowVarName_Opening(object sender, CancelEventArgs e)
        {
            cmsShowVarName.Items.Clear();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            if (showStr)
            {
                foreach (string n in context.StringKeys) this.addactionItems(n);
            }
            if (cmsShowVarName.Items.Count > 0 && ((showList && context.ListKeys.Count > 0) || (showInt && context.IntKeys.Count > 0))) cmsShowVarName.Items.Add(new ToolStripSeparator());

            if (showList)
            {
                foreach (string n in context.ListKeys) this.addactionItems(n);
            }

            if (cmsShowVarName.Items.Count > 0 && cmsShowVarName.Items[cmsShowVarName.Items.Count - 1].GetType() != typeof(ToolStripSeparator) && (showInt && context.IntKeys.Count > 0)) cmsShowVarName.Items.Add(new ToolStripSeparator());

            if (showInt)
            {
                foreach (string n in context.IntKeys) this.addactionItems(n);
            }

            SelectVarName.SetEmptyItems(this.cmsShowVarName, this.showStr, this.showList, this.showInt, false, (b) => InsertTextBox(this.textBox, "{-var." + b + "-}"));
        }

        private void addactionItems(string txt)
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem();
            tsmi.Text = txt;
            tsmi.Click += tsmi_Click;
            this.cmsShowVarName.Items.Add(tsmi);
        }

        void tsmi_Click(object sender, EventArgs e)
        {
            string insert = "{-var." + ((ToolStripMenuItem)sender).Text + "-}";
            InsertTextBox(this.textBox, insert);
        }

        /// <summary>
        /// 将内容插入到指定TextBox光标处
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="text"></param>
        public static void InsertTextBox(System.Windows.Forms.TextBox tb, string text="(*)")
        {
            if (string.IsNullOrEmpty(text)) return;

            int sid = tb.SelectionStart;
            if (sid < 0 || sid > tb.Text.Length) return;

            if (tb.SelectionLength > 0)
            {
                tb.Text = tb.Text.Remove(sid, tb.SelectionLength);
            }

            tb.Text = tb.Text.Insert(sid, text);
            tb.Select(sid, text.Length);
        }
    }
}
