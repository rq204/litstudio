using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using litsdk;

namespace litstudio
{
    internal class GetUrlUI :  litsdk.ILitUI
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbContains;
        private TextBox tbNotContains;
        private Label label6;
        private SelectVarName svSaveToVar;
        private CheckBox cbSrc;
        private CheckBox cbHref;
        private Label label4;
        private InsertVarName ivNotContains;
        private InsertVarName ivContians;
        private CheckBox cbEmail;
        private CheckBox cbPhone;
        private SelectVarName svHtmlStrVar;

        public GetUrlUI()
        {
            this.InitializeComponent();
            this.svHtmlStrVar.ShowVarName(true, false, false);
            this.svSaveToVar.ShowVarName(false, true, false);
            base.SaveActivity = new Action(() =>
              {
                  gua.SaveVarName = this.svSaveToVar.VarName;
                  gua.HtmlVarName = this.svHtmlStrVar.VarName;
                  string contains = this.tbContains.Text.Trim();
                  if (string.IsNullOrEmpty(contains))
                  {
                      gua.Contains = new List<string>();
                  }
                  else
                  {
                      gua.Contains =contains.Replace("\r", "").Split('\n').ToList();
                  }
                  string notcontains = this.tbNotContains.Text.Trim();
                  if (string.IsNullOrEmpty(notcontains))
                  {
                      gua.NotContains = new List<string>();
                  }
                  else
                  {
                      gua.NotContains =notcontains.Replace("\r", "").Split('\n').ToList();
                  }
                  gua.Name = this.tbActivityName.Text.Trim();
                  gua.SourceTypes.Clear();
                  if (this.cbHref.Checked) gua.SourceTypes.Add(litcore.type.SourceType.Href);
                  if (this.cbSrc.Checked) gua.SourceTypes.Add(litcore.type.SourceType.Src);
                  if (this.cbPhone.Checked) gua.SourceTypes.Add(litcore.type.SourceType.Phone);
                  if (this.cbEmail.Checked) gua.SourceTypes.Add(litcore.type.SourceType.Email);
              });
        }

