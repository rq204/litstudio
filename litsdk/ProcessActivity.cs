using System;
using System.Collections.Generic;
using System.Linq;

namespace litsdk
{
    /// <summary>
    /// 单步操作类型
    /// </summary>
    [Serializable]
    public abstract class ProcessActivity : Activity
    {
        /// <summary>
        /// 执行具体流程操作
        /// </summary>
        /// <param name="context">上下文内容</param>
        public abstract void Execute(ActivityContext context);
    }
}