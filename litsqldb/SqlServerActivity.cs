using litcore.sqldb;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsqldb
{
    [litsdk.ActivityInfo(Name = "SqlServer", IsLinux = true, Index = 3,RefFile = "FreeSql.dll,FreeSql.Provider.SqlServer.dll")]
    /// <summary>
    /// SqlServer
    /// </summary>
    public class SqlServerActivity : litcore.sqldb.SqlDBActivity
    {
        public override string Name { get; set; } = "SqlServer";

        [Newtonsoft.Json.JsonIgnore]
        public override SqlDbType DbType => SqlDbType.SqlServer;

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
                mksql = context.AddSlashReplaceVar(this.Sql, SqlserverAddSlash);
            }

            IFreeSql _fsql = SqlLoad.GetFreeSql(this.DbType, connstr);

            SqlLoad.Execute(mksql, _fsql, context, this);
        }
    }
}
