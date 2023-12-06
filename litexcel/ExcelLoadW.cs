using litexcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litexcel
{
    internal class ExcelLoadW
    {
        /// <summary>
        /// 设置下拉框
        /// </summary>
        /// <param name="box"></param>
        public static void SetComboBox(ComboBox box)
        {
            List<litsdk.Activity> lst = litsdk.API.GetDesignActivity(typeof(OpenActivity).FullName);
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            foreach (litsdk.Activity la in lst)
            {
                OpenActivity oaa = la as OpenActivity;
                if (oaa != null)
                {
                    string name = context.ReplaceVar(oaa.ExcelName);
                    if (!string.IsNullOrEmpty(name))
                    {
                        if (!box.Items.Contains(name)) box.Items.Add(name);
                    }
                }
            }
            if (box.Items.Count > 0) box.SelectedIndex = 0;
        }
    }
}
