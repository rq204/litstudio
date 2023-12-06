using litcore.sqldb;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litsqldb
{
    internal partial class FrmSqlDBConfig : Form
    {
        private litcore.sqldb.SqlDbType DbType = litcore.sqldb.SqlDbType.MySql;

        public FrmSqlDBConfig(litcore.sqldb.SqlDbType dbType)
        {
            InitializeComponent();
            this.ivhost.ShowVarName(true, false, false, this.tbHost);
            this.ivusername.ShowVarName(true, false, false, this.tbUserName);
            this.ivpassword.ShowVarName(true, false, false, this.tbPassword);
            this.ivDatabase.ShowVarName(true, false, false, this.tbDatabase);
            this.ivPort.ShowVarName(true, false, true, this.tbPort);
            this.DbType = dbType;
            this.Text += " " + dbType.ToDescriptionOrString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDBConfig sdb = GetUISqlDBConfig();
                litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
                SqlDBActivity.SetSqlDBConfig(context, sdb);
                this.reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "发生错误");
            }
        }

        private SqlDBConfig GetUISqlDBConfig()
        {
            SqlDBConfig dBConfig = new SqlDBConfig() { Name = this.tbName.Text.Trim(), CharSet = this.cbCharSet.Text, DBName = this.tbDatabase.Text, Host = this.tbHost.Text.Trim(), Password = this.tbPassword.Text.Trim(), Port = this.tbPort.Text, UserName = this.tbUserName.Text.Trim() };

            ///这个次序不能动，按索引 ,MySql, SqlServer, PostgreSQL,Oracle
            dBConfig.DbType = (litcore.sqldb.SqlDbType)Enum.ToObject(typeof(litcore.sqldb.SqlDbType), this.cbDatabaseType.SelectedIndex);

            if (string.IsNullOrEmpty(dBConfig.Name)) throw new Exception("数据库配置名称不能为空");
            if (string.IsNullOrEmpty(dBConfig.Host)) throw new Exception("数据库地址不能为空");

            if (string.IsNullOrEmpty(dBConfig.CharSet) && dBConfig.DbType == litcore.sqldb.SqlDbType.MySql) throw new Exception("数据库编码不能为空");

            if (string.IsNullOrEmpty(dBConfig.UserName)) throw new Exception("用户名不能为空");
            if (string.IsNullOrEmpty(dBConfig.Password)) throw new Exception("密码不能为空");
            if (string.IsNullOrEmpty(dBConfig.DBName)) throw new Exception("数据库名不能为空");

            return dBConfig;
        }

        private void reload()
        {
            this.lbDBConfigs.Items.Clear();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            List<SqlDBConfig> sdbs = SqlDBActivity.GetSqlDBConfigs(context);
            foreach (SqlDBConfig dBConfig in sdbs)
            {
                if (dBConfig.DbType == this.DbType) this.lbDBConfigs.Items.Add(dBConfig.Name);
            }
        }


        private void btnTest_Click(object sender, EventArgs e)
        {
            SqlDBConfig sdb = GetUISqlDBConfig();
            litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
            string connstr = context.ReplaceVar(sdb.ToConnectStr());
            this.btnTest.Enabled = false;
            new System.Threading.Thread(() =>
            {
                try
                {
                    if (sdb.DbType == litcore.sqldb.SqlDbType.PostgreSQL) SqlLoad.LoadPgSql();

                    IFreeSql _fsql = new FreeSql.FreeSqlBuilder()
                .UseConnectionString(GetDataType(sdb.DbType), connstr)
                .Build();

                    if (_fsql.Ado.ExecuteConnectTest())
                    {
                        MessageBox.Show("测试链接成功");
                    }
                    else
                    {
                        MessageBox.Show("测试链接失败，数据库配置有误:"+_fsql.Ado.MasterPool.UnavailableException.Message);
                    }
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace, "发生错误");
                }
                finally
                {
                    try
                    {
                        this.Invoke((EventHandler)delegate { this.btnTest.Enabled = true; });
                    }
                    catch { }
                }
            }).Start();
        }

        private void lbDBConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.lbDBConfigs.Text))
            {
                litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
                SqlDBConfig sqlDB = SqlDBActivity.GetSqlDBConfig(context, this.lbDBConfigs.Text);
                if (sqlDB != null)
                {
                    this.tbName.Text = sqlDB.Name;

                    this.tbHost.Text = sqlDB.Host;
                    this.tbPort.Text = sqlDB.Port;
                    this.cbCharSet.Text = sqlDB.CharSet;
                    this.tbUserName.Text = sqlDB.UserName;
                    this.tbPassword.Text = sqlDB.Password;
                    this.tbDatabase.Text = sqlDB.DBName;
                }
            }
        }

        public static FreeSql.DataType GetDataType(litcore.sqldb.SqlDbType dbType)
        {
            switch (dbType)
            {
                case litcore.sqldb.SqlDbType.MySql:
                    return FreeSql.DataType.MySql;
                case litcore.sqldb.SqlDbType.SqlServer:
                    return FreeSql.DataType.SqlServer;
                case litcore.sqldb.SqlDbType.Oracle:
                    return FreeSql.DataType.Oracle;
                case litcore.sqldb.SqlDbType.PostgreSQL:
                    return FreeSql.DataType.PostgreSQL;
                case litcore.sqldb.SqlDbType.Dameng:
                    return FreeSql.DataType.Dameng;
                case litcore.sqldb.SqlDbType.KingbaseES:
                    return FreeSql.DataType.KingbaseES;
                case litcore.sqldb.SqlDbType.ShenTong:
                    return FreeSql.DataType.ShenTong;
            }
            throw new Exception("不支持的数据库类型");
        }

        private void llbEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbDBConfigs_SelectedIndexChanged(null, null);
        }

        private void llbNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tbName.Clear();
            this.tbPassword.Clear();
            this.tbUserName.Clear();
            this.tbHost.Clear();
        }

        private void llbDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.lbDBConfigs.Text))
            {
                litsdk.ActivityContext context = litsdk.API.GetDesignActivityContext();
                List<SqlDBConfig> sdbs = SqlDBActivity.GetSqlDBConfigs(context);
                int index = sdbs.FindIndex((m) => m.Name == this.lbDBConfigs.Text);
                if (index > -1) sdbs.RemoveAt(index);

                this.reload();
            }
        }

        private void cbDatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbCharSet.Enabled = this.cbDatabaseType.SelectedIndex == 0;
        }

        private void FrmSqlDBConfig_Load(object sender, EventArgs e)
        {
            this.reload();
            //MySQL(TCP/IP)
            //                    SQLSERVER
            //                    PostgreSQL
            //Oracle
            //Dameng
            //ShenTong
            //KingbaseES
            if (this.DbType == litcore.sqldb.SqlDbType.MySql) this.cbDatabaseType.SelectedIndex = 0;
            else if (this.DbType == litcore.sqldb.SqlDbType.SqlServer) this.cbDatabaseType.SelectedIndex = 1;
            else if (this.DbType == litcore.sqldb.SqlDbType.PostgreSQL) this.cbDatabaseType.SelectedIndex = 2;
            else if (this.DbType == litcore.sqldb.SqlDbType.Oracle) this.cbDatabaseType.SelectedIndex = 3;
            else if (this.DbType == litcore.sqldb.SqlDbType.Dameng) this.cbDatabaseType.SelectedIndex = 4;
            else if (this.DbType == litcore.sqldb.SqlDbType.ShenTong) this.cbDatabaseType.SelectedIndex = 5;
            else if (this.DbType == litcore.sqldb.SqlDbType.KingbaseES) this.cbDatabaseType.SelectedIndex = 6;
        }
    }
}