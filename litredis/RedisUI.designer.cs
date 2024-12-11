namespace litredis
{
    partial class RedisUI
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
            this.tbHost = new System.Windows.Forms.TextBox();
            this.ivHost = new litsdk.InsertVarName();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.svValueVarName = new litsdk.SelectVarName();
            this.rbset = new System.Windows.Forms.RadioButton();
            this.rbget = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.ivPassword = new litsdk.InsertVarName();
            this.rblpush = new System.Windows.Forms.RadioButton();
            this.rbrpush = new System.Windows.Forms.RadioButton();
            this.rblpop = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.ivDatabase = new litsdk.InsertVarName();
            this.ivKey = new litsdk.InsertVarName();
            this.rbrpop = new System.Windows.Forms.RadioButton();
            this.tbDataBase = new System.Windows.Forms.TextBox();
            this.rbsadd = new System.Windows.Forms.RadioButton();
            this.rbsismember = new System.Windows.Forms.RadioButton();
            this.svOptResult = new litsdk.SelectVarName();
            this.label7 = new System.Windows.Forms.Label();
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
            this.scActivityUI.Panel1.Controls.Add(this.svOptResult);
            this.scActivityUI.Panel1.Controls.Add(this.label7);
            this.scActivityUI.Panel1.Controls.Add(this.rbsismember);
            this.scActivityUI.Panel1.Controls.Add(this.rbsadd);
            this.scActivityUI.Panel1.Controls.Add(this.ivDatabase);
            this.scActivityUI.Panel1.Controls.Add(this.ivKey);
            this.scActivityUI.Panel1.Controls.Add(this.ivPassword);
            this.scActivityUI.Panel1.Controls.Add(this.rbrpop);
            this.scActivityUI.Panel1.Controls.Add(this.rblpop);
            this.scActivityUI.Panel1.Controls.Add(this.rbrpush);
            this.scActivityUI.Panel1.Controls.Add(this.rblpush);
            this.scActivityUI.Panel1.Controls.Add(this.rbget);
            this.scActivityUI.Panel1.Controls.Add(this.rbset);
            this.scActivityUI.Panel1.Controls.Add(this.svValueVarName);
            this.scActivityUI.Panel1.Controls.Add(this.tbKey);
            this.scActivityUI.Panel1.Controls.Add(this.ivHost);
            this.scActivityUI.Panel1.Controls.Add(this.tbDataBase);
            this.scActivityUI.Panel1.Controls.Add(this.tbPassword);
            this.scActivityUI.Panel1.Controls.Add(this.tbHost);
            this.scActivityUI.Panel1.Controls.Add(this.label5);
            this.scActivityUI.Panel1.Controls.Add(this.label4);
            this.scActivityUI.Panel1.Controls.Add(this.label3);
            this.scActivityUI.Panel1.Controls.Add(this.label8);
            this.scActivityUI.Panel1.Controls.Add(this.label6);
            this.scActivityUI.Panel1.Controls.Add(this.label2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "服务器地址";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(97, 74);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(370, 21);
            this.tbHost.TabIndex = 1;
            // 
            // ivHost
            // 
            this.ivHost.Location = new System.Drawing.Point(474, 77);
            this.ivHost.Name = "ivHost";
            this.ivHost.Size = new System.Drawing.Size(16, 16);
            this.ivHost.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "操作类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "键名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "键值";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(96, 153);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(116, 21);
            this.tbKey.TabIndex = 3;
            // 
            // svValueVarName
            // 
            this.svValueVarName.Location = new System.Drawing.Point(329, 152);
            this.svValueVarName.Name = "svValueVarName";
            this.svValueVarName.Size = new System.Drawing.Size(161, 23);
            this.svValueVarName.TabIndex = 4;
            this.svValueVarName.VarName = "";
            // 
            // rbset
            // 
            this.rbset.AutoSize = true;
            this.rbset.Location = new System.Drawing.Point(97, 13);
            this.rbset.Name = "rbset";
            this.rbset.Size = new System.Drawing.Size(41, 16);
            this.rbset.TabIndex = 5;
            this.rbset.TabStop = true;
            this.rbset.Text = "set";
            this.rbset.UseVisualStyleBackColor = true;

            // 
            // rbget
            // 
            this.rbget.AutoSize = true;
            this.rbget.Location = new System.Drawing.Point(170, 14);
            this.rbget.Name = "rbget";
            this.rbget.Size = new System.Drawing.Size(41, 16);
            this.rbget.TabIndex = 5;
            this.rbget.TabStop = true;
            this.rbget.Text = "get";
            this.rbget.UseVisualStyleBackColor = true;

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "服务器密码";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(96, 112);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(119, 21);
            this.tbPassword.TabIndex = 1;
            // 
            // ivPassword
            // 
            this.ivPassword.Location = new System.Drawing.Point(221, 115);
            this.ivPassword.Name = "ivPassword";
            this.ivPassword.Size = new System.Drawing.Size(16, 16);
            this.ivPassword.TabIndex = 6;
            // 
            // rblpush
            // 
            this.rblpush.AutoSize = true;
            this.rblpush.Location = new System.Drawing.Point(243, 14);
            this.rblpush.Name = "rblpush";
            this.rblpush.Size = new System.Drawing.Size(53, 16);
            this.rblpush.TabIndex = 5;
            this.rblpush.TabStop = true;
            this.rblpush.Text = "lpush";
            this.rblpush.UseVisualStyleBackColor = true;
            
            // 
            // rbrpush
            // 
            this.rbrpush.AutoSize = true;
            this.rbrpush.Location = new System.Drawing.Point(329, 14);
            this.rbrpush.Name = "rbrpush";
            this.rbrpush.Size = new System.Drawing.Size(53, 16);
            this.rbrpush.TabIndex = 5;
            this.rbrpush.TabStop = true;
            this.rbrpush.Text = "rpush";
            this.rbrpush.UseVisualStyleBackColor = true;

            // 
            // rblpop
            // 
            this.rblpop.AutoSize = true;
            this.rblpop.Location = new System.Drawing.Point(96, 41);
            this.rblpop.Name = "rblpop";
            this.rblpop.Size = new System.Drawing.Size(47, 16);
            this.rblpop.TabIndex = 5;
            this.rblpop.TabStop = true;
            this.rblpop.Text = "lpop";
            this.rblpop.UseVisualStyleBackColor = true;

            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "数据库";
            // 
            // ivDatabase
            // 
            this.ivDatabase.Location = new System.Drawing.Point(474, 117);
            this.ivDatabase.Name = "ivDatabase";
            this.ivDatabase.Size = new System.Drawing.Size(16, 16);
            this.ivDatabase.TabIndex = 6;
            // 
            // ivKey
            // 
            this.ivKey.Location = new System.Drawing.Point(221, 154);
            this.ivKey.Name = "ivKey";
            this.ivKey.Size = new System.Drawing.Size(16, 16);
            this.ivKey.TabIndex = 6;
            // 
            // rbrpop
            // 
            this.rbrpop.AutoSize = true;
            this.rbrpop.Location = new System.Drawing.Point(170, 41);
            this.rbrpop.Name = "rbrpop";
            this.rbrpop.Size = new System.Drawing.Size(47, 16);
            this.rbrpop.TabIndex = 5;
            this.rbrpop.TabStop = true;
            this.rbrpop.Text = "rpop";
            this.rbrpop.UseVisualStyleBackColor = true;

            // 
            // tbDataBase
            // 
            this.tbDataBase.Location = new System.Drawing.Point(329, 114);
            this.tbDataBase.Name = "tbDataBase";
            this.tbDataBase.Size = new System.Drawing.Size(136, 21);
            this.tbDataBase.TabIndex = 1;
            // 
            // rbsadd
            // 
            this.rbsadd.AutoSize = true;
            this.rbsadd.Location = new System.Drawing.Point(243, 42);
            this.rbsadd.Name = "rbsadd";
            this.rbsadd.Size = new System.Drawing.Size(47, 16);
            this.rbsadd.TabIndex = 7;
            this.rbsadd.TabStop = true;
            this.rbsadd.Text = "sadd";
            this.rbsadd.UseVisualStyleBackColor = true;
            // 
            // rbsismember
            // 
            this.rbsismember.AutoSize = true;
            this.rbsismember.Location = new System.Drawing.Point(329, 42);
            this.rbsismember.Name = "rbsismember";
            this.rbsismember.Size = new System.Drawing.Size(77, 16);
            this.rbsismember.TabIndex = 7;
            this.rbsismember.TabStop = true;
            this.rbsismember.Text = "sismember";
            this.rbsismember.UseVisualStyleBackColor = true;
            // 
            // svOptResult
            // 
            this.svOptResult.Location = new System.Drawing.Point(96, 191);
            this.svOptResult.Name = "svOptResult";
            this.svOptResult.Size = new System.Drawing.Size(141, 23);
            this.svOptResult.TabIndex = 9;
            this.svOptResult.VarName = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "操作结果";
            // 
            // RedisUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RedisUI";
            this.scActivityUI.Panel1.ResumeLayout(false);
            this.scActivityUI.Panel1.PerformLayout();
            this.scActivityUI.Panel2.ResumeLayout(false);
            this.scActivityUI.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scActivityUI)).EndInit();
            this.scActivityUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private litsdk.InsertVarName ivHost;
        private System.Windows.Forms.TextBox tbHost;
        private litsdk.SelectVarName svValueVarName;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbset;
        private litsdk.InsertVarName ivPassword;
        private System.Windows.Forms.RadioButton rbget;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label6;
        private litsdk.InsertVarName ivDatabase;
        private litsdk.InsertVarName ivKey;
        private System.Windows.Forms.RadioButton rblpop;
        private System.Windows.Forms.RadioButton rbrpush;
        private System.Windows.Forms.RadioButton rblpush;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbrpop;
        private System.Windows.Forms.TextBox tbDataBase;
        private System.Windows.Forms.RadioButton rbsismember;
        private System.Windows.Forms.RadioButton rbsadd;
        private litsdk.SelectVarName svOptResult;
        private System.Windows.Forms.Label label7;
    }
}
