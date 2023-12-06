using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.type
{
    /// <summary>
    /// 智能提取类型
    /// </summary>
    public enum SourceType
    {
        /// <summary>
        /// 网址
        /// </summary>
        Href = 0,
        /// <summary>
        /// 图片
        /// </summary>
        Src = 1,
        /// <summary>
        /// 手机号
        /// </summary>
        Phone = 2,
        /// <summary>
        /// 邮箱
        /// </summary>
        Email = 3,
    }
}
