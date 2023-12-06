using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litsdk
{
    /// <summary>
    /// 组件商店
    /// </summary>
    public class ActivityStore
    {
        /// <summary>
        /// id编号
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///  描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string author { get; set; }

        /// <summary>
        /// 网站
        /// </summary>
        public string website { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime pubtime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime uptime { get; set; }

        /// <summary>
        /// 压缩包大小
        /// </summary>
        public int size { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        public string downurl { get; set; }

        /// <summary>
        /// 全名
        /// </summary>
        public string fullname { get; set; }
    }
}
