using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 启动任务时传入的参数，该参数需序列化为Json数据，然后Urlencode后以命令行参数方式传给litrobot.exe
    /// </summary>
    [Serializable]
    public class BotStart
    {
        /// <summary>
        /// WebSocket 端口
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// WebSocket 服务器地址，为空时为不启用WebSocket
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 机器人id，WebSocket 通讯时以该值来区分多个不同的机器人
        /// </summary>
        public string BotId { get; set; }

        /// <summary>
        /// SDK需要运行的流程文件
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// 服务端的进程id，当litrobot发现主进程不存在时，会退出运行
        /// </summary>
        public int ThreadId { get; set; }

        /// <summary>
        /// 谷歌浏览器缓存ID，方便实现多个不同浏览器的配置隔离
        /// </summary>
        public string CefCacheId { get; set; }

        /// <summary>
        /// 谷歌浏览器User-Agent，这个参数只能在启动时配置，且运行中不能修改
        /// </summary>
        public string CefUserAgent { get; set; }

        /// <summary>
        /// litrobot.exe 运行时窗口的标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 设置运行流程指定字符变量初始值
        /// </summary>
        public Dictionary<string,string> AddVar { get; set; }
    }
}