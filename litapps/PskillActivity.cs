using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litapps
{
    [litsdk.ActivityInfo(Name = "关闭进程")]
    public class PskillActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "关闭进程";

        public override ActivityGroup Group => ActivityGroup.App;

        public PskillCloseType PskillCloseType = PskillCloseType.Earliest;

        public PskillFindType PskillFindType = PskillFindType.ProcessName;

        /// <summary>
        /// 参数值
        /// </summary>
        public string PskillValue = "";


        public override void Execute(ActivityContext context)
        {
            string value = context.ReplaceVar(this.PskillValue);
            if (string.IsNullOrEmpty(value)) throw new Exception("参数值不能为空");
            List<System.Diagnostics.Process> ps = new List<System.Diagnostics.Process>();
            switch (this.PskillFindType)
            {
                case PskillFindType.FilePath:
                    foreach (System.Diagnostics.Process pc in System.Diagnostics.Process.GetProcesses())
                    {
                        try
                        {
                            if (pc.MainModule.FileName.Equals(value, StringComparison.OrdinalIgnoreCase))
                            {
                                ps.Add(pc);
                            }
                        }
                        catch { }
                    }
                    break;
                case PskillFindType.ProcessName:
                    if (value.EndsWith(".exe", StringComparison.OrdinalIgnoreCase)) value = value.Substring(0, value.Length - 4);
                    ps = System.Diagnostics.Process.GetProcessesByName(value).ToList();
                    break;
                case PskillFindType.ProcessId:
                    int pid = 0;
                    if (int.TryParse(value, out pid))
                    {
                        System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessById(pid);
                        if (p != null) ps.Add(p);
                    }
                    break;
            }

            if (ps.Count == 0)
            {
                context.WriteLog("没有找到需要关闭的进程");
            }
            else
            {
                ps = ps.OrderByDescending((h) => h.StartTime).ToList();
                switch (this.PskillCloseType)
                {
                    case PskillCloseType.Earliest:
                        ps = new List<System.Diagnostics.Process>() { ps[ps.Count-1] };
                        break;
                    case PskillCloseType.Latest:
                        ps = new List<System.Diagnostics.Process>() { ps[0] };
                        break;
                }

                foreach (System.Diagnostics.Process pk in ps)
                {
                    string log = $"成功关闭进程{pk.ProcessName}，PID为{pk.Id}";
                    try
                    {
                        pk.CloseMainWindow();
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (!pk.HasExited) pk.Kill();
                    }
                    catch { }
                    context.WriteLog(log);
                }
            }
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new PskillUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.PskillValue)) throw new Exception("参数值不能为空");
        }
    }
}
