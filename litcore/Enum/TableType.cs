using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.type
{
    public enum TableType
    {
        /// <summary>
        /// 添加
        /// </summary>
        Add = 0,
        /// <summary>
        /// 删除一行
        /// </summary>
        DeleteOne = 1,
        /// <summary>
        /// 删除多行
        /// </summary>
        DeleteMore = 2,
        /// <summary>
        /// 删除所有
        /// </summary>
        DeleteAll = 3,
        /// <summary>
        /// 编辑一行
        /// </summary>
        EditOne = 4,
        /// <summary>
        /// 编辑多行
        /// </summary>
        EditMore = 5,
        /// <summary>
        /// 排除重复
        /// </summary>
        Distinct = 6,
        /// <summary>
        /// 排序
        /// </summary>
        Sort = 7,
        /// <summary>
        /// 单元取值
        /// </summary>
        CellData = 8,
        /// <summary>
        /// 按Row另存为表格
        /// </summary>
        Rows2Table = 9,
    }
}