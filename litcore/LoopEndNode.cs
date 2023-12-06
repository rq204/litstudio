using litsdk;
using System;
using System.Drawing;
using System.Linq;

namespace litcore
{
    /// <summary>
    /// 循环结束
    /// </summary>
    public sealed class LoopEndNode : Node
    {
        public Guid LoopStartNodeId { get; set; }

        private LoopEndNode()
        {
            // required for XmlSerializer.
        }

        public LoopEndNode(Activity activity) : base(activity)
        {
            this.Ports.Add(new NextPort());
        }

        public override Guid Execute(ActivityContext context)
        {
            return this.Ports.First().NextNodeId;
        }
    }
}