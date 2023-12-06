using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litcore.sqldb
{
    /// <summary>
    /// 数据库操作基类
    /// </summary>
    public class SqlDBActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; }

        /// <summary>
        /// 分组
        /// </summary>
        public override ActivityGroup Group => ActivityGroup.Database;

        /// <summary>
        /// 要执行的Sql语句
        /// </summary>
        public string Sql = "";

        /// <summary>
        /// 配置名称
        /// </summary>
        public string DbConfigName = "";//实际显示按ip:端口(数据库)，这里是guid

        /// <summary>
        /// 是否转义
        /// </summary>
        public bool NoAddslashes = false;

        /// <summary>
        /// 数据库类型
        /// </summary>
        public virtual SqlDbType DbType { get; }

        /// <summary>
        /// 保存变量名称
        /// </summary>
        public string SaveVarName = "";

        public override void Execute(ActivityContext context)
        {
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            SqlDBConfig config = GetSqlDBConfig(context, this.DbConfigName);
            if (config == null) throw new Exception("找不到数据库配置");
            if (string.IsNullOrEmpty(this.Sql)) throw new Exception("执行Sql语句不能为空");
            if (!string.IsNullOrEmpty(this.SaveVarName) && !context.Contains(this.SaveVarName))
            {
                throw new Exception($"保存变量名 {this.SaveVarName} 不存在，请检查");
            }
            if (this.Sql.StartsWith("select", StringComparison.OrdinalIgnoreCase) && string.IsNullOrEmpty(this.SaveVarName)) throw new Exception("使用查询时必须指定保存变量");
        }

        public static SqlDBConfig GetSqlDBConfig(litsdk.ActivityContext context, string dbconfigName)
        {
            return GetSqlDBConfigs(context).Find((F) => F.Name == dbconfigName);
        }

        public static List<SqlDBConfig> GetSqlDBConfigs(litsdk.ActivityContext context)
        {
            object obj = context.GetUserConfig("SqlDBConfig");// litsdk.API.GetUserConfig("SqlDBConfig");
            if (obj == null) return new List<SqlDBConfig>();
            List<SqlDBConfig> dBConfigs = obj as List<SqlDBConfig>;
            return dBConfigs;
        }

        public static void SetSqlDBConfig(litsdk.ActivityContext context, SqlDBConfig sqlDBConfig)
        {
            List<SqlDBConfig> dbs = GetSqlDBConfigs(context);
            int index = dbs.FindIndex((f) => f.Name == sqlDBConfig.Name);

            if (index == -1) dbs.Add(sqlDBConfig);
            else
            {
                dbs[index] = sqlDBConfig;
            }
            context.SetUserConfig("SqlDBConfig", dbs);// litsdk.API.SetUserConfig("SqlDBConfig", dbs);
        }

        public static string SqlserverAddSlash(string str)
        {
            str = str != "" ? (str.Replace("'", @"''")) : "";
            return str;
        }
        /// <summary>
        /// MySql中\的转义
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MysqlAddSlash(string str)
        {
            str = str.Replace(@"\", @"\\");
            str = str.Replace("'", @"\'");
            return str;
        }
    }
}