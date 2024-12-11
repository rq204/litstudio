using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litext
{
    [ActivityInfo(Name = "执行PHP文件", RefFile = "PHP")]
    public class PHPActivity : litsdk.ProcessActivity
    {
        private string name = "执行PHP文件";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.Other;

        public static string PHPDir = AppDomain.CurrentDomain.BaseDirectory + "PHP\\";

        public override void Execute(ActivityContext context)
        {
            if (string.IsNullOrEmpty(PHPExePath)) LoadPHPPath();
            List<Variable> list = context.Variables.FindAll((f) => this.VarList.Contains(f.Name));
            string pyfile = System.IO.Path.Combine(PHPDir, this.PhpFile);
            Common.Execute(context, pyfile, PHPExePath, this.VarList);
            context.WriteLog($"PHP执行{pyfile}成功");
        }

        public void TestExecute(ActivityContext context)
        {
            List<Variable> list = context.Variables.FindAll((f) => this.VarList.Contains(f.Name));
            string pyfile = PHPDir + this.PhpFile;
            Common.Execute(context, pyfile, PHPExePath, this.VarList);
        }


        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new PHPUI());
        }

        /// <summary>
        /// php文件
        /// </summary>
        public string PhpFile = "";

        /// <summary>
        /// 要处理的变量
        /// </summary>
        public List<string> VarList = new List<string>();

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(PHPExePath)) LoadPHPPath();
            if (!System.IO.File.Exists(PHPExePath)) throw new Exception("当前电脑未安装PHP环境或未配置PHP环境变量！");
            if (string.IsNullOrEmpty(PhpFile)) throw new Exception("必须配置脚本文件");
            string pyfile = PHPDir + this.PhpFile;
            if (!System.IO.File.Exists(pyfile)) throw new Exception("没有找到PHP文件：" + pyfile);
            if (this.VarList.Count <= 0) throw new Exception("需要设置要操作的变量");
        }

        internal static string PHPExePath = "";

        internal static void LoadPHPPath()
        {
            if (!System.IO.Directory.Exists(PHPDir)) System.IO.Directory.CreateDirectory(PHPDir);
            PHPExePath = System.IO.Path.Combine(PHPDir, "php.exe");
            if (!System.IO.File.Exists(PHPExePath)) PHPExePath = Common.LoadEnvPath("php.exe");
        }
    }
}