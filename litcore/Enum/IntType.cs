using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace litcore.type
{
    /// <summary>
    /// 数字变量操作
    /// </summary>
    public enum IntType
    {
        ///// <summary>
        ///// 重置
        ///// </summary>
        //ReSet = 0,

        /// <summary>
        /// 乘以
        /// </summary>
        Multiplied = 1,

        /// <summary>
        /// 增加
        /// </summary>
        Add = 2,

        /// <summary>
        /// 减法
        /// </summary>
        Minus = 3,

        /// <summary>
        /// 四舍五入
        /// </summary>
        Round = 4,

        /// <summary>
        /// 向上取位
        /// </summary>
        RoundUp = 5,

        /// <summary>
        /// 向下取位
        /// </summary>
        RoundDown = 6
    }
}