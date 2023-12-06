using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "智能提取", Index = 40, IsLinux = true)]
    /// <summary>
    /// 提取资源，得到网址，自动识别，手动处理，网址补全基准
    /// </summary>
    public class GetResourceActivity : litsdk.ProcessActivity
    {
        private string name = "智能提取";

        /// <summary>
        /// 要提取的变量名称
        /// </summary>
        public string HtmlVarName = "";

        /// <summary>
        /// 要保存到的变量名
        /// </summary>
        public string SaveVarName = "";

        /// <summary>
        /// 必须包含
        /// </summary>
        public List<string> Contains = new List<string>();

        /// <summary>
        /// 不得包含
        /// </summary>
        public List<string> NotContains = new List<string>();

        /// <summary>
        /// 操作的类型
        /// </summary>
        public List<litcore.type.SourceType> SourceTypes = new List<type.SourceType>();

        public override void Execute(ActivityContext context)
        {
            string debug = "";
            //使用<a <img 来进行链接和图片的识别
            string html = context.GetStr(this.HtmlVarName);
            List<string> res = new List<string>();
            if (this.SourceTypes.Contains(type.SourceType.Href))
            {
                res.AddRange(this.Split(html, "<a", "href"));
                res.Remove("javascript:;");
                res.Remove("#");
            }
            if (this.SourceTypes.Contains(type.SourceType.Src))
            {
                res.AddRange(this.Split(html, "<img", "src"));
            }

            int repeat = 0;
            List<string> result = new List<string>();
            int filterNum = 0;

            try
            {
                if (this.SourceTypes.Contains(type.SourceType.Phone))
                {
                    //https://blog.csdn.net/u011415782/article/details/85601655
                    System.Text.RegularExpressions.MatchCollection matchCollection = System.Text.RegularExpressions.Regex.Matches(html, "[1](([3][0-9])|([4][5-9])|([5][0-3,5-9])|([6][5,6])|([7][0-8])|([8][0-9])|([9][1,8,9]))[0-9]{8}");
                    foreach (System.Text.RegularExpressions.Match m in matchCollection) res.Add(m.Groups[0].Value);
                }
                if (this.SourceTypes.Contains(type.SourceType.Email))
                {
                    //https://juejin.im/post/5aa637146fb9a028d663d09d
                    System.Text.RegularExpressions.MatchCollection matchCollection = System.Text.RegularExpressions.Regex.Matches(html, @"([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})");
                    foreach (System.Text.RegularExpressions.Match m in matchCollection) res.Add(m.Groups[0].Value);
                }
                int all = res.Count;
                res = res.Distinct().ToList();
                repeat = all - res.Count;
               
                if (this.Contains.Count == 0 && this.NotContains.Count == 0)
                {
                    result = res;
                }
                else
                {
                    int old = result.Count;
                    FilterUrl(result, res, this.Contains, this.NotContains);
                    filterNum += result.Count - old;
                }
            }
            catch (Exception ex)
            {
                context.WriteLog("发生错误：" + ex.Message);
            }

            context.AddVarListList(this.SaveVarName, result);
            string add = repeat > 0 ? $"(去掉重复{repeat})" : "";
            debug = string.Format("总共提取到资源{0}条{2},过滤{1}条", result.Count, filterNum, add);
            context.WriteLog(debug);
        }

        public static void FilterUrl(List<string> result, List<string> urls, List<string> Contains, List<string> NotContains)
        {
            foreach (string u in urls)
            {
                bool contains = false, notcontains = false;
                if (Contains.Count == 0)
                {
                    contains = true;
                }
                else
                {
                    foreach (string c in Contains)
                    {
                        if (c.Contains("(*)"))
                        {
                            string rstr = regexEncode(c);
                            if (System.Text.RegularExpressions.Regex.IsMatch(u, rstr))
                            {
                                contains = true;
                                break;
                            }
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(c) || u.Contains(c))
                            {
                                contains = true;
                                break;
                            }
                        }
                    }
                }

                notcontains = true;
                if (NotContains.Count > 0)
                {
                    foreach (string n in NotContains)
                    {
                        if (n.Contains("(*)"))
                        {
                            string rstr = regexEncode(n);
                            if (System.Text.RegularExpressions.Regex.IsMatch(u, rstr))
                            {
                                notcontains = false;
                                break;
                            }
                        }
                        else
                        {
                            if (u.Contains(n))
                            {
                                notcontains = false;
                                break;
                            }
                        }
                    }
                }
                if (contains && notcontains) result.Add(u);
            }
        }

        public override void Validate(ActivityContext context)
        {
            if (!context.ContainsStr(this.HtmlVarName))
            {
                throw new Exception("原变量名不存在:" + this.HtmlVarName);
            }
            if (!context.ContainsList(this.SaveVarName))
            {
                throw new Exception("新变量名不存在:" + this.SaveVarName);
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }


        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Variable;

        internal static string regexEncode(string str)
        {
            str = str.Replace(@"\", @"\\");//这个要先替换。。不然出现\又被替换了
            str = str.Replace(@".", @"\.");
            str = str.Replace(@"[", @"\[");
            str = str.Replace(@"]", @"\]");
            str = str.Replace(@"(", @"\(");
            str = str.Replace(@")", @"\)");
            str = str.Replace(@"?", @"\?");
            str = str.Replace(@"+", @"\+");
            str = str.Replace(@"*", @"\*");
            str = str.Replace(@"^", @"\^");
            str = str.Replace(@"{", @"\{");
            str = str.Replace(@"}", @"\}");
            str = str.Replace(@"$", @"\$");
            str = str.Replace(@"|", @"\|");
            str = str.Replace(@"\(\*\)", @"[\s\S]*?");
            return str;
        }
        private List<string> Split(string html, string sign, string att)
        {
            List<string> vs = new List<string>();
            int pos = 0;
            while (true)
            {
                pos = html.IndexOf(sign, pos, StringComparison.OrdinalIgnoreCase);
                if (pos == -1) break;
                int end = html.IndexOf(">", pos, StringComparison.OrdinalIgnoreCase);
                if (end == -1) break;
                string area = html.Substring(pos, end - pos + 1);

                int attpos = area.IndexOf(att, 0, StringComparison.OrdinalIgnoreCase);
                if (attpos > 0) // href="aa" 
                {
                    ///等于号位置
                    int eqpos = area.IndexOf("=", attpos + att.Length, StringComparison.OrdinalIgnoreCase);

                    string find = "";//'"和空，除去空外，第一个要不为单双引号，要不不用的
                    if (eqpos > 0)
                    {
                        string sheng = area.Substring(eqpos + 1, area.Length - eqpos - 1);
                        sheng = sheng.Trim();
                        if (sheng.Length > 0)
                        {
                            char first = sheng[0];
                            if (first.ToString() == "'" || first.ToString() == "\"")
                            {
                                find = first.ToString();
                                sheng = sheng.TrimStart(first);
                            }
                            else//下一个空即为
                            {
                                find = " ";
                            }

                            int fpos = sheng.IndexOf(find, 1);
                            if (fpos > 0)
                            {
                                string hit = sheng.Substring(0, fpos);
                                if (hit.Length > 0) vs.Add(hit);
                            }
                            else
                            {
                                //不带符号 target="_blank" href=/n2967/n2969/n3060/u1ai1930348.html>
                                if (sheng.EndsWith(">") && string.IsNullOrWhiteSpace(find))
                                {
                                    string fk = sheng.TrimEnd('>');
                                    vs.Add(fk);
                                }
                            }
                        }
                    }
                }
                pos = end + 1;
            }
            return vs;
        }
    }
}