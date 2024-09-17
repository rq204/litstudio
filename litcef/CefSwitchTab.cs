using CefSharp.WinForms;
using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litcef
{
    [litsdk.ActivityInfo(Name = "标签页切换", IsFront = false, IsWinForm = true, RefFile = CefLoad.CefFile, Index = 36)]
    public class CefSwitchTab : litcore.iecef.SwitchTab
    {
        public override void Execute(ActivityContext context)
        {
            CefLoad.LoadBrowser();
            ChromiumWebBrowser Browser_Select = CefLoad.CefUI_Select.browser;

            string name = context.ReplaceVar(this.TabName);

            CefUI find = null;
            List<CefUI> ies = new List<CefUI>();
            foreach (UserControl uc in litsdk.API.GetTabPages())
            {
                if (uc.GetType() == typeof(CefUI))
                {
                    ies.Add(uc as CefUI);
                    if (uc.AccessibleName == name) find = uc as CefUI;
                }
            }

            if (this.SwitchTabType == litcore.ictype.SwitchTabType.Create)
            {
                if (find == null)
                {
                    CefUI userControl = new CefUI();
                    userControl.AccessibleName = name;
                    litsdk.API.AddTabPage(userControl);
                    CefLoad.CefUI_Select = userControl;
                    context.WriteLog($"新建标签页并已切换至 {name} ");
                }
                else
                {
                    CefLoad.CefUI_Select = find;
                    context.WriteLog($"发现同名标签页 {name}，已直接切换");
                }
            }
            else
            {
                if (this.DefaultTab) find = CefUI.Instance;
                else if (this.LastTab) find = ies[ies.Count - 1];
                else
                {
                    if (this.UseRegex)
                    {
                        foreach (CefUI eUI in ies)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(eUI.AccessibleName, name))
                            {
                                find = eUI;
                                break;
                            }
                        }
                    }
                    else
                    {
                        find = ies.Find((a) => a.AccessibleName == name);
                    }
                }

                if (find is null) throw new Exception("找不到匹配的标签页");

                switch (this.SwitchTabType)
                {
                    case litcore.ictype.SwitchTabType.Close:
                        if (find.Equals(CefUI.Instance)) throw new Exception("不能关闭默认页标签");
                        find.browser.Dispose();
                        litsdk.API.CloseTabPage(find);
                        if (CefLoad.CefUI_Select == find) CefLoad.CefUI_Select = CefUI.Instance;
                        context.WriteLog($"发现标签页并关闭 {find.AccessibleName} ");
                        break;
                    case litcore.ictype.SwitchTabType.CloseOther:
                        bool guanbi = false;
                        foreach (CefUI ui in ies)
                        {
                            if (!ui.Equals(find) && !ui.Equals(CefUI.Instance))
                            {
                                ui.Dispose();
                                guanbi = ui.browser.Equals(CefLoad.CefUI_Select.browser);
                                litsdk.API.CloseTabPage(ui);
                            }
                        }

                        if (guanbi)//当前的被关闭了
                        {
                            CefLoad.CefUI_Select = CefUI.Instance;
                        }
                        context.WriteLog($"发现标签页并将其它标签页关闭 {find.AccessibleName} ");
                        break;
                    case litcore.ictype.SwitchTabType.Switch:
                        CefLoad.CefUI_Select = find;
                        context.WriteLog($"发现标签页并已切换至 {find.AccessibleName} ");
                        break;
                }
            }
        }

        public override void Validate(ActivityContext context)
        {
            if (!CefLoad.cefLoad.IsValueCreated && litsdk.API.GetMainForm != null) CefLoad.cefLoad.Value.InitializeCef();
            base.Validate(context);
        }

        public override void ShowConfig()
        {
            if (!CefLoad.cefLoad.IsValueCreated) CefLoad.cefLoad.Value.InitializeCef();
            base.ShowConfig();
        }

        public override ActivityGroup Group => ActivityGroup.CefBroswer;
    }
}