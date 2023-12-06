using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litcore.activity
{
    [ActivityInfo(Name = "文件存在", IsLinux = true)]
    public class IOResExistsActivity : litsdk.DecisionActivity
    {
        private string name = "文件存在";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.File;


        public bool IsDir = false;

        public string FileDirPath = "";

        public override bool Execute(ActivityContext context)
        {
            bool flag = false;
            string path = context.ReplaceVar(this.FileDirPath);
            if (IsDir) flag = System.IO.Directory.Exists(path);
            else flag = System.IO.File.Exists(path);
            context.WriteLog($"存的的判断结果是{flag}");
            return flag;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.FileDirPath)) throw new Exception("文件或文夹路径不能为空");
        }
    }
}
