using litsdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litcore.iecef
{
    public class Slide : litsdk.ProcessActivity
    {
        public override string Name { get; set; } = "鼠标拖动";

        public override ActivityGroup Group => ActivityGroup.Broswer;

        #region 要被废弃的参数
        /// <summary>
        /// 起始位置X数字变量名
        /// </summary>
        public string StartXVarName = "";

        /// <summary>
        /// 起始位置Y数字变量名
        /// </summary>
        public string StartYVarName = "";

        /// <summary>
        /// 结束位置X数字变量名
        /// </summary>
        public string EndXVarName = "";

        /// <summary>
        /// 结束位置Y数字变量名
        /// </summary>
        public string EndYVarName = "";

        #endregion

        /// <summary>
        /// 起始位置X数字
        /// </summary>
        public string StartX = "";

        /// <summary>
        /// 起始位置Y数字
        /// </summary>
        public string StartY = "";

        /// <summary>
        /// 结束位置X数字
        /// </summary>
        public string EndX= "";

        /// <summary>
        /// 结束位置Y数字
        /// </summary>
        public string EndY = "";

        /// <summary>
        /// 终止位置为起始位置的相对值
        /// </summary>
        public bool Relative = false;

        /// <summary>
        /// 框架名称
        /// </summary>
        public string FrameName = "";

        /// <summary>
        /// 开始的XPath
        /// </summary>
        public string StartXPath = "";

        /// <summary>
        /// 结束的XPath
        /// </summary>
        public string EndXPath = "";

        /// <summary>
        /// 开始使用XPath
        /// </summary>
        public bool UseStartXPath = false;

        /// <summary>
        /// 结束使用XPath
        /// </summary>
        public bool UseEndXpath = false;

        public override void Execute(ActivityContext context)
        {
            
        }

        public override void ShowConfig()
        {
            this.LoadOld();
            litsdk.API.ShowSystemConfigForm(this);
        }

        public override void Validate(ActivityContext context)
        {
            if (this.UseStartXPath)
            {
                if (string.IsNullOrEmpty(this.StartXPath)) throw new Exception("起始元素XPath不能为空");
            }
            else
            {
                if (string.IsNullOrEmpty(this.StartX)) throw new Exception($"起始位置X数字变量名不能为空");
                if (string.IsNullOrEmpty(this.StartY)) throw new Exception($"起始位置Y数字变量名不能为空");
            }

            if (this.UseEndXpath)
            {
                if (string.IsNullOrEmpty(this.EndXPath)) throw new Exception("结束元素XPath不能为空");
            }
            else
            {
                if (string.IsNullOrEmpty(this.EndX)) throw new Exception($"结束位置X数字变量名不能为空");
                if (string.IsNullOrEmpty(this.EndY)) throw new Exception($"结束位置Y数字变量名不能为空");
            }
        }

        public void LoadOld()
        {
            if (!string.IsNullOrEmpty(this.StartXVarName) && string.IsNullOrEmpty(this.StartX)) this.StartX = "{-var." + this.StartXVarName + "-}";
            if (!string.IsNullOrEmpty(this.StartYVarName) && string.IsNullOrEmpty(this.StartY)) this.StartY = "{-var." + this.StartYVarName + "-}";
            if (!string.IsNullOrEmpty(this.EndXVarName) && string.IsNullOrEmpty(this.EndX)) this.EndX = "{-var." + this.EndXVarName + "-}";
            if (!string.IsNullOrEmpty(this.EndYVarName) && string.IsNullOrEmpty(this.EndY)) this.EndY = "{-var." + this.EndYVarName + "-}";
        }
    }
}
