using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litext
{
    public enum FileAttriType
    {
        //获取创建时间
        GetCreationTime = 0,

        /// <summary>
        /// 获取修改时间
        /// </summary>
        GetLastWriteTime = 1,

        /// <summary>
        /// 获取最近一次访问时间
        /// </summary>
        GetLastAccessTime = 2,

        /// <summary>
        /// 设置创建时间
        /// </summary>
        SetCreationTime,

        /// <summary>
        /// 设置修改时间
        /// </summary>
        SetLastWriteTime,

        /// <summary>
        /// 设置最近一次访问时间
        /// </summary>
        SetLastAccessTime,
    }
}
