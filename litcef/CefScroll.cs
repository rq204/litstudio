using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "滚动条移动", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 48)]
    public class CefScroll : litcore.iecef.Scroll
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            switch (this.ScrollType)
            {
                case litcore.ictype.ScrollType.Top:
                    Browser_Select.GetBrowser().MainFrame.ExecuteJavaScriptAsync("window.scrollTo(0,0)");
                    context.WriteLog($"滚动条移至顶端成功");
                    break;
                case litcore.ictype.ScrollType.Botton:
                    Browser_Select.GetBrowser().MainFrame.ExecuteJavaScriptAsync("window.scrollTo(0,document.body.scrollHeight)");
                    context.WriteLog($"滚动条移至底部成功");
                    break;
                case litcore.ictype.ScrollType.DownBy:
                case litcore.ictype.ScrollType.UpBy:
                    string num = context.ReplaceVar(this.ScrollBy);
                    int inum = 0;
                    if (int.TryParse(num, out inum))
                    {
                        if (this.ScrollType == litcore.ictype.ScrollType.UpBy) inum = 0 - inum;
                        Browser_Select.GetBrowser().MainFrame.ExecuteJavaScriptAsync($"window.scrollBy(0,{inum})");

                        if (this.ScrollType == litcore.ictype.ScrollType.DownBy)
                        {
                            context.WriteLog($"滚动条向下{num}像素滚动成功");
                        }
                        else
                        {
                            context.WriteLog($"滚动条向上{num}像素滚动成功");
                        }
                    }
                    else
                    {
                        throw new Exception($"需要滚动的像素数错误{num}");
                    }
                    break;
                case litcore.ictype.ScrollType.Xpath:
                    string xpahtstr = context.ReplaceVar(this.XpathStr).Trim();
                    if (xpahtstr == "")
                    {
                        throw new Exception("xpath为空请检查");
                    }
                    List<string> xpaths = xpahtstr.Replace("\r", "").Split('\n').ToList();
                    string js = litcore.iecef.XPath.CefScrollIntoViewByXPathJs(xpaths, false);
                    Browser_Select.GetBrowser().MainFrame.ExecuteJavaScriptAsync(js);
                    break;

            }
            System.Threading.Thread.Sleep(300);
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