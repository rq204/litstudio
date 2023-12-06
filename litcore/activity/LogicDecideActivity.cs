using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litcore.type;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "变量比较",Index = 16, IsLinux = true)]
    public class LogicDecideActivity : litsdk.DecisionActivity
    {
        private string name = "变量比较";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Variable;

        /// <summary>
        /// 取相反值
        /// </summary>
        public bool Reverse = false;

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }


        public override bool Execute(ActivityContext context)
        {
            bool Result = false;
            string debug = "";
            switch (LogicType)
            {
                case LogicType.StrAIndexOfStrB:
                    string a = context.GetStr(ASetting);//.ReplaceVar(ASetting);
                    string b = context.GetStr(BSetting);//注意b不能为空，否则一直为true
                    Result = a.Contains(b);
                    debug = string.Format("字符A {0} 包含字符B {1} 的结果为{2}", ASetting, BSetting, Result);
                    break;
                case LogicType.StrAEqualsStrB:
                    string a4 = context.GetStr(ASetting);
                    string b4 = context.GetStr(BSetting);
                    Result = a4 == b4;
                    debug = string.Format("字符A {0} 等于字符B {1} 的结果为{2}", ASetting, BSetting, Result);
                    break;
                case LogicType.ListAContainsStrB:
                    List<string> lsta = context.GetList(ASetting);
                    string b2 = context.GetStr(BSetting);//.ReplaceVar(BSetting);
                    Result = lsta.Contains(b2);
                    debug = string.Format("列表A {0} 包含字符B {1} 的结果为{2}", ASetting, BSetting, Result);
                    break;
                case LogicType.IntAEqualsIntB:
                    int ia3 = context.GetInt(ASetting);
                    int ib3 = context.GetInt(BSetting);
                    Result = ia3 == ib3;
                    debug = string.Format("数字A {0} 等于数字B {1} 结果为{2}", ASetting, BSetting, Result);
                    break;
                case LogicType.IntABigerIntB:
                    int ia14 = context.GetInt(ASetting);
                    int ib14 = context.GetInt(BSetting);
                    Result = ia14 > ib14;
                    debug = string.Format("数字A {0} 大于数字B {1} 结果为{2}", ASetting, BSetting, Result);
                    break;
                case LogicType.TableAEqualsTableB:
                    DataTable dtA = context.GetTable(ASetting);
                    DataTable dtB = context.GetTable(BSetting);
                    Result = CompareDataTable(dtA, dtB);
                    debug = string.Format("表格A {0} 等于表格B {1} 结果为{2}", ASetting, BSetting, Result);
                    break;
                case LogicType.TableARowsBigerIntB:
                    DataTable dtA2 = context.GetTable(ASetting);
                    int it2 = context.GetInt(BSetting);
                    Result = dtA2.Rows.Count > it2;
                    debug = string.Format("表格A行数 {0} 大于于数字B {1} 结果为{2}", ASetting, BSetting, Result);
                    break;
                case LogicType.IntAIsZero:
                    int ia5 = context.GetInt(ASetting);
                    Result = ia5 == 0;
                    debug = string.Format("数字变量A {0} 值为0的结果为{1}", ASetting, Result);
                    break;
                case LogicType.StrANotEmpty:
                    string a88 = context.GetStr(ASetting);
                    Result = a88 != "";
                    debug = string.Format("字符变量A {0} 值不为空的结果为{1}", ASetting, Result);
                    break;
                case LogicType.StrAContainsListBItem:
                    string a99 = context.GetStr(ASetting);
                    List<string> b99 = context.GetList(BSetting);
                    foreach (string b9 in b99)
                    {
                        if (a99.Contains(b9))
                        {
                            Result = true;
                            break;
                        }
                    }
                    debug = string.Format("字符变量A {0} 值包含列表变量B {2} 其中某项 的 结果为{1}", ASetting, Result, BSetting);
                    break;
                case LogicType.ListACountBiger0:
                    List<string> b90 = context.GetList(ASetting);
                    Result = b90.Count > 0;
                    debug = string.Format("列表变量A {0} 行数大于0结果为{1}", ASetting, Result);
                    break;
                case LogicType.TableARowsBiger0:
                    System.Data.DataTable table91 = context.GetTable(this.ASetting);
                    Result = table91.Rows.Count > 0;
                    debug = string.Format("表格变量A {0} 行数大于0结果为{1}", ASetting, Result);
                    break;
                case LogicType.ListACountBigerIntB:
                    List<string> al12 = context.GetList(ASetting);
                    int bi12 = context.GetInt(BSetting);
                    Result = al12.Count > bi12;
                    debug = string.Format("列表变量A {0} 行数大于数字变量B {2}结果为{1}", ASetting, Result, BSetting);
                    break;
                case LogicType.ListACountBigerEqualIntB:
                    List<string> al126 = context.GetList(ASetting);
                    int bi126 = context.GetInt(BSetting);
                    Result = al126.Count >= bi126;
                    debug = string.Format("列表变量A {0} 行数大等于数字变量B {2}结果为{1}", ASetting, Result, BSetting);
                    break;
                case LogicType.ListACountLessIntB:
                    List<string> al13 = context.GetList(ASetting);
                    int bi13 = context.GetInt(BSetting);
                    Result = al13.Count < bi13;
                    debug = string.Format("列表变量A {0} 行数小于数字变量B {2}结果为{1}", ASetting, Result, BSetting);
                    break;
                case LogicType.ListACountEqualsIntB:
                    List<string> al14 = context.GetList(ASetting);
                    int bi14 = context.GetInt(BSetting);
                    Result = al14.Count == bi14;
                    debug = string.Format("列表变量A {0} 行数等于数字变量B {2}结果为{1}", ASetting, Result, BSetting);
                    break;
                case LogicType.ListANotContainsStrB:
                    List<string> lst15 = context.GetList(ASetting);
                    string b15 = context.GetStr(BSetting);//.ReplaceVar(BSetting);
                    Result = !lst15.Contains(b15);
                    debug = string.Format("列表A {0} 不包含字符B {1} 的结果为{2}", ASetting, BSetting, Result);
                    break;
            }
            if (this.Reverse)
            {
                Result = !Result;
                debug += "，取相反值为 " + Result.ToString();
            }
            context.WriteLog(debug);
            return Result;
        }


        public override void Validate(ActivityContext context)
        {
            if (LogicType != LogicType.StrANotEmpty && LogicType != LogicType.IntAIsZero && LogicType != LogicType.TableARowsBiger0 && LogicType != LogicType.ListACountBiger0)
            {
                if (!context.Contains(this.ASetting) || !context.Contains(this.BSetting))
                {
                    throw new Exception("必须同时指定变量A和变量B");
                }
            }
            else
            {
                if (LogicType == LogicType.StrANotEmpty)
                {
                    if (!context.ContainsStr(this.ASetting))
                    {
                        throw new Exception("必须指定字符变量A");
                    }
                }
                else if (LogicType == LogicType.IntAIsZero)
                {
                    if (!context.ContainsInt(this.ASetting))
                    {
                        throw new Exception("必须指定字符变量A");
                    }
                }
                else if (LogicType == LogicType.TableARowsBiger0)
                {
                    if (!context.ContainsTable(this.ASetting))
                    {
                        throw new Exception("必须指定表格变量A");
                    }
                }
                else if (LogicType == LogicType.ListACountBiger0)
                {
                    if (!context.ContainsList(this.ASetting))
                    {
                        throw new Exception("必须指定列表变量A");
                    }
                }
            }

            if (LogicType == LogicType.ListAContainsStrB || LogicType == LogicType.ListANotContainsStrB)
            {
                if (!context.ContainsList(ASetting))
                {
                    throw new Exception("不包含list变量:" + ASetting);
                }
                if (!context.ContainsStr(BSetting))
                {
                    throw new Exception("不包含字符变量:" + BSetting);
                }
            }
            else if (LogicType == LogicType.ListACountBigerIntB || LogicType == LogicType.ListACountEqualsIntB || LogicType == LogicType.ListACountLessIntB || LogicType == LogicType.ListACountBigerEqualIntB)
            {
                if (!context.ContainsList(ASetting))
                {
                    throw new Exception("不包含列表变量:" + ASetting);
                }
                if (!context.ContainsInt(BSetting))
                {
                    throw new Exception("不包含数字变量:" + BSetting);
                }
            }
            else if (LogicType == LogicType.StrAIndexOfStrB || LogicType == LogicType.StrAEqualsStrB)
            {
                if (!context.ContainsStr(ASetting))
                {
                    throw new Exception("不包含字符变量:" + ASetting);
                }
                if (!context.ContainsStr(BSetting))
                {
                    throw new Exception("不包含字符变量:" + BSetting);
                }
            }
            else if (LogicType == LogicType.IntAEqualsIntB || LogicType == LogicType.IntABigerIntB)
            {
                if (!context.ContainsInt(ASetting) || !context.ContainsInt(BSetting))
                {
                    throw new Exception("不包含数字变量:" + ASetting + "或者" + BSetting);
                }
            }
            else if (LogicType == LogicType.TableAEqualsTableB)
            {
                if (!context.ContainsTable(ASetting)) throw new Exception("不包含表格变量 " + ASetting);
                if (!context.ContainsTable(BSetting)) throw new Exception("不包含表格变量 " + BSetting);
            }
            else if (LogicType == LogicType.TableARowsBigerIntB)
            {
                if (!context.ContainsTable(ASetting)) throw new Exception("不包含表格变量 " + ASetting);
                if (!context.ContainsInt(BSetting)) throw new Exception("不包含数字变量 " + ASetting);
            }
            if (this.ASetting == this.BSetting) throw new Exception("变量AB不能使用同一变量");
        }

        /// <summary>
        /// 变量A
        /// </summary>
        public string ASetting = "";

        /// <summary>
        /// 变量B
        /// </summary>
        public string BSetting = "";

        /// <summary>
        /// 判断的类型
        /// </summary>
        public LogicType LogicType = LogicType.StrAIndexOfStrB;

        ///   <summary>
        ///   比较两个DataTable内容是否相等，先是比数量，数量相等就比内容
        ///   </summary>
        ///   <param   name= "dtA "> </param>
        ///   <param   name= "dtB "> </param>
        private bool CompareDataTable(DataTable dtA, DataTable dtB)
        {
            if (dtA.Rows.Count == dtB.Rows.Count)
            {
                if (CompareColumn(dtA.Columns, dtB.Columns))
                {
                    //比内容
                    for (int i = 0; i < dtA.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtA.Columns.Count; j++)
                        {
                            if (!dtA.Rows[i][j].Equals(dtB.Rows[i][j]))
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        ///   <summary>
        ///   比较两个字段集合是否名称,数据类型一致
        ///   </summary>
        ///   <param   name= "dcA "> </param>
        ///   <param   name= "dcB "> </param>
        ///   <returns> </returns>
        private bool CompareColumn(System.Data.DataColumnCollection dcA, System.Data.DataColumnCollection dcB)
        {
            if (dcA.Count == dcB.Count)
            {
                foreach (DataColumn dc in dcA)
                {
                    //找相同字段名称
                    if (dcB.IndexOf(dc.ColumnName) > -1)
                    {
                        //测试数据类型
                        if (dc.DataType != dcB[dcB.IndexOf(dc.ColumnName)].DataType)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
