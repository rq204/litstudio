using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore
{
    public class BotRunLog
    {
        BotRunner botRunner = null;
        public BotRunLog(BotRunner br)
        {
            this.botRunner = br;
        }

        public Action<litsdk.Node, string> NodeAction;

        public Action<BotRunner, string> BotRunnerAction;

        public void WriteLog(string log)
        {
            if (NodeAction != null) NodeAction(this.botRunner.CurrentNode, log);
            if (BotRunnerAction != null) BotRunnerAction(this.botRunner, log);
        }


    }
}