using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using litcore.type;
using litsdk;
using Newtonsoft.Json.Linq;

namespace litcore.activity
{
    [ActivityInfo(Name = "变量互转",Index = 28, IsLinux = true)]
    /// <summary>
    /// 变量转化,字符串变数字
    /// </summary>
    public class ConvertActivity : litsdk.ProcessActivity
    {
        /// <summary>
        /// 转化类型
        /// </summary>
        public ConvertType ConvertType = ConvertType.StrToInt;

        /// <summary>
        /// 转化失败后扔异常
        /// </summary>
        /// <param name="varInfo"></param>
        public override void Execute(ActivityContext context)
        {
            string msg = "";
            try
            {
                switch (this.ConvertType)
                {
                    case ConvertType.StrAddToList:
                        string old = context.GetStr(this.VarNameA);
                        context.AddVarListText(this.VarNameB, old);
                        msg = string.Format("成功将字符变量{0}添加至List变量{1}", this.VarNameA, this.VarNameB);
                        break;
                    case ConvertType.StrToInt:
                        int re;
                        string old2 = context.GetStr(this.VarNameA);
                        if (int.TryParse(old2, out re))
                        {
                            context.SetVarInt(this.VarNameB, re);
                            msg = string.Format("成功将字符变量{0}转换至数字变量{1}：{2}", this.VarNameA, this.VarNameB, re);
                        }
                        else
                        {
                            msg = string.Format("将字符变量{0}转换至数字变量{1}失败，原值：{2}", this.VarNameA, this.VarNameB, old2);
                            context.WriteLog(msg);
                            throw new Exception(msg);
                        }
                        break;
                    case ConvertType.ListJoinToStr:
                        List<string> ls = context.GetList(this.VarNameA);
                        string joincode = context.ReplaceVar(this.JoinStr);
                        context.SetVarStr(this.VarNameB, string.Join(joincode, ls.ToArray()));
                        msg = string.Format("将列表变量{0}转换至字符变量{1}成功，原列表长度{2}", this.VarNameA, this.VarNameB, ls.Count);
                        break;
                    case ConvertType.StrLenghToInt:
                        string old3 = context.GetStr(this.VarNameA);
                        context.SetVarInt(this.VarNameB, old3.Length);
                        msg = string.Format("字符变量{0}长度转到数字变量{1}成功，长度{2}", this.VarNameA, this.VarNameB, old3.Length);
                        break;
                    case ConvertType.ListCountToInt:
                        int l34 = context.GetList(this.VarNameA).Count;
                        context.SetVarInt(this.VarNameB, l34);
                        msg = string.Format("列表变量{0}长度转到数字变量{1}成功，值{2}", this.VarNameA, this.VarNameB, l34);
                        break;
                    case ConvertType.CopyListToList:
                        List<string> lsA = context.GetList(this.VarNameA).ToArray().ToList();
                        context.AddVarListList(this.VarNameB, lsA);
                        msg = string.Format("列表变量{0}添加到列表变量{1}成功", this.VarNameA, this.VarNameB);
                        break;
                    case ConvertType.TableAToJsonB:
                        System.Data.DataTable table = context.GetTable(this.VarNameA);
                        string json = Newtonsoft.Json.JsonConvert.SerializeObject(table);
                        context.SetVarStr(this.VarNameB, json);
                        msg = string.Format("表格变量{0}转化为Json字符{1}成功", this.VarNameA, this.VarNameB);
                        break;
                    case ConvertType.TableACountToIntB:
                        System.Data.DataTable table2 = context.GetTable(this.VarNameA);
                        context.SetVarInt(this.VarNameB, table2.Rows.Count);
                        msg = string.Format("数字变量 {1} 成功设置为表格变量{0}行数{2}", this.VarNameA, this.VarNameB, table2.Rows.Count);
                        break;
                    case ConvertType.StrSplitToList:
                        string me = context.ReplaceVar(this.JoinStr);
                        string sa = context.GetStr(this.VarNameA);
                        List<string> split = new List<string>();
                        if (sa.Length > 0)
                        {
                            if (string.IsNullOrEmpty(me))
                            {
                                for (int i = 0; i < sa.Length; i++)
                                {
                                    split.Add(sa[i].ToString());
                                }
                            }
                            else
                            {
                                foreach (string sp in System.Text.RegularExpressions.Regex.Split(sa, me))
                                {
                                    split.Add(sp);
                                }
                            }
                        }
                        context.SetVarList(this.VarNameB, split);
                        msg = string.Format("字符变量{0}转化为列表{1}成功为{2}个", this.VarNameA, this.VarNameB, split.Count);
                        break;
                    case ConvertType.TableAAdd2TableB:
                        System.Data.DataTable tableA = context.GetTable(this.VarNameA);

                        Variable vt = context.Variables.Find((t) => t.Name == this.VarNameB);
                        System.Data.DataTable tableB = vt.TableValue;

                        if (tableB == null)
                        {
                            tableB = new System.Data.DataTable();
                        }
                        if (tableB.Columns.Count == 0 && vt.TableColumns != null && vt.TableColumns.Count > 0)
                        {
                            foreach (string cname in vt.TableColumns) tableB.Columns.Add(cname);
                        }

                        int rowTableB = tableB.Rows.Count;

                        if (tableA == null)
                        {
                            msg = "表格A无数据，不进行任何操作";
                        }
                        else
                        {
                            foreach (System.Data.DataColumn dc in tableA.Columns)
                            {
                                if (!tableB.Columns.Contains(dc.ColumnName)) tableB.Columns.Add(dc.ColumnName);
                            }
                            foreach (System.Data.DataRow dr in tableA.Rows)
                            {
                                System.Data.DataRow addrow = tableB.NewRow();
                                foreach (System.Data.DataColumn dc in tableB.Columns)
                                {
                                    if (dr.Table.Columns.Contains(dc.ColumnName))
                                    {
                                        addrow[dc.ColumnName] = dr[dc.ColumnName];
                                    }
                                }
                                tableB.Rows.Add(addrow);
                            }
                        }

                        vt.TableValue = tableB;
                        //context.(this.VarNameB, tableB);
                        msg = string.Format("表格变量{0}添加{2}条记录至表格变量{1}成功", this.VarNameA, this.VarNameB, tableB.Rows.Count - rowTableB);
                        break;

                    case ConvertType.ListARemoveStrB:
                        List<string> lastA = context.GetList(this.VarNameA);
                        string strB = context.GetStr(this.VarNameB);
                        int lold = lastA.Count;
                        while (lastA.Contains(strB))
                            lastA.Remove(strB);
                        msg = $"列表 {this.VarNameA} 中移除字符 {this.VarNameB} {lold - lastA.Count}个";
                        break;
                    case ConvertType.JsonStrAToTableB:
                        string jstr = context.GetStr(this.VarNameA);
                        System.Data.DataTable tableBj = new System.Data.DataTable();

                        Newtonsoft.Json.Linq.JObject jsonObj = null;
                        Newtonsoft.Json.Linq.JArray jsonArr = null;

                        try
                        {
                            if (jstr.StartsWith("{"))
                            {
                                jsonObj = JObject.Parse(jstr);
                            }
                            else
                            {
                                jsonArr = JArray.Parse(jstr);
                            }
                        }
                        catch
                        {
                            context.WriteLog("变量值非Json解析失败，提取Json值置为空");
                            return;
                        }

                        if (jsonArr == null)
                        {
                            jsonArr = new JArray(jsonObj);
                        }

                        foreach (JObject jb in jsonArr)
                        {
                            System.Data.DataRow dr = tableBj.NewRow();
                            foreach (JProperty jp in jb.Properties())
                            {
                                if (!tableBj.Columns.Contains(jp.Name)) tableBj.Columns.Add(jp.Name);
                                dr[jp.Name] = jp.Value.ToString();
                            }
                            tableBj.Rows.Add(dr);
                        }
                        msg = $"变量 {this.VarNameA} 提取Jsono记录{tableBj.Rows.Count}条为表格变量 {this.VarNameB}";
                        context.Variables.Find((f) => f.Name == this.VarNameB).TableValue = tableBj;
                        break;
                }
                context.WriteLog(msg);
            }
            catch (Exception ex)
            {
                context.WriteLog($"变量转化发生错误：" + ex.Message);
            }
        }

