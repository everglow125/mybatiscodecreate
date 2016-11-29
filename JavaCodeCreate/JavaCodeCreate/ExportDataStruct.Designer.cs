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
            this.cbxDataBase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRemenber = new System.Windows.Forms.CheckBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnAccount = new System.Windows.Forms.RadioButton();
            this.rbtnLoacl = new System.Windows.Forms.RadioButton();
            this.cbxServer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbcDataBase.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.cbxDataBase);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbxRemenber);
            this.tabPage1.Controls.Add(this.txtPwd);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtAccount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rbtnAccount);
            this.tabPage1.Controls.Add(this.rbtnLoacl);
            this.tabPage1.Controls.Add(this.cbxServer);
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
            // cbxDataBase
            // 
            this.cbxDataBase.FormattingEnabled = true;
            this.cbxDataBase.Location = new System.Drawing.Point(113, 222);
            this.cbxDataBase.Name = "cbxDataBase";
            this.cbxDataBase.Size = new System.Drawing.Size(364, 20);
            this.cbxDataBase.TabIndex = 10;
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
            // cbxRemenber
            // 
            this.cbxRemenber.AutoSize = true;
            this.cbxRemenber.Location = new System.Drawing.Point(115, 188);
            this.cbxRemenber.Name = "cbxRemenber";
            this.cbxRemenber.Size = new System.Drawing.Size(72, 16);
            this.cbxRemenber.TabIndex = 8;
            this.cbxRemenber.Text = "记住密码";
            this.cbxRemenber.UseVisualStyleBackColor = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(184, 154);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(293, 21);
            this.txtPwd.TabIndex = 7;
            this.txtPwd.TextChanged += new System.EventHandler(this.txtPwd_TextChanged);
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
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(184, 127);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(293, 21);
            this.txtAccount.TabIndex = 5;
            this.txtAccount.TextChanged += new System.EventHandler(this.txtAccount_TextChanged);
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
            // rbtnAccount
            // 
            this.rbtnAccount.AutoSize = true;
            this.rbtnAccount.Location = new System.Drawing.Point(113, 94);
            this.rbtnAccount.Name = "rbtnAccount";
            this.rbtnAccount.Size = new System.Drawing.Size(95, 16);
            this.rbtnAccount.TabIndex = 3;
            this.rbtnAccount.Text = "账户密码验证";
            this.rbtnAccount.UseVisualStyleBackColor = true;
            // 
            // rbtnLoacl
            // 
            this.rbtnLoacl.AutoSize = true;
            this.rbtnLoacl.Checked = true;
            this.rbtnLoacl.Location = new System.Drawing.Point(113, 71);
            this.rbtnLoacl.Name = "rbtnLoacl";
            this.rbtnLoacl.Size = new System.Drawing.Size(71, 16);
            this.rbtnLoacl.TabIndex = 2;
            this.rbtnLoacl.TabStop = true;
            this.rbtnLoacl.Text = "本地验证";
            this.rbtnLoacl.UseVisualStyleBackColor = true;
            this.rbtnLoacl.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cbxServer
            // 
            this.cbxServer.FormattingEnabled = true;
            this.cbxServer.Location = new System.Drawing.Point(113, 34);
            this.cbxServer.Name = "cbxServer";
            this.cbxServer.Size = new System.Drawing.Size(364, 20);
            this.cbxServer.TabIndex = 1;
            this.cbxServer.SelectedIndexChanged += new System.EventHandler(this.cbxServer_SelectedIndexChanged);
            this.cbxServer.TextChanged += new System.EventHandler(this.cbxServer_TextChanged);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDataBase;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbtnAccount;
        private System.Windows.Forms.RadioButton rbtnLoacl;
        private System.Windows.Forms.ComboBox cbxServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExportSqlserver;
        private System.Windows.Forms.ComboBox cbxDataBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxRemenber;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label2;
    }
}