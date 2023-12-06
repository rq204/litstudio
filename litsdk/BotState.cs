using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 机器人状态
    /// </summary>
    [Serializable]
    public enum BotState
    {
        /// <summary>
        /// 停止
        /// </summary>
        Stopped = 0,
        /// <summary>
        /// 运行中
        /// </summary>
        Running,
        /// <summary>
        /// 暂停
        /// </summary>
        Paused,
        /// <summary>
        /// 运行完成
        /// </summary>
        Completed
    }
}
