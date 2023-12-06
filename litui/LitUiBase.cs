using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media.Imaging;

namespace litui
{
    internal partial class LitUiBase : litsdk.ILitUI
    {
        public LitUiBase()
        {
            InitializeComponent();
            this.ivProcessName.ShowVarName(true, false, false, this.tbProcessName);
            this.ivXPath.ShowVarName(true, false, false, this.tbXPath);
        }

        internal void SetUIConfig(UIConfig uc)
        {
            this.tbProcessName.Text = uc.ProcessName;
            this.tbXPath.Text = uc.XPath;// Newtonsoft.Json.JsonConvert.SerializeObject(ui);
            if (!string.IsNullOrEmpty(uc.ImgBase64))
            {
                byte[] bt = Convert.FromBase64String(uc.ImgBase64);
                this.pbImage.Image = Image.FromStream(new System.IO.MemoryStream(bt));
                this.llbSelectUI.Visible = false;
                this.pbImage.Click += PbImage_Click;
            }
            else
            {
                this.llbSelectUI.Visible = true;
            }
            this.lbEngine.Text = uc.Engine;
        }

        public bool IsWindowHighlight = false;

        internal UIConfig GetUIConfig()
        {
            UIConfig uc = new UIConfig();
            uc.ProcessName = this.tbProcessName.Text;
            uc.XPath = this.tbXPath.Text;
            uc.Engine = this.lbEngine.Text;
            if (this.pbImage.Image != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                uc.ImgBase64 = Convert.ToBase64String(ms.ToArray());
            }
            return uc;
        }

        private void llbSelectUI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UISelecter.OnSelected = UiElement_OnSelected;
            if (IsWindowHighlight) UISelecter.StartWindowHighlight();
            else UISelecter.StartElementHighlight();
        }

        private static int self_id = System.Diagnostics.Process.GetCurrentProcess().Id;
        private void UiElement_OnSelected(FlaUI.Core.AutomationElements.AutomationElement automationElement, Bitmap CaptureScreenshot)
        {
            var processId = 0;
            string processName = "";
            string xpath = "";
            Image image = null;

            try
            {
                processId = automationElement.Properties.ProcessId.Value;
            }
            catch { }
            try
            {
                processName = System.Diagnostics.Process.GetProcessById(processId).ProcessName;
                if (processId == self_id) processName = "[self]";
            }
            catch { }
            try
            {
                if (IsWindowHighlight)
                {
                    xpath = "/window";
                    if (!string.IsNullOrEmpty(automationElement.Name))
                    {
                        xpath += $"[Name='{automationElement.Name}']";
                    }
                    if (!string.IsNullOrEmpty(automationElement.ClassName))
                    {
                        xpath += $"[ClassName='{automationElement.ClassName}']";
                    }
                }
                else
                {
                    xpath = litui.Debug.GetXPathToElement(automationElement);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }

            if (CaptureScreenshot != null)
            {
                System.IO.MemoryStream ms = new MemoryStream();
                CaptureScreenshot.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                image = Image.FromStream(ms);
                this.llbSelectUI.Visible = false;
                this.pbImage.Click -= PbImage_Click;
                this.pbImage.Click += PbImage_Click;
            }
            this.tbProcessName.Text = processName;
            this.tbXPath.Text = xpath;
            this.pbImage.Image = image;
        }

        private void PbImage_Click(object sender, EventArgs e)
        {
            this.llbSelectUI_LinkClicked(null, null);
        }

        private static System.Windows.Controls.Image Bitmap2Image(System.Drawing.Bitmap Bi)
        {
            MemoryStream ms = new MemoryStream();
            Bi.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            BitmapImage bImage = new BitmapImage();
            bImage.BeginInit();
            bImage.StreamSource = new MemoryStream(ms.ToArray());
            bImage.EndInit();
            ms.Dispose();
            Bi.Dispose();
            System.Windows.Controls.Image i = new System.Windows.Controls.Image();
            i.Source = bImage;
            return i;
        }

        private void tsmiFlaUI3_Click(object sender, EventArgs e)
        {
            this.lbEngine.Text = "FlaUI3";
        }

        private void tsmiFlaUI2_Click(object sender, EventArgs e)
        {
            this.lbEngine.Text = "FlaUI2";
        }
    }
}
