using litcore.type;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.activity
{
    [ActivityInfo(Name = "表格操作",Index = 56, IsLinux = true)]
    public class TableActivity : litsdk.ProcessActivity
    {
        /// <summary>
        /// 表格锁
        /// </summary>
        public static object LockTable = new object();
        /// <summary>
        /// 操作表格名
        /// </summary>
        public string TableVarName = "";

        /// <summary>
        /// 操作名
        /// </summary>
        public TableType TableType = TableType.Add;

        /// <summary>
        /// 选中字段
        /// </summary>
        public List<string> SeletFields = new List<string>();

        /// <summary>
        /// 编辑字段
        /// </summary>
        public List<string> EditFields = new List<string>();

        public override string Name { get; set; } = "表格操作";

        public override ActivityGroup Group => ActivityGroup.Variable;

        public override void Execute(ActivityContext context)
        {
            System.Data.DataTable table = context.GetTable(this.TableVarName);
            lock (LockTable)
            {
                if (this.TableType == TableType.DeleteAll)
                {
                    context.WriteLog($"清除表格变量{this.TableVarName}中所有数据{table.Rows.Count}条");
                    table.Rows.Clear();
                }
                else if (this.TableType == TableType.Distinct)
                {
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    List<int> removes = new List<int>();
                    string guid = Guid.NewGuid().ToString();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (System.Data.DataColumn dc in table.Columns)
                        {
                            string txt = table.Rows[i][dc.ColumnName] == null ? "" : table.Rows[i][dc.ColumnName].ToString();
                            sb.Append(txt).Append(guid);
                        }
                        string md5 = litcore.activity.TextEncodeActivity.Md5(sb.ToString());
                        if (dic.ContainsKey(md5)) removes.Add(i);
                        else dic.Add(md5, null);
                    }
                    if (removes.Count == 0)
                    {
                        context.WriteLog($"没有发现重复记录");
                    }
                    else
                    {
                        removes.Reverse();
                        foreach (int r in removes) table.Rows.RemoveAt(r);
                        context.WriteLog($"成功删除{removes.Count}条重复数据");
                        removes.Clear();
                    }
                }
                else if (this.TableType == TableType.Add)
                {
                    foreach (string s in this.SeletFields)
                    {
                        bool find = false;
                        foreach (System.Data.DataColumn dc in table.Columns)
                        {
                            if (dc.ColumnName.Equals(s, StringComparison.OrdinalIgnoreCase))
                            {
                                find = true;
                                break;
                            }
                        }
                        if (!find) table.Columns.Add(s, typeof(string));
                    }
                    System.Data.DataRow dr = table.NewRow();
                    foreach (string s in this.SeletFields)
                    {
                        if (context.ContainsStr(s))
                        {
                            dr[s] = context.GetStr(s);
                        }
                        else
                        {
                            dr[s] = context.GetInt(s).ToString();
                        }
                    }
                    table.Rows.Add(dr);
                    context.WriteLog($"成功添加一条数据");
                }
                else if (this.TableType == TableType.Sort)
                {
                    if (!table.Columns.Contains(this.SeletFields[0])) throw new Exception("表不存在字段名：" + this.SeletFields[0]);
                    Dictionary<string, List<System.Data.DataRow>> dics = new Dictionary<string, List<System.Data.DataRow>>();
                    if (table.Rows.Count == 0)
                    {
                        context.WriteLog("当前表格数量为0，路过排序");
                    }
                    else
                    {
                        for (int r = 0; r < table.Rows.Count; r++)
                        {
                            string v = table.Rows[r][this.SeletFields[0]] == null ? "" : table.Rows[r][this.SeletFields[0]].ToString();
                            if (dics.ContainsKey(v)) dics[v].Add(table.Rows[r]);
                            else dics.Add(v, new List<System.Data.DataRow>() { table.Rows[r] });
                        }

                        List<string> fields = dics.Keys.ToList();// fields.Distinct().ToList();
                        fields.Sort();
                        foreach (string s in fields)
                        {
                            foreach (System.Data.DataRow dr in dics[s])
                            {
                                object[] vs = dr.ItemArray;
                                table.Rows.Remove(dr);
                                table.Rows.Add(vs);
                            }
                        }
                        context.WriteLog("当前表格排序完成");
                    }
                }
                else
                {
                    List<System.Data.DataRow> rows = new List<System.Data.DataRow>();
                    foreach (System.Data.DataRow dr in table.Rows) rows.Add(dr);
                    foreach (string s in this.SeletFields)
                    {
                        bool find = false;
                        foreach (System.Data.DataColumn dc in table.Columns)
                        {
                            if (dc.ColumnName.Equals(s, StringComparison.OrdinalIgnoreCase))
                            {
                                find = true;
                                rows = rows.FindAll((h) => h[s] != null && h[s].ToString() == context.GetStr(s)).ToList();
                                break;
                            }
                        }

                        if (!find) throw new Exception($"表格变量{this.TableVarName}不存在表头{s}");
                    }
                    if (rows.Count == 0)
                    {
                        context.WriteLog("没有发现匹配的表格行");
                    }
                    else
                    {
                        if (this.TableType == TableType.EditMore || this.TableType == TableType.EditOne)
                        {
                            foreach (string t in this.EditFields)
                            {
                                bool find = false;
                                foreach (System.Data.DataColumn dc in table.Columns)
                                {
                                    if (dc.ColumnName.Equals(t, StringComparison.OrdinalIgnoreCase))
                                    {
                                        find = true;
                                        break;

                                    }
                                }
                                if (!find) table.Columns.Add(t, typeof(string));

                            }

                            switch (this.TableType)
                            {
                                case TableType.EditOne:
                                    foreach (string s in this.EditFields)
                                    {
                                        rows[0][s] = context.GetStr(s);
                                    }
                                    context.WriteLog($"成功编辑表格变量{this.TableVarName}匹配的1行");
                                    break;
                                case TableType.EditMore:
                                    foreach (string s in this.EditFields)
                                    {
                                        foreach (System.Data.DataRow ddd in rows)
                                        {
                                            ddd[s] = context.GetStr(s);
                                        }
                                    }
                                    context.WriteLog($"成功编辑表格变量{this.TableVarName}匹配的{rows.Count}行");
                                    break;
                            }
                        }
                        else if (this.TableType == TableType.Rows2Table)
                        {
                            foreach (string tt in this.EditFields)
                            {
                                System.Data.DataTable data = table.Clone();// new System.Data.DataTable();
                                foreach (System.Data.DataRow drr in rows)
                                {
                                    data.Rows.Add(drr.ItemArray);
                                }
                                context.Variables.Find((f) => f.Name == tt).TableValue = data;
                                context.WriteLog($"成功转化匹配条件的{rows.Count}行数据至表格变量{tt}");
                            }
                        }
                        else if (this.TableType == TableType.CellData)
                        {
                            foreach (string ss in this.EditFields)
                            {
                                if (table.Columns.Contains(ss))
                                {
                                    string vv = rows[0][ss] == null ? "" : rows[0][ss].ToString();
                                    context.SetVarStr(ss, vv);
                                    context.WriteLog($"成功保存匹配条件的结果至变量{ss}");
                                }
                                else
                                {
                                    context.SetVarStr(ss, "");
                                    context.WriteLog($"没有找到表头名为{ss}的字符变量,变量置空");
                                }
                            }
                        }
                        else if(this.TableType== TableType.DeleteMore)
                        {
                            foreach (System.Data.DataRow r in rows) table.Rows.Remove(r);
                            context.WriteLog($"成功删除{rows.Count}条记录");
                        }
                        else if(this.TableType== TableType.DeleteOne)
                        {
                            table.Rows.Remove(rows[0]);
                            context.WriteLog($"成功删除1条记录");
                        }
                    }
                }
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.TableVarName)) throw new Exception("表格字段不能为空");
            if (!context.ContainsTable(this.TableVarName)) throw new Exception($"不存在表格字段{this.TableVarName}");
            if (TableType == TableType.DeleteAll || TableType == TableType.Distinct) return;

            if (TableType == TableType.Rows2Table)
            {
                foreach (string t in this.SeletFields)
                {
                    if (!context.ContainsStr(t)) throw new Exception($"要查找到表格字段{t}不存在");
                }
                return;
            }

            if (this.SeletFields.Count == 0) throw new Exception("添加编辑或删除的字段不能为空");
            foreach (string s in this.SeletFields)
            {
                if (TableType == TableType.Add)
                {
                    if (!context.ContainsStr(s) && !context.ContainsInt(s)) throw new Exception($"添加字符或数字字段{s}不存在");
                }
                else
                {
                    if (!context.ContainsStr(s)) throw new Exception($"添加编辑或删除的字符字段{s}不存在");
                }
            }

            if (TableType == TableType.Sort && this.SeletFields.Count > 1) throw new Exception("使用排序时只能选一个字段");
            if (TableType == TableType.EditMore || TableType == TableType.EditOne)
            {
                if (this.EditFields.Count == 0) throw new Exception("编辑的字段不能为空");
                foreach (string t in this.EditFields)
                {
                    if (!context.ContainsStr(t)) throw new Exception($"编辑的字符字段{t}不存在");
                }
            }
        }
    }
}