using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "点击上传", Index = 50)]
    public class CefClickUpload : litcore.iecef.ClickUpload
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            string xpahtstr = context.ReplaceVar(this.XPathStr).Trim();
            if (xpahtstr == "")
            {
                throw new Exception("xpath为空请检查");
            }
            List<string> xpaths = xpahtstr.Replace("\r", "").Split('\n').ToList();

            string frameName = context.ReplaceVar(this.FrameName);
            CefSharp.IFrame frame = CefLoad.GetIframe(Browser_Select, frameName);
            if (frame == null) throw new Exception("不存在框架:" + frame);

            List<string> uploads = new List<string>();

            if (context.ContainsStr(this.FileVarName))
            {
                uploads.Add(context.GetStr(this.FileVarName));
            }
            else
            {
                uploads = context.GetList(this.FileVarName);
            }

            DialogHandler uploader = CefLoad.CefUI_Select.dialoger;
            uploader.UploadFiles = uploads;
            uploader.WriteLog = context.WriteLog;
            uploader.Complate = false;

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            try
            {
                //先将整个界面显示出来，再将控件显示出来，再鼠标点击
                bool oldhide = false;

                Form f = CefLoad.CefUI_Select.browser.FindForm();// litsdk.API.GetTabForm();
                System.Drawing.Point oldloc = f.Location;

                //原来是隐藏的话先显示
                if (oldloc.X > Screen.PrimaryScreen.Bounds.Width)
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
                    oldhide = true;
                }

                //显示可见
                string js = litcore.iecef.XPath.CefScrollIntoViewByXPathJs(xpaths, false);
                Browser_Select.GetBrowser().MainFrame.ExecuteJavaScriptAsync(js);

                //寻找位置
                string jsstr = litcore.iecef.XPath.CefClickPositionByXPathJs(xpaths);
                object objclick = frame.EvaluateScriptAsync(jsstr).Result.Result;

                if (objclick != null)
                {
                    System.Dynamic.ExpandoObject dynamicObject = objclick as System.Dynamic.ExpandoObject;
                    IDictionary<string, object> dic = dynamicObject;
                    int x = Convert.ToInt32(dic["x"]);
                    int y = Convert.ToInt32(dic["y"]);

                    var host = Browser_Select.GetBrowser().GetHost();
                    host.SendMouseClickEvent(new CefSharp.MouseEvent(x, y, CefSharp.CefEventFlags.None), CefSharp.MouseButtonType.Left, false, 1);
                    host.SendMouseClickEvent(new CefSharp.MouseEvent(x, y, CefSharp.CefEventFlags.None), CefSharp.MouseButtonType.Left, true, 1);
                    context.WriteLog($"成功点击上传元素坐标位置于X{x} Y{y}");

                    sw.Restart();
                    while (!uploader.Complate)
                    {
                        System.Threading.Thread.Sleep(100);
                        System.Windows.Forms.Application.DoEvents();
                        context.ThrowIfCancellationRequested();
                        if (sw.ElapsedMilliseconds > 6000) throw new Exception("文件选择6秒超时");
                    }
                }
                else
                {
                    throw new Exception("没有找到元素位置");
                }
                if (oldhide)
                {
                    f.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width * 3, 0);
                    f.Width = Screen.PrimaryScreen.Bounds.Width;
                    f.Height = Screen.PrimaryScreen.Bounds.Height;
                }
            }
            finally
            {
                CefLoad.CefUI_Select.dialoger.WriteLog = null;
                CefLoad.CefUI_Select.dialoger.UploadFiles = null;
                sw.Stop();
            }
        }

        public override void Validate(ActivityContext context)
        {
            if (!CefLoad.cefLoad.IsValueCreated && litsdk.API.GetMainForm != null) CefLoad.cefLoad.Value.InitializeCef();
            base.Validate(context);
        }

        public override void ShowConfig()
        {
            if (!CefLoad.cefLoad.IsValueCreated) CefLoad.cefLoad.Value.InitializeCef();
            base.ShowConfig();
        }

        public override ActivityGroup Group => ActivityGroup.CefBroswer;
    }
}
