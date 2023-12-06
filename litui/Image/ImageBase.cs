using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpWin_JD.CaptureImage;
using System.IO;

namespace litui
{
    internal partial class ImageBase : litsdk.ILitUI
    {
        public ImageBase()
        {
            InitializeComponent();
        }

        private void llbSelectUI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.API.GetMainForm().WindowState = FormWindowState.Minimized;
            System.Threading.Thread.Sleep(300);
            CaptureImageTool captureImageTool = new CaptureImageTool();

            if (captureImageTool.ShowDialog() == DialogResult.OK)
            {
                this.pbImage.Tag = captureImageTool.Image;
                this.pbImage.Image = captureImageTool.Image;
                this.llbSelectUI.Visible = false;
                this.pbImage.Click += pbImage_Click;
            }
            litsdk.API.GetMainForm().WindowState = FormWindowState.Maximized;
        }

        internal void SetUIConfig(ImgConfig uc)
        {
            if (!string.IsNullOrEmpty(uc.ImgBase64))
            {
                byte[] bt = Convert.FromBase64String(uc.ImgBase64);
                this.pbImage.Image = Image.FromStream(new System.IO.MemoryStream(bt));
                this.llbSelectUI.Visible = false;
                this.pbImage.Click += pbImage_Click;
            }
            else
            {
                this.llbSelectUI.Visible = true;
            }
            this.rbIsFullScreen.Checked = uc.IsFullScreen;
            this.rbIsActivite.Checked = !uc.IsFullScreen;

            this.nudSimilarity.Value = uc.Similarity;
            this.nudRowNum.Value = uc.ImageNum;

            this.tbMoveX.Text = uc.MoveX.ToString();
            this.tbMoveY.Text = uc.MoveY.ToString();
        }

        internal ImgConfig GetUIConfig()
        {
            ImgConfig uc = new ImgConfig();
          
            if (this.pbImage.Image != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                uc.ImgBase64 = Convert.ToBase64String(ms.ToArray());
            }

            uc.IsFullScreen = this.rbIsFullScreen.Checked;
            uc.Similarity = (int)this.nudSimilarity.Value;
            uc.ImageNum = (int)this.nudRowNum.Value;
            int x = 0, y = 0;
            int.TryParse(this.tbMoveX.Text, out x);
            int.TryParse(this.tbMoveY.Text, out y);
            uc.MoveX = x;
            uc.MoveY = y;
            return uc;
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            if (this.pbImage.Image != null)
            {
                llbSelectUI_LinkClicked(null, null);
            }
        }
    }
}
