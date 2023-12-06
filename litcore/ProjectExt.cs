using litsdk;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace litcore
{
    /// <summary>
    /// 项目配置文件，两大核心，行为和数据
    /// </summary>
    public static class ProjectExt
    {
        /// <summary>
        /// 获取包含的行为，
        /// </summary>
        /// <returns></returns>
        public static void CheckCreateApp(this Project project, ref bool IsFront, ref bool IsWinForm, ref bool IsBrowser)
        {
            foreach (Node node in project.Nodes)
            {
                if (node is EndNode) continue;

                // 如果没有任何链接到就不处理
                if (project.Nodes.Find((f) => f.Ports.Find((m) => m.NextNodeId == node.Id) != null) != null)
                {
                    Utility.CheckActivity(node.Activity, ref IsFront, ref IsWinForm, ref IsBrowser);
                }
            }
        }


    }
}