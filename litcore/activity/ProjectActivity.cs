using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.activity
{
    [ActivityInfo(Name = "流程引用", IsLinux = true)]
    public class ProjectActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "流程引用";

        public override ActivityGroup Group => ActivityGroup.General;

        /// <summary>
        /// 引用文件
        /// </summary>
        public string FilePath = "";

        /// <summary>
        /// 文件内容，这个是打包时用的
        /// </summary>
        public string ProjectStr = "";

        /// <summary>
        /// 备注
        /// </summary>
        public string Bak = "";

        /// <summary>
        /// 只输出用户日志
        /// </summary>
        public bool OnlyUserLog = true;

        /// <summary>
        /// 被引用的变量名
        /// </summary>
        public List<string> RefVarNames = new List<string>();

        /// <summary>
        /// 异步
        /// </summary>
        public bool UseAsyn = false;

        /// <summary>
        /// 同时线程数
        /// </summary>
        public int ThreadNum { get; set; } = 1;


        public override void Execute(ActivityContext context)
        {
            string pname = "";
            string projectstr = this.ProjectStr;// this.GetProjectContent(context);
            if (string.IsNullOrEmpty(projectstr))
            {
                string filepath = context.ReplaceVar(this.FilePath);
                pname = System.IO.Path.GetFileNameWithoutExtension(filepath);
                if (litsdk.API.GetRefProject == null)
                {
                    if (System.IO.File.Exists(filepath)) projectstr = System.IO.File.ReadAllText(filepath, System.Text.Encoding.UTF8);
                    else throw new Exception("找不到引用流程文件：" + filepath);
                }
                else
                {
                    //引用文件的另外处理方法
                    projectstr = litsdk.API.GetRefProject(pname);
                }
            }
            else
            {
                pname = System.IO.Path.GetFileNameWithoutExtension(this.FilePath);
            }

            if (!UseAsyn)//同步执行时
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                try
                {
                    context.WriteLog("开始执行流程文件：" + pname);
                    context.RunProject(projectstr, this.OnlyUserLog);//   litsdk.API.RunProject(projectstr);
                    context.WriteLog("流程文件执行完成，用时" + ((int)(sw.ElapsedMilliseconds / 1000)).ToString() + "秒");
                }
                catch (Exception)
                {
                    context.WriteLog("流程文件执行中发生错误，用时" + ((int)(sw.ElapsedMilliseconds / 1000)).ToString() + "秒");
                    throw;
                }
                finally
                {
                    sw.Stop();
                }
            }
            else
            {
                litsdk.Project project = litsdk.Project.GetProject(projectstr);
                List<litsdk.Variable> variables = context.Variables;
                if (this.RefVarNames.Count > 0) variables = context.Variables.FindAll((f) => this.RefVarNames.Contains(f.Name));

                foreach (litsdk.Variable variable in variables)
                {
                    litsdk.Variable find = project.Variables.Find((f) => f.Name == variable.Name);
                    if (find != null && find.VariableType == variable.VariableType)
                    {
                        find.InitIntValue = variable.IntValue;
                        find.InitStrValue = variable.StrValue;
                        find.InitListValue = variable.ListValue;
                        find.InitTableValue = variable.TableValue == null ? null : variable.TableValue.Copy();
                    }
                }

                this.RefWriteLog = context.WriteLog;

                lock (lkRef)
                {
                    RefProjects.Add(project);
                }

                if (this.arunner == null)
                {
                    this.arunner = new AsynRunner(pname, context, this);
                }

                context.WriteLog("成功添加异步引用流程：" + pname);
            }
        }

        public void ClearArunner()
        {
            this.arunner = null;
            RefWriteLog = null;
            RefProjects = new List<Project>();
        }

        private AsynRunner arunner = null;

        internal object lkRef = new object();

        internal Action<string> RefWriteLog;

        /// <summary>
        /// 被引用的要执行的流程
        /// </summary>
        internal List<Project> RefProjects = new List<Project>();


        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.FilePath) && string.IsNullOrEmpty(this.ProjectStr)) throw new Exception("流程文件不能为空");

            string projectstr = this.ProjectStr;// this.GetProjectContent(context);
            if (string.IsNullOrEmpty(projectstr))
            {
                string filepath = context.ReplaceVar(this.FilePath);
                if (litsdk.API.GetRefProject == null)
                {
                    if (System.IO.File.Exists(filepath)) projectstr = System.IO.File.ReadAllText(filepath, System.Text.Encoding.UTF8);
                    else throw new Exception("找不到引用流程文件：" + filepath);
                }
                else
                {
                    projectstr = litsdk.API.GetRefProject(filepath);
                }
            }

            if (string.IsNullOrEmpty(projectstr)) throw new Exception("引用流程文件为空请检查");

            Project p = Project.GetProject(projectstr);

            if (p == null)
            {
                throw new Exception("引用流程文件解析出错：" + Project.PaserError.ErrorContext.Error.Message);
            }

            BotRunner botRunner = new BotRunner(p);
            botRunner.InitAction();
            Node snode = null;
            botRunner.Validate(ref snode);

            if (UseAsyn)
            {
                bool isfront = false, iswinfom = false, isbroswer = false;
                p.CheckCreateApp(ref isfront, ref iswinfom, ref isbroswer);
                if (isfront || iswinfom || isbroswer) throw new Exception("子流程启用异步时，不能涉及桌面和浏览器操作");
            }
        }
    }
}