        /// <summary>
        /// 原变量名
        /// </summary>
        public string VarNameA = "";


        /// <summary>
        /// 保存至变量名
        /// </summary>
        public string VarNameB = "";

        public override void Validate(ActivityContext context)
        {
            //A变量
            switch (this.ConvertType)
            {
                case ConvertType.ListCountToInt:
                case ConvertType.ListJoinToStr:
                case ConvertType.CopyListToList:
                case ConvertType.ListARemoveStrB:
                    if(!context.ContainsList(this.VarNameA))
                    {
                        throw new Exception("列表变量A不存在:" + this.VarNameA);
                    }
                    break;
                case ConvertType.StrToInt:
                case ConvertType.StrAddToList:
                case ConvertType.StrLenghToInt:
                case ConvertType.StrSplitToList:
                case ConvertType.JsonStrAToTableB:
                    if (!context.ContainsStr(this.VarNameA))
                    {
                        throw new Exception("字符变量A不存在:" + this.VarNameA);
                    }
                    break;
                case ConvertType.TableAToJsonB:
                case ConvertType.TableACountToIntB:
                    if (!context.ContainsTable(this.VarNameA))
                    {
                        throw new Exception("表格变量A不存在:" + this.VarNameA);
                    }
                    break;
            }

            //B变量
            switch (ConvertType)
            {
                case ConvertType.StrToInt:
                case ConvertType.ListCountToInt:
                case ConvertType.StrLenghToInt:
                case ConvertType.TableACountToIntB:
                    if (!context.ContainsInt(this.VarNameB))
                    {
                        throw new Exception("数字变量B不存在:" + this.VarNameB);
                    }
                    break;
                case ConvertType.StrAddToList:
                case ConvertType.CopyListToList:
                case ConvertType.StrSplitToList:
                    if (!context.ContainsList(this.VarNameB))
                    {
                        throw new Exception("列表变量B不存在:" + this.VarNameB);
                    }
                    if (this.VarNameA == this.VarNameB) throw new Exception("列表AB不能相同");
                    break;
                case ConvertType.ListJoinToStr:
                case ConvertType.TableAToJsonB:
                case ConvertType.ListARemoveStrB:
                    if (!context.ContainsStr(this.VarNameB))
                    {
                        throw new Exception("字符变量B不存在:" + this.VarNameB);
                    }
                    break;
                case ConvertType.JsonStrAToTableB:
                    if (!context.ContainsTable(this.VarNameB))
                    {
                        throw new Exception("表格变量B不存在:" + this.VarNameB);
                    }
                    break;
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        /// <summary>
        /// 合并字符串
        /// </summary>
        public string JoinStr = ",";

        private string name = "变量互转";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Variable;
    }
}