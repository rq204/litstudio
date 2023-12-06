using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "输入文本", RefFile = UIConfig.RefFile, IsFront = true, Index = 15)]
    public class TypeIntoActivity : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "输入文本";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;

        public UIConfig UIConfig = new UIConfig();

        public string Content = "";

        public bool CurMousePosition = false;

        public override void Execute(ActivityContext context)
        {
            string c = context.ReplaceVar(this.Content);
            if (c.Length == 0)
            {
                context.WriteLog($"文本长度0，不执行本次输入文本"); return;
            }

            if (!this.CurMousePosition)
            {
                List<FlaUI.Core.AutomationElements.AutomationElement> automationElements = this.UIConfig.GetElements(context);
                if (automationElements.Count == 0) throw new Exception("没有找到元素");
                automationElements[0].SetForeground();
            }

            List<string> strList = new List<string>();
            foreach (char cr in c) strList.Add(cr.ToString());
            //ParseStringToList(ref c, ref strList);
            foreach (string _strValue in strList)
            {
                string strValue = _strValue;
                //if (strValue.Contains("[(") && strValue.Contains(")]"))
                //{
                //    strValue = strValue.Replace("[(", "");
                //    strValue = strValue.Replace(")]", "");
                //    Thread.Sleep(100);

                //    foreach (FlaUI.Core.WindowsAPI.VirtualKeyShort item in Enum.GetValues(typeof(FlaUI.Core.WindowsAPI.VirtualKeyShort)))
                //    {
                //        if (strValue.Equals(item.ToString(), StringComparison.OrdinalIgnoreCase))
                //        {
                //            FlaUI.Core.Input.Keyboard.Press(item);
                //            break;
                //        }
                //    }
                //}
                //else if (strValue != null && strValue != "")
                //{
                Thread.Sleep(100);
                System.Windows.Forms.SendKeys.SendWait(strValue);
                //}
            }
            context.WriteLog($"文本输入成功，文本长度{c.Length}");
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new TypeIntoUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (!CurMousePosition)
            {
                UIConfig.Validate(context);
            }
            if (string.IsNullOrEmpty(this.Content)) throw new Exception("输入文本内容不能为空");
        }

        //void ParseStringToList(ref string inText, ref List<string> strList)
        //{
        //    string strBuff = "";
        //    string keyBuff = "";
        //    bool isKeyFlag = false;
        //    for (int counter = 0; counter < inText.Length; counter++)
        //    {
        //        if (counter < inText.Length - 1)
        //        {
        //            if (inText[counter] == '[' && inText[counter + 1] == 'k')
        //            {
        //                isKeyFlag = true;
        //            }
        //            if (inText[counter] == ')' && inText[counter + 1] == ']')
        //            {
        //                isKeyFlag = false;
        //            }
        //        }
        //        if (isKeyFlag)
        //        {
        //            keyBuff += inText[counter].ToString();
        //            if (strBuff != "")
        //            {
        //                strBuff = strBuff.Replace("[k(", "");
        //                strBuff = strBuff.Replace(")]", "");
        //                strList.Add(strBuff);
        //                strBuff = "";
        //            }
        //        }
        //        else
        //        {
        //            strBuff += inText[counter].ToString();

        //            if (keyBuff != "")
        //            {
        //                keyBuff = keyBuff.Replace("[k(", "");
        //                keyBuff = keyBuff.Replace("[k(", "");
        //                keyBuff = "[(" + keyBuff + ")]";
        //                strList.Add(keyBuff);
        //                keyBuff = "";
        //            }
        //        }

        //        if (counter == inText.Length - 1 && inText[counter] != ']')
        //        {
        //            strBuff = strBuff.Replace("[k(", "");
        //            strBuff = strBuff.Replace(")]", "");
        //            strList.Add(strBuff);
        //        }
        //    }
        //}
    }
}