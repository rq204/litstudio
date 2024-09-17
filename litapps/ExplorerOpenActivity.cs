using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using litsdk;

namespace litapps
{
    [litsdk.ActivityInfo(Name = "打开文件(夹)")]
    public class ExplorerOpenActivity : litsdk.ProcessActivity
    {
        private string name = "打开文件(夹)";
        public override string Name { get => name; set => name = value; }

        public override ActivityGroup Group => ActivityGroup.App;

        /// <summary>
        /// 打开文件
        /// </summary>
        public bool OpenFile = true;

        /// <summary>
        /// 打开目录和选中文件
        /// </summary>
        public bool OpenDirSelectFile = true;

        /// <summary>
        /// 打开目录
        /// </summary>
        public bool OpenDir = false;

        /// <summary>
        /// 要打开的文件路径
        /// </summary>
        public string FilePath = "";
        public override void Execute(ActivityContext context)
        {
            string path = context.ReplaceVar(this.FilePath);
            if (!System.IO.File.Exists(path)) throw new Exception("不存在文件:" + path);

            if (this.OpenDirSelectFile)
            {
                ExplorerFile(path);
            }

            if (this.OpenDir && !this.OpenDirSelectFile)
            {
                string dir = System.IO.Path.GetDirectoryName(path);
                System.Diagnostics.Process.Start(dir);
                context.WriteLog("成功打开文件夹：" + dir);
            }
            if (this.OpenFile)
            {
                System.Diagnostics.Process.Start(path);
                context.WriteLog("成功打开文件：" + path);
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new ExplorerOpenUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (!this.OpenFile && !this.OpenDir && !this.OpenDirSelectFile)
            {
                throw new Exception("打开选项不能全为空");
            }
            if (string.IsNullOrEmpty(this.FilePath)) throw new Exception("要打开的文件名不能为空");
        }

        //https://www.cnblogs.com/crwy/p/SHOpenFolderAndSelectItems.html

        /// <summary>
        /// 打开路径并定位文件...对于@"h:\Bleacher Report - Hardaway with the safe call ??.mp4"这样的，explorer.exe /select,d:xxx不认，用API整它
        /// </summary>
        /// <param name="filePath">文件绝对路径</param>
        [DllImport("shell32.dll", ExactSpelling = true)]
        private static extern void ILFree(IntPtr pidlList);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern IntPtr ILCreateFromPathW(string pszPath);

        [DllImport("shell32.dll", ExactSpelling = true)]
        private static extern int SHOpenFolderAndSelectItems(IntPtr pidlList, uint cild, IntPtr children, uint dwFlags);

        public static void ExplorerFile(string filePath)
        {
            if (!File.Exists(filePath) && !Directory.Exists(filePath))
                return;

            if (Directory.Exists(filePath))
                Process.Start(@"explorer.exe", "/select,\"" + filePath + "\"");
            else
            {
                IntPtr pidlList = ILCreateFromPathW(filePath);
                if (pidlList != IntPtr.Zero)
                {
                    try
                    {
                        Marshal.ThrowExceptionForHR(SHOpenFolderAndSelectItems(pidlList, 0, IntPtr.Zero, 0));
                    }
                    finally
                    {
                        ILFree(pidlList);
                    }
                }
            }
        }
    }
}
