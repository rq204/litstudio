using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class PageInfo : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "页面信息";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        /// <summary>
        /// 源代码
        /// </summary>
        public string HtmlVarName = "";

        /// <summary>
        /// 标题
        /// </summary>
        public string TitleVarName = "";

        /// <summary>
        /// 网址
        /// </summary>
        public string UrlVarName = "";

        /// <summary>
        /// 图片链接
        /// </summary>
        public string ImagesVarName = "";

        /// <summary>
        /// A链接
        /// </summary>
        public string HrefsVarName = "";


        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (!string.IsNullOrEmpty(this.HtmlVarName) && !context.ContainsStr(this.HtmlVarName)) throw new Exception("保存源代码变量类型不是字符");
            if (!string.IsNullOrEmpty(this.TitleVarName) && !context.ContainsStr(this.TitleVarName)) throw new Exception("保存标题变量类型不是字符");
            if (!string.IsNullOrEmpty(this.UrlVarName) && !context.ContainsStr(this.UrlVarName)) throw new Exception("保存网址变量类型不是字符");
            //if (!string.IsNullOrEmpty(this.RefererVarName) && !context.ContainsStr(this.RefererVarName)) throw new Exception("保存来源网址变量类型不是字符");
            if (!string.IsNullOrEmpty(this.ImagesVarName) && !context.ContainsList(this.ImagesVarName)) throw new Exception("保存图片链接变量类型不是列表");
            if (!string.IsNullOrEmpty(this.HrefsVarName) && !context.ContainsList(this.HrefsVarName)) throw new Exception("保存网址链接变量类型不是列表");
        }


        /// <summary>
        /// 补全网址
        /// </summary>
        /// <param name="lst"></param>
        /// <param name="fullurl"></param>
        /// <returns></returns>
        public static List<string> FillUrl(List<string> lst, string fullurl)
        {
            string httpors = fullurl.Split(':')[0];
            Uri uri = new Uri(fullurl);
            List<string> fills = new List<string>();
            foreach (string s in lst)
            {
                if (s == null || s.Length < 2) continue;
                if (s.StartsWith("javascript", StringComparison.OrdinalIgnoreCase)) continue;
                if (s.StartsWith("#", StringComparison.OrdinalIgnoreCase)) continue;
                if (s.StartsWith("data:", StringComparison.OrdinalIgnoreCase)) continue;
                if (s.StartsWith("mailto:", StringComparison.OrdinalIgnoreCase)) continue;

                if (!s.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    string ok = "";
                    if (s.StartsWith("//")) ok = httpors + s;
                    else
                    {
                        if (s.StartsWith("/")) ok = httpors + ":" + uri.Host + s;
                        else
                        {
                            List<string> arr = uri.AbsolutePath.Split('/').ToList();
                            if (arr[arr.Count - 1] != "") arr.RemoveAt(arr.Count - 1);
                            ok = httpors + ":" + string.Join("/", arr.ToArray()) + s;
                        }
                    }
                }
                else
                {
                    fills.Add(s);
                }
            }
            fills = fills.Distinct().ToList();
            return fills;
        }

        public override void Execute(ActivityContext context)
        {
          
        }
        //img src
        //        var str = " \n";
        //        var list = document.getElementsByTagName("a");
        //for(var i=0; i<list.length; i++){
        //   str += list[i].href + ' \n';
        //};
        //    console.log(str);
    }
}
