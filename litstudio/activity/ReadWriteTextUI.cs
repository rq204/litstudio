using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using litsdk;

namespace litstudio
{
    internal class ReadWriteTextUI : ILitUI
    {
        private SelectVarName svContent;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lbShow;
        private System.Windows.Forms.CheckBox cbAppend;
        private System.Windows.Forms.RadioButton rbWrite;
        private System.Windows.Forms.RadioButton rbRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private InsertVarName insertVar1;
        private System.Windows.Forms.ComboBox cbEncoding;
        private System.Windows.Forms.LinkLabel llbdir;
        private System.Windows.Forms.LinkLabel llbOpen;
        private CheckBox cbAppendLine;
        private Label label3;
        private System.Windows.Forms.Label label2;

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lbShow = new System.Windows.Forms.Label();
            this.svContent = new litsdk.SelectVarName();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbRead = new System.Windows.Forms.RadioButton();
            this.rbWrite = new System.Windows.Forms.RadioButton();
            this.cbAppend = new System.Windows.Forms.CheckBox();
            this.insertVar1 = new litsdk.InsertVarName();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.llbdir = new System.Windows.Forms.LinkLabel();
            this.llbOpen = new System.Windows.Forms.LinkLabel();
            this.cbAppendLine = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.llbOpen);
            this.scActivityUI.Panel1.Controls.Add(this.llbdir);
            this.scActivityUI.Panel1.Controls.Add(this.cbEncoding);
            this.scActivityUI.Panel1.Controls.Add(this.insertVar1);
            this.scActivityUI.Panel1.Controls.Add(this.cbAppendLine);
            this.scActivityUI.Panel1.Controls.Add(this.cbAppend);
            this.scActivityUI.Panel1.Controls.Add(this.rbWrite);
            this.scActivityUI.Panel1.Controls.Add(this.rbRead);
            this.scActivityUI.Panel1.Controls.Add(this.svContent);
            this.scActivityUI.Panel1.Controls.Add(this.tbFilePath);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.lbShow);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件路径";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(92, 56);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(341, 21);
            this.tbFilePath.TabIndex = 1;
            // 
            // lbShow
            // 
            this.lbShow.AutoSize = true;
            this.lbShow.Location = new System.Drawing.Point(33, 97);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(53, 12);
            this.lbShow.TabIndex = 0;
            this.lbShow.Text = "存入变量";
            // 
            // svContent
            // 
            this.svContent.Location = new System.Drawing.Point(92, 93);
            this.svContent.Name = "svContent";
            this.svContent.Size = new System.Drawing.Size(192, 23);
            this.svContent.TabIndex = 2;
            this.svContent.VarName = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "文件编码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "操作类型";
            // 
            // rbRead
            // 
            this.rbRead.AutoSize = true;
            this.rbRead.Checked = true;
            this.rbRead.Location = new System.Drawing.Point(92, 24);
            this.rbRead.Name = "rbRead";
            this.rbRead.Size = new System.Drawing.Size(95, 16);
            this.rbRead.TabIndex = 3;
            this.rbRead.TabStop = true;
            this.rbRead.Text = "读取文本文件";
            this.rbRead.UseVisualStyleBackColor = true;
            this.rbRead.CheckedChanged += new System.EventHandler(this.rbRead_CheckedChanged);
            // 
            // rbWrite
            // 
            this.rbWrite.AutoSize = true;
            this.rbWrite.Location = new System.Drawing.Point(205, 24);
            this.rbWrite.Name = "rbWrite";
            this.rbWrite.Size = new System.Drawing.Size(95, 16);
            this.rbWrite.TabIndex = 3;
            this.rbWrite.Text = "写入文本文件";
            this.rbWrite.UseVisualStyleBackColor = true;
            this.rbWrite.CheckedChanged += new System.EventHandler(this.rbWrite_CheckedChanged);
            // 
            // cbAppend
            // 
            this.cbAppend.AutoSize = true;
            this.cbAppend.Location = new System.Drawing.Point(301, 96);
            this.cbAppend.Name = "cbAppend";
            this.cbAppend.Size = new System.Drawing.Size(72, 16);
            this.cbAppend.TabIndex = 4;
            this.cbAppend.Text = "追加写入";
            this.cbAppend.UseVisualStyleBackColor = true;
            this.cbAppend.Visible = false;
            // 
            // insertVar1
            // 
            this.insertVar1.Location = new System.Drawing.Point(439, 56);
            this.insertVar1.Name = "insertVar1";
            this.insertVar1.Size = new System.Drawing.Size(20, 23);
            this.insertVar1.TabIndex = 5;
            // 
            // cbEncoding
            // 
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.Items.AddRange(new object[] {
            "UTF-8",
            "GB2312",
            "GBK"});
            this.cbEncoding.Location = new System.Drawing.Point(92, 130);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(121, 20);
            this.cbEncoding.TabIndex = 6;
            // 
            // llbdir
            // 
            this.llbdir.AutoSize = true;
            this.llbdir.Location = new System.Drawing.Point(463, 59);
            this.llbdir.Name = "llbdir";
            this.llbdir.Size = new System.Drawing.Size(65, 12);
            this.llbdir.TabIndex = 7;
            this.llbdir.TabStop = true;
            this.llbdir.Text = "[当前目录]";
            this.llbdir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbdir_LinkClicked);
            // 
            // llbOpen
            // 
            this.llbOpen.AutoSize = true;
            this.llbOpen.Location = new System.Drawing.Point(530, 59);
            this.llbOpen.Name = "llbOpen";
            this.llbOpen.Size = new System.Drawing.Size(41, 12);
            this.llbOpen.TabIndex = 9;
            this.llbOpen.TabStop = true;
            this.llbOpen.Text = "[浏览]";
            this.llbOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbOpen_LinkClicked);
            // 
            // cbAppendLine
            // 
            this.cbAppendLine.AutoSize = true;
            this.cbAppendLine.Location = new System.Drawing.Point(388, 97);
            this.cbAppendLine.Name = "cbAppendLine";
            this.cbAppendLine.Size = new System.Drawing.Size(132, 16);
            this.cbAppendLine.TabIndex = 4;
            this.cbAppendLine.Text = "追加时末尾添加换行";
            this.cbAppendLine.UseVisualStyleBackColor = true;
            this.cbAppendLine.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(299, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "读写文件出错时会抛出异常，请注意处理异常";
            // 
            // ReadWriteTextUI
            // 
            this.Name = "ReadWriteTextUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void rbRead_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRead.Checked)
            {
                this.lbShow.Text = "存入变量";
                this.cbAppend.Visible = false;
                this.cbAppendLine.Visible = false;
            }
        }

        public ReadWriteTextUI()
        {
            this.InitializeComponent();
            this.insertVar1.ShowVarName(true, false, true, this.tbFilePath);
            this.svContent.ShowVarName(true, true, true);
            base.SaveActivity = new Action(() =>
            {
                rw.FilePath = this.tbFilePath.Text.Trim();
                rw.IsWrite = this.rbWrite.Checked;
                rw.Append = this.cbAppend.Checked;
                rw.Content = this.svContent.VarName;
                rw.Encoding = this.cbEncoding.Text;
                rw.AppendLine = this.cbAppendLine.Checked;
                rw.Name = this.tbActivityName.Text.Trim();
            });
        }

        private void rbWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWrite.Checked)
            {
                this.lbShow.Text = "写入内容";
                this.cbAppend.Visible = true;
                this.cbAppendLine.Visible = true;
            }
        }

        litcore.activity.RWTextActivity rw = null;
        public override void SetActivity(Activity activity)
        {
            rw = activity as litcore.activity.RWTextActivity;
            this.tbFilePath.Text = rw.FilePath;
            this.rbWrite.Checked = rw.IsWrite;
            this.cbAppend.Checked = rw.Append;
            this.svContent.VarName = rw.Content;
            this.cbEncoding.Text = rw.Encoding;
            this.tbActivityName.Text = rw.Name;
            this.cbAppendLine.Checked = rw.AppendLine;
        }

        private void llbdir_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbFilePath, this.llbdir.Text);
        }

        private void llbOpen_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (this.rbRead.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "文本文件|*.txt;*.ini;*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.tbFilePath.Text = openFileDialog.FileName;
                }
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "文本文件|*.txt|INI文件|*.ini|Json文件|*.json";
                save.DefaultExt = ".txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    this.tbFilePath.Text = save.FileName;
                }
            }
        }
    }
}