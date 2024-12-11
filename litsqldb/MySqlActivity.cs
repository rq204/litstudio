using litcore.sqldb;
using litsdk;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsqldb
{
    [litsdk.ActivityInfo(Name = "MySql", IsFront = false, IsWinForm = false, IsLinux = true, Index = 0, RefFile = "FreeSql.dll,FreeSql.Provider.MySql.dll,MySql.Data.dll,Google.Protobuf.dll,K4os.Hash.xxHash.dll,K4os.Compression.LZ4.dll,K4os.Compression.LZ4.Streams.dll,Ubiety.Dns.Core.dll,Zstandard.Net.dll")]
    public class MySqlActivity : litcore.sqldb.SqlDBActivity
    {
        public override string Name { set; get; } = "MySql";

        [Newtonsoft.Json.JsonIgnore]
        public override litcore.sqldb.SqlDbType DbType => litcore.sqldb.SqlDbType.MySql;

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