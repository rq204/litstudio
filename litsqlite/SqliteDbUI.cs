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

namespace litsqlite
{
    internal partial class SqlitedbUI : litsdk.ILitUI
    {
        public SqlitedbUI()
        {
            InitializeComponent();
            this.ivSqliteFile.ShowVarName(true, false, true, this.tbSqliteFile);
            this.svSaveVarName.ShowVarName(true, true, true, true);
            this.ivSql.ShowVarName(true, false, true, this.tbSql);
            this.SaveActivity = new Action(() =>
              {
                  sdb.SqliteFile = this.tbSqliteFile.Text.Trim();
                  sdb.Sql = this.tbSql.Text.Trim();
                  sdb.Name = this.tbActivityName.Text.Trim();
                  sdb.SaveVarName = this.svSaveVarName.VarName;
              });
        }

        Sqlitedb sdb = null;
        public override string ActivityType => "litsqlite.Sqlitedb";

        public override void SetActivity(Activity activity)
        {
            sdb = activity as Sqlitedb;
            this.tbSqliteFile.Text = sdb.SqliteFile;
            this.tbSql.Text = sdb.Sql;
            this.tbActivityName.Text = sdb.Name;
            this.svSaveVarName.VarName = sdb.SaveVarName;
        }

        private void llbCurrentDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            litsdk.InsertVarName.InsertTextBox(this.tbSqliteFile, this.llbCurrentDir.Text);
        }

        private void llbOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "*.db3|*.db3;*.*";
            if(of.ShowDialog()== DialogResult.OK)
            {
                this.tbSqliteFile.Text = of.FileName;
            }
        }

        private void llbAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = "insert into [table_name] ([title],[content]) values ('标题','内容')";
            litsdk.InsertVarName.InsertTextBox(this.tbSql, sql);
        }

        private void llbDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = "delete from [table_name] where[id] = 1";
            litsdk.InsertVarName.InsertTextBox(this.tbSql, sql);
        }

        private void llbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = "update [table_name] set [title]='标题',[content]='内容' where id=1";
            litsdk.InsertVarName.InsertTextBox(this.tbSql, sql);
        }

        private void llbSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sql = "select * from [table_name]";
            litsdk.InsertVarName.InsertTextBox(this.tbSql, sql);
        }
    }
}
