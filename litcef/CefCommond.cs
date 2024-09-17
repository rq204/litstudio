using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "刷新后退", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 52)]
    public class CefCommond : litcore.iecef.Commond
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            switch (this.CmdType)
            {
                case litcore.ictype.CommondType.GoBack:
                    if (Browser_Select.CanGoBack)
                    {
                        Browser_Select.GetBrowser().GoBack();
                        context.WriteLog("浏览器后退成功");
                    }
                    else
                    {
                        context.WriteLog("浏览器当前状态无后退");
                    }
                    break;
                case litcore.ictype.CommondType.GoForward:
                    if (Browser_Select.CanGoForward)
                    {
                        Browser_Select.GetBrowser().GoForward();
                    }
                    else
                    {
                        context.WriteLog("浏览器前进成功");
                    }
                    break;
                case litcore.ictype.CommondType.Reload:
                    Browser_Select.GetBrowser().Reload();
                    context.WriteLog("浏览器开始刷新");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case litcore.ictype.CommondType.Stop:
                    Browser_Select.GetBrowser().StopLoad();
                    context.WriteLog("浏览器停止载入成功");
                    break;
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
