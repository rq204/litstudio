using System;
using System.Linq;

namespace litsdk
{
    /// <summary>
    /// 开始活动
    /// </summary>
    [Serializable]
    public sealed class StartActivity : Activity
    {
        /// <summary>
        /// 
        /// </summary>
        public override string Name { set { } get => "开始"; }

        /// <summary>
        /// 
        /// </summary>
        public override ActivityGroup Group => ActivityGroup.General;

        /// <summary>
        /// 
        /// </summary>
        public override void ShowConfig()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Validate(ActivityContext context)
        {
        }
    }
}