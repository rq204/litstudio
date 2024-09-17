using litsdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litapps
{
    internal partial class FrmUserInput : Form
    {
        UserInputActivity inputActivity = null;
        ActivityContext context = null;

        public FrmUserInput(UserInputActivity userInput, ActivityContext context)
        {
            InitializeComponent();
            this.inputActivity = userInput;
            this.context = context;
            this.Controls.Clear();
            this.Size = new Size(350, 500);
        }

        private void FrmUserInput_Load(object sender, EventArgs e)
        {
            this.Text = context.ReplaceVar(inputActivity.FormTitle);
            //确定左侧右侧的最大宽度
            int leftwidth = 0;
            int rightwidth = 220;//宽度设置默认为200

            foreach (UserInputConfig config in this.inputActivity.Configs)
            {
                config.Label = new Label();//字节*6+5
                config.Label.Text = context.ReplaceVar(config.Title);
                int len = System.Text.ASCIIEncoding.Default.GetBytes(config.Label.Text).Length;
                if (len > leftwidth) leftwidth = len;
                config.Panel = new Panel() { Tag = config };
                config.Panel.Controls.Add(config.Label);

                switch (config.Type)
                {
                    case UserInputType.TextBox:
                        System.Windows.Forms.TextBox textBox = new TextBox();
                        textBox.Text = string.IsNullOrEmpty(config.DefaultVarName) ? "" : context.GetStr(config.DefaultVarName);
                        config.Control = textBox;
                        break;
                    case UserInputType.MulTextBox:
                        System.Windows.Forms.TextBox mtextBox = new TextBox() { Multiline = true, ScrollBars = ScrollBars.Both };
                        mtextBox.Text = string.IsNullOrEmpty(config.DefaultVarName) ? "" : context.GetStr(config.DefaultVarName);
                        config.Control = mtextBox;
                        mtextBox.Height = 120;
                        break;
                    case UserInputType.ComboBox:
                        System.Windows.Forms.ComboBox comboBox = new ComboBox() { DropDownStyle = ComboBoxStyle.DropDownList };
                        List<string> vs = context.GetList(config.DefaultVarName);
                        foreach (string v in vs) comboBox.Items.Add(v);
                        if (vs.Count > 0) comboBox.SelectedIndex = 0;
                        config.Control = comboBox;
                        break;
                    case UserInputType.RadioButton://字节*6+23
                        List<string> vdes = context.GetList(config.DefaultVarName);
                        int rlen = 0;
                        config.Controls = new List<Control>();
                        foreach (string rd in vdes)
                        {
                            System.Windows.Forms.RadioButton radio = new RadioButton();
                            radio.Text = rd;
                            int ll = getlen(rd) * 6 + 23;
                            radio.Width = ll;
                            rlen += ll;
                            config.Controls.Add(radio);
                        }
                        if (rlen > rightwidth) rightwidth = rlen;
                        break;
                    case UserInputType.CheckBox://字节*6+24
                        int clen = 0;
                        config.Controls = new List<Control>();
                        List<string> checks = new List<string>();
                        if (context.ContainsList(config.DefaultVarName)) checks = context.GetList(config.DefaultVarName);
                        else
                        {
                            checks.Add(context.GetStr(config.DefaultVarName));
                        }

                        foreach (string ck in checks)
                        {
                            System.Windows.Forms.CheckBox cb = new CheckBox();
                            cb.Text = ck;
                            config.Controls.Add(cb);
                            int ll = getlen(ck) * 6 + 24;
                            cb.Width = ll;
                            clen += ll;
                        }
                        if (clen > rightwidth) rightwidth = clen;
                        break;
                    case UserInputType.NumericUpDwon:
                        System.Windows.Forms.NumericUpDown numericUp = new NumericUpDown();
                        numericUp.Maximum = int.MaxValue;
                        if (!string.IsNullOrEmpty(config.DefaultVarName))
                        {
                            int it = context.GetInt(config.DefaultVarName);
                            numericUp.Value = it;
                        }
                        config.Control = numericUp;
                        break;
                }

                if (config.Control != null) config.Control.Width = 200;
                if (config.Control != null) config.Panel.Controls.Add(config.Control);
                if (config.Controls != null)
                {
                    foreach (System.Windows.Forms.Control c in config.Controls)
                    {
                        config.Panel.Controls.Add(c);
                    }
                }
                this.Controls.Add(config.Panel);
            }

            leftwidth = leftwidth * 6;//一个字符占用6计算,前后各加20
            int width = leftwidth + rightwidth + 20 * 2 + 10;
            int lastHeght = 10;
            foreach (UserInputConfig config in this.inputActivity.Configs)
            {
                config.Panel.Location = new Point(0, lastHeght);
                if (config.Type == UserInputType.MulTextBox)
                {
                    config.Panel.Size = new Size(width, 120);//单行的固定值
                }
                else
                {
                    config.Panel.Size = new Size(width, 40);//单行的固定值
                }

                int len = getlen(config.Label.Text) * 6;
                config.Label.Width = len + 5;
                config.Label.Location = new Point(leftwidth - len + 20, 14);

                int rowheght = getsize(config.Type);

                int start = leftwidth + 5 + 20 + 10;
                if (config.Control != null) config.Control.Location = new Point(start, (40 - rowheght) / 2);
                else
                {
                    foreach (Control child in config.Controls)
                    {
                        child.Location = new Point(start, (40 - rowheght) / 2);
                        start += child.Width;
                    }
                }

                lastHeght += config.Panel.Height;
            }


            this.Size = new Size(width, lastHeght + 90);
            this.Controls.Add(btnSave);
            btnSave.Location = new Point(width / 2 - btnSave.Width / 2, lastHeght + 5);

            if (this.inputActivity.CanCloseForm && this.inputActivity.TimeOutClose)
            {
                new System.Threading.Thread(() =>
                {
                    System.Threading.Thread.Sleep(this.inputActivity.TimeOutSenconds * 1000);
                    if (this.Disposing || this.IsDisposed) return;
                    try
                    {
                        this.Invoke((EventHandler)delegate { this.Close(); });
                        context.WriteLog($"超时窗口 {this.inputActivity.FormTitle} 被关闭");
                    }
                    catch { }
                }).Start();
            }
        }

        private int getlen(string txt)
        {
            return System.Text.ASCIIEncoding.Default.GetBytes(txt).Length;
        }


        private int getsize(UserInputType inputType)
        {
            int num = 22;
            if (inputType == UserInputType.RadioButton || inputType == UserInputType.CheckBox) num = 16;
            else if (inputType == UserInputType.ComboBox) num = 20;
            return num;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> adds = new Dictionary<string, object>();

            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Panel p)
                    {
                        UserInputConfig config = p.Tag as UserInputConfig;
                        switch (config.Type)
                        {
                            case UserInputType.TextBox:
                            case UserInputType.MulTextBox:
                                string data = config.Control.Text;
                                if (!config.CanEmpty && string.IsNullOrEmpty(data)) throw new Exception(config.Title + " 不能为空");
                                adds.Add(config.ValueVarName, data);
                                break;
                            case UserInputType.CheckBox:
                                List<string> likes = new List<string>();
                                foreach (Control child in p.Controls)
                                {
                                    if (child is CheckBox cb)
                                    {
                                        if (cb.Checked)
                                        {
                                            likes.Add(cb.Text);
                                        }
                                    }
                                }
                                if (context.ContainsStr(config.ValueVarName))
                                {
                                    if (likes.Count == 0) adds.Add(config.ValueVarName, "");
                                    else adds.Add(config.ValueVarName, likes[0]);
                                }
                                else
                                {
                                    adds.Add(config.ValueVarName, likes);
                                }
                                break;
                            case UserInputType.ComboBox:
                                adds.Add(config.ValueVarName, config.Control.Text);
                                break;
                            case UserInputType.NumericUpDwon:
                                adds.Add(config.ValueVarName, (int)((NumericUpDown)config.Control).Value);
                                break;
                            case UserInputType.RadioButton:
                                string checktxt = "";
                                foreach (Control child in p.Controls)
                                {
                                    if (child is RadioButton rb)
                                    {
                                        if (rb.Checked)
                                        {
                                            checktxt = rb.Text;
                                        }
                                    }
                                }
                                if (string.IsNullOrEmpty(checktxt) && !config.CanEmpty) throw new Exception(config.ValueVarName + " 必须选择一个");
                                adds.Add(config.ValueVarName, checktxt);
                                break;
                        }
                    }
                }

                foreach (KeyValuePair<string, object> kv in adds)
                {
                    if (kv.Value is List<string> ls)
                    {
                        context.SetVarList(kv.Key, ls);
                        context.WriteLog($"成功设置变量 {kv.Key} 值为列表\r\n{string.Join("\r\n", ls.ToArray())}\r\n");
                    }
                    else if (kv.Value is string s)
                    {
                        context.SetVarStr(kv.Key, s);
                        context.WriteLog($"成功设置变量 {kv.Key} 值 {kv.Value}");
                    }
                    else if (kv.Value is int i)
                    {
                        context.SetVarInt(kv.Key, i);
                        context.WriteLog($"成功设置变量 {kv.Key} 值 {i}");
                    }

                }
                this.FormClosing -= FrmUserInput_FormClosing;
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "发生错误");
            }
        }

        private void FrmUserInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.inputActivity.CanCloseForm && e.CloseReason == CloseReason.UserClosing)
            {
                MessageBox.Show("请填写输入选项后点击确认","操作有误");
                e.Cancel = true;
            }
        }
    }
}
