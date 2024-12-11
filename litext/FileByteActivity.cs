using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litext
{
    [litsdk.ActivityInfo(Name = "二进制操作", Index = 100, InSequence = true, IsLinux = false)]
    public class FileByteActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "二进制操作";

        public FileByteType FileByteType { get; set; } = FileByteType.FileDataToBase64;

        public override ActivityGroup Group => ActivityGroup.File;


        public string FilePath = "";

        /// <summary>
        /// 操作变量名
        /// </summary>
        public string OptVarName = "";

        public override void Execute(ActivityContext context)
        {
            string path = context.ReplaceVar(this.FilePath);
            string data = context.GetStr(this.OptVarName);

            switch (this.FileByteType)
            {
                case FileByteType.FileDataToBase64:
                    if (!System.IO.File.Exists(path)) throw new Exception("文件不存在:" + path);
                    byte[] bytes = System.IO.File.ReadAllBytes(path);
                    data = Convert.ToBase64String(bytes);
                    context.SetVarStr(this.OptVarName, data);
                    context.WriteLog("成功读取二进制文件至变量中:" + path);
                    break;
                case FileByteType.Base64Str2File:
                    if (string.IsNullOrEmpty(data)) throw new Exception("base64数据不能为空");
                    byte[] fbt = System.Text.Encoding.UTF8.GetBytes(data);
                    string dir=System.IO.Path.GetDirectoryName(path);
                    if(!System.IO.Directory.Exists(dir)) System.IO.Directory.CreateDirectory(dir);
                    System.IO.File.WriteAllBytes(path, fbt);
                    context.WriteLog("成功将base64变量写入文件:" + path);
                    break;
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new FileByteUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.OptVarName)) throw new Exception("操作变量不能为空");
            if (!context.ContainsStr(this.OptVarName)) throw new Exception($"字符变量 {this.OptVarName} 不存在");
            if (string.IsNullOrEmpty(this.FilePath)) throw new Exception("文件路径不能为空");
        }
    }
}
