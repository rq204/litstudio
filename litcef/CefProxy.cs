using CefSharp;
using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "设置代理", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 56)]
    public class CefProxy : litcore.iecef.Proxy
    {
        /// <summary>
        /// https://github.com/cefsharp/CefSharp/issues/1813
        /// </summary>
        /// <param name="context"></param>
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            string proxystr = context.ReplaceVar(this.ProxySetting);
            Cef.UIThreadTaskFactory.StartNew(delegate
            {
                var rc = Browser_Select.GetBrowser().GetHost().RequestContext;
                var v = new Dictionary<string, object>();
                v["mode"] = "fixed_servers";
                v["server"] = proxystr;//"socks5://127.0.0.1:9190";
                string error;
                bool success = rc.SetPreference("proxy", v, out error);
                if (success)
                {
                    if (!string.IsNullOrEmpty(proxystr))
                    {
                        context.WriteLog("成功设置代理：" + proxystr);
                    }
                    else
                    {
                        context.WriteLog("成功取消代理");
                    }
                }
            });
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