using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace litcore.type
{
    /// <summary>
    /// 判断的类型
    /// </summary>
    public enum LogicType
    {
        /// <summary>
        /// 字符A包含字符B
        /// </summary>
        StrAIndexOfStrB = 0,

        /// <summary>
        /// 字符A等于字符B
        /// </summary>
        StrAEqualsStrB = 1,

        ///// <summary>
        ///// 字符串A值不为空
        ///// </summary>
        //StrAEmpty = 2,

        /// <summary>
        /// List变量A包含字符B
        /// </summary>
        ListAContainsStrB = 3,

        /// <summary>
        /// 数字A等于数字B
        /// </summary>
        IntAEqualsIntB = 4,

        /// <summary>
        /// 数字A大于数字B
        /// </summary>
        IntABigerIntB = 5,

        /// <summary>
        /// 表格A等于表格B
        /// </summary>
        TableAEqualsTableB = 6,

        /// <summary>
        /// 数字A等于0
        /// </summary>
        IntAIsZero = 7,

        /// <summary>
        /// 字符串A值不为空
        /// </summary>
        StrANotEmpty = 8,

        /// <summary>
        /// 字符A包含列表B某项
        /// </summary>
        StrAContainsListBItem = 9,

        /// <summary>
        /// 表格行大于0
        /// </summary>
        TableARowsBiger0 = 10,

        /// <summary>
        /// 列表行数大于0
        /// </summary>
        ListACountBiger0 = 11,

        /// <summary>
        /// 列表A条数大于数字B
        /// </summary>
        ListACountBigerIntB=12,

        /// <summary>
        /// 列表A条数等于数字B
        /// </summary>
        ListACountEqualsIntB = 13,

        /// <summary>
        /// 列表A条数小于数字B
        /// </summary>
        ListACountLessIntB = 14,

        /// <summary>
        /// 列表A不包含字符B
        /// </summary>
        ListANotContainsStrB=15,

        /// <summary>
        /// 列表A行数大于等于数字B
        /// </summary>
        ListACountBigerEqualIntB=16,

        /// <summary>
        /// 表格A行数大于数字B
        /// </summary>
        TableARowsBigerIntB=17,
    }
}