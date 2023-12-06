using litsdk;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(Name = "页面信息", IsFront = false, IsWinForm = true, RefFile = ChrLoad.RefFile, Index = 28)]
    public class ChrPageInfo : litcore.iecef.PageInfo
    {
        public override void Execute(ActivityContext context)
        {
            ChrLoad.LoadChromeSetting(context);
            string rnd = litcore.iecef.XPath.GetRnd();

            if (!string.IsNullOrEmpty(this.HtmlVarName))
            {
                //https://www.cnblogs.com/pu369/p/12390920.html 涉及了多框架
                string html = ChrLoad.Driver.PageSource;

                try
                {
                    var byTagNames = ChrLoad.Driver.FindElements(By.TagName("iframe"));
                    foreach (OpenQA.Selenium.IWebElement ele in byTagNames)
                    {
                        ChrLoad.Driver.SwitchTo().Frame(ele);
                        html += ChrLoad.Driver.PageSource;
                    }
                }
                catch { }
                finally
                {
                    ChrLoad.Driver.SwitchTo().DefaultContent();
                }
                context.SetVarStr(this.HtmlVarName, html);
            }
            if (!string.IsNullOrEmpty(this.UrlVarName))
            {
                context.SetVarStr(this.UrlVarName, ChrLoad.Driver.Url);
            }
            if (!string.IsNullOrEmpty(this.TitleVarName))
            {
                string title = "";
                try
                {
                    title = ChrLoad.Driver.Title;
                }
                catch { }
                context.SetVarStr(this.TitleVarName, title);
            }
            if (!string.IsNullOrEmpty(this.ImagesVarName))
            {
                List<string> imgs = new List<string>();
                var obja = ChrLoad.Driver.ExecuteScript($"var litdatas{rnd}=[];var col{rnd}=document.getElementsByTagName('img');for(var l=0;l<col{rnd}.length;l++){{litdatas{rnd}.push(col{rnd}[l].getAttribute('src'));}}return JSON.stringify(litdatas{rnd});");
                if (obja != null)
                {
                    List<string> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(obja.ToString());
                    imgs = litcore.iecef.PageInfo.FillUrl(lst, ChrLoad.Driver.Url);
                }
                context.SetVarList(this.ImagesVarName, imgs);
            }

            if (!string.IsNullOrEmpty(this.HrefsVarName))
            {
                List<string> urls = new List<string>();

                var obja = ChrLoad.Driver.ExecuteScript($"var litdatas{rnd}=[];var col{rnd}=document.getElementsByTagName('a');for(var l=0;l<col{rnd}.length;l++){{litdatas{rnd}.push(col{rnd}[l].getAttribute('href'));}} return JSON.stringify(litdatas{rnd});");
                if (obja != null)
                {
                    List<string> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(obja.ToString());
                    urls = litcore.iecef.PageInfo.FillUrl(lst, ChrLoad.Driver.Url);
                }
                context.SetVarList(this.HrefsVarName, urls);
            }

            context.WriteLog($"获取页面信息成功");
        }

        public override void Validate(ActivityContext context)
        {
            base.Validate(context);
        }

        public override void ShowConfig()
        {
            base.ShowConfig();
        }

        public override ActivityGroup Group => ActivityGroup.Chrome;
    }
}