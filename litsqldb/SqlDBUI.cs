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
using litcore.sqldb;

namespace litsqldb
{
    internal partial class SqlDBUI : litsdk.ILitUI
    {
        public SqlDBUI()
        {
            InitializeComponent();
            this.svSaveVarName.ShowVarName(true, true, true, true);
            this.ivSql.ShowVarName(true, false, true, this.tbSql);
            this.SaveActivity = new Action(() =>
              {
                  sdb.Name = this.tbActivityName.Text;
                  sdb.Sql = this.tbSql.Text;
                  sdb.SaveVarName = this.svSaveVarName.VarName;
                  sdb.DbConfigName = this.cbDbConfigName.Text;
                  sdb.NoAddslashes = this.cbNoAddslashes.Checked;
              });
        }

        private void tbSql_TextChanged(object sender, EventArgs e)
        {
            string txt = this.tbSql.Text.Trim();
            this.svSaveVarName.Enabled = txt.StartsWith("select", StringComparison.CurrentCultureIgnoreCase);
        }

        SqlDBActivity sdb = null;
        public override void SetActivity(Activity activity)
        {
            sdb = activity as SqlDBActivity;
            this.tbActivityName.Text = sdb.Name;
            this.tbSql.Text = sdb.Sql;
            this.svSaveVarName.VarName = sdb.SaveVarName;
            this.reloadlist();
            this.cbDbConfigName.Text = sdb.DbConfigName;
            this.cbNoAddslashes.Checked = sdb.NoAddslashes;
            if (this.cbDbConfigName.SelectedIndex == -1 && this.cbDbConfigName.Items.Count > 0)
                this.cbDbConfigName.SelectedIndex = 0;
        }

        private void reloadlist()
        {
            this.cbDbConfigName.Items.Clear();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            foreach (SqlDBConfig config in SqlDBActivity.GetSqlDBConfigs(context))
            {
                if (config.DbType == this.sdb.DbType) this.cbDbConfigName.Items.Add(config.Name);
            }
        }

        public override string ActivityType => "litcore.sqldb.SqlDBActivity";
        private void llbShowDatabase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            string old = Newtonsoft.Json.JsonConvert.SerializeObject(SqlDBActivity.GetSqlDBConfigs(context));
            new FrmSqlDBConfig(this.sdb.DbType).ShowDialog();
            string now = Newtonsoft.Json.JsonConvert.SerializeObject(SqlDBActivity.GetSqlDBConfigs(context));
            if (old != now)
            {
                this.reloadlist();
            }
        }

        private void llbAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            SqlDBConfig config = SqlDBActivity.GetSqlDBConfigs(context).Find((f) => f.Name == this.cbDbConfigName.Text);
            if (this.cbDbConfigName.SelectedIndex == -1 || config == null)
            {
                MessageBox.Show("请先选择数据库配置"); return;
            }
            string sql = "";
            switch (config.DbType)
            {
                case litcore.sqldb.SqlDbType.MySql:
                    sql = "insert into `table_name` (`title`,`content`) values ('标题','内容')";
                    break;
                case litcore.sqldb.SqlDbType.SqlServer:
                    sql = "insert into [table_name] ([title],[content]) values ('标题','内容')";
                    break;
            }
            litsdk.InsertVarName.InsertTextBox(this.tbSql, sql);
        }

        private void llbDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            SqlDBConfig config = SqlDBActivity.GetSqlDBConfigs(context).Find((f) => f.Name == this.cbDbConfigName.Text);
            if (this.cbDbConfigName.SelectedIndex == -1 || config == null)
            {
                MessageBox.Show("请先选择数据库配置"); return;
            }
            string sql = "";
            switch (config.DbType)
            {
                case litcore.sqldb.SqlDbType.MySql:
                    sql = "delete  from `table_name`  where `id`=1";
                    break;
                case litcore.sqldb.SqlDbType.SqlServer:
                    sql = "delete from [table_name] where [id]=1";
                    break;
            }
            litsdk.InsertVarName.InsertTextBox(this.tbSql, sql);
        }

        private void llbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            SqlDBConfig config = SqlDBActivity.GetSqlDBConfigs(context).Find((f) => f.Name == this.cbDbConfigName.Text);
            if (this.cbDbConfigName.SelectedIndex == -1 || config == null)
            {
                MessageBox.Show("请先选择数据库配置"); return;
            }
            string sql = "";
            switch (config.DbType)
            {
                case  litcore.sqldb.SqlDbType.MySql:
                    sql = "update `table_name` set `title`='标题',`content`='内容' where id=1";
                    break;
                case  litcore.sqldb.SqlDbType.SqlServer:
                    sql = "update [table_name] set [title]='标题',[content]='内容' where id=1";
                    break;
            }
            litsdk.InsertVarName.InsertTextBox(this.tbSql, sql);
        }

        private void llbSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            SqlDBConfig config = SqlDBActivity.GetSqlDBConfigs(context).Find((f) => f.Name == this.cbDbConfigName.Text);
            if (this.cbDbConfigName.SelectedIndex == -1 || config == null)
            {
                MessageBox.Show("请先选择数据库配置"); return;
            }
            string sql = "";
            switch (config.DbType)
            {
                case litcore.sqldb.SqlDbType.MySql:
                    sql = "select * from `table_name` limit 100";
                    break;
                case litcore.sqldb.SqlDbType.SqlServer:
                    sql = "select * from [table_name] top 100";
                    break;
            }
            litsdk.InsertVarName.InsertTextBox(this.tbSql, sql);
        }
    }
}
