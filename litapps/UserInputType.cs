using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litapps
{
    public enum UserInputType
    {
        /// <summary>
        /// 文本框
        /// </summary>
        TextBox = 0,
        /// <summary>
        /// 多行文本框
        /// </summary>
        MulTextBox = 1,
        /// <summary>
        /// 数字输入框
        /// </summary>
        NumericUpDwon = 2,
        /// <summary>
        /// 下拉框
        /// </summary>
        ComboBox = 3,
        /// <summary>
        /// 单选
        /// </summary>
        RadioButton = 4,
        /// <summary>
        /// 复选
        /// </summary>
        CheckBox = 5,
    }
}