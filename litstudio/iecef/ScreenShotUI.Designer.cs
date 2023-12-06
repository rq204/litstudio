using System;
using System.Collections.Generic;

namespace litstudio.iecef
{
    partial class ScreenShotUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPng = new System.Windows.Forms.RadioButton();
            this.rbJpg = new System.Windows.Forms.RadioButton();
            this.rbBmp = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.svSavePathVarName = new litsdk.SelectVarName();
            this.rbXPath = new System.Windows.Forms.RadioButton();
            this.tbXPathStr = new System.Windows.Forms.TextBox();
            this.lbXpath = new System.Windows.Forms.Label();
            this.cbUseTempPath = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbpen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFrameName = new System.Windows.Forms.TextBox();
            this.ivXPath = new litsdk.InsertVarName();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.ivXPath);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.tbFrameName);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.lbpen);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.cbUseTempPath);
            this.scActivityUI.Panel1.Controls.Add(this.tbXPathStr);
            this.scActivityUI.Panel1.Controls.Add(this.lbXpath);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.rbFull);
            this.scActivityUI.Panel1.Controls.Add(this.rbXPath);
            this.scActivityUI.Panel1.Controls.Add(this.panel1);
            this.scActivityUI.Panel1.Controls.Add(this.svSavePathVarName);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "截图方式";
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Location = new System.Drawing.Point(225, 14);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(95, 16);
            this.rbFull.TabIndex = 1;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "截取整个页面";
            this.rbFull.UseVisualStyleBackColor = true;
            this.rbFull.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "图片格式";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPng);
            this.panel1.Controls.Add(this.rbJpg);
            this.panel1.Controls.Add(this.rbBmp);
            this.panel1.Location = new System.Drawing.Point(97, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 23);
            this.panel1.TabIndex = 2;
            // 
            // rbPng
            // 
            this.rbPng.AutoSize = true;
            this.rbPng.Location = new System.Drawing.Point(4, 4);
            this.rbPng.Name = "rbPng";
            this.rbPng.Size = new System.Drawing.Size(41, 16);
            this.rbPng.TabIndex = 1;
            this.rbPng.TabStop = true;
            this.rbPng.Text = "png";
            this.rbPng.UseVisualStyleBackColor = true;
            // 
            // rbJpg
            // 
            this.rbJpg.AutoSize = true;
            this.rbJpg.Location = new System.Drawing.Point(51, 4);
            this.rbJpg.Name = "rbJpg";
            this.rbJpg.Size = new System.Drawing.Size(41, 16);
            this.rbJpg.TabIndex = 1;
            this.rbJpg.TabStop = true;
            this.rbJpg.Text = "jpg";
            this.rbJpg.UseVisualStyleBackColor = true;
            // 
            // rbBmp
            // 
            this.rbBmp.AutoSize = true;
            this.rbBmp.Location = new System.Drawing.Point(98, 4);
            this.rbBmp.Name = "rbBmp";
            this.rbBmp.Size = new System.Drawing.Size(41, 16);
            this.rbBmp.TabIndex = 1;
            this.rbBmp.TabStop = true;
            this.rbBmp.Text = "bmp";
            this.rbBmp.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "保存地址";
            // 
            // svSavePathVarName
            // 
            this.svSavePathVarName.Location = new System.Drawing.Point(97, 170);
            this.svSavePathVarName.Name = "svSavePathVarName";
            this.svSavePathVarName.Size = new System.Drawing.Size(176, 23);
            this.svSavePathVarName.TabIndex = 6;
            this.svSavePathVarName.VarName = "";
            // 
            // rbXPath
            // 
            this.rbXPath.AutoSize = true;
            this.rbXPath.Location = new System.Drawing.Point(97, 14);
            this.rbXPath.Name = "rbXPath";
            this.rbXPath.Size = new System.Drawing.Size(119, 16);
            this.rbXPath.TabIndex = 1;
            this.rbXPath.TabStop = true;
            this.rbXPath.Text = "获取指定图片元素";
            this.rbXPath.UseVisualStyleBackColor = true;
            this.rbXPath.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tbXPathStr
            // 
            this.tbXPathStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbXPathStr.Location = new System.Drawing.Point(97, 42);
            this.tbXPathStr.Multiline = true;
            this.tbXPathStr.Name = "tbXPathStr";
            this.tbXPathStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbXPathStr.Size = new System.Drawing.Size(375, 45);
            this.tbXPathStr.TabIndex = 7;
            // 
            // lbXpath
            // 
            this.lbXpath.AutoSize = true;
            this.lbXpath.Location = new System.Drawing.Point(25, 46);
            this.lbXpath.Name = "lbXpath";
            this.lbXpath.Size = new System.Drawing.Size(59, 12);
            this.lbXpath.TabIndex = 9;
            this.lbXpath.Text = "元素XPath";
            // 
            // cbUseTempPath
            // 
            this.cbUseTempPath.AutoSize = true;
            this.cbUseTempPath.Location = new System.Drawing.Point(292, 172);
            this.cbUseTempPath.Name = "cbUseTempPath";
            this.cbUseTempPath.Size = new System.Drawing.Size(156, 16);
            this.cbUseTempPath.TabIndex = 11;
            this.cbUseTempPath.Text = "使用系统临时文件名保存";
            this.cbUseTempPath.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(93, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(461, 34);
            this.label4.TabIndex = 12;
            this.label4.Text = "使用系统临时文件名保存时，将会使用随机文件名，将文件保存在系统临时目录下，并将该路径保存至保存地址变量当中";
            // 
            // lbpen
            // 
            this.lbpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpen.ForeColor = System.Drawing.Color.Green;
            this.lbpen.Location = new System.Drawing.Point(499, 42);
            this.lbpen.Name = "lbpen";
            this.lbpen.Size = new System.Drawing.Size(70, 53);
            this.lbpen.TabIndex = 14;
            this.lbpen.Text = "鼠标移动选择元素，鼠标右键停止选择或开始";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(365, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "空为主页面，可为框架名或框架网址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "指定Frame";
            // 
            // tbFrameName
            // 
            this.tbFrameName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFrameName.Location = new System.Drawing.Point(97, 102);
            this.tbFrameName.Name = "tbFrameName";
            this.tbFrameName.Size = new System.Drawing.Size(264, 21);
            this.tbFrameName.TabIndex = 20;
            // 
            // ivXPath
            // 
            this.ivXPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivXPath.Location = new System.Drawing.Point(476, 46);
            this.ivXPath.Name = "ivXPath";
            this.ivXPath.Size = new System.Drawing.Size(16, 16);
            this.ivXPath.TabIndex = 22;
            // 
            // ScreenShotUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ScreenShotUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbBmp;
        private System.Windows.Forms.RadioButton rbJpg;
        private System.Windows.Forms.RadioButton rbPng;
        private System.Windows.Forms.Label label6;
        private litsdk.SelectVarName svSavePathVarName;
        private System.Windows.Forms.TextBox tbXPathStr;
        private System.Windows.Forms.RadioButton rbXPath;
        private System.Windows.Forms.Label lbXpath;
        private System.Windows.Forms.CheckBox cbUseTempPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFrameName;
        private litsdk.InsertVarName ivXPath;
    }
}
