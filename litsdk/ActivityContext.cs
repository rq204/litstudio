using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;

namespace litsdk
{
    /// <summary>
    /// 组件的上下文，包含变量
    /// </summary>
    [Serializable]
    public sealed class ActivityContext
    {
        /// <summary>
        /// 变量集合
        /// </summary>
        public List<Variable> Variables { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Variables"></param>

        public ActivityContext(List<Variable> Variables)
        {
            this.Variables = Variables;
        }

        /// <summary>
        /// 这个是要动态变化的，且是有实例的
        /// </summary>
        public Func<CancellationTokenSource> GetCancellationTokenSource;

        /// <summary>
        /// 发出中断执行的信号
        /// </summary>
        public void ThrowIfCancellationRequested()
        {
            this.GetCancellationTokenSource().Token.ThrowIfCancellationRequested();
        }

        /// <summary>
        /// 最后的错误
        /// </summary>
        public string LastError { get; set; }

        /// <summary>
        /// 变量中是否包含变量名
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <returns>包含为true</returns>
        public bool Contains(string varName)
        {
            return this.Variables.Find((a) => a.Name == varName) != null;
        }

        /// <summary>
        /// 检查是否包含字符串变量
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <returns>包含为true</returns>
        public bool ContainsStr(string varName)
        {
            return this.Variables.Find((a) => a.Name == varName && a.VariableType == VariableType.String) != null;
        }

        /// <summary>
        /// 检查是否包含数字变量
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <returns>包含为true</returns>
        public bool ContainsInt(string varName)
        {
            return this.Variables.Find((a) => a.Name == varName && a.VariableType == VariableType.Int) != null;
        }

        /// <summary>
        /// 检查是否有这个list变量
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <returns>包含为true</returns>
        public bool ContainsList(string varName)
        {
            return this.Variables.Find((a) => a.Name == varName && a.VariableType == VariableType.List) != null;
        }

        /// <summary>
        /// 是否包含表格变量
        /// </summary>
        /// <param name="varName"></param>
        /// <returns></returns>
        public bool ContainsTable(string varName)
        {
            return this.Variables.Find((a) => a.Name == varName && a.VariableType == VariableType.Table) != null;
        }

        /// <summary>
        /// 在fiddler和websocket这类操作中，要锁操作
        /// </summary>
        private static object lstLock = new object();
        /// <summary>
        /// 从变量名得到list变量
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <returns>list变量</returns>
        public List<string> GetList(string varName)
        {
            lock (lstLock)
            {
                Variable varinfo = this.Variables.Find((a) => a.Name == varName && a.VariableType == VariableType.List);
                if (varinfo == null) return new List<string>();
                else
                {
                    return varinfo.ListValue ?? new List<string>();
                }
            }
        }

        /// <summary>
        /// 按变量名得到字符串
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <returns>字符变量值</returns>
        public string GetStr(string varName)
        {
            Variable varinfo = this.Variables.Find((a) => a.Name == varName && a.VariableType == VariableType.String);
            if (varinfo == null) return "";
            else
            {
                return varinfo.StrValue;
            }
        }

        /// <summary>
        /// 按变量名得到数字
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <returns>数字</returns>
        public int GetInt(string varName)
        {
            Variable varinfo = this.Variables.Find((a) => a.Name == varName && a.VariableType == VariableType.Int);
            if (varinfo == null) return 0;
            else
            {
                return varinfo.IntValue;
            }
        }

        /// <summary>
        /// 获取表格
        /// </summary>
        /// <param name="varName"></param>
        /// <returns></returns>
        public System.Data.DataTable GetTable(string varName)
        {
            Variable varinfo = this.Variables.Find((a) => a.Name == varName && a.VariableType == VariableType.Table);
            if (varinfo == null) return null;
            else
            {
                return varinfo.TableValue;
            }
        }

        /// <summary>
        /// 对字符中的变量进行替换
        /// </summary>
        /// <param name="oldStr"></param>
        /// <returns></returns>
        public string ReplaceVar(string oldStr)
        {
            return this.AddSlashReplaceVar(oldStr, null);
        }

        /// <summary>
        /// 在替换变量时，对变量值进行转义
        /// </summary>
        /// <param name="oldStr">原字符</param>
        /// <param name="func">转义方法</param>
        /// <returns></returns>
        public string AddSlashReplaceVar(string oldStr, Func<string, string> func)
        {
            if (oldStr.Contains("{-var."))
            {
                foreach (Variable kv in this.Variables.FindAll((a) => a.VariableType == VariableType.String))
                {
                    string data = kv.StrValue;
                    if (func != null) data = func(data);
                    string key = "{-var." + kv.Name + "-}";
                    if (oldStr.Contains(key))
                    {
                        if (oldStr != "") oldStr = oldStr.Replace(key, data);
                    }
                }
                foreach (Variable kv in this.Variables.FindAll((a) => a.VariableType == VariableType.Int))
                {
                    string data = kv.IntValue.ToString();
                    if (func != null) data = func(data);
                    string key = "{-var." + kv.Name + "-}";
                    if (oldStr.Contains(key))
                    {
                        if (oldStr != "") oldStr = oldStr.Replace(key, data);
                    }
                }
            }
            if (!string.IsNullOrEmpty(oldStr))
            {
                oldStr = oldStr.Replace("[当前目录]", AppDomain.CurrentDomain.BaseDirectory);
                if (oldStr.Contains("[临时文件]"))
                {
                    oldStr = oldStr.Replace("[临时文件]", System.IO.Path.GetTempFileName());
                }
            }
            if (!string.IsNullOrEmpty(oldStr))
            {
                oldStr = oldStr.Replace("[换行]", "\r\n");
            }
            return oldStr;
        }

        /// <summary>
        /// 设置字符串变量值， 要变量名称存在
        /// </summary>
        /// <param name="key">变量名</param>
        /// <param name="value">变量值</param>
        public void SetVarStr(string key, string value)
        {
            Variable varinfo = this.Variables.Find((a) => a.Name == key && a.VariableType == VariableType.String);
            if (varinfo != null)
            {
                varinfo.StrValue = value;
            }
        }

        /// <summary>
        /// 设置数字变量值。要变量名称存在
        /// </summary>
        /// <param name="key">变量名</param>
        /// <param name="value">变量值</param>
        public void SetVarInt(string key, int value)
        {
            Variable varinfo = this.Variables.Find((a) => a.Name == key && a.VariableType == VariableType.Int);
            if (varinfo != null)
            {
                varinfo.IntValue = value;
            }
        }

        /// <summary>
        /// 设置lst变量
        /// </summary>
        /// <param name="key">变量名</param>
        /// <param name="lst">list变量值</param>
        public void SetVarList(string key, List<string> lst)
        {
            lock (lstLock)
            {
                Variable varinfo = this.Variables.Find((a) => a.Name == key && a.VariableType == VariableType.List);
                if (varinfo != null) varinfo.ListValue = lst;
            }
        }

        /// <summary>
        /// 获取表头信息
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<string> GetTableColumns(string key)
        {
            Variable varinfo = this.Variables.Find((a) => a.Name == key && a.VariableType == VariableType.Table);
            if (varinfo != null)
            {
                return varinfo.TableColumns ?? new List<string>();
            }
            else return new List<string>();
        }

        /// <summary>
        /// 添加list值
        /// </summary>
        /// <param name="key">变量名</param>
        /// <param name="lst">List变量值</param>
        public void AddVarListList(string key, List<string> lst)
        {
            lock (lstLock)
            {
                Variable varinfo = this.Variables.Find((a) => a.Name == key && a.VariableType == VariableType.List);
                if (varinfo != null) varinfo.ListValue.AddRange(lst);
            }
        }

        /// <summary>
        /// 添加list值
        /// </summary>
        /// <param name="key">变量名</param>
        /// <param name="txt">List变量值</param>
        public void AddVarListText(string key, string txt)
        {
            lock (lstLock)
            {
                Variable varinfo = this.Variables.Find((a) => a.Name == key && a.VariableType == VariableType.List);
                if (varinfo != null) varinfo.ListValue.Add(txt);
            }
        }

        /// <summary>
        /// 所有字符变量名
        /// </summary>
        public List<string> StringKeys
        {
            get
            {
                List<string> ls = new List<string>();
                foreach (litsdk.Variable v in this.Variables.FindAll((a) => a.VariableType == VariableType.String))
                {
                    ls.Add(v.Name);
                }
                return ls;
            }
        }

        /// <summary>
        /// 所有数字变量名
        /// </summary>
        public List<string> IntKeys
        {
            get
            {
                List<string> ls = new List<string>();
                foreach (litsdk.Variable v in this.Variables.FindAll((a) => a.VariableType == VariableType.Int))
                {
                    ls.Add(v.Name);
                }
                return ls;
            }
        }

        /// <summary>
        /// 所有列表变量名
        /// </summary>
        public List<string> ListKeys
        {
            get
            {
                List<string> ls = new List<string>();
                foreach (litsdk.Variable v in this.Variables.FindAll((a) => a.VariableType == VariableType.List))
                {
                    ls.Add(v.Name);
                }
                return ls;
            }
        }

        /// <summary>
        /// 所有表格变量名
        /// </summary>
        public List<string> TableKeys
        {
            get
            {
                List<string> ls = new List<string>();
                foreach (litsdk.Variable v in this.Variables.FindAll((a) => a.VariableType == VariableType.Table))
                {
                    ls.Add(v.Name);
                }
                return ls;
            }
        }

        /// <summary>
        /// 所有变量名
        /// </summary>
        public List<string> Keys
        {
            get
            {
                List<string> ls = new List<string>();
                foreach (litsdk.Variable v in this.Variables)
                {
                    ls.Add(v.Name);
                }
                return ls;
            }
        }

        /// <summary>
        /// 按key移除变量
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            Variable variable = Variables.Find((a) => a.Name == key);
            if (variable != null) this.Variables.Remove(variable);
        }

