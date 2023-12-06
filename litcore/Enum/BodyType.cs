using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.type
{
    /// <summary>
    /// Post类型
    /// </summary>
    public enum BodyType
    {
        /// <summary>
        /// 没有内容
        /// </summary>
        None = 0,
        /// <summary>
        /// application/x-www-form-urlencoded
        /// </summary>
        FormUrlencode = 1,
        /// <summary>
        /// 带文件的
        /// </summary>
        FormData = 2,
        /// <summary>
        /// multipart/form-data
        /// </summary>
        Raw = 3,
        /// <summary>
        /// 二进制
        /// </summary>
        Binary = 4,
    }
}
