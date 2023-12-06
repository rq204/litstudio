using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litchrome
{
    [litsdk.ActivityInfo(Name = "标签页切换", IsFront = false, IsWinForm = true, RefFile = ChrLoad.RefFile, Index = 36)]
    public class ChrSwitchTab : litcore.iecef.SwitchTab
    {
        private static Dictionary<string, string> tabDic = new Dictionary<string, string>();
        private static object lk = new object();
        private static string lastCreateTab = null;

        public static void InitTab(string tabHandle)
        {
            lock (lk)
            {
                tabDic.Clear();
                tabDic.Add("默认页", tabHandle);
                lastCreateTab = "默认页";
            }
        }

        public override void Execute(ActivityContext context)
        {
            ChrLoad.LoadChromeSetting(context);

            string name = context.ReplaceVar(this.TabName);

            if (this.SwitchTabType == litcore.ictype.SwitchTabType.Create)
            {
                string oldHead = null;
                ///已存在
                if (tabDic.ContainsKey(name))
                {
                    oldHead = ChrLoad.Driver.WindowHandles.ToList().Find(f => f == tabDic[name]);
                    if (oldHead != null)
                    {
                        ChrLoad.Driver.SwitchTo().Window(tabDic[name]);
                        context.WriteLog($"发现同名标签页 {name}，已直接切换");
                    }
                }

                ///要新建
                if (oldHead == null)
                {
                    ChrLoad.Driver.SwitchTo().NewWindow(OpenQA.Selenium.WindowType.Tab);
                    string head = ChrLoad.Driver.CurrentWindowHandle;
                    lastCreateTab = oldHead;
                    lock (lk)
                    {
                        if (tabDic.ContainsKey(name)) tabDic[name] = head;
                        else tabDic.Add(name, head);
                    }
                    context.WriteLog($"新建标签页并已切换至 {name} ");
                }
            }
            else
            {
                OpenQA.Selenium.IWebDriver find = null;
                string findHead = null;

                if (this.LastTab) name = lastCreateTab;
                else if (this.DefaultTab) name = "默认页";
                else if (this.UseRegex)
                {
                    //foreach(string head in ChrLoad.Driver.WindowHandles)
                    //{
                    //    ChrLoad.Driver.SwitchTo().Window(head);

                    //}
                }


                if (tabDic.ContainsKey(name))
                {
                    findHead = ChrLoad.Driver.WindowHandles.ToList().Find(f => f == tabDic[name]);
                }

                if (findHead == null && this.SwitchTabType != litcore.ictype.SwitchTabType.CloseOther)
                {
                    throw new Exception("找不到匹配的标签页：" + name);
                }
                else
                {
                    find = ChrLoad.Driver.SwitchTo().Window(findHead);
                }

                switch (this.SwitchTabType)
                {
                    case litcore.ictype.SwitchTabType.Close:
                        find.Close();
                        find.Dispose();
                        lock (lk)
                        {
                            tabDic.Remove(name);
                        }
                        context.WriteLog($"发现标签页并关闭 {name} ");
                        break;
                    case litcore.ictype.SwitchTabType.CloseOther:
                        lock (lk)
                        {
                            foreach (string head in ChrLoad.Driver.WindowHandles)
                            {
                                if (findHead != head)
                                {
                                    OpenQA.Selenium.IWebDriver need = ChrLoad.Driver.SwitchTo().Window(head);
                                    need.Close();
                                    need.Dispose();
                                    tabDic.Remove(head);
                                }
                            }
                        }
                        context.WriteLog($"发现标签页并将其它标签页关闭 {name} ");
                        break;
                    case litcore.ictype.SwitchTabType.Switch:
                        context.WriteLog($"发现标签页并已切换至 {name} ");
                        break;
                }
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