using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.ictype
{
    /// <summary>
    /// 时间来源方式
    /// </summary>
    public enum TimeType
    {
        /// <summary>
        /// 当前时间
        /// </summary>
        TimeNow = 1,
        /// <summary>
        /// 特定时间
        /// </summary>
        SpecialTime = 2,
        /// <summary>
        /// 最近周几
        /// </summary>
        LastDayOfWeek = 3,
        /// <summary>
        /// 兼容处理旧的
        /// </summary>
        None = 0
    }
}
