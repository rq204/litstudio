using System;
using System.Collections.Generic;

namespace litstudio.iecef
{
    partial class XPathUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbAttName = new System.Windows.Forms.Label();
            this.cbAttribute = new System.Windows.Forms.ComboBox();
            this.lbRWName = new System.Windows.Forms.Label();
            this.svRWVarName = new litsdk.SelectVarName();
            this.label6 = new System.Windows.Forms.Label();
            this.rbGet = new System.Windows.Forms.RadioButton();
            this.rbSet = new System.Windows.Forms.RadioButton();
            this.rbClick = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSleep = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lbpen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFrameName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNotice = new System.Windows.Forms.Label();
            this.ivXPath = new litsdk.InsertVarName();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.ivXPath);
            this.scActivityUI.Panel1.Controls.Add(this.lbNotice);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.tbFrameName);
            this.scActivityUI.Panel1.Controls.Add(this.lbpen);
            this.scActivityUI.Panel1.Controls.Add(this.nudSleep);
            this.scActivityUI.Panel1.Controls.Add(this.rbClick);
            this.scActivityUI.Panel1.Controls.Add(this.rbSet);
            this.scActivityUI.Panel1.Controls.Add(this.rbGet);
            this.scActivityUI.Panel1.Controls.Add(this.svRWVarName);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.lbRWName);
            this.scActivityUI.Panel1.Controls.Add(this.cbAttribute);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.lbAttName);
            this.scActivityUI.Panel1.Controls.Add(this.tbXPathStr);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            // 
            // tbXPathStr
            // 
            this.tbXPathStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbXPathStr.Location = new System.Drawing.Point(80, 12);
            this.tbXPathStr.Multiline = true;
            this.tbXPathStr.Name = "tbXPathStr";
            this.tbXPathStr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbXPathStr.Size = new System.Drawing.Size(369, 51);
            this.tbXPathStr.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "   XPath\r\n一行一条";
            // 
            // lbAttName
            // 
            this.lbAttName.AutoSize = true;
            this.lbAttName.Location = new System.Drawing.Point(18, 152);
            this.lbAttName.Name = "lbAttName";
            this.lbAttName.Size = new System.Drawing.Size(53, 12);
            this.lbAttName.TabIndex = 3;
            this.lbAttName.Text = "属性名称";
            // 
            // cbAttribute
            // 
            this.cbAttribute.FormattingEnabled = true;
            this.cbAttribute.Location = new System.Drawing.Point(80, 149);
            this.cbAttribute.Name = "cbAttribute";
            this.cbAttribute.Size = new System.Drawing.Size(178, 20);
            this.cbAttribute.TabIndex = 4;
            // 
            // lbRWName
            // 
            this.lbRWName.AutoSize = true;
            this.lbRWName.Location = new System.Drawing.Point(291, 153);
            this.lbRWName.Name = "lbRWName";
            this.lbRWName.Size = new System.Drawing.Size(53, 12);
            this.lbRWName.TabIndex = 5;
            this.lbRWName.Text = "取值存入";
            // 
            // svRWVarName
            // 
            this.svRWVarName.Location = new System.Drawing.Point(355, 149);
            this.svRWVarName.Name = "svRWVarName";
            this.svRWVarName.Size = new System.Drawing.Size(188, 23);
            this.svRWVarName.TabIndex = 6;
            this.svRWVarName.VarName = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "操作方式";
            // 
            // rbGet
            // 
            this.rbGet.AutoSize = true;
            this.rbGet.Location = new System.Drawing.Point(80, 114);
            this.rbGet.Name = "rbGet";
            this.rbGet.Size = new System.Drawing.Size(47, 16);
            this.rbGet.TabIndex = 7;
            this.rbGet.TabStop = true;
            this.rbGet.Text = "取值";
            this.rbGet.UseVisualStyleBackColor = true;
            this.rbGet.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSet
            // 
            this.rbSet.AutoSize = true;
            this.rbSet.Location = new System.Drawing.Point(141, 115);
            this.rbSet.Name = "rbSet";
            this.rbSet.Size = new System.Drawing.Size(47, 16);
            this.rbSet.TabIndex = 7;
            this.rbSet.TabStop = true;
            this.rbSet.Text = "写值";
            this.rbSet.UseVisualStyleBackColor = true;
            this.rbSet.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbClick
            // 
            this.rbClick.AutoSize = true;
            this.rbClick.Location = new System.Drawing.Point(206, 115);
            this.rbClick.Name = "rbClick";
            this.rbClick.Size = new System.Drawing.Size(47, 16);
            this.rbClick.TabIndex = 7;
            this.rbClick.TabStop = true;
            this.rbClick.Text = "点击";
            this.rbClick.UseVisualStyleBackColor = true;
            this.rbClick.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "延时等待";
            // 
            // nudSleep
            // 
            this.nudSleep.Location = new System.Drawing.Point(80, 186);
            this.nudSleep.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.nudSleep.Name = "nudSleep";
            this.nudSleep.Size = new System.Drawing.Size(79, 21);
            this.nudSleep.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "毫秒";
            // 
            // lbpen
            // 
            this.lbpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpen.ForeColor = System.Drawing.Color.Green;
            this.lbpen.Location = new System.Drawing.Point(473, 15);
            this.lbpen.Name = "lbpen";
            this.lbpen.Size = new System.Drawing.Size(89, 48);
            this.lbpen.TabIndex = 15;
            this.lbpen.Text = "在浏览器上移动鼠标选择元素，鼠标右键停止选择或重新开始";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "指定Frame";
            // 
            // tbFrameName
            // 
            this.tbFrameName.Location = new System.Drawing.Point(80, 77);
            this.tbFrameName.Name = "tbFrameName";
            this.tbFrameName.Size = new System.Drawing.Size(277, 21);
            this.tbFrameName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(363, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "空为主页面，可为框架名或框架网址";
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.ForeColor = System.Drawing.Color.Green;
            this.lbNotice.Location = new System.Drawing.Point(274, 117);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(185, 12);
            this.lbNotice.TabIndex = 18;
            this.lbNotice.Text = "均为Js方式操作，非真实键盘鼠标";
            // 
            // ivXPath
            // 
            this.ivXPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivXPath.Location = new System.Drawing.Point(453, 15);
            this.ivXPath.Name = "ivXPath";
            this.ivXPath.Size = new System.Drawing.Size(16, 16);
            this.ivXPath.TabIndex = 19;
            // 
            // XPathUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "XPathUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSleep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbSet;
        private System.Windows.Forms.RadioButton rbGet;
        private litsdk.SelectVarName svRWVarName;
        private System.Windows.Forms.Label lbRWName;
        private System.Windows.Forms.ComboBox cbAttribute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAttName;
        private System.Windows.Forms.TextBox tbXPathStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbClick;
        private System.Windows.Forms.NumericUpDown nudSleep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFrameName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNotice;
        private litsdk.InsertVarName ivXPath;
    }
}
