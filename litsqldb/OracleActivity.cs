using litcore.sqldb;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsqldb
{
    [litsdk.ActivityInfo(Name = "Oracle", IsFront = false, IsWinForm = false, IsLinux = true, Index = 6, RefFile = "FreeSql.dll,FreeSql.Provider.Oracle.dll,Oracle.ManagedDataAccess.dll")]
    public class OracleActivity : litcore.sqldb.SqlDBActivity
    {
        [Newtonsoft.Json.JsonIgnore]
        public override SqlDbType DbType => SqlDbType.Oracle;

        public override string Name { get; set; } = "Oracle";

        public override void Execute(ActivityContext context)
        {
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
