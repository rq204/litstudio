using litcore.sqldb;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsqldb
{
    [litsdk.ActivityInfo(Name = "PostgreSQL", IsFront = false, IsWinForm = false, IsLinux = true, Index = 6, RefFile = "FreeSql.dll,FreeSql.Provider.PostgreSQL.dll,Oracle.ManagedDataAccess.dll")]
    public class PostgreSQLActivity : litcore.sqldb.SqlDBActivity
    {
        public override string Name { get; set; } = "PostgreSQL";

        [Newtonsoft.Json.JsonIgnore]
        public override SqlDbType DbType => SqlDbType.PostgreSQL;

        public override void Execute(ActivityContext context)
        {
            SqlLoad.LoadPgSql();
            SqlDBConfig dBConfig = GetSqlDBConfig(context, this.DbConfigName);
            string connstr = context.ReplaceVar(dBConfig.ToConnectStr());
            string mksql = "";

            if (this.NoAddslashes)
            {
                mksql = context.ReplaceVar(this.Sql);
            }
            else
            {
                mksql = context.AddSlashReplaceVar(this.Sql, MysqlAddSlash);
            }

            IFreeSql _fsql = SqlLoad.GetFreeSql(this.DbType, connstr);

            SqlLoad.Execute(mksql, _fsql, context, this);
        }
    }
}
