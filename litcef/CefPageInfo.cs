using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "页面信息", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 28)]
    public class CefPageInfo : litcore.iecef.PageInfo
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            string rnd = litcore.iecef.XPath.GetRnd();
            if (!string.IsNullOrEmpty(this.HtmlVarName))
            {
                string html = Browser_Select.GetBrowser().MainFrame.GetSourceAsync().Result;

                try
                {
                    foreach (string name in Browser_Select.GetBrowser().GetFrameNames())
                    {
                        CefSharp.IFrame frame = Browser_Select.GetBrowser().GetFrame(name);
                        if (!frame.IsMain)
                        {
                            string fhtml = frame.GetSourceAsync().Result;
                            html += fhtml;
                        }
                    }
                }
                catch { }
                context.SetVarStr(this.HtmlVarName, html);
            }
            if (!string.IsNullOrEmpty(this.UrlVarName))
            {
                context.SetVarStr(this.UrlVarName, Browser_Select.Address);
            }
            if (!string.IsNullOrEmpty(this.TitleVarName))
            {
                string title = "";
                try
                {
                    title = Browser_Select.GetBrowser().MainFrame.EvaluateScriptAsync("document.title").Result.Result.ToString();
                }
                catch { }
                context.SetVarStr(this.TitleVarName, title);
            }
            if (!string.IsNullOrEmpty(this.ImagesVarName))
            {
                List<string> imgs = new List<string>();
                var obja = Browser_Select.GetBrowser().MainFrame.EvaluateScriptAsync($"var litdatas{rnd}=[];var col{rnd}=document.getElementsByTagName('img');for(var l=0;l<col{rnd}.length;l++){{litdatas{rnd}.push(col{rnd}[l].getAttribute('src'));}}JSON.stringify(litdatas{rnd});").Result.Result;
                if (obja != null)
                {
                    List<string> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(obja.ToString());
                    imgs = litcore.iecef.PageInfo.FillUrl(lst, Browser_Select.Address);
                }
                context.SetVarList(this.ImagesVarName, imgs);
            }

            if (!string.IsNullOrEmpty(this.HrefsVarName))
            {
                List<string> urls = new List<string>();

                var obja = Browser_Select.GetBrowser().MainFrame.EvaluateScriptAsync($"var litdatas{rnd}=[];var col{rnd}=document.getElementsByTagName('a');for(var l=0;l<col{rnd}.length;l++){{litdatas{rnd}.push(col{rnd}[l].getAttribute('href'));}}JSON.stringify(litdatas{rnd});").Result.Result;
                if (obja != null)
                {
                    List<string> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(obja.ToString());
                    urls = litcore.iecef.PageInfo.FillUrl(lst, Browser_Select.Address);
                }
                context.SetVarList(this.HrefsVarName, urls);
            }

            context.WriteLog($"获取页面信息成功");
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