using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    /// <summary>
    /// 窗口操作类型
    /// </summary>
    public enum WindowType
    {
        /// <summary>
        /// 关闭
        /// </summary>
        Close = 0,
        /// <summary>
        /// 最小化
        /// </summary>
        Min = 1,
        /// <summary>
        /// 最大化
        /// </summary>
        Max = 2,
        /// <summary>
        /// 隐藏
        /// </summary>
        Hide = 3,
        /// <summary>
        /// 显示
        /// </summary>
        Show = 4,
        /// <summary>
        /// 置顶
        /// </summary>
        Foreground=5,
    }
}
