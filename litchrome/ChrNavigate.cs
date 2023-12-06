using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(IsWinForm = true, IsFront = false, IsLinux = true, Index = 0, RefFile = ChrLoad.RefFile)]
    public class ChrNavigate : litcore.iecef.Navigate
    {

        public string ChromeName = "";

        public override void Execute(ActivityContext context)
        {
            ChrLoad.LoadChromeSetting(context);
            string url = context.ReplaceVar(this.Url);
            if (!url.ToLower().StartsWith("http://") && !url.ToLower().StartsWith("https://")) url = "http://" + url;

            ChrLoad.Driver.Url = url;

            if (context.ContainsInt("ChrProcessId")) context.SetVarInt("ChrProcessId", ChrLoad.ProcessId);

            context.WriteLog("成功打开网页：" + url);
        }

        public override void Validate(ActivityContext context)
        {
            base.Validate(context);
        }

        public override void ShowConfig()
        {
            litcore.iecef.ChrSetting.IsChrome = true;
            litsdk.API.ShowSystemConfigForm(this);
            litcore.iecef.ChrSetting.IsChrome = false;
        }

        public override ActivityGroup Group => litsdk.ActivityGroup.Chrome;
    }
}
