using litcore.type;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.activity
{
    [litsdk.ActivityInfo(Name = "复制移动删除", IsLinux = true)]
    public class FileActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "复制移动删除";

        public override ActivityGroup Group => ActivityGroup.File;


        public FileType FileType = FileType.DeleteFile;

        public string SourcePath = "";

        public string DestPath = "";

        public override void Execute(ActivityContext context)
        {
            string source = context.ReplaceVar(this.SourcePath);
            string dest = context.ReplaceVar(this.DestPath);
            string msg = "";
            try
            {
                switch (this.FileType)
                {
                    case FileType.CopyFile:
                        if (!System.IO.File.Exists(source)) throw new Exception("不存在要复制的源文件:" + source);
                        if (dest.EndsWith("\\")) dest += System.IO.Path.GetFileName(source);
                        System.IO.File.Copy(source, dest, true);
                        msg = $"成功复制文件{source}至文件{dest}";
                        break;
                    case FileType.CreateDir:
                        if (!System.IO.Directory.Exists(source))
                        {
                            System.IO.Directory.CreateDirectory(source);
                            msg = "成功创建目录：" + source;
                        }
                        else
                        {
                            msg = "目录已存在，跳过新建：" + source;
                        }
                        break;
                    case FileType.DeleteFile:
                        if (System.IO.File.Exists(source))
                        {
                            System.IO.File.Delete(source);
                            msg = "成功删除文件：" + source;
                        }
                        else
                        {
                            msg = "要删除的文件不存在，跳过删除";
                        }
                        break;
                    case FileType.MoveFile:
                        if (System.IO.File.Exists(dest)) System.IO.File.Delete(dest);
                        if (!System.IO.File.Exists(source)) throw new Exception("不存在要移动的原文件:" + source);
                        if (dest.EndsWith("\\")) dest += System.IO.Path.GetFileName(source);
                        string destdir = System.IO.Path.GetDirectoryName(dest);
                        if (!System.IO.Directory.Exists(destdir)) System.IO.Directory.CreateDirectory(destdir);
                        System.IO.File.Move(source, dest);
                        msg = $"成功移动文件{source}到{dest}";
                        break;
                    case FileType.DeleteDir:
                        if (System.IO.Directory.Exists(source))
                        {
                            System.IO.Directory.Delete(source, true);
                            msg = $"成功删除文件夹：{source}";
                        }
                        else
                        {
                            msg = $"文件夹不存在：{source}";
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                msg += "发生错误：" + ex.Message;
            }

            context.WriteLog(msg);
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.SourcePath)) throw new Exception("源文件或目录不能为空");
            if (this.FileType != FileType.DeleteFile && this.FileType != FileType.CreateDir && this.FileType != FileType.DeleteDir)
            {
                if (string.IsNullOrEmpty(this.DestPath)) throw new Exception("目标目录不能为空");
            }

        }
    }
}
