using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(Name = "关闭浏览器", IsFront = false, IsLinux = true, IsWinForm = true, RefFile = ChrLoad.RefFile, Index = 88)]
    public class ChrRestart : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "关闭浏览器";

        public override ActivityGroup Group => ActivityGroup.Chrome;

        public override void Execute(ActivityContext context)
        {
            ChrLoad.Quit();
        }

        public override void ShowConfig()
        {
#if NET461
            System.Windows.Forms.MessageBox.Show("关闭浏览器是关闭当前的外置谷歌浏览器实例，当有新的浏览器操作时会加载最新配置重新启动");
#endif
        }

        public override void Validate(ActivityContext context)
        {

        }
    }
}