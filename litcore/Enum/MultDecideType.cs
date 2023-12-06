using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.type
{
    public enum MultDecideType
    {
        /// <summary>
        /// 所有不为空
        /// </summary>
        AllIsNotEmpty = 0,

        /// <summary>
        /// 所有为空
        /// </summary>
        AllIsEmpty = 1,

        /// <summary>
        /// 不全为空
        /// </summary>
        OneMoreIsEmpty = 2,
    }
}