        litcore.activity.GetResourceActivity gua = null;
        public override void SetActivity(Activity activity)
        {
            gua = activity as litcore.activity.GetResourceActivity;
            this.svHtmlStrVar.VarName = gua.HtmlVarName;
            this.svSaveToVar.VarName = gua.SaveVarName;
            this.tbNotContains.Text =string.Join("\r\n", gua.NotContains);
            this.tbContains.Text = string.Join("\r\n", gua.Contains);
            this.tbActivityName.Text = gua.Name;
            if (gua.SourceTypes.Contains(litcore.type.SourceType.Href)) this.cbHref.Checked = true;
            if (gua.SourceTypes.Contains(litcore.type.SourceType.Src)) this.cbSrc.Checked = true;
            if (gua.SourceTypes.Contains(litcore.type.SourceType.Phone)) this.cbPhone.Checked = true;
            if (gua.SourceTypes.Contains(litcore.type.SourceType.Email)) this.cbEmail.Checked = true;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.svHtmlStrVar = new litsdk.SelectVarName();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContains = new System.Windows.Forms.TextBox();
            this.tbNotContains = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.svSaveToVar = new litsdk.SelectVarName();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHref = new System.Windows.Forms.CheckBox();
            this.cbSrc = new System.Windows.Forms.CheckBox();
            this.ivContians = new litsdk.InsertVarName();
            this.ivNotContains = new litsdk.InsertVarName();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.ivNotContains);
            this.scActivityUI.Panel1.Controls.Add(this.ivContians);
            this.scActivityUI.Panel1.Controls.Add(this.cbEmail);
            this.scActivityUI.Panel1.Controls.Add(this.cbPhone);
            this.scActivityUI.Panel1.Controls.Add(this.cbSrc);
            this.scActivityUI.Panel1.Controls.Add(this.cbHref);
            this.scActivityUI.Panel1.Controls.Add(this.svSaveToVar);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.tbNotContains);
            this.scActivityUI.Panel1.Controls.Add(this.tbContains);
            this.scActivityUI.Panel1.Controls.Add(this.svHtmlStrVar);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "提取字符变量";
            // 
            // svHtmlStrVar
            // 
            this.svHtmlStrVar.Location = new System.Drawing.Point(114, 50);
            this.svHtmlStrVar.Name = "svHtmlStrVar";
            this.svHtmlStrVar.Size = new System.Drawing.Size(178, 23);
            this.svHtmlStrVar.TabIndex = 1;
            this.svHtmlStrVar.VarName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "结果必须包含\r\n (一行一条)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "结果不得包含\r\n(一行一条)";
            // 
            // tbContains
            // 
            this.tbContains.Location = new System.Drawing.Point(114, 87);
            this.tbContains.Multiline = true;
            this.tbContains.Name = "tbContains";
            this.tbContains.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContains.Size = new System.Drawing.Size(156, 94);
            this.tbContains.TabIndex = 3;
            // 
            // tbNotContains
            // 
            this.tbNotContains.Location = new System.Drawing.Point(389, 87);
            this.tbNotContains.Multiline = true;
            this.tbNotContains.Name = "tbNotContains";
            this.tbNotContains.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNotContains.Size = new System.Drawing.Size(156, 94);
            this.tbNotContains.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "结果添加至列表";
            // 
            // svSaveToVar
            // 
            this.svSaveToVar.Location = new System.Drawing.Point(113, 196);
            this.svSaveToVar.Name = "svSaveToVar";
            this.svSaveToVar.Size = new System.Drawing.Size(179, 23);
            this.svSaveToVar.TabIndex = 6;
            this.svSaveToVar.VarName = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "资源提取类型";
            // 
            // cbHref
            // 
            this.cbHref.AutoSize = true;
            this.cbHref.Location = new System.Drawing.Point(116, 15);
            this.cbHref.Name = "cbHref";
            this.cbHref.Size = new System.Drawing.Size(48, 16);
            this.cbHref.TabIndex = 8;
            this.cbHref.Text = "网址";
            this.cbHref.UseVisualStyleBackColor = true;
            // 
            // cbSrc
            // 
            this.cbSrc.AutoSize = true;
            this.cbSrc.Location = new System.Drawing.Point(170, 15);
            this.cbSrc.Name = "cbSrc";
            this.cbSrc.Size = new System.Drawing.Size(48, 16);
            this.cbSrc.TabIndex = 8;
            this.cbSrc.Text = "图片";
            this.cbSrc.UseVisualStyleBackColor = true;
            // 
            // ivContians
            // 
            this.ivContians.Location = new System.Drawing.Point(276, 90);
            this.ivContians.Name = "ivContians";
            this.ivContians.Size = new System.Drawing.Size(16, 16);
            this.ivContians.TabIndex = 9;
            // 
            // ivNotContains
            // 
            this.ivNotContains.Location = new System.Drawing.Point(551, 90);
            this.ivNotContains.Name = "ivNotContains";
            this.ivNotContains.Size = new System.Drawing.Size(16, 16);
            this.ivNotContains.TabIndex = 10;
            // 
            // cbPhone
            // 
            this.cbPhone.AutoSize = true;
            this.cbPhone.Location = new System.Drawing.Point(225, 16);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(60, 16);
            this.cbPhone.TabIndex = 8;
            this.cbPhone.Text = "手机号";
            this.cbPhone.UseVisualStyleBackColor = true;
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(291, 16);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(48, 16);
            this.cbEmail.TabIndex = 8;
            this.cbEmail.Text = "邮箱";
            this.cbEmail.UseVisualStyleBackColor = true;
            // 
            // GetUrlUI
            // 
            this.Name = "GetUrlUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
