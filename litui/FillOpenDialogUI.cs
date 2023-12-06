using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using litsdk;

namespace litui
{
    public partial class FillOpenDialogUI : litsdk.ILitUI//这里是继承了默认的界面
    {
        public FillOpenDialogUI()
        {
            InitializeComponent();
            this.ivSavePath.ShowVarName(true, false, false, this.tbSavePath);

            //使用默认界面，这个方法必须实现
            this.SaveActivity = new Action(() =>
              {
                  da.FilePath = this.tbSavePath.Text;
                  da.TimeOutSendconds = (int)this.numericUpDown1.Value;
                  da.Name = this.tbActivityName.Text;
              });
        }

        FillOpenDialog da = null;
        /// <summary>
        /// 设置界面，这个方法必须实现
        /// </summary>
        /// <param name="activity"></param>
        public override void SetActivity(Activity activity)
        {
            da = activity as FillOpenDialog;
            this.tbSavePath.Text = da.FilePath;
            this.numericUpDown1.Value = da.TimeOutSendconds;
            this.tbActivityName.Text = da.Name;
        }

        private void llbBaseDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbSavePath, this.llbBaseDir.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "所有文件|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                this.tbSavePath.Text = of.FileName;
            }
        }
    }
}
