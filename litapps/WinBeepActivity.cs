using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace litapps
{
    [litsdk.ActivityInfo(Name = "播放系统声音")]
    public class WinBeepActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "播放系统声音";

        public override ActivityGroup Group => ActivityGroup.App;

        public WinBeepType WinBeepType = WinBeepType.Beep;

        public int PlayTimes = 1;

        public override void Execute(ActivityContext context)
        {
            for (int i = 0; i < this.PlayTimes; i++)
            {
                string txt = "开始播放声音";
                if (this.PlayTimes > 1) txt = $"开始第{i + 1}次播放声音，总共{this.PlayTimes}次";
                context.WriteLog(txt);
                if (this.WinBeepType == WinBeepType.Beep)
                    Beep(2000, 500);
                else if (this.WinBeepType == WinBeepType.Asterisk)
                    System.Media.SystemSounds.Asterisk.Play();// 警示音
                System.Threading.Thread.Sleep(1000);
                if (Console.In == System.IO.StreamReader.Null) System.Windows.Forms.Application.DoEvents();
                context.ThrowIfCancellationRequested();
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new WinBeepUI());
        }

        public override void Validate(ActivityContext context)
        {
 
        }

        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);
    }
}
