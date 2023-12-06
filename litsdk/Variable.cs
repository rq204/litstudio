using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 变量定义
    /// </summary>
    [Serializable]
    public class Variable
    {
        /// <summary>
        /// 变量名
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 变量类型
        /// </summary>
        public litsdk.VariableType VariableType { get; set; }

        /// <summary>
        /// 字符变量值
        /// </summary>
        public string StrValue { get; set; }


        private List<string> listValue = new List<string>();
        /// <summary>
        /// 列表变量值
        /// </summary>
        public List<string> ListValue
        {
            get
            {
                if (listValue == null) listValue = new List<string>();
                return listValue;
            }
            set => listValue = value;
        }

        /// <summary>
        /// 数字变量值
        /// </summary>
        public int IntValue { get; set; }

        /// <summary>
        /// 布尔变量
        /// </summary>
        public bool BoolenValue { get; set; }

        /// <summary>
        /// 表格变量
        /// </summary>
        public System.Data.DataTable TableValue
        {
            get; set;
        }

        /// <summary>
        /// 初始化表格
        /// </summary>
        public System.Data.DataTable InitTableValue
        {
            get;set;
        }

        /// <summary>
        /// 初始值字符
        /// </summary>
        public string InitStrValue { get; set; }

        /// <summary>
        /// 初始值数字
        /// </summary>
        public int InitIntValue { get; set; }


        private List<string> initListValue = new List<string>();
        /// <summary>
        /// 初始值列表
        /// </summary>
        public List<string> InitListValue
        {
            get
            {
                if (initListValue == null) initListValue = new List<string>();
                return initListValue;
            }
            set => initListValue = value;
        }

        private List<string> tableColumns = new List<string>();
        /// <summary>
        /// 表格表头
        /// </summary>
        public List<string> TableColumns
        {
            get
            {
                if (tableColumns == null) tableColumns = new List<string>();
                return tableColumns;
            }
            set => tableColumns = value;
        }
    }
}
