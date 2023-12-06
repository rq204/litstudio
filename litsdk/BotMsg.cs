using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 发送的消息
    /// </summary>
    public class BotMsg
    {
        /// <summary>
        /// 消息类型
        /// </summary>
        public BotMsgType BotMsgType = BotMsgType.DownProject;

        /// <summary>
        /// 消息值
        /// </summary>
        public string Data = "";

        /// <summary>
        /// 运行日志
        /// </summary>
        public List<string> Logs = new List<string>();
    }
}
