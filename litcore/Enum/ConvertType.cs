using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace litcore.type
{
    /// <summary>
    /// 转换类型
    /// </summary>
    public enum ConvertType
    {
        /// <summary>
        /// 字符串到数字 
        /// </summary>
        StrToInt = 0,

        /// <summary>
        /// 字符串添加到list
        /// </summary>
        StrAddToList = 1,

        /// <summary>
        /// 列表使用Join合并成字符串
        /// </summary>
        ListJoinToStr = 2,

        /// <summary>
        /// 复制listtolist
        /// </summary>
        CopyListToList = 3,

        /// <summary>
        /// 列表变量长度变数字
        /// </summary>
        ListCountToInt = 4,

        /// <summary>
        /// 字符长度变数字
        /// </summary>
        StrLenghToInt = 5,

        /// <summary>
        /// 表格A序列化为B
        /// </summary>
        TableAToJsonB = 6,

        /// <summary>
        /// 表格记录数转数字B
        /// </summary>
        TableACountToIntB = 7,

        /// <summary>
        /// 字符A分割成列表B
        /// </summary>
        StrSplitToList = 8,

        /// <summary>
        /// 表格A内容添加至表格B
        /// </summary>
        TableAAdd2TableB = 9,

        /// <summary>
        /// 列表A移除字符B
        /// </summary>
        ListARemoveStrB = 10,

        /// <summary>
        /// json数据转成表格
        /// </summary>
        JsonStrAToTableB = 11,
    }
}