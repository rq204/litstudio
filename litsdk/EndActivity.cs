using System;

namespace litsdk
{
    /// <summary>
    /// 流程结束
    /// </summary>
    [Serializable]
    public sealed class EndActivity : Activity
    {
        /// <summary>
        /// 组件名称
        /// </summary>
        public override string Name { set { } get => "结束"; }

        /// <summary>
        /// 组件分组
        /// </summary>
        public override ActivityGroup Group =>  ActivityGroup.General;

        /// <summary>
        /// 组件配置界面无
        /// </summary>
        public override void ShowConfig()
        {
        }

        /// <summary>
        /// 流程组件配置检测
        /// </summary>
        /// <param name="context"></param>
        public override void Validate(ActivityContext context)
        {
        }
    }
}
