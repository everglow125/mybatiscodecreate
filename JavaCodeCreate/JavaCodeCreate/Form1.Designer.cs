namespace JavaCodeCreate
{
    partial class MyBatis
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBatis));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbxDbName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServiceAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbxTables = new System.Windows.Forms.ListBox();
            this.rtxtTablesMap = new System.Windows.Forms.RichTextBox();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModelFile = new System.Windows.Forms.Button();
            this.txtModelPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelPg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMappingFile = new System.Windows.Forms.Button();
            this.txtMapPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMapPg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDaoFile = new System.Windows.Forms.Button();
            this.txtDaoPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDaoPg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnJarFile = new System.Windows.Forms.Button();
            this.txtJarPath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTmpPath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTmpPg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxTmp = new System.Windows.Forms.CheckBox();
            this.btnSaveCfg = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtXMLPath = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库类型";
            // 
            // cbxDbType
            // 
            this.cbxDbType.FormattingEnabled = true;
            this.cbxDbType.Location = new System.Drawing.Point(83, 19);
            this.cbxDbType.Name = "cbxDbType";
            this.cbxDbType.Size = new System.Drawing.Size(121, 20);
            this.cbxDbType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "账号";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(268, 18);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(166, 21);
            this.txtAccount.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(478, 18);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 21);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(660, 15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(123, 27);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "连接服务器";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbxDbName
            // 
            this.cbxDbName.FormattingEnabled = true;
            this.cbxDbName.Location = new System.Drawing.Point(445, 59);
            this.cbxDbName.Name = "cbxDbName";
            this.cbxDbName.Size = new System.Drawing.Size(209, 20);
            this.cbxDbName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据库";
            // 
            // txtServiceAddress
            // 
            this.txtServiceAddress.Location = new System.Drawing.Point(83, 54);
            this.txtServiceAddress.Name = "txtServiceAddress";
            this.txtServiceAddress.Size = new System.Drawing.Size(285, 21);
            this.txtServiceAddress.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "服务器地址";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(660, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 27);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "表查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbxTables
            // 
            this.lbxTables.FormattingEnabled = true;
            this.lbxTables.HorizontalScrollbar = true;
            this.lbxTables.ItemHeight = 12;
            this.lbxTables.Location = new System.Drawing.Point(12, 90);
            this.lbxTables.Name = "lbxTables";
            this.lbxTables.Size = new System.Drawing.Size(239, 268);
            this.lbxTables.TabIndex = 12;
            // 
            // rtxtTablesMap
            // 
            this.rtxtTablesMap.Location = new System.Drawing.Point(372, 90);
            this.rtxtTablesMap.Name = "rtxtTablesMap";
            this.rtxtTablesMap.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtxtTablesMap.Size = new System.Drawing.Size(411, 268);
            this.rtxtTablesMap.TabIndex = 13;
            this.rtxtTablesMap.Text = "";
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(268, 201);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddTable.TabIndex = 14;
            this.btnAddTable.Text = "=>";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModelFile);
            this.groupBox1.Controls.Add(this.txtModelPath);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtModelPg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(14, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 57);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // btnModelFile
            // 
            this.btnModelFile.Location = new System.Drawing.Point(663, 17);
            this.btnModelFile.Name = "btnModelFile";
            this.btnModelFile.Size = new System.Drawing.Size(103, 27);
            this.btnModelFile.TabIndex = 11;
            this.btnModelFile.Text = "选择路径";
            this.btnModelFile.UseVisualStyleBackColor = true;
            this.btnModelFile.Click += new System.EventHandler(this.btnModelFile_Click);
            // 
            // txtModelPath
            // 
            this.txtModelPath.Location = new System.Drawing.Point(345, 20);
            this.txtModelPath.Name = "txtModelPath";
            this.txtModelPath.Size = new System.Drawing.Size(295, 21);
            this.txtModelPath.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "FilePath";
            // 
            // txtModelPg
            // 
            this.txtModelPg.Location = new System.Drawing.Point(62, 20);
            this.txtModelPg.Name = "txtModelPg";
            this.txtModelPg.Size = new System.Drawing.Size(206, 21);
            this.txtModelPg.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Package";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMappingFile);
            this.groupBox2.Controls.Add(this.txtMapPath);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMapPg);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(13, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 57);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mapping";
            // 
            // btnMappingFile
            // 
            this.btnMappingFile.Location = new System.Drawing.Point(663, 17);
            this.btnMappingFile.Name = "btnMappingFile";
            this.btnMappingFile.Size = new System.Drawing.Size(103, 27);
            this.btnMappingFile.TabIndex = 11;
            this.btnMappingFile.Text = "选择路径";
            this.btnMappingFile.UseVisualStyleBackColor = true;
            this.btnMappingFile.Click += new System.EventHandler(this.btnMappingFile_Click);
            // 
            // txtMapPath
            // 
            this.txtMapPath.Location = new System.Drawing.Point(345, 20);
            this.txtMapPath.Name = "txtMapPath";
            this.txtMapPath.Size = new System.Drawing.Size(295, 21);
            this.txtMapPath.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "FilePath";
            // 
            // txtMapPg
            // 
            this.txtMapPg.Location = new System.Drawing.Point(62, 20);
            this.txtMapPg.Name = "txtMapPg";
            this.txtMapPg.Size = new System.Drawing.Size(206, 21);
            this.txtMapPg.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "Package";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDaoFile);
            this.groupBox3.Controls.Add(this.txtDaoPath);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtDaoPg);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(13, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 57);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dao";
            // 
            // btnDaoFile
            // 
            this.btnDaoFile.Location = new System.Drawing.Point(663, 17);
            this.btnDaoFile.Name = "btnDaoFile";
            this.btnDaoFile.Size = new System.Drawing.Size(103, 27);
            this.btnDaoFile.TabIndex = 11;
            this.btnDaoFile.Text = "选择路径";
            this.btnDaoFile.UseVisualStyleBackColor = true;
            this.btnDaoFile.Click += new System.EventHandler(this.btnDaoFile_Click);
            // 
            // txtDaoPath
            // 
            this.txtDaoPath.Location = new System.Drawing.Point(345, 20);
            this.txtDaoPath.Name = "txtDaoPath";
            this.txtDaoPath.Size = new System.Drawing.Size(295, 21);
            this.txtDaoPath.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "FilePath";
            // 
            // txtDaoPg
            // 
            this.txtDaoPg.Location = new System.Drawing.Point(62, 20);
            this.txtDaoPg.Name = "txtDaoPg";
            this.txtDaoPg.Size = new System.Drawing.Size(206, 21);
            this.txtDaoPg.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "Package";
            // 
            // btnJarFile
            // 
            this.btnJarFile.Location = new System.Drawing.Point(677, 539);
            this.btnJarFile.Name = "btnJarFile";
            this.btnJarFile.Size = new System.Drawing.Size(103, 27);
            this.btnJarFile.TabIndex = 20;
            this.btnJarFile.Text = "选择路径";
            this.btnJarFile.UseVisualStyleBackColor = true;
            this.btnJarFile.Click += new System.EventHandler(this.btnJarFile_Click);
            // 
            // txtJarPath
            // 
            this.txtJarPath.Location = new System.Drawing.Point(110, 543);
            this.txtJarPath.Name = "txtJarPath";
            this.txtJarPath.Size = new System.Drawing.Size(544, 21);
            this.txtJarPath.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 547);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "数据库连接Jar包";
            // 
            // txtTmpPath
            // 
            this.txtTmpPath.Location = new System.Drawing.Point(349, 579);
            this.txtTmpPath.Name = "txtTmpPath";
            this.txtTmpPath.Size = new System.Drawing.Size(305, 21);
            this.txtTmpPath.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 583);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "FilePath";
            // 
            // txtTmpPg
            // 
            this.txtTmpPg.Location = new System.Drawing.Point(66, 579);
            this.txtTmpPg.Name = "txtTmpPg";
            this.txtTmpPg.Size = new System.Drawing.Size(206, 21);
            this.txtTmpPg.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 583);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "Package";
            // 
            // cbxTmp
            // 
            this.cbxTmp.AutoSize = true;
            this.cbxTmp.Location = new System.Drawing.Point(676, 583);
            this.cbxTmp.Name = "cbxTmp";
            this.cbxTmp.Size = new System.Drawing.Size(96, 16);
            this.cbxTmp.TabIndex = 25;
            this.cbxTmp.Text = "约定优先原则";
            this.cbxTmp.UseVisualStyleBackColor = true;
            // 
            // btnSaveCfg
            // 
            this.btnSaveCfg.Location = new System.Drawing.Point(549, 615);
            this.btnSaveCfg.Name = "btnSaveCfg";
            this.btnSaveCfg.Size = new System.Drawing.Size(103, 27);
            this.btnSaveCfg.TabIndex = 26;
            this.btnSaveCfg.Text = "保存当前配置";
            this.btnSaveCfg.UseVisualStyleBackColor = true;
            this.btnSaveCfg.Click += new System.EventHandler(this.btnSaveCfg_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(676, 615);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(103, 27);
            this.btnCreateFile.TabIndex = 27;
            this.btnCreateFile.Text = "生成实体文件";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 30;
            this.button1.Text = "选择路径";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtXMLPath
            // 
            this.txtXMLPath.Location = new System.Drawing.Point(66, 619);
            this.txtXMLPath.Name = "txtXMLPath";
            this.txtXMLPath.Size = new System.Drawing.Size(323, 21);
            this.txtXMLPath.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 619);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "XML地址";
            // 
            // MyBatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtXMLPath);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnSaveCfg);
            this.Controls.Add(this.cbxTmp);
            this.Controls.Add(this.txtTmpPath);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTmpPg);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnJarFile);
            this.Controls.Add(this.txtJarPath);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.rtxtTablesMap);
            this.Controls.Add(this.lbxTables);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtServiceAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxDbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDbType);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBatis";
            this.Text = "MyBatis代码生成";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbxDbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServiceAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbxTables;
        private System.Windows.Forms.RichTextBox rtxtTablesMap;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModelFile;
        private System.Windows.Forms.TextBox txtModelPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelPg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMappingFile;
        private System.Windows.Forms.TextBox txtMapPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMapPg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDaoFile;
        private System.Windows.Forms.TextBox txtDaoPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDaoPg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnJarFile;
        private System.Windows.Forms.TextBox txtJarPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTmpPath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTmpPg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbxTmp;
        private System.Windows.Forms.Button btnSaveCfg;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtXMLPath;
        private System.Windows.Forms.Label label15;
    }
}

