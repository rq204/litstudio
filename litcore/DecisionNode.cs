using litsdk;
using System;
using System.Drawing;
using System.Linq;

namespace litcore
{
    /// <summary>
    /// 判断节点
    /// </summary>
    public sealed class DecisionNode : Node
    {
        private DecisionNode()
        {
            // required for XmlSerializer.
        }

        public DecisionNode(Activity activity) : base(activity)
        {
            this.Ports.Add(new TruePort());
            this.Ports.Add(new FalsePort());
        }

        public override Guid Execute(ActivityContext context)
        {
            if ((this.Activity as DecisionActivity).Execute(context))
            {
                return this.Ports.Where(x => x is TruePort).First().NextNodeId;
            }
            else
            {
                return this.Ports.Where(x => x is FalsePort).First().NextNodeId;
            }
        }
    }
}
