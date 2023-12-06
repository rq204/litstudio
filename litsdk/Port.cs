using System;
using System.Drawing;

namespace litsdk
{
    public abstract class Port
    {
        public Guid Id { get; private set; }

        public Guid NextNodeId { get; set; }

        public Rect Bounds { get; set; }

        public abstract Point GetOffset(Rect r);

        public Port()
        {
            this.Id = Guid.NewGuid();
        }

        public void ReSetId()
        {
            this.Id = Guid.NewGuid();
        }
    }

    [Serializable]
    public sealed class NextPort : Port
    {
        public override Point GetOffset(Rect r) => r.CenterBottom;
    }

    [Serializable]
    public sealed class TruePort : Port
    {
        public override Point GetOffset(Rect r) => r.CenterBottom;
    }

    [Serializable]
    public sealed class FalsePort : Port
    {
        public override Point GetOffset(Rect r) => r.CenterRight;
    }
}
