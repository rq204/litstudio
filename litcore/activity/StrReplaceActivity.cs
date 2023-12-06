using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "字符替换",Index = 8, IsLinux = true)]
    public class StrReplaceActivity : litsdk.ProcessActivity
    {

        private string name = "字符替换";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Variable;

        /// <summary>
        /// 原字符
        /// </summary>
        public string OldStr = "";

        /// <summary>
        /// 替换的新字符
        /// </summary>
        public string NewStr = "";

        /// <summary>
        /// 是否正则替换
        /// </summary>
        public bool IsRegex = false;

        /// <summary>
        /// 字符变量
        /// </summary>
        public string StrVarName = "";

        /// <summary>
        /// 保存至变量
        /// </summary>
        public string StrSaveVarName = "";

        public override void Execute(ActivityContext context)
        {
            string oldstr = context.ReplaceVar(this.OldStr);
            string newstr = context.ReplaceVar(this.NewStr);
            if (string.IsNullOrEmpty(oldstr))
            {
                context.WriteLog("原替换字符为空，跳过替换");
                return;
            }

            try
            {

                if (context.ContainsStr(this.StrSaveVarName))
                {
                    string text = context.GetStr(this.StrVarName);
                    if (string.IsNullOrEmpty(oldstr))
                    {
                        context.WriteLog("原字符为空，跳过替换");
                        return;
                    }
                    string re = "";
                    if (this.IsRegex)
                    {
                        re = System.Text.RegularExpressions.Regex.Replace(text, oldstr, newstr);
                    }
                    else
                    {
                        re = text.Replace(oldstr, newstr);
                    }
                    context.SetVarStr(this.StrSaveVarName, re);
                    context.WriteLog($"原字符长度{text.Length}替换后长度{re.Length}");
                }
                else
                {
                    List<string> oldlist = context.GetList(this.StrVarName);
                    List<string> addlist = new List<string>();
                    foreach (string text in oldlist)
                    {
                        string text2 = text;
                        try
                        {
                            if (!string.IsNullOrEmpty(oldstr))
                            {
                                if (this.IsRegex)
                                {
                                    text2 = System.Text.RegularExpressions.Regex.Replace(text2, oldstr, newstr);
                                }
                                else
                                {
                                    text2 = text2.Replace(oldstr, newstr);
                                }
                            }
                        }
                        catch { }
                        addlist.Add(text2);
                    }
                    context.SetVarList(this.StrSaveVarName, addlist);
                    context.WriteLog($"原列表变量 {this.StrVarName} 长度 {oldlist.Count} 替换并保存为变量{this.StrSaveVarName}");
                }
            }
            catch (Exception ex)
            {
                context.WriteLog($"字符替换出错：{ex.Message}");
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (context.ContainsStr(this.StrVarName))
            {
                if (!context.ContainsStr(this.StrSaveVarName)) throw new Exception($"不存在字符变量 {this.StrSaveVarName}");
            }
            else if (context.ContainsList(this.StrVarName))
            {
                if (!context.ContainsList(this.StrSaveVarName)) throw new Exception($"不存在列表变量 {this.StrSaveVarName}");
            }
            else
            {
                throw new Exception($"不存在字符变量或列表变量 {this.StrVarName}");
            }

            if (string.IsNullOrEmpty(this.OldStr)) throw new Exception("原替换字符不得为空");
        }
    }
}
