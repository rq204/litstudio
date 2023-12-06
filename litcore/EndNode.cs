using System;
using System.Drawing;
using litsdk;

namespace litcore
{
    public sealed class EndNode : Node
    {
        private EndNode()
        {
            // required for XmlSerializer.
        }

        public EndNode(Activity activity) : base(activity)
        {
            this.Ports.Clear();
        }

        public override Guid Execute(ActivityContext context)
        {
            return Guid.Empty;
        }

        public override bool CanStartLink => false;
       
    }
}
