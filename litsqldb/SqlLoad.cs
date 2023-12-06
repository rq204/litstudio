using litsdk;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsqldb
{
    internal class SqlLoad
    {
        public static void Execute(string mksql, IFreeSql _fsql, ActivityContext context, litcore.sqldb.SqlDBActivity dBActivity)
        {
            string msg = "";
            try
            {
                if (mksql.StartsWith("select", StringComparison.OrdinalIgnoreCase))
                {
                    DataSet ds = new DataSet();

                    try
                    {
                        lock (string.Intern(_fsql.Ado.ConnectionString))
                        {
                            ds = _fsql.Ado.ExecuteDataSet(mksql);
                        }
                    }
                    catch
                    {
                        System.Threading.Thread.Sleep(1000);
                        lock (string.Intern(_fsql.Ado.ConnectionString))
                        {
                            ds = _fsql.Ado.ExecuteDataSet(mksql);
                        }
                    }

                    if (context.ContainsStr(dBActivity.SaveVarName))
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            object first = ds.Tables[0].Rows[0][0];
                            string restr = first == DBNull.Value ? "" : first.ToString();
                            context.SetVarStr(dBActivity.SaveVarName, restr);
                            msg = $"获取到结果长度{restr.Length}并存入字符变量{dBActivity.SaveVarName}";
                        }
                        else
                        {
                            context.SetVarStr(dBActivity.SaveVarName, "");
                            msg = $"查询到0例数据并设置字符变量{dBActivity.SaveVarName}为空";
                        }
                    }
                    else if (context.ContainsList(dBActivity.SaveVarName))
                    {
                        foreach (System.Data.DataRow dr in ds.Tables[0].Rows)
                        {
                            string re2 = dr[0] == DBNull.Value ? "" : dr[0].ToString();
                            context.AddVarListText(dBActivity.SaveVarName, re2);
                        }
                        msg = $"获取到记录数{ds.Tables[0].Rows.Count}并存入列表变量{dBActivity.SaveVarName}";
                    }
                    else if (context.ContainsInt(dBActivity.SaveVarName))
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            object first2 = ds.Tables[0].Rows[0][0];
                            int restr2 = first2 == DBNull.Value ? 0 : Convert.ToInt32(first2);
                            context.SetVarInt(dBActivity.SaveVarName, restr2);
                            msg = $"获取到数字变量{restr2}并存入数字变量{dBActivity.SaveVarName}";
                        }
                        else
                        {
                            context.SetVarInt(dBActivity.SaveVarName, 0);
                            msg = $"查询到0例数据并设置数字变量{dBActivity.SaveVarName}为0";
                        }
                    }
                    else if (context.ContainsTable(dBActivity.SaveVarName))
                    {
                        DataTable dataTable = context.GetTable(dBActivity.SaveVarName);
                        if (dataTable.Columns.Count == 0) context.Variables.Find((f) => f.Name == dBActivity.SaveVarName).TableValue = ds.Tables[0];
                        else
                        {
                            foreach (System.Data.DataRow dr in ds.Tables[0].Rows)
                            {
                                foreach (System.Data.DataColumn dc in ds.Tables[0].Columns)
                                {
                                    if (!dataTable.Columns.Contains(dc.ColumnName))
                                    {
                                        dataTable.Columns.Add(dc.ColumnName);
                                    }
                                }

                                System.Data.DataRow add = dataTable.NewRow();
                                foreach (System.Data.DataColumn dc in ds.Tables[0].Columns)
                                {
                                    if (dataTable.Columns.Contains(dc.ColumnName)) add[dc.ColumnName] = dr[dc.ColumnName];
                                }
                                dataTable.Rows.Add(add);
                            }
                        }
                        msg = $"获取到表格数据{ ds.Tables[0].Rows.Count}并存入表格变量{dBActivity.SaveVarName}";
                    }
                }
                else
                {
                    for (int err = 0; err < 3; err++)
                    {
                        try
                        {
                            lock (string.Intern(_fsql.Ado.ConnectionString))
                            {
                                _fsql.Ado.ExecuteNonQuery(mksql);
                            }
                            break;
                        }
                        catch
                        {
                            if (err == 2) throw;
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                    msg = $"成功执行Sql";
                }
                context.WriteLog(msg);
            }
            catch (Exception ex)
            {
                msg = ex.Message + "\r\n" + ex.StackTrace + "\r\n" + mksql;
                throw new Exception(msg);
            }
        }

        private static bool pgsqlInit = false;
        public static void LoadPgSql()
        {
            if (pgsqlInit) return;
            Npgsql.NpgsqlConnection.GlobalTypeMapper.UseLegacyPostgis();
            pgsqlInit = true;
        }

        public static FreeSql.DataType GetDataType(litcore.sqldb.SqlDbType dbType)
        {
            switch (dbType)
            {
                case litcore.sqldb.SqlDbType.MySql:
                    return FreeSql.DataType.MySql;
                case litcore.sqldb.SqlDbType.SqlServer:
                    return FreeSql.DataType.SqlServer;
                case litcore.sqldb.SqlDbType.Oracle:
                    return FreeSql.DataType.Oracle;
                case litcore.sqldb.SqlDbType.PostgreSQL:
                    return FreeSql.DataType.PostgreSQL;
            }
            throw new Exception("不支持的数据库类型");
        }


        static Dictionary<string, IFreeSql> dsql = new Dictionary<string, IFreeSql>();

        static object lkadd = new object();
        public static IFreeSql GetFreeSql(litcore.sqldb.SqlDbType dbType, string connstr)
        {
            IFreeSql _fsql = null;
            lock (lkadd)
            {
                if (dsql.ContainsKey(connstr)) _fsql = dsql[connstr];
                else
                {
                    _fsql = new FreeSql.FreeSqlBuilder()
                   .UseConnectionString(SqlLoad.GetDataType(dbType), connstr)
                   .Build();
                    dsql.Add(connstr, _fsql);
                }
            }
            return _fsql;
        }
    }
}
