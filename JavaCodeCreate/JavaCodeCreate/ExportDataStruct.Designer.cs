namespace JavaCodeCreate
{
    partial class ExportDataStruct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcDataBase = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExportSqlserver = new System.Windows.Forms.Button();
            this.cbx_sqlserver_database = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_sqlserver_remenber = new System.Windows.Forms.CheckBox();
            this.txt_sqlserver_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sqlserver_account = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_sqlserver_account = new System.Windows.Forms.RadioButton();
            this.rbtn_sqlserver_local = new System.Windows.Forms.RadioButton();
            this.cbx_sqlserver_server = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_mysql_export = new System.Windows.Forms.Button();
            this.cbx_mysql_database = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_mysql_remenber = new System.Windows.Forms.CheckBox();
            this.txt_mysql_pwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mysql_account = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_mysql_server = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mysql_port = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbcDataBase.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcDataBase
            // 
            this.tbcDataBase.Controls.Add(this.tabPage1);
            this.tbcDataBase.Controls.Add(this.tabPage2);
            this.tbcDataBase.Controls.Add(this.tabPage3);
            this.tbcDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcDataBase.Location = new System.Drawing.Point(0, 0);
            this.tbcDataBase.Name = "tbcDataBase";
            this.tbcDataBase.SelectedIndex = 0;
            this.tbcDataBase.Size = new System.Drawing.Size(591, 406);
            this.tbcDataBase.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExportSqlserver);
            this.tabPage1.Controls.Add(this.cbx_sqlserver_database);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbx_sqlserver_remenber);
            this.tabPage1.Controls.Add(this.txt_sqlserver_pwd);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_sqlserver_account);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rbtn_sqlserver_account);
            this.tabPage1.Controls.Add(this.rbtn_sqlserver_local);
            this.tabPage1.Controls.Add(this.cbx_sqlserver_server);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sql Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnExportSqlserver
            // 
            this.btnExportSqlserver.Location = new System.Drawing.Point(184, 283);
            this.btnExportSqlserver.Name = "btnExportSqlserver";
            this.btnExportSqlserver.Size = new System.Drawing.Size(126, 36);
            this.btnExportSqlserver.TabIndex = 11;
            this.btnExportSqlserver.Text = "导出数据结构";
            this.btnExportSqlserver.UseVisualStyleBackColor = true;
            this.btnExportSqlserver.Click += new System.EventHandler(this.btnExportSqlserver_Click);
            // 
            // cbx_sqlserver_database
            // 
            this.cbx_sqlserver_database.FormattingEnabled = true;
            this.cbx_sqlserver_database.Location = new System.Drawing.Point(113, 222);
            this.cbx_sqlserver_database.Name = "cbx_sqlserver_database";
            this.cbx_sqlserver_database.Size = new System.Drawing.Size(364, 20);
            this.cbx_sqlserver_database.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "数据库";
            // 
            // cbx_sqlserver_remenber
            // 
            this.cbx_sqlserver_remenber.AutoSize = true;
            this.cbx_sqlserver_remenber.Location = new System.Drawing.Point(115, 188);
            this.cbx_sqlserver_remenber.Name = "cbx_sqlserver_remenber";
            this.cbx_sqlserver_remenber.Size = new System.Drawing.Size(72, 16);
            this.cbx_sqlserver_remenber.TabIndex = 8;
            this.cbx_sqlserver_remenber.Text = "记住密码";
            this.cbx_sqlserver_remenber.UseVisualStyleBackColor = true;
            // 
            // txt_sqlserver_pwd
            // 
            this.txt_sqlserver_pwd.Location = new System.Drawing.Point(184, 154);
            this.txt_sqlserver_pwd.Name = "txt_sqlserver_pwd";
            this.txt_sqlserver_pwd.Size = new System.Drawing.Size(293, 21);
            this.txt_sqlserver_pwd.TabIndex = 7;
            this.txt_sqlserver_pwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "密码";
            // 
            // txt_sqlserver_account
            // 
            this.txt_sqlserver_account.Location = new System.Drawing.Point(184, 127);
            this.txt_sqlserver_account.Name = "txt_sqlserver_account";
            this.txt_sqlserver_account.Size = new System.Drawing.Size(293, 21);
            this.txt_sqlserver_account.TabIndex = 5;
            this.txt_sqlserver_account.TextChanged += new System.EventHandler(this.txtAccount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "账号";
            // 
            // rbtn_sqlserver_account
            // 
            this.rbtn_sqlserver_account.AutoSize = true;
            this.rbtn_sqlserver_account.Location = new System.Drawing.Point(113, 94);
            this.rbtn_sqlserver_account.Name = "rbtn_sqlserver_account";
            this.rbtn_sqlserver_account.Size = new System.Drawing.Size(95, 16);
            this.rbtn_sqlserver_account.TabIndex = 3;
            this.rbtn_sqlserver_account.Text = "账户密码验证";
            this.rbtn_sqlserver_account.UseVisualStyleBackColor = true;
            // 
            // rbtn_sqlserver_local
            // 
            this.rbtn_sqlserver_local.AutoSize = true;
            this.rbtn_sqlserver_local.Checked = true;
            this.rbtn_sqlserver_local.Location = new System.Drawing.Point(113, 71);
            this.rbtn_sqlserver_local.Name = "rbtn_sqlserver_local";
            this.rbtn_sqlserver_local.Size = new System.Drawing.Size(71, 16);
            this.rbtn_sqlserver_local.TabIndex = 2;
            this.rbtn_sqlserver_local.TabStop = true;
            this.rbtn_sqlserver_local.Text = "本地验证";
            this.rbtn_sqlserver_local.UseVisualStyleBackColor = true;
            this.rbtn_sqlserver_local.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cbx_sqlserver_server
            // 
            this.cbx_sqlserver_server.FormattingEnabled = true;
            this.cbx_sqlserver_server.Location = new System.Drawing.Point(113, 34);
            this.cbx_sqlserver_server.Name = "cbx_sqlserver_server";
            this.cbx_sqlserver_server.Size = new System.Drawing.Size(364, 20);
            this.cbx_sqlserver_server.TabIndex = 1;
            this.cbx_sqlserver_server.SelectedIndexChanged += new System.EventHandler(this.cbxServer_SelectedIndexChanged);
            this.cbx_sqlserver_server.TextChanged += new System.EventHandler(this.cbxServer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt_mysql_port);
            this.tabPage2.Controls.Add(this.btn_mysql_export);
            this.tabPage2.Controls.Add(this.cbx_mysql_database);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbx_mysql_remenber);
            this.tabPage2.Controls.Add(this.txt_mysql_pwd);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_mysql_account);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbx_mysql_server);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MySql";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(583, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Oracle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_mysql_export
            // 
            this.btn_mysql_export.Location = new System.Drawing.Point(220, 244);
            this.btn_mysql_export.Name = "btn_mysql_export";
            this.btn_mysql_export.Size = new System.Drawing.Size(126, 36);
            this.btn_mysql_export.TabIndex = 23;
            this.btn_mysql_export.Text = "导出数据结构";
            this.btn_mysql_export.UseVisualStyleBackColor = true;
            this.btn_mysql_export.Click += new System.EventHandler(this.btn_mysql_export_Click);
            // 
            // cbx_mysql_database
            // 
            this.cbx_mysql_database.FormattingEnabled = true;
            this.cbx_mysql_database.Location = new System.Drawing.Point(140, 186);
            this.cbx_mysql_database.Name = "cbx_mysql_database";
            this.cbx_mysql_database.Size = new System.Drawing.Size(364, 20);
            this.cbx_mysql_database.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "数据库";
            // 
            // cbx_mysql_remenber
            // 
            this.cbx_mysql_remenber.AutoSize = true;
            this.cbx_mysql_remenber.Location = new System.Drawing.Point(142, 152);
            this.cbx_mysql_remenber.Name = "cbx_mysql_remenber";
            this.cbx_mysql_remenber.Size = new System.Drawing.Size(72, 16);
            this.cbx_mysql_remenber.TabIndex = 20;
            this.cbx_mysql_remenber.Text = "记住密码";
            this.cbx_mysql_remenber.UseVisualStyleBackColor = true;
            // 
            // txt_mysql_pwd
            // 
            this.txt_mysql_pwd.Location = new System.Drawing.Point(140, 114);
            this.txt_mysql_pwd.Name = "txt_mysql_pwd";
            this.txt_mysql_pwd.Size = new System.Drawing.Size(364, 21);
            this.txt_mysql_pwd.TabIndex = 19;
            this.txt_mysql_pwd.Text = "123456";
            this.txt_mysql_pwd.TextChanged += new System.EventHandler(this.txt_mysql_pwd_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "密码";
            // 
            // txt_mysql_account
            // 
            this.txt_mysql_account.Location = new System.Drawing.Point(140, 87);
            this.txt_mysql_account.Name = "txt_mysql_account";
            this.txt_mysql_account.Size = new System.Drawing.Size(364, 21);
            this.txt_mysql_account.TabIndex = 17;
            this.txt_mysql_account.Text = "root";
            this.txt_mysql_account.TextChanged += new System.EventHandler(this.txt_mysql_account_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "账号";
            // 
            // cbx_mysql_server
            // 
            this.cbx_mysql_server.FormattingEnabled = true;
            this.cbx_mysql_server.Location = new System.Drawing.Point(140, 48);
            this.cbx_mysql_server.Name = "cbx_mysql_server";
            this.cbx_mysql_server.Size = new System.Drawing.Size(184, 20);
            this.cbx_mysql_server.TabIndex = 13;
            this.cbx_mysql_server.Text = "127.0.0.1";
            this.cbx_mysql_server.SelectedIndexChanged += new System.EventHandler(this.cbx_mysql_server_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "服务器";
            // 
            // txt_mysql_port
            // 
            this.txt_mysql_port.Location = new System.Drawing.Point(399, 48);
            this.txt_mysql_port.Name = "txt_mysql_port";
            this.txt_mysql_port.Size = new System.Drawing.Size(105, 21);
            this.txt_mysql_port.TabIndex = 24;
            this.txt_mysql_port.Text = "3306";
            this.txt_mysql_port.TextChanged += new System.EventHandler(this.txt_mysql_port_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "端口";
            // 
            // ExportDataStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 406);
            this.Controls.Add(this.tbcDataBase);
            this.Name = "ExportDataStruct";
            this.Text = "导出数据结构";
            this.Load += new System.EventHandler(this.ExportDataStruct_Load);
            this.tbcDataBase.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDataBase;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbtn_sqlserver_account;
        private System.Windows.Forms.RadioButton rbtn_sqlserver_local;
        private System.Windows.Forms.ComboBox cbx_sqlserver_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExportSqlserver;
        private System.Windows.Forms.ComboBox cbx_sqlserver_database;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbx_sqlserver_remenber;
        private System.Windows.Forms.TextBox txt_sqlserver_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sqlserver_account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mysql_port;
        private System.Windows.Forms.Button btn_mysql_export;
        private System.Windows.Forms.ComboBox cbx_mysql_database;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbx_mysql_remenber;
        private System.Windows.Forms.TextBox txt_mysql_pwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mysql_account;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_mysql_server;
        private System.Windows.Forms.Label label8;
    }
}