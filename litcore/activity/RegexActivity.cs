using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using litsdk;

namespace litcore.activity
{
    /// <summary>
    /// 使用正则时，可以保存至表格变量
    /// </summary>
    [ActivityInfo(Name = "正则提取", Index = 4, IsLinux = true)]
    public class RegexActivity : litsdk.ProcessActivity
    {
        private string name = "正则提取";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Variable;

        //public string CutStartString = "";

        //public string CutEndString = "";

        public string RegexString = "";

        public string StrVarName = "";

        public string SaveVarName = "";

        /// <summary>
        /// 去html
        /// </summary>
        public bool TrimHtml = false;

        /// <summary>
        /// 去空白
        /// </summary>
        public bool TrimBlank = false;

        /// <summary>
        /// 去两端空白
        /// </summary>
        public bool Trim = false;

        /// <summary>
        /// 提取多条记录
        /// </summary>
        public bool CollectList = false;

        public override void Execute(ActivityContext context)
        {
            string html = context.GetStr(this.StrVarName);
            if (html == "")
            {
                context.WriteLog($"等处理数据为空，跳过提取");
                if (context.ContainsStr(this.SaveVarName))
                {
                    context.SetVarStr(this.SaveVarName, "");
                }
                return;
            }
            string re = "";
            string regexStr = context.ReplaceVar(this.RegexString);

            try
            {
                if (context.ContainsTable(this.SaveVarName))//表格变量的处理
                {
                    System.Data.DataTable table = context.GetTable(this.SaveVarName);
                    int oldrows = table.Rows.Count;
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(regexStr);
                    if (this.CollectList)
                    {
                        System.Text.RegularExpressions.MatchCollection mc = regex.Matches(html);

                        foreach (System.Text.RegularExpressions.Match mm in mc)
                        {
                            this.AddTable(table, regex, mm);
                        }

                        context.WriteLog($"获取到数据{table.Rows.Count - oldrows}条,表格总共数据{table.Rows.Count}条");
                    }
                    else
                    {
                        System.Text.RegularExpressions.Match m = regex.Match(html);
                        if (m.Success)
                        {
                            this.AddTable(table, regex, m);
                            context.WriteLog($"本次提取数据成功,表格总共数据{table.Rows.Count}条");
                        }
                        else
                        {
                            context.WriteLog($"本次没有提取到数据");
                        }
                    }
                }
                else
                {
                    if (this.CollectList)
                    {
                        List<string> ls = new List<string>();

                        System.Text.RegularExpressions.MatchCollection mc = System.Text.RegularExpressions.Regex.Matches(html, regexStr);
                        foreach (System.Text.RegularExpressions.Match mm in mc) ls.Add(strtrim(mm.Groups["data"].Value));

                        context.WriteLog($"获取到数据{ls.Count}条");
                        context.AddVarListList(this.SaveVarName, ls);
                    }
                    else
                    {
                        System.Text.RegularExpressions.Match m = System.Text.RegularExpressions.Regex.Match(html, regexStr);
                        if (m.Success) re = m.Groups["data"].Value;
                        else re = "";
                        re = strtrim(re);

                        if (context.ContainsStr(this.SaveVarName))
                        {
                            context.SetVarStr(this.SaveVarName, re);
                            if (re.Length > 20)
                            {
                                context.WriteLog($"本次提取到数据长度{re.Length}");
                            }
                            else
                            {
                                context.WriteLog($"本次提取到数据：{re}");
                            }
                        }
                        else if (context.ContainsInt(this.SaveVarName))
                        {
                            int t = 0;
                            if (int.TryParse(re, out t))
                            {
                                context.SetVarInt(this.SaveVarName, t);
                                context.WriteLog($"本次提取到数字{t}");
                            }
                            else
                            {
                                context.SetVarInt(this.SaveVarName, 0);
                                context.WriteLog($"本次提取到结果非数字，默认为0");
                            }
                        }
                        else
                        {
                            context.AddVarListText(this.SaveVarName, re);
                            context.WriteLog($"本次提取到数据长度{re.Length}并添加至列表变量");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                context.WriteLog($"正则提取出错：" + ex.Message);
            }
        }

        private void AddTable(System.Data.DataTable table, System.Text.RegularExpressions.Regex regex, System.Text.RegularExpressions.Match mm)
        {
            List<string> gs = regex.GetGroupNames().ToList();
            gs.Remove("0");
            foreach (string g in gs)
            {
                if (!table.Columns.Contains(g)) table.Columns.Add(g);
            }
            System.Data.DataRow dr = table.NewRow();
            object[] vs = new object[table.Columns.Count];
            for (int i = 0; i < table.Columns.Count; i++)
            {
                object obj = gs.Contains(table.Columns[i].ColumnName) ? strtrim(mm.Groups[table.Columns[i].ColumnName].Value) : "";
                vs[i] = obj;
            }
            dr.ItemArray = vs;
            table.Rows.Add(dr);
        }

        private string strtrim(string txt)
        {
            if (txt != "" && this.TrimHtml) txt = System.Text.RegularExpressions.Regex.Replace(txt, "<[^>]*?>", "");
            if (txt != "" && this.TrimBlank) txt = System.Text.RegularExpressions.Regex.Replace(txt, "\\s", "");
            if (txt != "" && this.Trim) txt = txt.Trim();
            return txt;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (!context.ContainsStr(this.StrVarName)) throw new Exception($"不存在提取变量 {this.StrVarName}");

            if (!context.ContainsStr(this.SaveVarName) && !context.ContainsList(this.SaveVarName) && !context.ContainsTable(this.SaveVarName) && !context.ContainsInt(this.SaveVarName)) throw new Exception($"不存在变量{this.SaveVarName}");

            if (!context.ContainsTable(this.SaveVarName) && !this.RegexString.Contains("(?<data>"))
            {
                throw new Exception("正则表达式内容不包含(?<data>");
            }

            if (this.CollectList && !context.ContainsList(this.SaveVarName) && !context.ContainsTable(this.SaveVarName)) throw new Exception("提取多条记录时要保存至列表或表格变量");
        }
    }
}