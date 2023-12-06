using litsdk;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.activity
{
    [litsdk.ActivityInfo(Name = "表单取值", IsFront = false, IsWinForm = false, Index = 60, IsLinux = true)]
    public class FormActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "表单取值";

        public override ActivityGroup Group => ActivityGroup.Variable;

        public type.FormType FormType = type.FormType.All;

        public string SourceVarName = "";

        public string FormName = "";

        public string TableVarName = "";

        public bool OnlyNameValue = false;

        public bool ClearTable = true;

        public bool RemoveAspNetInput = true;

        public bool RemoveSubmit = true;

        private static List<string> aspnetInput = "__VIEWSTATEENCRYPTED,__EVENTTARGET,__EVENTARGUMENT,__LASTFOCUS,__VIEWSTATE".Split(',').ToList();

        public override void Execute(ActivityContext context)
        {
            string html = context.GetStr(this.SourceVarName);
            System.Data.DataTable table = context.GetTable(this.TableVarName);
            if (this.ClearTable) table.Rows.Clear();
            int oldrow = table.Rows.Count;
            if (string.IsNullOrEmpty(html))
            {
                context.WriteLog("当前源字符为空，直接跳过提取"); return;
            }

            try
            {
                System.Text.RegularExpressions.MatchCollection mc = System.Text.RegularExpressions.Regex.Matches(html, "<([^>]*?)>");
                List<HtmlAttribute> attributes = new List<HtmlAttribute>();
                foreach (System.Text.RegularExpressions.Match m in mc) attributes.Add(new HtmlAttribute(m.Groups[1].Value, m.Groups[0].Value));

                if (!string.IsNullOrEmpty(this.FormName))
                {
                    string formname = context.ReplaceVar(this.FormName);
                    int start = -1, end = -1;
                    for (int i = 0; i < attributes.Count; i++)
                    {
                        if (start == -1)
                        {
                            if (attributes[i].TagName == "form" && attributes[i].GetAttribute("name") == formname) start = i;
                        }
                        else if (end == -1)
                        {
                            if (attributes[i].TagName == "/form") end = i;
                        }
                    }

                    if (start > -1 && end > -1)
                    {
                        attributes = attributes.GetRange(start, end - start);
                    }
                    else
                    {
                        context.WriteLog($"没有找到表单{formname}"); return;
                    }
                }

                if (this.FormType == type.FormType.All || this.FormType == type.FormType.Input)
                {
                    List<string> radios = new List<string>();
                    if (this.OnlyNameValue)
                    {
                        if (!table.Columns.Contains("name")) table.Columns.Add("name");
                        if (!table.Columns.Contains("value")) table.Columns.Add("value");
                    }
                    for (int j = 0; j < attributes.Count; j++)
                    {
                        if (attributes[j].TagName == "input")
                        {
                            string name = attributes[j].GetAttribute("name");
                            if (string.IsNullOrEmpty(name)) continue;
                            if (attributes[j].GetAttribute("type") == "radio")
                            {
                                if (!radios.Contains(name) && !string.IsNullOrEmpty(name))
                                {
                                    string ckd = attributes[j].GetAttribute("checked");
                                    if (ckd == "checked")
                                    {
                                        this.TableAddInPut(table, attributes[j]);
                                        radios.Add(name);
                                    }
                                    else
                                    {
                                        for (int n = j + 1; n < attributes.Count; n++)
                                        {
                                            if (attributes[n].TagName == "input" && attributes[n].GetAttribute("type") == "radio" && attributes[n].GetAttribute("name") == name && attributes[n].GetAttribute("checked") == "checked")
                                            {
                                                this.TableAddInPut(table, attributes[n]);
                                                radios.Add(name);
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            else if (attributes[j].GetAttribute("type") == "checkbox")
                            {
                                if (attributes[j].HasAttribute("checked") && attributes[j].GetAttribute("checked") == "checked")
                                {
                                    attributes[j].SetAttribute("value", "on");
                                    this.TableAddInPut(table, attributes[j]);
                                }
                                else
                                {
                                    attributes[j].SetAttribute("value", "");
                                    this.TableAddInPut(table, attributes[j]);
                                }
                            }
                            else if (attributes[j].GetAttribute("type") == "submit")
                            {
                                if (!this.RemoveSubmit)
                                {
                                    this.TableAddInPut(table, attributes[j]);
                                }
                            }
                            else
                            {
                                if (!this.RemoveAspNetInput || !aspnetInput.Contains(name))
                                {
                                    this.TableAddInPut(table, attributes[j]);
                                }
                            }
                        }
                        else if (this.FormType == type.FormType.All)
                        {
                            if (attributes[j].TagName == "select")
                            {
                                for (int n = j + 1; n < attributes.Count; n++)
                                {
                                    if (attributes[n].TagName == "/select")
                                    {
                                        j = n;
                                        break;
                                    }
                                    else if (attributes[n].TagName == "option")
                                    {
                                        if (attributes[n].HasAttribute("selected") && attributes[n].GetAttribute("selected") == "selected")
                                        {
                                            string value = attributes[n].GetAttribute("value");
                                            attributes[j].SetAttribute("value", value);
                                            this.TableAddInPut(table, attributes[j]);
                                        }
                                    }
                                }
                            }
                            else if (attributes[j].TagName == "textarea")
                            {
                                string name = attributes[j].GetAttribute("name");
                                int pos = html.IndexOf(attributes[j].OriginalHtml);
                                int pos2 = html.IndexOf("</textarea>", pos, StringComparison.OrdinalIgnoreCase);
                                if (pos > -1 && pos2 > -1)
                                {
                                    string txt = html.Substring(pos, pos2 - pos);
                                    txt = txt.Remove(0, attributes[j].OriginalHtml.Length);
                                    attributes[j].SetAttribute("value", txt);
                                    this.TableAddInPut(table, attributes[j]);
                                }

                                for (int n = j + 1; n < attributes.Count; n++)
                                {
                                    if (attributes[n].TagName == "/textarea")
                                    {
                                        j = n;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    //todo
                }
            }
            catch (Exception ex)
            {
                context.WriteLog("表单提取发生错误：" + ex.Message);
            }
            context.WriteLog($"成功添加{table.Rows.Count - oldrow}条记录");
        }

        private void TableAddInPut(System.Data.DataTable table, HtmlAttribute htmlAttribute)
        {
            if (!this.OnlyNameValue)
            {
                if (!table.Columns.Contains("tagname")) table.Columns.Add("tagname");
                foreach (string s in htmlAttribute.Names)
                {
                    if (!table.Columns.Contains(s)) table.Columns.Add(s);
                }
            }
            System.Data.DataRow dr = table.NewRow();
            object[] item = new object[table.Columns.Count];
            for (int i = 0; i < table.Columns.Count; i++)
            {
                item[i] = htmlAttribute.GetAttribute(table.Columns[i].ColumnName);
            }
            dr.ItemArray = item;
            table.Rows.Add(dr);
        }


        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.SourceVarName)) throw new Exception("源字符变量不能为空");
            if (!context.ContainsStr(this.SourceVarName)) throw new Exception($"源字符变量{this.SourceVarName}不存在");

            if (string.IsNullOrEmpty(this.TableVarName)) throw new Exception("表格变量不能为空");
            if (!context.ContainsTable(this.TableVarName)) throw new Exception($"表格变量{this.TableVarName}不存在");
        }

        internal class HtmlAttribute
        {
            private Hashtable Items;
            public List<string> Names;
            public string SourceString;
            public string OriginalHtml;


            public HtmlAttribute(string htmlCode, string originalHtml)
            {
                this.SourceString = htmlCode;
                this.Items = new Hashtable();
                this.Names = new List<string>();
                this.OriginalHtml = originalHtml;
                this.ParSource2();
            }

            public string GetAttribute(string attname)
            {
                attname = attname.ToLower();
                if (this.Items.Contains(attname))
                {
                    return this.Items[attname].ToString();
                }
                return "";
            }

            public void SetAttribute(string attname, string attvalue)
            {
                if (!Items.ContainsKey(attname))
                {
                    Items.Add(attname, attvalue);
                    Names.Add(attname);
                }
                else
                {
                    Items[attname] = attvalue;
                }
            }

            public string TagName
            {
                get
                {
                    if (this.Items.Contains("tagname"))
                    {
                        return this.Items["tagname"].ToString();
                    }
                    return "";
                }
            }

            public bool HasAttribute(string attname)
            {
                return this.Items.Contains(attname);
            }

            protected void ParSource2()
            {
                if (string.IsNullOrEmpty(SourceString))
                {
                    return;
                }
                StringBuilder sbtagName = new StringBuilder();//标签名
                StringBuilder attrName = new StringBuilder();//属性名
                StringBuilder attrValue = new StringBuilder();//属性值

                //state=0,标签名开始；state=1 标签名结束，属性名开始，
                int state = 0;
                //attrstate为属性状态，0为属性名开始；1为属性名结束，
                int attrstate = 0;
                int attrValueState = 0;

                //属性值起始结束字符 ",'
                char attrValueStartChar = char.MinValue;
                for (int i = 0; i < SourceString.Length; i++)
                {
                    char ch = SourceString[i];
                    switch (state)
                    {
                        case 0:
                            switch (ch)
                            {
                                case '!':
                                    return;
                                case ' ':
                                    string tagname = sbtagName.ToString().ToLower().Trim();
                                    if (!Items.ContainsKey("tagname") && tagname.Length > 0)
                                    {
                                        Items.Add("tagname", tagname);
                                        sbtagName.Remove(0, sbtagName.Length);
                                    }
                                    state = 1;
                                    break;
                                default:
                                    sbtagName.Append(ch);
                                    break;
                            }
                            break;
                        case 1:
                            switch (attrstate)
                            {
                                case 0:
                                    if (ch == '=')
                                    {
                                        attrstate = 1;
                                    }
                                    else if (char.IsWhiteSpace(ch))//比如出现了这种恶心的<img alt src="..."
                                    {
                                        attrName.Remove(0, attrName.Length);
                                    }
                                    else
                                    {
                                        attrName.Append(ch);
                                    }
                                    break;
                                case 1:
                                    switch (attrValueState)
                                    {
                                        case 0:
                                            attrValueStartChar = ch;
                                            //有的属性值既不是' 也不是" 开始， http://news.qq.com/a/20120713/001913.htm img的alt
                                            //以空格结尾
                                            if (attrValueStartChar != '\'' && attrValueStartChar != '"')
                                            {
                                                attrValueStartChar = ' ';
                                                attrValue.Append(ch);
                                            }
                                            attrValueState = 1;//属性值开始
                                            break;
                                        case 1:
                                            if (ch == attrValueStartChar) //属性值结束
                                            {
                                                string _attname = attrName.ToString().ToLower().Trim();
                                                if (!Items.ContainsKey(_attname) && _attname.Length > 0)
                                                {
                                                    Items.Add(_attname, attrValue.ToString());
                                                    Names.Add(_attname);
                                                }
                                                attrValue.Remove(0, attrValue.Length);
                                                attrName.Remove(0, attrName.Length);
                                                attrstate = 0;
                                                //if (ch != ' ')
                                                //{
                                                //    state = 0;
                                                //}
                                                attrValueState = 0;
                                                attrValueStartChar = char.MinValue;
                                            }
                                            else
                                            {
                                                if (ch == '\\')//转义
                                                {
                                                    if (i + 1 < SourceString.Length)
                                                    {
                                                        attrValue.Append(SourceString[i + 1]);
                                                        i++;
                                                    }
                                                }
                                                else
                                                {
                                                    attrValue.Append(ch);
                                                }
                                            }
                                            break;
                                    }
                                    break;
                                case 2:
                                    break;
                            }
                            break;

                    }
                }
                string __attname = attrName.ToString().ToLower().Trim();
                if (__attname != "/")
                {
                    if (!Items.ContainsKey(__attname) && __attname.Length > 0)
                    {
                        Items.Add(__attname, attrValue.ToString());
                        Names.Add(__attname);
                    }
                }

                if (!Items.Contains("tagname") && !SourceString.Contains(" ") && !SourceString.Contains("="))
                {
                    Items.Add("tagname", SourceString);
                }
            }
        }
    }
}
