using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.ictype
{
    public enum CookieType
    {
        /// <summary>
        /// 导出到文本
        /// </summary>
        ExportFile = 0,
        /// <summary>
        /// 导入到文本
        /// </summary>
        ImportFile = 1,
        /// <summary>
        /// 导出到变量
        /// </summary>
        ExportVar = 2,
        /// <summary>
        /// 导入到变量
        /// </summary>
        ImportVar = 3,
        /// <summary>
        /// 清除当前域名cookie
        /// </summary>
        ClearUrl = 4,
        /// <summary>
        /// 清除所有cookie
        /// </summary>
        ClearAll = 5,

        /// <summary>
        /// 导出变量至AB格式
        /// </summary>
        ExportAbVar = 6,

        ///// <summary>
        ///// 导出所有变量至AB格式
        ///// </summary>
        //ExporAbAllVar=7,

        /// <summary>
        /// 清除非当前域名Cookie
        /// </summary>
        ClearOther = 8,
    }
}
