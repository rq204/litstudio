using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "窗口控制", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 32)]
    public sealed class CefFormState : litcore.iecef.FormState
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            litsdk.API.GetMainForm().Invoke((EventHandler)delegate
            {
                while (!CefLoad.CefUI_Select.browser.IsBrowserInitialized)
                {
                    System.Threading.Thread.Sleep(100);
                    Application.DoEvents();
                }
                Form f = CefLoad.CefUI_Select.browser.FindForm();// litsdk.API.GetTabForm();
                if (Show)
                {
                    Control c = CefLoad.CefUI_Select.browser.Parent.Parent;
                    if (c is TabPage tp)
                    {
                        if (tp.Parent is TabControl tc)
                        {
                            tc.SelectedTab = tp;
                        }
                    }
                    f.Location = new System.Drawing.Point(0, 0);
                    f.Width = Screen.PrimaryScreen.Bounds.Width;
                    f.Height = Screen.PrimaryScreen.Bounds.Height;
                    f.ShowInTaskbar = true;
                    context.WriteLog("浏览器窗口成功显示");
                }
                else
                {
                    f.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width * 3, 0);
                    f.Width = Screen.PrimaryScreen.Bounds.Width;
                    f.Height = Screen.PrimaryScreen.Bounds.Height;
                    f.ShowInTaskbar = false;
                    context.WriteLog("浏览器窗口成功隐藏");
                }
            });
        }

        public override ActivityGroup Group => ActivityGroup.CefBroswer;
    }
}