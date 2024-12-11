using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litsqlite
{
    [ActivityInfo(Name = "Sqlite", RefFile = "FreeSql.dll,FreeSql.Provider.Sqlite.dll,System.Data.SQLite.dll,x86,x64", Index = 5, IsLinux = true)]
    public class Sqlitedb : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "Sqlite";

        public override ActivityGroup Group => ActivityGroup.Database;

        /// <summary>
        /// 文件地址
        /// </summary>
        public string SqliteFile = "";

        /// <summary>
        /// sql语句
        /// </summary>
        public string Sql = "";

        /// <summary>
        /// 保存至变量
        /// </summary>
        public string SaveVarName = "";

        public override void Execute(ActivityContext context)
        {
            string msg = "";
            string mksql = "";
            string filepath = context.ReplaceVar(this.SqliteFile);
            mksql = context.AddSlashReplaceVar(this.Sql, SqliteAddSlash);

            string connstr = SqliteConn(filepath);
            IFreeSql _fsql = null;

            try
            {
                if (mksql.StartsWith("select", StringComparison.OrdinalIgnoreCase))
                {
                    _fsql = new FreeSql.FreeSqlBuilder()
                 .UseConnectionString(FreeSql.DataType.Sqlite, connstr)
                 .Build();
                    DataSet ds = new DataSet();
                    ds = _fsql.Ado.ExecuteDataSet(mksql);

                    if (context.ContainsStr(this.SaveVarName))
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            object first = ds.Tables[0].Rows[0][0];
                            string restr = first == DBNull.Value ? "" : first.ToString();
                            context.SetVarStr(this.SaveVarName, restr);
                            msg = $"获取到结果长度{restr.Length}并存入字符变量{this.SaveVarName}";
                        }
                        else
                        {
                            context.SetVarStr(this.SaveVarName, "");
                            msg = $"查询到结果记录数为空，置空字符变量{this.SaveVarName}";
                        }
                    }
                    else if (context.ContainsList(this.SaveVarName))
                    {
                        foreach (System.Data.DataRow dr in ds.Tables[0].Rows)
                        {
                            string re2 = dr[0] == DBNull.Value ? "" : dr[0].ToString();
                            context.AddVarListText(this.SaveVarName, re2);
                        }
                        msg = $"获取到记录数{ds.Tables[0].Rows.Count}并存入列表变量{this.SaveVarName}";
                    }
                    else if (context.ContainsInt(this.SaveVarName))
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            object first2 = ds.Tables[0].Rows[0][0];
                            int restr2 = first2 == DBNull.Value ? 0 : Convert.ToInt32(first2);
                            context.SetVarInt(this.SaveVarName, restr2);
                            msg = $"获取到数字变量{restr2}并存入数字变量{this.SaveVarName}";
                        }
                        else
                        {
                            context.SetVarInt(this.SaveVarName, 0);
                            msg = $"获取到结果为空置空数字变量{this.SaveVarName}";
                        }
                    }
                    else if (context.ContainsTable(this.SaveVarName))
                    {
                        DataTable dataTable = context.GetTable(this.SaveVarName);
                        if (dataTable.Columns.Count == 0) context.Variables.Find((f) => f.Name == this.SaveVarName).TableValue = ds.Tables[0];
                        else
                        {
                            foreach (System.Data.DataRow dr in ds.Tables[0].Rows)
                            {
                                System.Data.DataRow add = dataTable.NewRow();
                                foreach (System.Data.DataColumn dc in ds.Tables[0].Columns)
                                {
                                    if (dataTable.Columns.Contains(dc.ColumnName)) add[dc.ColumnName] = dr[dc.ColumnName];
                                }
                                dataTable.Rows.Add(add);
                            }
                        }
                        msg = $"获取到表格数据{ ds.Tables[0].Rows.Count}并存入表格变量{this.SaveVarName}";
                    }
                }
                else
                {
                    if (mksql.StartsWith("create", StringComparison.OrdinalIgnoreCase) && !System.IO.File.Exists(filepath))
                    {
                        System.Data.SQLite.SQLiteConnection.CreateFile(filepath);
                    }
                    _fsql = new FreeSql.FreeSqlBuilder()
                 .UseConnectionString(FreeSql.DataType.Sqlite, connstr)
                 .Build();

                    _fsql.Ado.ExecuteNonQuery(mksql);

                    msg = $"成功执行Sql操作";
                }
                context.WriteLog(msg);
            }
            catch (Exception ex)
            {
                msg = ex.Message + "\r\n" + ex.StackTrace + "\r\n" + mksql;
                throw new Exception(msg);
            }
            finally
            {
                try
                {
                    if (_fsql != null) _fsql.Dispose();
                }
                catch { }
            }
        }

        internal static string SqliteConn(string path)
        {
            //return "Provider=SQLiteOLEDB;Data Source=" + path;
            return $"Data Source={path}; Pooling=true;Min Pool Size=1";
        }

        internal static string SqliteAddSlash(string str)
        {
            str = str != "" ? (str.Replace("'", @"''")) : "";
            return str;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.SqliteFile)) throw new Exception("数据库文件不能为空");
            if (string.IsNullOrEmpty(this.Sql)) throw new Exception("执行Sql语句不能为空");
            if (!string.IsNullOrEmpty(this.SaveVarName) && !context.Contains(this.SaveVarName))
            {
                throw new Exception($"保存变量名 {this.SaveVarName} 不存在，请检查");
            }
            if (this.Sql.StartsWith("select", StringComparison.OrdinalIgnoreCase) && string.IsNullOrEmpty(this.SaveVarName)) throw new Exception("使用查询时必须指定保存变量");
        }
    }
}