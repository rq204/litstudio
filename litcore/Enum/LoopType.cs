using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace litcore.type
{
    /// <summary>
    /// 循环类型
    /// </summary>
    public enum LoopType
    {
        /// <summary>
        /// 无限循环
        /// </summary>
        Forever = 0,
        /// <summary>
        /// 循环指定次数
        /// </summary>
        Number = 1,
        /// <summary>
        /// 按列表循环
        /// </summary>
        List = 2,
        /// <summary>
        /// 循环指定数字变量
        /// </summary>
        IntVar = 3,

        /// <summary>
        /// 表格循环
        /// </summary>
        Table = 4,
    }
}