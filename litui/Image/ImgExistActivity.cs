using litsdk;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace litui
{
    [litsdk.ActivityInfo(Name = "图像存在", IsFront = true, IsWinForm = false, RefFile = UIConfig.RefFile, Index = 95)]
    public class ImgExistActivity : litsdk.DecisionActivity
    {
        public override string Name { get; set; } = "图像存在";

        public override ActivityGroup Group => ActivityGroup.UIAutomation;


        public ImgConfig ImgConfig = new ImgConfig();


        public string SaveX = "";

        public string SaveY = "";

        /// <summary>
        /// 取相反值
        /// </summary>
        public bool Reverse = false;


        public override bool Execute(ActivityContext context)
        {
            bool exsit = false;
            string add = "";

            Point point = new Point();
            string result = this.ImgConfig.GetClickablePoint(ref point);
            if (result == null)
            {
                if (!string.IsNullOrEmpty(this.SaveX))
                {
                    context.SetVarInt(this.SaveX, point.X);
                    add = $"，获取到坐标X：{point.X}保存至变量{this.SaveX}";
                }
                if (!string.IsNullOrEmpty(this.SaveY))
                {
                    if (add != "") add = add + "，";
                    else add = "，";
                    context.SetVarInt(this.SaveY, point.Y);
                    add += $"获取到坐标Y:{point.Y}并保存至变量{this.SaveY}";
                }
                exsit = true;
            }
            else
            {
                add = "，" + result;
            }

            string log = "图片查找结果：" + (exsit ? "存在" : "不存在") + add;
            if (this.Reverse)
            {
                exsit = !exsit;
                log += "，取相反值为：" + exsit.ToString();
            }
            context.WriteLog(log);
            return exsit;
        }

        public override void ShowConfig()
        {
            litsdk.API.ShowConfigForm(this, new ImgExistUI());
        }

        public override void Validate(ActivityContext context)
        {
            if (!string.IsNullOrEmpty(this.SaveX) && !context.ContainsInt(this.SaveX)) throw new Exception("坐标X变量必须是数字");
            if (!string.IsNullOrEmpty(this.SaveY) && !context.ContainsInt(this.SaveY)) throw new Exception("坐标Y变量必须是数字");
            this.ImgConfig.Validate(context);
        }
    }
}
