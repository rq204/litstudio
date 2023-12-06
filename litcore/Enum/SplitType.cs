using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace litcore.type
{
    /// <summary>
    /// 字符串分割成list的方式
    /// </summary>
    public enum SplitType
    {
        /// <summary>
        /// 字符串split
        /// </summary>
        StrSplit = 0,

        /// <summary>
        /// 正则循环提取
        /// </summary>
        RegexMatch = 1,

        /// <summary>
        /// 使用楼层型分割
        /// </summary>
        FloorMatch = 2,

        /// <summary>
        /// Json数组转列表
        /// </summary>
        JsonArr = 3
    }
}