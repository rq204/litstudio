using System;
using System.Collections.Generic;
using System.Linq;

namespace litsdk
{
    /// <summary>
    /// 条件判断
    /// </summary>
    [Serializable]
    public abstract class DecisionActivity : Activity
    {
        /// <summary>
        /// 条件判断，返回true或false
        /// </summary>
        /// <param name="context">上下文内容</param>
        /// <returns>结果</returns>
        public abstract bool Execute(ActivityContext context);
    }
}