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
using litcore.type;

namespace litstudio
{
    internal partial class TextEncodeUI : litsdk.ILitUI
    {
        public TextEncodeUI()
        {
            InitializeComponent();
            this.svStrVarName.ShowVarName(true, false, false);
            this.svSaveVarName.ShowVarName(true, false, false);

            base.SaveActivity = new Action(() =>
              {
                  litcore.type.Encodetype type = Encodetype.FromBase64;

                  if (rbdURLEncode.Checked)
                  {
                      type = Encodetype.URLEncode;
                  }
                  else if (rbdURLDecode.Checked)
                  {
                      type = Encodetype.URLDecode;
                  }
                  else if (rbdHtmlEncode.Checked)
                  {
                      type = Encodetype.HTMLEncode;
                  }
                  else if (rbdHtmlDecode.Checked)
                  {
                      type = Encodetype.HTMLDecode;
                  }
                  else if (rbdToBase64.Checked)
                  {
                      type = Encodetype.ToBase64;
                  }
                  else if (rbdFromBase64.Checked)
                  {
                      type = Encodetype.FromBase64;
                  }
                  else if (rbdToJsString.Checked)
                  {
                      type = Encodetype.JSEncode;
                  }
                  else if (rbdFromJsString.Checked)
                  {
                      type = Encodetype.JSDecode;
                  }
                  else if (rbdToMD5.Checked)
                  {
                      type = Encodetype.ToMd5;
                  }
                  else if (rbdToSha256.Checked)
                  {
                      type = Encodetype.ToSha256;
                  }
                  else if (rbToLower.Checked)
                  {
                      type = Encodetype.ToLower;
                  }
                  else if (rbToUpper.Checked)
                  {
                      type = Encodetype.ToUpper;
                  }
                  RF.CodeType = type;
                  RF.Encoding = cbEncoding.Text;
                  RF.StrVarName = this.svStrVarName.VarName;
                  RF.SaveVarName = this.svSaveVarName.VarName;
                  RF.Name = this.tbActivityName.Text.Trim();
              });
        }

        litcore.activity.TextEncodeActivity RF = null;
        public override void SetActivity(Activity activity)
        {
            RF = activity as litcore.activity.TextEncodeActivity;
            switch (RF.CodeType)
            {
                case Encodetype.FromBase64:
                    this.rbdFromBase64.Checked = true;
                    break;
                case Encodetype.HTMLDecode:
                    this.rbdHtmlDecode.Checked = true;
                    break;
                case Encodetype.HTMLEncode:
                    this.rbdHtmlEncode.Checked = true;
                    break;
                case Encodetype.JSDecode:
                    this.rbdFromJsString.Checked = true;
                    break;
                case Encodetype.JSEncode:
                    this.rbdToJsString.Checked = true;
                    break;
                case Encodetype.ToBase64:
                    this.rbdToBase64.Checked = true;
                    break;
                case Encodetype.URLDecode:
                    this.rbdURLDecode.Checked = true;
                    break;
                case Encodetype.URLEncode:
                    this.rbdURLEncode.Checked = true;
                    break;
                case Encodetype.ToUpper:
                    this.rbToUpper.Checked = true;
                    break;
                case Encodetype.ToLower:
                    this.rbToLower.Checked = true;
                    break;
                case Encodetype.ToMd5:
                    this.rbdToMD5.Checked = true;
                    break;
                case Encodetype.ToSha256:
                    this.rbdToSha256.Checked = true;
                    break;

            }
            this.cbEncoding.Text = RF.Encoding;
            this.svStrVarName.VarName = RF.StrVarName;
            this.svSaveVarName.VarName = RF.SaveVarName;
            this.tbActivityName.Text = RF.Name;
        }

        private void rbdURLEncode_CheckedChanged(object sender, EventArgs e)
        {
            this.lbEncoding.Visible = this.cbEncoding.Visible = this.rbdURLEncode.Checked;
            if (rbdURLEncode.Checked) this.lbEncoding.Text = "URLEncode编码:";
        }

        private void rbdURLDecode_CheckedChanged(object sender, EventArgs e)
        {
            this.lbEncoding.Visible = this.cbEncoding.Visible = this.rbdURLDecode.Checked;
            if(rbdURLDecode.Checked) this.lbEncoding.Text= "URLDecode编码:";
        }
    }
}
