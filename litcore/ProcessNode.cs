using litsdk;
using System;
using System.Drawing;
using System.Linq;

namespace litcore
{
    public sealed class ProcessNode : Node
    {
        private ProcessNode()
        {
            // required for XmlSerializer.
        }

        public ProcessNode(Activity activity) : base(activity)
        {
            this.Ports.Add(new NextPort());
        }

        public override Guid Execute(ActivityContext context)
        {
            (this.Activity as ProcessActivity).Execute(context);
            return this.Ports.First().NextNodeId;
        }
    }
}