        /// <summary>
        /// 清除变量值
        /// </summary>
        /// <param name="key"></param>
        public void Clear(string key)
        {
            Variable variable = Variables.Find((a) => a.Name == key);
            if (variable != null)
            {
                switch (variable.VariableType)
                {
                    case VariableType.Int:
                        variable.IntValue = 0;
                        break;
                    case VariableType.List:
                        variable.ListValue.Clear();
                        break;
                    case VariableType.String:
                        variable.StrValue = "";
                        break;
                    case VariableType.Table:
                        variable.TableValue.Rows.Clear();
                        break;
                }
            }
        }

        /// <summary>
        /// 初始化变量
        /// </summary>
        public void InitVariable()
        {
            //字符和数字以及列表进行初始化
            foreach (Variable v in this.Variables)
            {
                switch (v.VariableType)
                {
                    case VariableType.String:
                        if (v.InitStrValue == null) v.InitStrValue = "";
                        v.StrValue = v.InitStrValue;
                        break;
                    case VariableType.Int:
                        v.IntValue = v.InitIntValue; ;
                        break;
                    case VariableType.List:
                        if (v.InitListValue == null) v.InitListValue = new List<string>();
                        v.ListValue = v.InitListValue.ToArray().ToList();
                        break;
                    case VariableType.Table:
                        if (v.TableColumns == null) v.TableColumns = new List<string>();
                        if (v.InitTableValue != null) v.TableValue = v.InitTableValue.Copy();
                        else v.TableValue = new System.Data.DataTable();

                        foreach (string name in v.TableColumns)
                        {
                            if (!v.TableValue.Columns.Contains(name))
                            {
                                DataColumn dc = new DataColumn() { ColumnName = name };
                                v.TableValue.Columns.Add(dc);
                            }
                        }

                        break;
                }
            }
        }

        /// <summary>
        /// 从当前流程获取指定键值的变量
        /// </summary>
        public Func<string, object> GetUserConfig;

        /// <summary>
        /// 设置指定键值的值
        /// </summary>
        public Action<string, object> SetUserConfig;

        /// <summary>
        /// 从当前流程执行一个完整的project,是否只显示自定义日志
        /// </summary>
        public Action<string, bool> RunProject;

        /// <summary>
        /// 执行加密的组件
        /// </summary>
        public Action<string> RunProtectProject;

        /// <summary>
        /// 写日志
        /// </summary>
        public Action<string> WriteLog;

        /// <summary>
        /// 最后的附加的活动
        /// </summary>
        public Action OnEnd;
    }
}