using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "打开对话框", Index =50)]
    public class FillOpenDialog : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "打开对话框";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        /// <summary>
        /// 超时秒
        /// </summary>
        public int TimeOutSendconds = 3;


        public string FilePath = "";



        public override void Execute(ActivityContext context)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int timeout = this.TimeOutSendconds * 1000;
            string filePath = context.ReplaceVar(this.FilePath);

            if (!System.IO.File.Exists(filePath)) throw new Exception("文件不存在:" + filePath);

            context.WriteLog("开始查找打开对话框并执行填写点击");

            string lastErr = "";
            int num = 1;

            while (sw.ElapsedMilliseconds < timeout)
            {
                IntPtr main = FindWindow(null, "打开");
                if (main != IntPtr.Zero)
                {
                    IntPtr lpComboBoxEx32 = FlaUI.Core.WindowsAPI.User32.FindWindowEx(main, IntPtr.Zero, "ComboBoxEx32", null);
                    if (lpComboBoxEx32 != IntPtr.Zero)
                    {
                        IntPtr lpComboBox = FlaUI.Core.WindowsAPI.User32.FindWindowEx(lpComboBoxEx32, IntPtr.Zero, "ComboBox", null);
                        if (lpComboBox != IntPtr.Zero)
                        {
                            IntPtr lpEdit = FlaUI.Core.WindowsAPI.User32.FindWindowEx(lpComboBox, IntPtr.Zero, "Edit", null);

                            if (lpEdit != IntPtr.Zero)
                            {
                                IntPtr lpButton = FlaUI.Core.WindowsAPI.User32.FindWindowEx(main, IntPtr.Zero, "Button", "打开(&O)");
                                if (lpButton != null)
                                {
                                    IntPtr file = Marshal.StringToCoTaskMemAuto(filePath);
                                    FlaUI.Core.WindowsAPI.User32.SendMessage(lpEdit, 0x000C, IntPtr.Zero, file);
                                    System.Threading.Thread.Sleep(20);
                                    FlaUI.Core.WindowsAPI.User32.SendMessage(lpButton, BM_CLICK, IntPtr.Zero, IntPtr.Zero);
                                    context.WriteLog($"成功写值并点击，用时：{sw.ElapsedMilliseconds}毫秒");
                                    sw.Stop();
                                    return;
                                }
                                else
                                {
                                    lastErr = "Button 未找到";
                                }
                            }
                            else
                            {
                                lastErr = "Edit 未找到";
                            }
                        }
                        else
                        {
                            lastErr = "ComboBox 未找到";
                        }
                    }
                    else
                    {
                        lastErr = "ComboBoxEx32 未找到";
                    }
                }
                else
                {
                    lastErr = "没找到打开对话框";
                }

                System.Threading.Thread.Sleep(100);
                context.WriteLog($"第{num}次尝试，结果为：{lastErr}");
                num++;
            }
            sw.Stop();
            context.WriteLog("超时没完成打开点击操作");
        }

        const int BM_CLICK = 0xF5;

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string className, string windowName);

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new FillOpenDialogUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (string.IsNullOrEmpty(this.FilePath)) throw new Exception("文件路径不能为空");
        }
    }
}