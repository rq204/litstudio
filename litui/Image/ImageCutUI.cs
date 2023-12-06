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
using CSharpWin_JD.CaptureImage;

namespace litui
{
    internal partial class ImageCutUI : litsdk.ILitUI
    {
        public ImageCutUI()
        {
            InitializeComponent();
            this.svSourceVarName.ShowVarName(true, false, false);
            this.svSaveVarName.ShowVarName(true, false, false);
            this.ivBasePoint.ShowVarName(true, false, true,this.tbBasePoint);
            this.ivCutSize.ShowVarName(true, false, true, this.tbCutSize);

            this.SaveActivity = () =>
            {
                ca.SourceVarName = this.svSourceVarName.VarName;
                ca.BasePoint = this.tbBasePoint.Text;
                ca.CutSize = this.tbCutSize.Text;

                if (this.rbLeftTop.Checked) ca.OrientType = OrientType.LeftTop;
                else if (this.rbRightTop.Checked) ca.OrientType = OrientType.RightTop;
                else if (this.rbLeftBottom.Checked) ca.OrientType = OrientType.LeftBottom;
                else if (this.rbRightBottom.Checked) ca.OrientType = OrientType.RightBottom;

                if (this.rbPng.Checked) ca.ImageFormat = "png";
                else if (this.rbJpg.Checked) ca.ImageFormat = "jpg";
                else if (this.rbBmp.Checked) ca.ImageFormat = "bmp";

                ca.SaveVarName = this.svSaveVarName.VarName;
                ca.SaveTempPath = this.cbSaveTempPath.Checked;
                ca.Name = this.tbActivityName.Text;

                ca.UseImage = this.cbUseImg.Checked;
                ca.Similarity = (int)this.nudSimilarity.Value;
                if (this.pbImage.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    ca.ImgBase64 = Convert.ToBase64String(ms.ToArray());
                }
            };
        }

        ImageCutActivity ca = null;

        public override void SetActivity(Activity activity)
        {
            ca = activity as ImageCutActivity;
            this.svSourceVarName.VarName = ca.SourceVarName;
            this.tbBasePoint.Text = ca.BasePoint;
            this.tbCutSize.Text = ca.CutSize;
            switch (ca.OrientType)
            {
                case OrientType.LeftTop:
                    this.rbLeftTop.Checked = true;
                    break;
                case OrientType.RightTop:
                    this.rbRightTop.Checked = true;
                    break;
                case OrientType.LeftBottom:
                    this.rbLeftBottom.Checked = true;
                    break;
                case OrientType.RightBottom:
                    this.rbRightBottom.Checked = true;
                    break;
            }

            switch (ca.ImageFormat)
            {
                case "png":
                    this.rbPng.Checked = true;
                    break;
                case "jpg":
                    this.rbJpg.Checked = true;
                    break;
                case "bmp":
                    this.rbBmp.Checked = true;
                    break;
            }

            this.svSaveVarName.VarName = ca.SaveVarName;
            this.cbSaveTempPath.Checked = ca.SaveTempPath;
            this.tbActivityName.Text = ca.Name;

            this.cbUseImg.Checked = ca.UseImage;
            cbUseImg_CheckedChanged(null, null);

            this.nudSimilarity.Value = ca.Similarity;
            if (!string.IsNullOrEmpty(ca.ImgBase64))
            {
                byte[] bt = Convert.FromBase64String(ca.ImgBase64);
                this.pbImage.Image = Image.FromStream(new System.IO.MemoryStream(bt));
                this.llbSelectUI.Visible = false;
                this.pbImage.Click += pbImage_Click;
            }
            else
            {
                this.llbSelectUI.Visible = true;
            }
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

        private void pbImage_Click(object sender, EventArgs e)
        {
            if (this.pbImage.Image != null)
            {
                llbSelectUI_LinkClicked(null, null);
            }
        }

        private void cbUseImg_CheckedChanged(object sender, EventArgs e)
        {
            this.pbImage.Visible = this.llbSelectUI.Visible = this.pbImage.Visible = this.cbUseImg.Checked;
        }
    }
}
