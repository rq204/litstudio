using System;
using System.Collections.Generic;

namespace litstudio.iecef
{
    partial class WaitUI
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
            this.lbpen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFrameName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbWaitIFrame = new System.Windows.Forms.CheckBox();
            this.rbWaitDisAppear = new System.Windows.Forms.RadioButton();
            this.rbWaitAppear = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudTimeOut = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ivXPath = new litsdk.InsertVarName();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).BeginInit();
            this.scActivityUI.Panel1.SuspendLayout();
            this.scActivityUI.Panel2.SuspendLayout();
            this.scActivityUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOut)).BeginInit();
            this.SuspendLayout();
            // 
            // scActivityUI
            // 
            // 
            // scActivityUI.Panel1
            // 
            this.scActivityUI.Panel1.Controls.Add(this.ivXPath);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.nudTimeOut);
            this.scActivityUI.Panel1.Controls.Add(this.label9);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.rbWaitDisAppear);
            this.scActivityUI.Panel1.Controls.Add(this.rbWaitAppear);
            this.scActivityUI.Panel1.Controls.Add(this.cbWaitIFrame);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.tbFrameName);
            this.scActivityUI.Panel1.Controls.Add(this.lbpen);
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
            this.tbXPathStr.Size = new System.Drawing.Size(371, 51);
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
            // lbpen
            // 
            this.lbpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbpen.ForeColor = System.Drawing.Color.Green;
            this.lbpen.Location = new System.Drawing.Point(478, 15);
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
            this.label5.Location = new System.Drawing.Point(360, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "空为主页面，可为框架名或框架网址";
            // 
            // cbWaitIFrame
            // 
            this.cbWaitIFrame.AutoSize = true;
            this.cbWaitIFrame.Location = new System.Drawing.Point(248, 122);
            this.cbWaitIFrame.Name = "cbWaitIFrame";
            this.cbWaitIFrame.Size = new System.Drawing.Size(72, 16);
            this.cbWaitIFrame.TabIndex = 18;
            this.cbWaitIFrame.Text = "等待框架";
            this.cbWaitIFrame.UseVisualStyleBackColor = true;
            // 
            // rbWaitDisAppear
            // 
            this.rbWaitDisAppear.AutoSize = true;
            this.rbWaitDisAppear.Location = new System.Drawing.Point(159, 121);
            this.rbWaitDisAppear.Name = "rbWaitDisAppear";
            this.rbWaitDisAppear.Size = new System.Drawing.Size(71, 16);
            this.rbWaitDisAppear.TabIndex = 19;
            this.rbWaitDisAppear.TabStop = true;
            this.rbWaitDisAppear.Text = "等待消失";
            this.rbWaitDisAppear.UseVisualStyleBackColor = true;
            // 
            // rbWaitAppear
            // 
            this.rbWaitAppear.AutoSize = true;
            this.rbWaitAppear.Location = new System.Drawing.Point(80, 121);
            this.rbWaitAppear.Name = "rbWaitAppear";
            this.rbWaitAppear.Size = new System.Drawing.Size(71, 16);
            this.rbWaitAppear.TabIndex = 20;
            this.rbWaitAppear.TabStop = true;
            this.rbWaitAppear.Text = "等待出现";
            this.rbWaitAppear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "等待方式";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "毫秒";
            // 
            // nudTimeOut
            // 
            this.nudTimeOut.Location = new System.Drawing.Point(78, 155);
            this.nudTimeOut.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.nudTimeOut.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTimeOut.Name = "nudTimeOut";
            this.nudTimeOut.Size = new System.Drawing.Size(84, 21);
            this.nudTimeOut.TabIndex = 22;
            this.nudTimeOut.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "等待超时";
            // 
            // ivXPath
            // 
            this.ivXPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ivXPath.Location = new System.Drawing.Point(455, 15);
            this.ivXPath.Name = "ivXPath";
            this.ivXPath.Size = new System.Drawing.Size(16, 16);
            this.ivXPath.TabIndex = 24;
            // 
            // WaitUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "WaitUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbXPathStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFrameName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbWaitIFrame;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbWaitDisAppear;
        private System.Windows.Forms.RadioButton rbWaitAppear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTimeOut;
        private System.Windows.Forms.Label label9;
        private litsdk.InsertVarName ivXPath;
    }
}
