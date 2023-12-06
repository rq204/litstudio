using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 数据类型
    /// </summary>
    [Serializable]
    public enum VariableType
    {
        /// <summary>
        /// 字符
        /// </summary>
        String = 0, 
        /// <summary>
        /// 数字
        /// </summary>
        Int = 1,
        /// <summary>
        /// 列表
        /// </summary>
        List = 2, 
        /// <summary>
        /// 布尔
        /// </summary>
        Boolen = 3, 
        /// <summary>
        /// 表格
        /// </summary>
        Table = 4
    }
}