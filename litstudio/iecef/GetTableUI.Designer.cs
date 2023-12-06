using System;
using System.Collections.Generic;

namespace litstudio.iecef
{
    partial class GetTableUI
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            litsdk.API.SetXPath -= new Action<string,List<string>>(this.SetXPath);
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbXPathStr = new System.Windows.Forms.TextBox();
            this.lbXpath = new System.Windows.Forms.Label();
            this.lbpen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFrameName = new System.Windows.Forms.TextBox();
            this.ivXPath = new litsdk.InsertVarName();
            this.label4 = new System.Windows.Forms.Label();
            this.svFileVarName = new litsdk.SelectVarName();
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
            this.scActivityUI.Panel1.Controls.Add(this.svFileVarName);
            this.scActivityUI.Panel1.Controls.Add(this.ivXPath);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.tbFrameName);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.lbpen);
            this.scActivityUI.Panel1.Controls.Add(this.tbXPathStr);
            this.scActivityUI.Panel1.Controls.Add(this.lbXpath);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            // 
            // tbXPathStr
            // 
            this.tbXPathStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbXPathStr.Location = new System.Drawing.Point(96, 13);
            this.tbXPathStr.Multiline = true;
            this.tbXPathStr.Name = "tbXPathStr";
            this.tbXPathStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbXPathStr.Size = new System.Drawing.Size(375, 45);
            this.tbXPathStr.TabIndex = 7;
            // 
            // lbXpath
            // 
            this.lbXpath.AutoSize = true;
            this.lbXpath.Location = new System.Drawing.Point(24, 17);
            this.lbXpath.Name = "lbXpath";
            this.lbXpath.Size = new System.Drawing.Size(59, 12);
            this.lbXpath.TabIndex = 9;
            this.lbXpath.Text = "元素XPath";
            // 
            // lbpen
            // 
            this.lbpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpen.ForeColor = System.Drawing.Color.Green;
            this.lbpen.Location = new System.Drawing.Point(498, 13);
            this.lbpen.Name = "lbpen";
            this.lbpen.Size = new System.Drawing.Size(70, 53);
            this.lbpen.TabIndex = 14;
            this.lbpen.Text = "鼠标移动选择元素，鼠标右键停止选择或开始";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(364, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "空为主页面，可为框架名或框架网址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "指定Frame";
            // 
            // tbFrameName
            // 
            this.tbFrameName.Location = new System.Drawing.Point(96, 73);
            this.tbFrameName.Name = "tbFrameName";
            this.tbFrameName.Size = new System.Drawing.Size(264, 21);
            this.tbFrameName.TabIndex = 20;
            // 
            // ivXPath
            // 
            this.ivXPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivXPath.Location = new System.Drawing.Point(475, 17);
            this.ivXPath.Name = "ivXPath";
            this.ivXPath.Size = new System.Drawing.Size(16, 16);
            this.ivXPath.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "表格变量";
            // 
            // svFileVarName
            // 
            this.svFileVarName.Location = new System.Drawing.Point(96, 201);
            this.svFileVarName.Name = "svFileVarName";
            this.svFileVarName.Size = new System.Drawing.Size(174, 23);
            this.svFileVarName.TabIndex = 32;
            this.svFileVarName.VarName = "";
            // 
            // GetTableUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GetTableUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbXPathStr;
        private System.Windows.Forms.Label lbXpath;
        private System.Windows.Forms.Label lbpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFrameName;
        private litsdk.InsertVarName ivXPath;
        private litsdk.SelectVarName svFileVarName;
        private System.Windows.Forms.Label label4;
    }
}
