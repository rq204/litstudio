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

namespace litstudio.iecef
{
    internal partial class SnifferUI : litsdk.ILitUI
    {
        public SnifferUI()
        {
            InitializeComponent();
            this.svDataVarName.ShowVarName(false, false, false, true);
            this.ivUrls.ShowVarName(true, false, false, this.tbUrls);

            string[] EncodingsArr = new string[] { "UTF-8", "GBK", "GB2312", "BIG5" };
            foreach (string a in EncodingsArr)
            {
                this.cbEncoding.Items.Add(a);
            }

            this.SaveActivity = () =>
            {
                nf.Name = this.tbActivityName.Text;
                nf.Urls = this.tbUrls.Text;
                nf.UseRegex = this.cbUseRegex.Checked;
                nf.DataVarName = this.svDataVarName.VarName;
                nf.DataIsFile = this.cbDataIsFile.Checked;
                nf.Encoding = this.cbEncoding.Text ;
            };
        }

        litcore.iecef.Sniffer nf = null;
        public override void SetActivity(Activity activity)
        {
            nf = activity as litcore.iecef.Sniffer;
            this.tbActivityName.Text = nf.Name;
            this.tbUrls.Text = nf.Urls;
            this.cbUseRegex.Checked = nf.UseRegex;
            this.svDataVarName.VarName = nf.DataVarName;
            this.cbDataIsFile.Checked = nf.DataIsFile;
            this.cbEncoding.Text = nf.Encoding;
        }

        private void cbDataIsFile_CheckedChanged(object sender, EventArgs e)
        {
            this.lbencoding.Visible = this.cbEncoding.Visible = !this.cbDataIsFile.Checked;
        }
    }
}
