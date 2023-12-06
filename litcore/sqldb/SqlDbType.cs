using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.sqldb
{
    [Serializable]
    /// <summary>
    /// 数据库类型,和freesql的次序一样的
    /// </summary>
    public enum SqlDbType
    {
        MySql = 0,
        SqlServer = 1,
        PostgreSQL = 2,
        Oracle = 3,
        Sqlite = 4,
        OdbcOracle = 5,
        OdbcSqlServer = 6,
        OdbcMySql = 7,
        OdbcPostgreSQL = 8,
        //
        // 摘要:
        //     通用的 Odbc 实现，只能做基本的 Crud 操作
        //     不支持实体结构迁移、不支持分页（只能 Take 查询）
        //     通用实现为了让用户自己适配更多的数据库，比如连接 mssql 2000、db2 等数据库
        //     默认适配 SqlServer，可以继承后重新适配 FreeSql.Odbc.Default.OdbcAdapter，最好去看下代码
        //     适配新的 OdbcAdapter，请在 FreeSqlBuilder.Build 之后调用 IFreeSql.SetOdbcAdapter 方法设置
        Odbc = 9,
        //
        // 摘要:
        //     武汉达梦数据库有限公司，基于 Odbc 的实现
        OdbcDameng = 10,
        //
        // 摘要:
        //     Microsoft Office Access 是由微软发布的关联式数据库管理系统
        MsAccess = 11,
        //
        // 摘要:
        //     武汉达梦数据库有限公司，基于 DmProvider.dll 的实现
        Dameng = 12,
        //
        // 摘要:
        //     北京人大金仓信息技术股份有限公司，基于 Odbc 的实现
        OdbcKingbaseES = 13,
        //
        // 摘要:
        //     天津神舟通用数据技术有限公司，基于 System.Data.OscarClient.dll 的实现
        ShenTong = 14,
        //
        // 摘要:
        //     北京人大金仓信息技术股份有限公司，基于 Kdbndp.dll 的实现
        KingbaseES = 15,
        //
        // 摘要:
        //     Firebird 是一个跨平台的关系数据库，能作为多用户环境下的数据库服务器运行，也提供嵌入式数据库的实现
        Firebird = 16
    }
}