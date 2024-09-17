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
    [litsdk.ActivityInfo(Name = "Cookie操作", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 40)]
    public class CefCookies : litcore.iecef.Cookies
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            DateTime dt1970 = TimeZoneInfo.ConvertTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0), TimeZoneInfo.Local);

            if (this.CookieType == litcore.ictype.CookieType.ExportFile || this.CookieType == litcore.ictype.CookieType.ExportVar || this.CookieType == litcore.ictype.CookieType.ExportAbVar)
            {
                var cookieManager = CefSharp.Cef.GetGlobalCookieManager();

                CefCookieVisitor.Cookies.Clear();

                cookieManager.VisitAllCookies(new CefCookieVisitor());//.VisitUrlCookiesAsync(Browser_Select.Address, true).Result;//.VisitAllCookies(visitor);
                System.Threading.Thread.Sleep(100);

                List<CefSharp.Cookie> cks = CefCookieVisitor.Cookies.ToArray().ToList();
                string cookiestr = "";
                if (this.CookieType == litcore.ictype.CookieType.ExportAbVar)
                {
                    foreach (CefSharp.Cookie c in cks)
                    {
                        if (!string.IsNullOrEmpty(this.ExportHost) && !c.Domain.ToLower().Contains(ExportHost.ToLower())) continue;
                        if (c == null || string.IsNullOrEmpty(c.Name)) continue;
                        cookiestr += $"{c.Name}={c.Value};";
                    }
                }
                else
                {
                    foreach (CefSharp.Cookie c in cks)
                    {
                        if (!string.IsNullOrEmpty(ExportHost) && !c.Domain.ToLower().Contains(ExportHost.ToLower())) continue;
                        DateTime exp = DateTime.MaxValue;
                        if (c.Expires != null) exp = Convert.ToDateTime(c.Expires);
                        string r10 = litcore.activity.TimeActivity.ToTimeStamp10(exp);
                        ///http://httrack.kauler.com/help/Cookies
                        cookiestr += $"{c.Domain}\t{c.HttpOnly}\t{c.Path}\t{c.Secure}\t{r10}\t{c.Name}\t{c.Value}\r\n";
                    }
                }
                if (this.CookieType == litcore.ictype.CookieType.ExportFile)
                {
                    string path = context.ReplaceVar(this.FilePath);
                    string dir = System.IO.Path.GetDirectoryName(path);
                    if (!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);
                    System.IO.File.WriteAllText(path, cookiestr, System.Text.Encoding.UTF8);
                    context.WriteLog("Cookie写入文件成功：" + path);
                }
                else
                {
                    context.SetVarStr(this.SaveVarName, cookiestr);
                    context.WriteLog($"Cookie存入变量{this.SaveVarName}成功");
                }
            }
            else if (this.CookieType == litcore.ictype.CookieType.ClearUrl)
            {
                var cookieManager = CefSharp.Cef.GetGlobalCookieManager();
                cookieManager.DeleteCookies(new Uri(Browser_Select.Address).Host);
                context.WriteLog("当前域名Cookie清除成功：" + Browser_Select.Address);
            }
            else if (this.CookieType == litcore.ictype.CookieType.ClearAll)
            {
                var cookieManager = CefSharp.Cef.GetGlobalCookieManager();
                cookieManager.DeleteCookies();
                context.WriteLog("所有Cookie清除成功");
            }
            else if (this.CookieType == litcore.ictype.CookieType.ClearOther)
            {
                var cookieManager = CefSharp.Cef.GetGlobalCookieManager();
                int ct = 0;
                List<CefSharp.Cookie> cks = cookieManager.VisitUrlCookiesAsync(Browser_Select.Address, true).Result;
                foreach (CefSharp.Cookie c in cks)
                {
                    if (!Browser_Select.Address.Contains(c.Domain))
                    {
                        cookieManager.DeleteCookies(c.Domain); ct++;
                    }
                }
                context.WriteLog($"非当前域名Cookie清除成功{ct}个：" + Browser_Select.Address);
            }
            else
            {
                string slog = "";
                string cookiestr = "";
                if (this.CookieType == litcore.ictype.CookieType.ImportFile)
                {
                    string path = context.ReplaceVar(this.FilePath);
                    cookiestr = System.IO.File.ReadAllText(path, System.Text.Encoding.UTF8);
                    slog = $"从文件导入Cookie成功：{path}";
                }
                else
                {
                    cookiestr = context.GetStr(this.SaveVarName);
                    slog = $"从变量{this.SaveVarName}导入Cookie成功";
                }

                var cookieManager = CefSharp.Cef.GetGlobalCookieManager();
                List<System.Net.Cookie> netcookies = litcore.iecef.Cookies.Parse(cookiestr, Browser_Select.Address);

                int addnum = 0;
                foreach (System.Net.Cookie ckk in netcookies)
                {
                    CefSharp.Cookie add = new Cookie
                    {
                        Domain = ckk.Domain,
                        HttpOnly = ckk.HttpOnly,
                        Path = ckk.Path,
                        Secure = ckk.Secure,
                        Name = ckk.Name,
                        Value = ckk.Value,
                        Expires = ckk.Expires
                    };
                    string url = add.Secure ? "https" : "http";
                    url += "://" + add.Domain.Trim('.') + add.Path;
                    cookieManager.SetCookieAsync(url, add);
                    addnum++;
                }
                slog += $"，共计{addnum}个";
                context.WriteLog(slog);
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

    public class CefCookieVisitor : ICookieVisitor
    {
        public static List<CefSharp.Cookie> Cookies = new List<Cookie>();
        public void Dispose()
        {

        }

        public bool Visit(Cookie cookie, int count, int total, ref bool deleteCookie)
        {
            Cookies.Add(cookie);
            return true;
        }
    } 
}