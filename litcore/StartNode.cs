
using litsdk;
using System;
using System.Drawing;
using System.Linq;

namespace litcore
{
    public sealed class StartNode : Node
    {
        private StartNode()
        {
        }

        public StartNode(Activity activity) : base(activity)
        {
            this.Ports.Add(new NextPort());
        }

        public override Guid Execute(ActivityContext context)
        {
            return this.Ports.First().NextNodeId;
        }

        public override bool CanEndLink => false;
    }
}