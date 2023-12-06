using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace litsdk
{
    /// <summary>
    /// 所有组件的基类
    /// </summary>
    [Serializable]
    public abstract class Activity
    {
        /// <summary>
        /// 流程名，显示在列表中
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// 校验当前流程
        /// </summary>
        /// <returns></returns>
        public abstract void Validate(ActivityContext context);

        /// <summary>
        ///  弹出配置界面
        /// </summary>
        public abstract void ShowConfig();

        /// <summary>
        /// 分组
        /// </summary>
        public abstract ActivityGroup Group { get; }
    }
}