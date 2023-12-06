using litsdk;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace litcore
{
    /// <summary>
    /// 循环开始
    /// </summary>
    public sealed class LoopStartNode : Node
    {
        public Guid LoopEndNodeId { get; set; }

        private LoopStartNode()
        {
            // required for XmlSerializer.
        }

        public LoopStartNode(Activity activity) : base(activity)
        {
            this.Ports.Add(new NextPort());
        }

        public override Guid Execute(ActivityContext context)
        {
            return this.Ports.First().NextNodeId;
        }

      
        [JsonIgnore]
        /// <summary>
        /// 需要循环次数,-1初始化，0为无限
        /// </summary>
        public int NeedLoop = -1;

        [JsonIgnore]
        /// <summary>
        /// 已经循环的次数
        /// </summary>
        public int RunIndex = -1;

        [JsonIgnore]
        /// <summary>
        /// 循环的列表
        /// </summary>
        public List<string> LoopList = new List<string>();

        [JsonIgnore]
        /// <summary>
        /// 循环的datatable
        /// </summary>
        public System.Data.DataTable Table = new System.Data.DataTable();

    }
}