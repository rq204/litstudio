using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 机器人消息类型
    /// </summary>
    public enum BotMsgType
    {
        /// <summary>
        /// 下载项目
        /// </summary>
        DownProject = 0,
        /// <summary>
        /// 上传日志
        /// </summary>
        UploadLog = 1,
        /// <summary>
        /// 暂停任务
        /// </summary>
        PauseJob = 2,
        /// <summary>
        /// 停止任务
        /// </summary>
        StopJob = 3,
        /// <summary>
        /// 上传数据
        /// </summary>
        UploadData=4,
        /// <summary>
        /// 继续执行
        /// </summary>
        ContinueJob=5,
    }
}
