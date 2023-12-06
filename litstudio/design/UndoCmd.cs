using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litcore;
using litsdk;
using litstudio;
using Newtonsoft.Json;

namespace litstudio
{
    /// <summary>
    /// 撤销恢复
    /// https://www.cnblogs.com/youyipin/p/5923615.html
    /// </summary>
    internal class UndoCmd
    {
        public string NewStr { get; set; }

        /// <summary>
        /// 旧的值
        /// </summary>
        public string OldStr { get; set; }


        internal void Undo(Page page)
        {
            page.SelectedNodes.Clear();
            page.Nodes.Clear();
            List<Node> nodes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<litsdk.Node>>(OldStr, new JsonSerializerSettings { TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto });
            page.Nodes.AddRange(nodes);
            page.Invalidate();
        }

        internal void Redo(Page page)
        {
            page.SelectedNodes.Clear();
            page.Nodes.Clear();
            List<Node> nodes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<litsdk.Node>>(NewStr, new JsonSerializerSettings { TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto });
            page.Nodes.AddRange(nodes);
            page.Invalidate();
        }
    }
}