using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace litcore
{
    /// <summary>
    /// 机器人运行逻辑
    /// </summary>
    public sealed class BotRunner
    {
        private Project project = null;
        private litsdk.ActivityContext activityContext = null;
        public litsdk.ActivityContext ActivityContext
        {
            get { return this.activityContext; }
        }

        public BotRunner(Project project)
        {
            this.project = project;
            this.State = BotState.Stopped;
            this.CurrentNode = null;
            this.activityContext = new ActivityContext(project.Variables);
            this.activityContext.GetCancellationTokenSource = new Func<CancellationTokenSource>(() => { return this.ctsStop; });
        }

        public BotState State { get; private set; }

        /// <summary>
        /// 运行状态变化时
        /// </summary>
        public Action<litcore.BotRunner> OnStateChanged;
        private void setStateChange()
        {
            if (OnStateChanged != null) OnStateChanged(this);
        }

        /// <summary>
        /// 当当前node变化时，给设计器用的
        /// </summary>
        public Action<Node> OnNodeChanged;

        private void setNodeChange(Node node)
        {
            if (OnNodeChanged != null) OnNodeChanged(node);
        }

        public Node CurrentNode = null;
        public static Node ExeUserLogNode = null;

        public CancellationTokenSource ctsStop;

        public void InitAction()
        {
            this.activityContext.GetUserConfig = this.GetUserConfig;
            this.activityContext.RunProject = this.RunProject;
            this.activityContext.RunProtectProject = this.RunProtectProject;
            this.activityContext.SetUserConfig = this.SetUserConfig;
        }

        private void RunProtectProject(string desproject)
        {
            string ps = DESDecrypt(desproject, "#$5fgH40", "tesDj.,5");
            this.RunProject(ps, true);
        }

        /// <summary>  
        /// C# DES解密方法  
        /// </summary>  
        /// <param name="encryptedValue">待解密的字符串</param>  
        /// <param name="key">密钥</param>  
        /// <param name="iv">向量</param>  
        /// <returns>解密后的字符串</returns>  
        private static string DESDecrypt(string encryptedValue, string key, string iv)
        {
            using (DESCryptoServiceProvider sa =
                new DESCryptoServiceProvider
                { Key = Encoding.UTF8.GetBytes(key), IV = Encoding.UTF8.GetBytes(iv) })
            {
                using (ICryptoTransform ct = sa.CreateDecryptor())
                {
                    byte[] byt = Convert.FromBase64String(encryptedValue);

                    using (var ms = new System.IO.MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                        {
                            cs.Write(byt, 0, byt.Length);
                            cs.FlushFinalBlock();
                        }
                        return Encoding.UTF8.GetString(ms.ToArray());
                    }
                }
            }
        }

        public void Run(CancellationTokenSource ctsStop = null)
        {
            if (ctsStop == null) ctsStop = new CancellationTokenSource();
            this.ctsStop = ctsStop;

            switch (this.State)
            {
                case BotState.Running:
                    this.setStateChange();
                    break;
                case BotState.Paused:
                    this.ctsStop = ctsStop;
                    this.State = BotState.Running;
                    this.setStateChange();
                    this.RunNextAsync();
                    break;
                case BotState.Stopped:
                case BotState.Completed:
                    this.activityContext.InitVariable();
                    this.CurrentNode = this.project.Nodes.First(x => x is StartNode);
                    this.State = BotState.Running;

                    foreach (Node node in this.project.Nodes)
                    {
                        if (node is LoopStartNode loopStart) loopStart.NeedLoop = -1;
                    }

                    this.setStateChange();
                    this.RunNextAsync();
                    break;
            }
        }


        /// <summary>
        /// 暂停
        /// </summary>
        public void Pause()
        {
            if (this.State == BotState.Running)
            {
                if (!this.ctsStop.IsCancellationRequested)
                {
                    this.ctsStop.Cancel();
                    System.Threading.Thread.Sleep(100);
                }

                activityContext.WriteLog("当前操作被用户暂停");
            }
            this.State = BotState.Paused;
            this.setStateChange();
        }

        /// <summary>
        /// 停止
        /// </summary>
        public void Stop()
        {
            if (this.State == BotState.Running || this.State == BotState.Paused)
            {
                if (!this.ctsStop.IsCancellationRequested)
                {
                    this.ctsStop.Cancel();
                    System.Threading.Thread.Sleep(100);
                }

                activityContext.WriteLog("当前操作被用户停止");
            }
            this.State = BotState.Stopped;
            this.setStateChange();
        }

        private void RunNextAsync()
        {
            // this.runTask = 
            Task.Run(() =>
            {
                var nextNodeId = Guid.Empty;
                try
                {
                    if (this.CurrentNode == null)
                    {
                        throw new OperationCanceledException("The robot cannot find the current activity.", this.ctsStop.Token);
                    }
                    if (this.CurrentNode is StartNode)
                    {
                        if (!this.refStatus) this.activityContext.WriteLog("当前流程开始");
                    }

                    ///最深入的当前运行的流程
                    ExeUserLogNode = this.CurrentNode;

                    this.setNodeChange(this.CurrentNode);
                    this.ctsStop.Token.ThrowIfCancellationRequested();

                    if (this.CurrentNode is EndNode endNode)
                    {
                        try
                        {
                            if (this.activityContext.OnEnd != null && !this.refStatus)
                            {
                                this.activityContext.OnEnd();//异步子流程
                            }
                        }
                        catch { }
                        throw new OperationCanceledException("The robot completed successfully.", null);
                    }

                    if (this.CurrentNode.Ports.Count == 1) nextNodeId = this.CurrentNode.Ports[0].NextNodeId;
                    if (this.CurrentNode.Activity.Group == ActivityGroup.CefBroswer)
                    {
#if NET461
                        litsdk.API.GetMainForm().Invoke((EventHandler)delegate
                        {
                            nextNodeId = this.CurrentNode.Execute(this.activityContext);
                        });
#endif
                    }
                    else
                    {
                        nextNodeId = this.CurrentNode.Execute(this.activityContext);
                    }
                    if (this.CurrentNode is LoopStartNode loopStartNode)
                    {
                        litcore.activity.LoopStartActivity loopStartActivity = loopStartNode.Activity as litcore.activity.LoopStartActivity;
                        switch (loopStartActivity.LoopType)
                        {
                            case type.LoopType.Forever:
                                loopStartNode.NeedLoop = int.MaxValue;
                                break;
                            case type.LoopType.IntVar:
                                loopStartNode.NeedLoop = this.activityContext.GetInt(loopStartActivity.IntVarName);
                                break;
                            case type.LoopType.Number:
                                loopStartNode.NeedLoop = loopStartActivity.Number;
                                break;
                            case type.LoopType.List:
                                loopStartNode.LoopList = this.activityContext.GetList(loopStartActivity.ListVarName).ToArray().ToList();
                                loopStartNode.NeedLoop = loopStartNode.LoopList.Count;
                                break;
                            case type.LoopType.Table:
                                System.Data.DataTable oldTable = activityContext.GetTable(loopStartActivity.TableVarName);
                                loopStartNode.Table = oldTable.Copy();//  activityContext.GetTable(loopStartActivity.TableVarName);
                                loopStartNode.NeedLoop = loopStartNode.Table.Rows.Count;
                                break;
                        }
                        if (loopStartNode.NeedLoop == 0)//如果是0次就直接跳出
                        {
                            this.activityContext.WriteLog("当前循环计算循环次数为0，不进行该循环");
                            nextNodeId = this.GetNodeById(loopStartNode.LoopEndNodeId).Execute(this.activityContext);//直接end
                            if (nextNodeId == Guid.Empty) throw new OperationCanceledException("The robot completed successfully.", null);
                        }
                        else
                        {
                            loopStartNode.RunIndex = 0;
                            if (loopStartActivity.LoopType == type.LoopType.List)
                            {
                                this.activityContext.SetVarStr(loopStartActivity.SaveVarName, loopStartNode.LoopList[loopStartNode.RunIndex]);
                            }
                            else if (loopStartActivity.LoopType == type.LoopType.Table)
                            {
                                this.SetTable(loopStartNode);
                            }
                            this.activityContext.WriteLog($"当前循环{loopStartNode.RunIndex + 1}/{loopStartNode.NeedLoop}");
                            if (!string.IsNullOrEmpty(loopStartActivity.SaveVarName))
                            {
                                activityContext.SetVarInt(loopStartActivity.SaveVarName, 1);
                            }
                        }
                    }
                    else if (this.CurrentNode is LoopEndNode loopEndNode)
                    {
                        LoopStartNode loopStartNode2 = this.GetNodeById(loopEndNode.LoopStartNodeId) as LoopStartNode;
                        this.setNodeChange(loopStartNode2);
                        litcore.activity.LoopStartActivity loopStartActivity = loopStartNode2.Activity as litcore.activity.LoopStartActivity;
                        if (loopStartNode2.NeedLoop > loopStartNode2.RunIndex + 1)
                        {
                            loopStartNode2.RunIndex++;
                            if (loopStartActivity.LoopType == type.LoopType.List) this.activityContext.SetVarStr(loopStartActivity.SaveVarName, loopStartNode2.LoopList[loopStartNode2.RunIndex]);
                            else if (loopStartActivity.LoopType == type.LoopType.Table)
                            {
                                this.SetTable(loopStartNode2);
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(loopStartActivity.SaveVarName))
                                {
                                    activityContext.SetVarInt(loopStartActivity.SaveVarName, loopStartNode2.RunIndex + 1);
                                }
                            }
                            nextNodeId = loopStartNode2.Ports.First().NextNodeId;
                            this.activityContext.WriteLog($"当前循环{loopStartNode2.RunIndex + 1}/{loopStartNode2.NeedLoop}");
                        }
                        else
                        {
                            //完全结束后重置
                            loopStartNode2.NeedLoop = -1;
                            if (loopStartNode2.Table != null) loopStartNode2.Table.Dispose();
                        }
                    }

                    if (this.GetNodeById(nextNodeId) is Node nextNode)
                    {
                        this.CurrentNode = nextNode;
                        this.RunNextAsync();
                    }
                    else
                    {
                        throw new OperationCanceledException("The robot cannot find the next activity.", this.ctsStop.Token);
                    }
                }
                catch (OperationCanceledException opex)
                {
                    if (opex.CancellationToken != this.ctsStop.Token)
                    {
                        if (!this.refStatus) this.activityContext.WriteLog("当前流程成功完成");
                        this.State = BotState.Completed;
                        this.setNodeChange(null);
                        this.setStateChange();
                    }
                }
                catch (Exception ex)
                {
                    if (nextNodeId != Guid.Empty && this.GetNodeById(nextNodeId) is DecisionNode deciNode)
                    {
                        if (deciNode.Activity is litcore.activity.ErrorCatchActivity errActivity)
                        {
                            this.activityContext.LastError = ex.Message + ex.StackTrace;
                            nextNodeId = deciNode.Execute(this.activityContext);
                            this.CurrentNode = this.GetNodeById(nextNodeId);
                            this.RunNextAsync();
                            return;
                        }
                    }

                    string inner = ex.InnerException == null ? "" : ex.InnerException.Message + "\r\n" + ex.InnerException.StackTrace;
                    string error = ex.Message + "\r\n" + ex.StackTrace + "\r\n" + inner;
                    if (Environment.MachineName != "WENNAS-PC") error = ex.Message;
                    error = error.Trim();

                    if (this.refStatus)
                    {
                        this.refError = error;
                    }
                    else
                    {
                        this.activityContext.WriteLog(error);// + "\r\n" + ex.StackTrace + "\r\n" + inner
                        if (litsdk.API.GetDesignActivityContext != null)
                        {
                            this.activityContext.WriteLog("当前测试暂停");// + "\r\n" + ex.StackTrace + "\r\n" + inner
                        }
                    }

                    if (litsdk.API.GetDesignActivityContext == null)
                    {
                        this.State = BotState.Stopped;
                    }
                    else
                    {
                        this.State = BotState.Paused;
                    }

                    if (!this.refStatus)
                    {
                        this.setStateChange();
                    }
                }
            });
        }

        private void SetTable(LoopStartNode loopStartNode)
        {
            System.Data.DataRow dr = loopStartNode.Table.Rows[loopStartNode.RunIndex];
            foreach (System.Data.DataColumn dc in loopStartNode.Table.Columns)
            {
                string objvalue = dr[dc.ColumnName] == null ? "" : dr[dc.ColumnName].ToString();
                if (this.activityContext.ContainsStr(dc.ColumnName))
                {
                    this.activityContext.SetVarStr(dc.ColumnName, objvalue);
                }
                else if (this.activityContext.ContainsInt(dc.ColumnName))
                {
                    int data = -1;
                    if (int.TryParse(objvalue, out data))
                    {
                        this.activityContext.SetVarInt(dc.ColumnName, data);
                    }
                    else this.activityContext.SetVarInt(dc.ColumnName, -1);
                }
            }
        }

        private Node GetNodeById(Guid id)
        {
            return this.project.Nodes.FirstOrDefault(x => x.Id == id);
        }

        public void Validate(ref Node snode)
        {
            //除起始node外先删除没有链接入的单个
            List<Node> filterNodes = this.project.Nodes.ToArray().ToList();
            while (true)
            {
                List<Node> processNodes = filterNodes.FindAll((f) => f is ProcessNode).ToList();
                //没有链接到下一个
                List<Node> bottons = processNodes.FindAll((p) => p.Ports.First().NextNodeId == Guid.Empty);
                foreach (Node node in bottons)
                {
                    filterNodes.Remove(node);
                    processNodes.Remove(node);
                }

                //没有上一个链接
                List<Node> tops = new List<Node>();
                foreach (Node t in processNodes)
                {
                    if (filterNodes.FindAll((n) => n != t && n.Ports.FindAll((ps) => ps.NextNodeId == t.Id).Count > 0).Count == 0) tops.Add(t);
                }
                foreach (Node node in tops) filterNodes.Remove(node);

                //判断节点
                List<Node> decis = filterNodes.FindAll((f) => f is DecisionNode d && (d.Ports.First().NextNodeId == Guid.Empty || d.Ports[1].NextNodeId == Guid.Empty || filterNodes.FindAll((m) => m.Id == d.Id).Count == 0));
                foreach (Node node in decis) filterNodes.Remove(node);

                //循环节点
                List<Node> loops = filterNodes.FindAll((f) => f is LoopStartNode d && (d.Ports.First().NextNodeId == Guid.Empty || filterNodes.FindAll((m) => m.Id == d.Id).Count == 0));
                foreach (Node node in loops)
                {
                    Node lend = filterNodes.Find((q) => q is LoopEndNode le && le.LoopStartNodeId == node.Id);
                    filterNodes.Remove(node);
                    filterNodes.Remove(lend);
                }

                if (bottons.Count == 0 && tops.Count == 0 && decis.Count == 0 && loops.Count == 0) break;
            }

            //todo 优先级低
            foreach (Node node in filterNodes)
            {
                snode = node;
                if (node is StartNode startNode)
                {
                    if (startNode.Execute(this.activityContext) == Guid.Empty)
                    {
                        throw new Exception("第一个活动必须链接到开始");
                    }
                }
                else if (node is litcore.DecisionNode decisionNode)//判断节点
                {
                    if (decisionNode.Ports[0].NextNodeId == Guid.Empty || decisionNode.Ports[1].NextNodeId == Guid.Empty) throw new Exception("判断节点必须同时接入两个活动");
                }
                else if (node is litcore.LoopStartNode loopStartNode)
                {
                    if (loopStartNode.Ports[0].NextNodeId == Guid.Empty) throw new Exception("开始循环必须接入下一个活动");
                }

                if (node is EndNode) continue;

                node.Activity.Validate(this.activityContext);
                snode = node;// = node.Activity.Error;
            }
        }

        /// <summary>
        /// 引用状态
        /// </summary>
        private bool refStatus = false;

        /// <summary>
        /// 引用发生的错误
        /// </summary>
        private string refError = null;

        /// <summary>
        /// 设置为引用
        /// </summary>
        internal void SetRefTrue()
        {
            this.refStatus = true;
        }

        /// <summary>
        /// 引用流程运行
        /// </summary>
        /// <param name="pjrefer"></param>
        /// <param name="pnow"></param>
        public void RunProject(string pjjson, bool onlyUserLog)
        {
            litsdk.Project pjrefer = litsdk.Project.GetProject(pjjson);
            foreach (Variable v in pjrefer.Variables)
            {
                Variable find = this.activityContext.Variables.Find((f) => f.Name == v.Name && f.VariableType == v.VariableType);
                if (find != null)
                {
                    v.InitIntValue = find.IntValue;
                    v.InitStrValue = find.StrValue;
                    v.InitListValue = find.ListValue.ToArray().ToList();
                    if (find.TableValue != null) v.InitTableValue = find.TableValue.Copy();
                    else v.InitTableValue = null;
                }
            }
            BotRunner botRunner2 = new BotRunner(pjrefer);
            botRunner2.refStatus = true;
            if (onlyUserLog)
            {
                BotRunLog brl = new BotRunLog(botRunner2);
                brl.NodeAction = new Action<litsdk.Node, string>(this.ShowOnlyUserLog);
                botRunner2.activityContext.WriteLog = brl.WriteLog;
            }
            else
            {
                botRunner2.activityContext.WriteLog = this.activityContext.WriteLog;
            }
            botRunner2.InitAction();
            botRunner2.Run(this.ctsStop);

            while (botRunner2.State == BotState.Running)
            {
#if NET461
                if (Console.In == System.IO.StreamReader.Null) System.Windows.Forms.Application.DoEvents();
#endif
                System.Threading.Thread.Sleep(200);
            }

            foreach (Variable v in pjrefer.Variables)
            {
                Variable find = this.activityContext.Variables.Find((f) => f.Name == v.Name && f.VariableType == v.VariableType);
                if (find != null)
                {
                    find.IntValue = v.IntValue;
                    find.StrValue = v.StrValue;
                    find.ListValue = v.ListValue.ToArray().ToList();
                    find.TableValue = v.TableValue == null ? null : v.TableValue.Copy();
                }
            }

            if (!string.IsNullOrEmpty(botRunner2.refError)) throw new Exception(botRunner2.refError);
        }

        private void ShowOnlyUserLog(Node node, string txt)
        {
            if (node.Activity.GetType() == typeof(litcore.activity.LogActivity))
            {
                if (this.activityContext.WriteLog != null)
                {
                    this.activityContext.WriteLog(txt);
                }
            }
        }

        /// <summary>
        /// 获取参数，要处理多层流程的问题
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public object GetUserConfig(string configName)
        {
            if (this.project.UserConfigs.ContainsKey(configName)) return project.UserConfigs[configName];
            else return null;
        }

        public void SetUserConfig(string configName,object obj)
        {
            if (this.project.UserConfigs == null) this.project.UserConfigs = new Dictionary<string, object>();
            if (this.project.UserConfigs.ContainsKey(configName)) project.UserConfigs[configName] = obj;
            else this.project.UserConfigs.Add(configName, obj);
        }
    }
}