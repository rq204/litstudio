using System;
using System.Collections.Generic;

namespace litstudio.iecef
{
    partial class ClickDownUI
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
            this.label6 = new System.Windows.Forms.Label();
            this.tbXPathStr = new System.Windows.Forms.TextBox();
            this.lbXpath = new System.Windows.Forms.Label();
            this.lbpen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFrameName = new System.Windows.Forms.TextBox();
            this.ivXPath = new litsdk.InsertVarName();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDownTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.ivSavePath = new litsdk.InsertVarName();
            this.llbCurDir = new System.Windows.Forms.LinkLabel();
            this.llbRand = new System.Windows.Forms.LinkLabel();
            this.llbExt = new System.Windows.Forms.LinkLabel();
            this.llbOriginalName = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.svSaveVarName = new litsdk.SelectVarName();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.svSaveVarName);
            this.scActivityUI.Panel1.Controls.Add(this.llbRand);
            this.scActivityUI.Panel1.Controls.Add(this.llbExt);
            this.scActivityUI.Panel1.Controls.Add(this.llbOriginalName);
            this.scActivityUI.Panel1.Controls.Add(this.llbCurDir);
            this.scActivityUI.Panel1.Controls.Add(this.ivSavePath);
            this.scActivityUI.Panel1.Controls.Add(this.tbSavePath);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.nudDownTimeOut);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            this.scActivityUI.Panel1.Controls.Add(this.ivXPath);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.tbFrameName);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.lbpen);
            this.scActivityUI.Panel1.Controls.Add(this.tbXPathStr);
            this.scActivityUI.Panel1.Controls.Add(this.lbXpath);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "保存地址";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "下载超时";
            // 
            // nudDownTimeOut
            // 
            this.nudDownTimeOut.Location = new System.Drawing.Point(96, 183);
            this.nudDownTimeOut.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.nudDownTimeOut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDownTimeOut.Name = "nudDownTimeOut";
            this.nudDownTimeOut.Size = new System.Drawing.Size(86, 21);
            this.nudDownTimeOut.TabIndex = 24;
            this.nudDownTimeOut.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(191, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "秒，如果超过将停止下载，请使用文件存在来判断是否下载完成";
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(96, 110);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(264, 21);
            this.tbSavePath.TabIndex = 26;
            // 
            // ivSavePath
            // 
            this.ivSavePath.Location = new System.Drawing.Point(372, 112);
            this.ivSavePath.Name = "ivSavePath";
            this.ivSavePath.Size = new System.Drawing.Size(16, 16);
            this.ivSavePath.TabIndex = 27;
            // 
            // llbCurDir
            // 
            this.llbCurDir.AutoSize = true;
            this.llbCurDir.Location = new System.Drawing.Point(394, 107);
            this.llbCurDir.Name = "llbCurDir";
            this.llbCurDir.Size = new System.Drawing.Size(65, 12);
            this.llbCurDir.TabIndex = 28;
            this.llbCurDir.TabStop = true;
            this.llbCurDir.Text = "[当前目录]";
            this.llbCurDir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCurDir_LinkClicked);
            // 
            // llbRand
            // 
            this.llbRand.AutoSize = true;
            this.llbRand.Location = new System.Drawing.Point(465, 129);
            this.llbRand.Name = "llbRand";
            this.llbRand.Size = new System.Drawing.Size(77, 12);
            this.llbRand.TabIndex = 31;
            this.llbRand.TabStop = true;
            this.llbRand.Text = "[随机文件名]";
            this.llbRand.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRand_LinkClicked);
            // 
            // llbExt
            // 
            this.llbExt.AutoSize = true;
            this.llbExt.Location = new System.Drawing.Point(394, 129);
            this.llbExt.Name = "llbExt";
            this.llbExt.Size = new System.Drawing.Size(65, 12);
            this.llbExt.TabIndex = 29;
            this.llbExt.TabStop = true;
            this.llbExt.Text = "[原扩展名]";
            this.llbExt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbExt_LinkClicked);
            // 
            // llbOriginalName
            // 
            this.llbOriginalName.AutoSize = true;
            this.llbOriginalName.Location = new System.Drawing.Point(465, 107);
            this.llbOriginalName.Name = "llbOriginalName";
            this.llbOriginalName.Size = new System.Drawing.Size(77, 12);
            this.llbOriginalName.TabIndex = 30;
            this.llbOriginalName.TabStop = true;
            this.llbOriginalName.Text = "[原文件全名]";
            this.llbOriginalName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOriginalName_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "地址存入";
            // 
            // svSaveVarName
            // 
            this.svSaveVarName.Location = new System.Drawing.Point(96, 146);
            this.svSaveVarName.Name = "svSaveVarName";
            this.svSaveVarName.Size = new System.Drawing.Size(151, 23);
            this.svSaveVarName.TabIndex = 32;
            this.svSaveVarName.VarName = "";
            // 
            // ClickDownUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ClickDownUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDownTimeOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbXPathStr;
        private System.Windows.Forms.Label lbXpath;
        private System.Windows.Forms.Label lbpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFrameName;
        private litsdk.InsertVarName ivXPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDownTimeOut;
        private litsdk.InsertVarName ivSavePath;
        private System.Windows.Forms.TextBox tbSavePath;
        private System.Windows.Forms.LinkLabel llbCurDir;
        private System.Windows.Forms.LinkLabel llbRand;
        private System.Windows.Forms.LinkLabel llbExt;
        private System.Windows.Forms.LinkLabel llbOriginalName;
        private System.Windows.Forms.Label label4;
        private litsdk.SelectVarName svSaveVarName;
    }
}
