
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "清空重置",Index = 12, IsLinux = true)]
    /// <summary>
    /// 变量重置
    /// </summary>
    public class ReSetVarActivity : litsdk.ProcessActivity
    {
        /// <summary>
        /// 变量类型
        /// </summary>

        public VariableType VariableType =  VariableType.String;

        /// <summary>
        /// 保存到变量名
        /// </summary>

        public string SaveVarName = "";

        /// <summary>
        /// 要设置的值，可以有多行
        /// </summary>

        public string SetVarValue = "";

        /// <summary>
        /// 要清空的变量值
        /// </summary>
        public List<string> EmptyVarNames = new List<string>();

        /// <summary>
        /// 先对其中的变量进行替换，然后，如果是列表，则按一行一个，转换成列表
        /// </summary>
        /// <param name="varInfo"></param>
        public override void Execute(ActivityContext context)
        {
            string msg = "";
            if (!string.IsNullOrEmpty(this.SaveVarName))
            {
                string data = context.ReplaceVar(this.SetVarValue);
                switch (this.VariableType)
                {
                    case VariableType.String:
                        context.SetVarStr(this.SaveVarName, data);
                        msg = string.Format("成功重设字符变量{0}，长度为{1}", this.SaveVarName, data.Length);
                        break;
                    case VariableType.List:
                        List<string> lst = new List<string>();
                        if (!string.IsNullOrWhiteSpace(data))
                        {
                            lst = System.Text.RegularExpressions.Regex.Split(data, @"\r\n").ToList();
                        }
                        context.SetVarList(this.SaveVarName, lst);
                        msg = string.Format("成功重设列表变量{0}为{1}个", this.SaveVarName, lst.Count);
                        break;
                    case VariableType.Int:
                        int shuzi = -1;
                        if (int.TryParse(data, out shuzi))
                        {
                            context.SetVarInt(this.SaveVarName, shuzi);
                            msg = string.Format("成功重设数字变量{0}为{1}", this.SaveVarName, shuzi);
                        }
                        else
                        {
                            throw new Exception($"转化成数字时失败,原值为{data}");
                        }
                        break;
                }
            }
            if (this.EmptyVarNames.Count > 0)
            {
                foreach (string n in this.EmptyVarNames)
                {
                    if (context.ContainsStr(n)) context.SetVarStr(n, "");
                    else if (context.ContainsInt(n)) context.SetVarInt(n, 0);
                    else if (context.ContainsList(n)) context.SetVarList(n, new List<string>());
                    else if (context.ContainsTable(n))
                    {
                        System.Data.DataTable table = context.Variables.Find((f) => f.Name == n).TableValue;
                        if (table != null)
                        {
                            if (table.Rows.Count > 0) table.Rows.Clear();
                        }
                        else
                        {
                            table = new System.Data.DataTable();
                        }
                        List<string> cols = context.Variables.Find((f) => f.Name == n).TableColumns;
                        foreach(string c in cols)
                        {
                            if (!table.Columns.Contains(c)) table.Columns.Add(c);
                        }
                   
                            List<string> rms = new List<string>();
                            foreach(System.Data.DataColumn dc in table.Columns)
                            {
                                if (!cols.Contains(dc.ColumnName)) rms.Add(dc.ColumnName);
                            }
                            foreach (string r in rms) table.Columns.Remove(r);
                    
                    }
                }
                msg += $"，成功清空变量{string.Join("、", this.EmptyVarNames.ToArray())}";
                msg = msg.TrimStart('，');
            }
            context.WriteLog(msg);
        }

        public override void Validate(ActivityContext context)
        {
            if (this.EmptyVarNames.Count == 0 && string.IsNullOrEmpty(this.SaveVarName)) throw new Exception("重置变量参数不能全为空");
            if (!string.IsNullOrEmpty(this.SaveVarName))
            {
                if (!context.Contains(this.SaveVarName))
                {
                    throw new Exception(string.Format("变量{0}不存在", this.SaveVarName));
                }
                switch (this.VariableType)
                {
                    case VariableType.String:
                        if (!context.ContainsStr(this.SaveVarName)) throw new Exception("不存在字符变量：" + this.SaveVarName);
                        break;
                    case VariableType.Int:
                        if (!context.ContainsInt(this.SaveVarName)) throw new Exception("不存在数字变量：" + this.SaveVarName);
                        break;
                    case VariableType.List:
                        if (!context.ContainsList(this.SaveVarName)) throw new Exception("不存在列表变量：" + this.SaveVarName);
                        break;
                }
            }
            foreach (string s in this.EmptyVarNames)
            {
                if (!context.Contains(s)) throw new Exception("不存在的变量名" + s);
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override string Name { get; set; } = "清空重置";

        public override ActivityGroup Group =>  ActivityGroup.Variable;
    }
}