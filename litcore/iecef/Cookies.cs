using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    /// <summary>
    /// Cookie操作
    /// </summary>
    public class Cookies : ProcessActivity
    {
        public override string Name { get; set; } = "Cookie操作";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        /// 操作类型
        /// </summary>
        public ictype.CookieType CookieType = ictype.CookieType.ExportFile;

        /// <summary>
        /// 文件地址
        /// </summary>
        public string FilePath = "";

        /// <summary>
        /// 导出到变量的保存
        /// </summary>
        public string SaveVarName = "";

        /// <summary>
        /// 只提取某个域名下cookie
        /// </summary>
        public string ExportHost = "";

        public override void Validate(ActivityContext context)
        {
            if (CookieType == ictype.CookieType.ExportFile || CookieType == ictype.CookieType.ImportFile)
            {
                if (string.IsNullOrEmpty(this.FilePath)) throw new Exception("文件地址不能为空");
            }
            else if (string.IsNullOrEmpty(this.SaveVarName) && this.CookieType != ictype.CookieType.ClearUrl && this.CookieType != ictype.CookieType.ClearAll && this.CookieType != ictype.CookieType.ClearOther)
            {
                throw new Exception("变量名称不能为空");
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Execute(ActivityContext context)
        {

        }


        public static List<System.Net.Cookie> Parse(string cookiestr, string url)
        {
            List<Cookie> lcs = new List<Cookie>();
            if (cookiestr.Contains('\t'))
            {
                string[] lines = cookiestr.Trim().Replace("\r", "").Split('\n');
                foreach (string l in lines)
                {
                    if (l.StartsWith("#")) continue;
                    string[] arr = l.Split('\t');
                    if (arr.Length == 7)
                    {
                        try
                        {
                            //$"{c.Domain}   {c.HttpOnly}    {c.Path}    {c.Secure}  {c.Expires} {c.Name}    {c.Value}
                            Cookie add = new Cookie
                            {
                                Domain = arr[0],
                                HttpOnly = bool.Parse(arr[1]),
                                Path = arr[2],
                                Secure = bool.Parse(arr[3]),
                                Name = arr[5],
                                Value = arr[6],
                                Expires = litcore.activity.TimeActivity.FromTimeStamp10(arr[4])
                            };
                            lcs.Add(add);
                        }
                        catch { }
                    }
                }
            }
            else
            {
                foreach (string c in cookiestr.Split(';'))
                {
                    string[] item = c.Split('=');
                    if (item.Length == 2)
                    {
                        Cookie add2 = new Cookie()
                        {
                            Domain = new Uri(url).Host,
                            Name = item[0],
                            Value = item[1],
                            Secure = url.Contains("https"),
                            Expires = DateTime.MaxValue
                        };
                        lcs.Add(add2);
                    }
                }
            }
            return lcs;
        }

        /// <summary>
        /// mb浏览器设置cookie的方式
        /// </summary>
        /// <param name="cookie"></param>
        /// <returns></returns>
        public static string ToMbString(System.Net.Cookie cookie)
        {
            string a = $"{cookie.Name}={cookie.Value}; expires={cookie.Expires.ToUniversalTime().ToString("r")}; path={cookie.Path}; domain={cookie.Domain}";
            if (cookie.Secure) a += "; secure";
            if (cookie.HttpOnly) a += "; httponly";
            return a;
        }
    }
}
