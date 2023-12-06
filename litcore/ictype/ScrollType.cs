using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.ictype
{
    public enum ScrollType
    {
        /// <summary>
        /// 底部
        /// </summary>
        Botton = 0,
        /// <summary>
        /// 顶部
        /// </summary>
        Top = 1,

        /// <summary>
        /// 相对向上
        /// </summary>
        UpBy=2,

        /// <summary>
        /// 相对向下
        /// </summary>
        DownBy=3,

        /// <summary>
        /// Xpath
        /// </summary>
        Xpath=4,
    }
}
