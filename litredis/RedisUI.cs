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

namespace litredis
{
    internal partial class RedisUI : litsdk.ILitUI
    {
        public RedisUI()
        {
            InitializeComponent();
            this.ivHost.ShowVarName(true, false, true, this.tbHost);
            this.ivPassword.ShowVarName(true, false, false, this.tbPassword);
            this.ivDatabase.ShowVarName(true, false, true, this.tbDataBase);
            this.ivKey.ShowVarName(true, false, false, this.tbKey);
            this.svValueVarName.ShowVarName(true, true, false);
            this.svOptResult.ShowVarName(true, false, false);

            this.SaveActivity = new Action(() =>
              {
                  if (this.rbget.Checked)
                  {
                      ra.RedisType = RedisType.get;
                  }
                  else if (this.rbset.Checked)
                  {
                      ra.RedisType = RedisType.set;
                  }
                  else if (this.rblpush.Checked)
                  {
                      ra.RedisType = RedisType.lpush;
                  }
                  else if (this.rbrpush.Checked)
                  {
                      ra.RedisType = RedisType.rpush;
                  }
                  else if (this.rblpop.Checked)
                  {
                      ra.RedisType = RedisType.lpop;
                  }
                  else if (this.rbrpop.Checked)
                  {
                      ra.RedisType = RedisType.rpop;
                  }
                  else if (this.rbsadd.Checked)
                  {
                      ra.RedisType = RedisType.sadd;
                  }
                  else if (this.rbsismember.Checked)
                  {
                      ra.RedisType = RedisType.sismember;
                  }
                  ra.Host = this.tbHost.Text;
                  ra.Password = this.tbPassword.Text.Trim();
                  ra.DatabaseNum = this.tbDataBase.Text.Trim();
                  ra.Key = this.tbKey.Text.Trim();
                  ra.ValueVarName = this.svValueVarName.VarName;
                  ra.ResultVarName = this.svOptResult.VarName;
                  ra.Name = this.tbActivityName.Text;
              });

            foreach (Control c in this.scActivityUI.Panel1.Controls)
            {
                if (c is RadioButton rb) rb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            }
        }

        public override string ActivityType => "litredis.RedisActivity";
        RedisActivity ra = null;
        public override void SetActivity(Activity activity)
        {
            ra = activity as RedisActivity;

            switch (ra.RedisType)
            {
                case RedisType.get:
                    this.rbget.Checked = true;
                    break;
                case RedisType.set:
                    this.rbset.Checked = true;
                    break;
                case RedisType.lpush:
                    this.rblpush.Checked = true;
                    break;
                case RedisType.rpush:
                    this.rbrpush.Checked = true;
                    break;
                case RedisType.lpop:
                    this.rblpop.Checked = true;
                    break;
                case RedisType.rpop:
                    this.rbrpop.Checked = true;
                    break;
                case RedisType.sadd:
                    this.rbsadd.Checked = true;
                    break;
                case RedisType.sismember:
                    this.rbsismember.Checked = true;
                    break;
            }
            this.tbHost.Text = ra.Host;
            this.tbPassword.Text = ra.Password;
            this.tbDataBase.Text = ra.DatabaseNum;
            this.tbKey.Text = ra.Key;
            this.svValueVarName.VarName = ra.ValueVarName;
            this.svOptResult.VarName = ra.ResultVarName;
            this.tbActivityName.Text = ra.Name;
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            //可以处理列表
            if (this.rblpush.Checked || this.rbrpush.Checked || this.rbset.Checked || this.rbsadd.Checked)
            {
                this.svValueVarName.ShowVarName(true, true, false);
            }
            else
            {
                this.svValueVarName.ShowVarName(true, false, false);
            }
        }
    }
}