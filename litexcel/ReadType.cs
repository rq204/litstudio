using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litexcel
{
    public enum ReadType
    {
        /// <summary>
        /// 单元格
        /// </summary>
        Cell = 0,
        /// <summary>
        /// 区域
        /// </summary>
        Region = 1,
        /// <summary>
        /// 行
        /// </summary>
        Row = 2,
        /// <summary>
        /// 列
        /// </summary>
        Col = 3,
    }
}
