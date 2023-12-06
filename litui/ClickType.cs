using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    /// <summary>
    /// 鼠标点击方式
    /// </summary>
    public enum ClickType
    {
        Click = 0,
        DoubleClick = 1,
        Down = 2,
        Up = 3,
        /// <summary>
        /// 悬浮
        /// </summary>
        Hover=4,
    }
}