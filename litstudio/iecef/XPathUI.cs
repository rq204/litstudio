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

namespace litstudio.iecef
{
    internal partial class XPathUI : litsdk.ILitUI
    {
        public XPathUI()
        {
            InitializeComponent();
            this.svRWVarName.ShowVarName(true, true, true);
            this.ivXPath.ShowVarName(true, false, true, this.tbXPathStr);

            this.SaveActivity = new Action(() =>
              {
                  xp.XPathStr = this.tbXPathStr.Text.Trim();
                  if (this.rbClick.Checked) xp.XPathType = litcore.ictype.XPathType.Click;
                  else if (this.rbGet.Checked) xp.XPathType = litcore.ictype.XPathType.Get;
                  else if (this.rbSet.Checked) xp.XPathType = litcore.ictype.XPathType.Set;
                  xp.Attribute = this.cbAttribute.Text;
                  xp.RWVarName = this.svRWVarName.VarName;
                  xp.Sleep = (int)this.nudSleep.Value;
                  xp.Name = this.tbActivityName.Text;
                  xp.FrameName = this.tbFrameName.Text.Trim();
              });
            litsdk.API.SetXPath = new Action<string,List<string>>(this.SetXPath);
        }

        private void SetXPath(string frameName,List<string> ls)
        {
            if (this.IsDisposed || this.Disposing) return;
            this.Invoke((EventHandler)delegate
            {
                this.tbXPathStr.Text = string.Join("\r\n", ls.ToArray());
                this.tbFrameName.Text = frameName;
            });
        }

        litcore.iecef.XPath xp = null;


        public override void SetActivity(Activity activity)
        {
            xp = activity as litcore.iecef.XPath;
            this.tbXPathStr.Text = xp.XPathStr;
            switch (xp.XPathType)
            {
                case litcore.ictype.XPathType.Click:
                    this.rbClick.Checked = true;
                    break;
                case litcore.ictype.XPathType.Get:
                    this.rbGet.Checked = true;
                    break;
                case litcore.ictype.XPathType.Set:
                    this.rbSet.Checked = true;
                    break;
            }
            if (!this.cbAttribute.Items.Contains(xp.Attribute))
            {
                this.cbAttribute.Items.Add(xp.Attribute);
            }
            this.cbAttribute.Text = xp.Attribute;
            this.svRWVarName.VarName = xp.RWVarName;
            this.nudSleep.Value = xp.Sleep;
            this.tbActivityName.Text = xp.Name;
            this.tbFrameName.Text = xp.FrameName;

            if (this.xp.GetType().FullName == "litchrome.ChrXPath") this.lbNotice.Text = "使用SendKeys方式进行点击和写操作";
        }


        private string lastAttName, lastClickName;

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            this.lbRWName.Visible = this.svRWVarName.Visible = !this.rbClick.Checked;
            if (this.rbClick.Checked)
            {
                this.lbAttName.Text = "点击方式";
                this.lastAttName = this.cbAttribute.Text;

                this.cbAttribute.Items.Clear();
                this.cbAttribute.Items.AddRange(new object[] { "click", "focus", "blur", "select" });

                if (!string.IsNullOrEmpty(lastClickName))
                {
                    if (!this.cbAttribute.Items.Contains(this.lastClickName))
                    {
                        this.cbAttribute.Items.Add(this.lastClickName);
                    }
                    this.cbAttribute.Text = this.lastClickName;
                }
                else this.cbAttribute.SelectedIndex = 0;
            }
            else
            {
                bool lastclick = this.lbAttName.Text == "点击方式";

                this.lbAttName.Text = "属性名称";
                if (this.rbGet.Checked)
                {
                    this.lbRWName.Text = "取值存入";
                }
                else if (this.rbSet.Checked)
                {
                    this.lbRWName.Text = "取值写入";
                }

                this.cbAttribute.Items.Clear();
                this.cbAttribute.Items.AddRange(new object[] { "value", "href", "src", "innerHTML", "innerText", "textContent", "outerText", "outerHTML", "name", "id", "height", "width", "alt" });

                if (lastclick) this.lastClickName = this.cbAttribute.Text;

                if (!string.IsNullOrEmpty(lastAttName))
                {
                    if (!this.cbAttribute.Items.Contains(this.lastAttName))
                    {
                        this.cbAttribute.Items.Add(this.lastAttName);
                    }
                    this.cbAttribute.Text = this.lastAttName;
                }
                else this.cbAttribute.SelectedIndex = 0;
            }
        }

        //private void pbPen_MouseDown(object sender, MouseEventArgs e)
        //{
        //    tmXPath.Enabled = true;
        //    this.Cursor = this.moveCursor;
        //}

        //private static object lkxpath = new object();
        //private Action<List<string>> setxpath = null;
        //private void tmXPath_Tick(object sender, EventArgs e)
        //{
        //    lock (lkxpath)
        //    {
        //        if (litsdk.API.SelectXPath == null) return;
        //        litsdk.API.SelectXPath(this.setxpath);
        //    }
        //}

        //private void pbPen_MouseUp(object sender, MouseEventArgs e)
        //{
        //    tmXPath.Enabled = false;
        //    this.Cursor = Cursors.Default;
        //    litsdk.API.StopXPath();
        //}
    }
}
