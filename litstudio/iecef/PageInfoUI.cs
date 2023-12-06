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
    internal partial class PageInfoUI : litsdk.ILitUI
    {
        public PageInfoUI()
        {
            InitializeComponent();
            this.svHtmlVarName.ShowVarName(true, false, false);
            this.svTitleVarName.ShowVarName(true, false, false);
            this.svUrlVarName.ShowVarName(true, false, false);
            this.svImagesVarName.ShowVarName(false, true, false);
            this.svHrefsVarName.ShowVarName(false, true, false);


            this.SaveActivity = new Action(() =>
            {
                pi.HtmlVarName = this.svHtmlVarName.VarName;
                pi.TitleVarName = this.svTitleVarName.VarName;
                pi.UrlVarName = this.svUrlVarName.VarName;
                pi.ImagesVarName = this.svImagesVarName.VarName;
                pi.HrefsVarName = this.svHrefsVarName.VarName;
                pi.Name = this.tbActivityName.Text.Trim();

            });
        }

        litcore.iecef.PageInfo pi = null;
        public override void SetActivity(Activity activity)
        {
            pi = activity as litcore.iecef.PageInfo;
            this.svHtmlVarName.VarName = pi.HtmlVarName;
            this.svTitleVarName.VarName = pi.TitleVarName;
            this.svUrlVarName.VarName = pi.UrlVarName;
            this.svImagesVarName.VarName = pi.ImagesVarName;
            this.svHrefsVarName.VarName = pi.HrefsVarName;
            this.tbActivityName.Text = pi.Name;
        }
    }
}
