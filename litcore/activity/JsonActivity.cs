using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;
using Newtonsoft.Json.Linq;

namespace litcore.activity
{
    [ActivityInfo(Name = "Json解析",Index = 32, IsLinux = true)]
    /// <summary>
    /// newtonsoft.json默认支持jsonpath,
    /// https://goessner.net/articles/JsonPath/
    /// </summary>
    public class JsonActivity : litsdk.ProcessActivity
    {
        private string name = "Json解析";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Variable;

        public override void Execute(ActivityContext context)
        {
            string source = context.GetStr(this.SourceVarName);

            ///先将字符和数字变量设置为空
            foreach (KeyValuePair<string, string> kv in this.VarNameJsonPaths)
            {
                if (context.ContainsStr(kv.Key))
                {
                    context.SetVarStr(kv.Key, "");
                }
                else if (context.ContainsInt(kv.Key))
                {
                    context.SetVarInt(kv.Key, 0);
                }
            }

            if (string.IsNullOrEmpty(source))
            {
                context.WriteLog("变量值为空，提取Json值全为空");
                return;
            }

            Newtonsoft.Json.Linq.JObject jsonObj = null;
            Newtonsoft.Json.Linq.JArray jsonArr = null;

            try
            {
                if (source.StartsWith("{"))
                {
                    jsonObj = JObject.Parse(source);
                }
                else
                {
                    jsonArr = JArray.Parse(source);
                }
            }
            catch
            {
                context.WriteLog("变量值非Json解析失败，提取Json值全为空");
                return;
            }
            // var books = jObj.SelectToken("$.store.book[?(@.category=='reference')]");
            //jsonArr.SelectTokens("");
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> kv in this.VarNameJsonPaths)
            {
                try
                {
                    string xpath = context.ReplaceVar(kv.Value);
                    List<JToken> tokens = new List<JToken>();
                    if (jsonObj != null)
                    {
                        tokens = jsonObj.SelectTokens(xpath).ToList();
                    }
                    else
                    {
                        tokens = jsonArr.SelectTokens(xpath).ToList();
                    }

                    if (context.ContainsStr(kv.Key))
                    {
                        if (tokens.Count > 0)
                        {
                            foreach (JToken jt in tokens)
                            {
                                string onestr = jt.ToString();
                                context.SetVarStr(kv.Key, onestr);
                                sb.Append($"{kv.Key}长度{onestr.Length},");
                                break;
                            }
                        }
                        else
                        {
                            sb.Append($"{kv.Key}长度没有找到匹配的节点{xpath},");
                        }
                    }
                    else if (context.ContainsList(kv.Key))
                    {
                        if (tokens.Count > 0)
                        {
                            foreach (JToken token in tokens)
                            {
                                string add = token.ToString();
                                context.AddVarListText(kv.Key, add);
                            }
                            sb.Append($"{kv.Key}个数{tokens.Count},");
                        }
                        else
                        {
                            sb.Append($"{kv.Key}没有找到匹配的节点{xpath},");
                        }
                    }
                    else if (context.ContainsInt(kv.Key))
                    {
                        if (tokens.Count > 0)
                        {
                            foreach (JToken jToken in tokens)
                            {
                                int it = Convert.ToInt32(jToken.ToString());
                                context.SetVarInt(kv.Key, it);
                                sb.Append($"{kv.Key}的值{it},");
                                break;
                            }
                        }
                        else
                        {
                            sb.Append($"{kv.Key}没有找到匹配的节点{xpath},");
                        }
                    }
                    else if (context.ContainsTable(kv.Key))
                    {
                        System.Data.DataTable dataTable = context.GetTable(kv.Key);

                        if (tokens.Count > 0)
                        {
                            List<JObject> jolist = new List<JObject>();

                            foreach (JToken jToken in tokens)
                            {
                                if (jToken is JObject jo)
                                {
                                    jolist.Add(jo);
                                    foreach (JProperty jp in jo.Properties())
                                    {
                                        if (!dataTable.Columns.Contains(jp.Name)) dataTable.Columns.Add(jp.Name);
                                    }
                                }
                            }

                            foreach (JObject jo in jolist)
                            {
                                System.Data.DataRow dr = dataTable.NewRow();
                                foreach (JProperty jpp in jo.Properties())
                                {
                                    dr[jpp.Name] = jpp.Value.ToString();
                                }
                                dataTable.Rows.Add(dr);
                            }
                            context.Variables.Find((f) => f.Name == kv.Key).TableValue = dataTable;
                            sb.Append($"{kv.Key}增加表格数据记录{jolist.Count}条,");
                        }
                        else
                        {
                            sb.Append($"{kv.Key}没有找到匹配的节点{xpath},");
                        }
                    }
                }
                catch (Exception ex)
                {
                    context.WriteLog($"{kv.Key}提取json出错:{ex.Message}");
                }
            }

            context.WriteLog("json解析完成：" + sb.ToString().Trim(',')); return;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.SourceVarName)) throw new Exception("源字符变量名不能为空");
            if (!context.ContainsStr(this.SourceVarName)) throw new Exception("不存在字符变量：" + this.SourceVarName);
            if (VarNameJsonPaths.Count == 0) throw new Exception("jsonpath设置不能为空");
            foreach (KeyValuePair<string, string> kv in VarNameJsonPaths)
            {
                if (!context.Contains(kv.Key)) throw new Exception("不存在变量名：" + kv.Key);
            }
        }

        /// <summary>
        /// 获取的字符
        /// </summary>
        public string SourceVarName = "";

        /// <summary>
        /// 名称和 jsonpath
        /// </summary>
        public Dictionary<string, string> VarNameJsonPaths = new Dictionary<string, string>();
    }
}
