using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.sqldb
{
    [Serializable]
    /// <summary>
    /// 数据库配置
    /// </summary>
    public class SqlDBConfig
    {
        /// <summary>
        /// 数据库类型
        /// </summary>
        public SqlDbType DbType = SqlDbType.MySql;

        /// <summary>
        /// 配置名称
        /// </summary>
        public string Name = "";

        /// <summary>
        /// 服务器地地址
        /// </summary>
        public string Host = "";

        /// <summary>
        /// 端口
        /// </summary>
        public string Port = "3306";

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName = "";

        /// <summary>
        /// 密码
        /// </summary>
        public string Password = "";

        /// <summary>
        /// 数据库名
        /// </summary>
        public string DBName = "";

        /// <summary>
        /// 编码
        /// </summary>
        public string CharSet = "";

        public string ToConnectStr()
        {
            string conn = "";
            switch (this.DbType)
            {
                case SqlDbType.MySql:
                    string mydb = string.IsNullOrEmpty(this.DBName) ? "information_schema" : this.DBName;
                    conn = $"server={this.Host};user id={this.UserName}; password={this.Password}; database={mydb}; pooling=true;charset={this.CharSet};Port={this.Port};";
                    break;
                case SqlDbType.SqlServer:
                    string db = this.DBName == "" ? "master" : this.DBName;
                    conn = $"Data Source={this.Host},{this.Port};User ID={this.UserName};Password={this.Password};Initial Catalog={db};Connect Timeout=10;Encrypt=True;TrustServerCertificate=True;";
                    break;
                case SqlDbType.PostgreSQL:
                    conn = $"Host={Host};Port={Port};Username={UserName};Password={Password}; Database={DBName};Pooling=true;Minimum Pool Size=1";
                    break;
                case SqlDbType.Oracle:
                    conn = $"user id={UserName};password={Password}; data source=//{Host}:{Port}/{DBName};Pooling=true;Min Pool Size=1";
                    break;
                case SqlDbType.Dameng:
                    conn = $"server={Host};port={Port};user id={UserName};password={Password};database={DBName};poolsize=1";
                    break;
                case SqlDbType.KingbaseES:
                    conn = $"Server={Host};Port={Port};UID={UserName};PWD={Password};database={DBName};MAXPOOLSIZE=1";
                    break;
                case SqlDbType.ShenTong:
                    conn = $"HOST={Host};PORT={Port};DATABASE={DBName};USERNAME={UserName};PASSWORD={Password};MAXPOOLSIZE=1";
                    break;
            }
            return conn;
        }
    }
}