using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litext
{
    [ActivityInfo(Name = "执行Python文件", RefFile = "Python")]
    public class PythonActivity : litsdk.ProcessActivity
    {
        private string name = "执行Python文件";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Other;

        public override void Execute(ActivityContext context)
        {
            if (string.IsNullOrEmpty(PythonExePath)) LoadPythonPath();
            List<Variable> list = context.Variables.FindAll((f) => this.VarList.Contains(f.Name));
            string pyfile = System.IO.Path.Combine(PythonDir, this.PyFile);
            Common.Execute(context, pyfile, PythonExePath, this.VarList);
            context.WriteLog($"Python执行{pyfile}成功");
        }

        public void TestExecute(ActivityContext context)
        {
            List<Variable> list = context.Variables.FindAll((f) => this.VarList.Contains(f.Name));
            string pyfile = PythonDir + this.PyFile;
            Common.Execute(context, pyfile, PythonExePath, this.VarList);
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new PythonUI());
        }

        /// <summary>
        /// python文件
        /// </summary>
        public string PyFile = "";

        internal static string PythonDir = AppDomain.CurrentDomain.BaseDirectory + "Python\\";

        /// <summary>
        /// 要处理的变量
        /// </summary>
        public List<string> VarList = new List<string>();

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(PythonExePath)) LoadPythonPath();
            if (!System.IO.File.Exists(PythonExePath)) throw new Exception("当前电脑未安装Python环境或未配置Python环境变量！");
            if (string.IsNullOrEmpty(PyFile)) throw new Exception("必须配置脚本文件");
            string pyfile = PythonDir + this.PyFile;
            if (!System.IO.File.Exists(pyfile)) throw new Exception("没有找到python文件：" + pyfile);
            if (this.VarList.Count <= 0) throw new Exception("需要设置要操作的变量");
        }

        internal static string PythonExePath = "";

        internal static void LoadPythonPath()
        {
            if (!System.IO.Directory.Exists(PythonDir)) System.IO.Directory.CreateDirectory(PythonDir);
            PythonExePath = System.IO.Path.Combine(PythonDir, "python.exe");
            if (!System.IO.File.Exists(PythonExePath)) PythonExePath = Common.LoadEnvPath("python.exe");
        }
    }
}