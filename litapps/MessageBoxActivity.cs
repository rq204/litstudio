using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litapps
{
    [litsdk.ActivityInfo(Name = "确认取消弹窗", IsFront = true, IsWinForm = true)]
    /// <summary>
    /// 确认取消
    /// </summary>
    public class MessageBoxActivity : litsdk.DecisionActivity
    {
        public override string Name { get; set; } = "确认取消弹窗";

        public override ActivityGroup Group => ActivityGroup.Other;

        /// <summary>
        /// 弹窗内容
        /// </summary>
        public string Text = "";

        /// <summary>
        /// 弹窗标题
        /// </summary>
        public string Caption = "";

        public MessageBoxType MessageBoxType = MessageBoxType.Information;

        /// <summary>
        /// 超时时间
        /// </summary>
        public int TimeOutSenconds = 0;

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool EndDialog(IntPtr hDlg, out IntPtr nResult);

        private string Result = null;
        public override bool Execute(ActivityContext context)
        {
            string txt = context.ReplaceVar(Text).Trim();
            string caption = context.ReplaceVar(this.Caption).Trim();
            System.Windows.Forms.MessageBoxIcon icon = MessageBoxIcon.Information;
            switch (this.MessageBoxType)
            {
                case MessageBoxType.Warning:
                    icon = MessageBoxIcon.Warning;
                    break;
                case MessageBoxType.Error:
                    icon = MessageBoxIcon.Error;
                    break;
            }

            System.Threading.Thread thread = null;
            if (this.TimeOutSenconds > 0)
            {
                this.Result = null;
                thread = new System.Threading.Thread(() =>
             {
                 litsdk.API.GetMainForm().Invoke((EventHandler)delegate
                 {
                     DialogResult dr = System.Windows.Forms.MessageBox.Show(txt, caption, System.Windows.Forms.MessageBoxButtons.OKCancel, icon);
                     this.Result = dr == DialogResult.OK ? "true" : "false";
                 });
             });
                thread.Start();
                System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
                while (this.Result == null)
                {
                    if (stopwatch.ElapsedMilliseconds > this.TimeOutSenconds * 1000)//超时了
                    {
                        IntPtr dlg = FindWindow(null, caption);

                        if (dlg != IntPtr.Zero)
                        {
                            IntPtr result;
                            EndDialog(dlg, out result);
                            this.Result = "false";
                        }
                        break;
                    }
                    System.Threading.Thread.Sleep(300);
                }
                stopwatch.Stop();
                return Convert.ToBoolean(this.Result);
            }
            else
            {
                DialogResult dr = System.Windows.Forms.MessageBox.Show(txt, caption, System.Windows.Forms.MessageBoxButtons.OKCancel, icon);
                return dr == DialogResult.OK;
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new MessageBoxUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.Text)) throw new Exception("提示内容不能为空");
            if (string.IsNullOrEmpty(this.Caption)) throw new Exception("提示标题不能为空");
        }
    }
}
