using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(Name = "刷新后退", IsFront = false, IsWinForm = true, RefFile = ChrLoad.RefFile, Index = 52)]
    public class ChrCommond : litcore.iecef.Commond
    {
        public override void Execute(ActivityContext context)
        {
            ChrLoad.LoadChromeSetting(context);
            switch (this.CmdType)
            {
                case litcore.ictype.CommondType.GoBack:
                    ChrLoad.Driver.Navigate().Back();
                    context.WriteLog("浏览器后退成功");
                    break;
                case litcore.ictype.CommondType.GoForward:
                    ChrLoad.Driver.Navigate().Forward();
                    context.WriteLog("浏览器前进成功");
                    break;
                case litcore.ictype.CommondType.Reload:
                    ChrLoad.Driver.Navigate().Refresh();
                    context.WriteLog("浏览器开始刷新");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case litcore.ictype.CommondType.Stop:
                    context.WriteLog("外置浏览器不支持停止功能");
                    break;
            }
        }

        public override void Validate(ActivityContext context)
        {
            base.Validate(context);
        }

        public override void ShowConfig()
        {
            base.ShowConfig();
        }

        public override ActivityGroup Group => ActivityGroup.Chrome;
    }
}
