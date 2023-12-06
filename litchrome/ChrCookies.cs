using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(Name = "Cookie操作", IsFront = false, IsWinForm = true, RefFile = ChrLoad.RefFile, Index = 40)]
    public class ChrCookies : litcore.iecef.Cookies
    {
        public override void Execute(ActivityContext context)
        {
            ChrLoad.LoadChromeSetting(context);

            OpenQA.Selenium.ICookieJar cookieJar = ChrLoad.Driver.Manage().Cookies;
            DateTime dt1970 = TimeZoneInfo.ConvertTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0), TimeZoneInfo.Local);

            if (this.CookieType == litcore.ictype.CookieType.ExportFile || this.CookieType == litcore.ictype.CookieType.ExportVar || this.CookieType == litcore.ictype.CookieType.ExportAbVar)
            {
                string cookiestr = "";
                if (this.CookieType == litcore.ictype.CookieType.ExportAbVar)
                {
                    foreach (OpenQA.Selenium.Cookie c in cookieJar.AllCookies)
                    {
                        if (c == null || string.IsNullOrEmpty(c.Name)) continue;
                        cookiestr += $"{c.Name}={c.Value};";
                    }
                }
                else
                {
                    foreach (OpenQA.Selenium.Cookie c in cookieJar.AllCookies)
                    {
                        DateTime exp = DateTime.MaxValue;
                        if (c.Expiry != null) exp = Convert.ToDateTime(c.Expiry);
                        string r10 = litcore.activity.TimeActivity.ToTimeStamp10(exp);
                        ///http://httrack.kauler.com/help/Cookies
                        cookiestr += $"{c.Domain}\t{c.IsHttpOnly}\t{c.Path}\t{c.Secure}\t{r10}\t{c.Name}\t{c.Value}\r\n";
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
                if (string.IsNullOrEmpty(ChrLoad.Driver.Url))
                {
                    context.WriteLog($"当前没打开网页或指定网页，不做Cookie清除");
                }
                else
                {
                    string domain = new Uri(ChrLoad.Driver.Url).Host;
                    List<OpenQA.Selenium.Cookie> deletes = new List<OpenQA.Selenium.Cookie>();
                    foreach (OpenQA.Selenium.Cookie cookie in cookieJar.AllCookies)
                    {
                        if (cookie.Domain == domain) deletes.Add(cookie);
                    }
                    foreach (OpenQA.Selenium.Cookie ck in deletes) cookieJar.DeleteCookie(ck);

                    context.WriteLog($"当前域名Cookie清除成功：{ domain}，总计{deletes.Count}个");
                }
            }
            else if (this.CookieType == litcore.ictype.CookieType.ClearAll)
            {
                cookieJar.DeleteAllCookies();
            }
            else if (this.CookieType == litcore.ictype.CookieType.ClearOther)
            {
                if (string.IsNullOrEmpty(ChrLoad.Driver.Url))
                {
                    context.WriteLog($"当前没打开网页或指定网页，不做Cookie清除");
                }
                else
                {
                    string domain = new Uri(ChrLoad.Driver.Url).Host;
                    List<OpenQA.Selenium.Cookie> deletes = new List<OpenQA.Selenium.Cookie>();
                    foreach (OpenQA.Selenium.Cookie cookie in cookieJar.AllCookies)
                    {
                        if (cookie.Domain != domain) deletes.Add(cookie);
                    }
                    foreach (OpenQA.Selenium.Cookie ck in deletes) cookieJar.DeleteCookie(ck);

                    context.WriteLog($"非当前域名Cookie清除成功：{ domain}，总计{deletes.Count}个");
                }
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

                List<System.Net.Cookie> netcookies = litcore.iecef.Cookies.Parse(cookiestr, ChrLoad.Driver.Url);

                int addnum = 0;
                foreach (System.Net.Cookie ckk in netcookies)
                {
                    OpenQA.Selenium.Cookie add = new OpenQA.Selenium.Cookie(ckk.Name, ckk.Value, ckk.Domain, ckk.Path, ckk.Expires, ckk.Secure, ckk.HttpOnly, "");
                    cookieJar.AddCookie(add);
                    addnum++;
                }
                slog += $"，共计{addnum}个";
                context.WriteLog(slog);
            }
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