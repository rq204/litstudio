using litsdk;
using System;

namespace litcore.activity
{
    /// <summary>
    /// 循环
    /// </summary>
    public sealed class LoopEndActivity : Activity
    {
        private string name = "循环";
        public override string Name { set { name = value; } get => name; }

        public override ActivityGroup Group =>  ActivityGroup.General;

        public void Execute(ActivityContext context)
        {

        }

        public override void ShowConfig()
        {

        }

        public override void Validate(ActivityContext context) { }
    }
}