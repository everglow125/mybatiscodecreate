namespace JavaCodeCreate
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImportConfig = new System.Windows.Forms.Button();
            this.btnSelectConfig = new System.Windows.Forms.Button();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSearchTable = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDbName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnectDb = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSaveConfigName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.txtSaveConfigPath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCreateGenerator = new System.Windows.Forms.Button();
            this.btnExcuteCmd = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelectGeneratorJar = new System.Windows.Forms.Button();
            this.txtGeneratorJar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSelectSqlJar = new System.Windows.Forms.Button();
            this.txtMapping = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSqlJar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOutputpath = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rtxtTablesMap = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnClearnAllTable = new System.Windows.Forms.Button();
            this.btnAddAllTable = new System.Windows.Forms.Button();
            this.btnAddSelectedTable = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbxTables = new System.Windows.Forms.ListBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImportConfig);
            this.groupBox1.Controls.Add(this.btnSelectConfig);
            this.groupBox1.Controls.Add(this.txtConfig);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导入配置";
            // 
            // btnImportConfig
            // 
            this.btnImportConfig.Location = new System.Drawing.Point(942, 18);
            this.btnImportConfig.Name = "btnImportConfig";
            this.btnImportConfig.Size = new System.Drawing.Size(126, 26);
            this.btnImportConfig.TabIndex = 3;
            this.btnImportConfig.Text = "导入配置";
            this.btnImportConfig.UseVisualStyleBackColor = true;
            this.btnImportConfig.Click += new System.EventHandler(this.btnImportConfig_Click);
            // 
            // btnSelectConfig
            // 
            this.btnSelectConfig.Location = new System.Drawing.Point(758, 19);
            this.btnSelectConfig.Name = "btnSelectConfig";
            this.btnSelectConfig.Size = new System.Drawing.Size(126, 26);
            this.btnSelectConfig.TabIndex = 2;
            this.btnSelectConfig.Text = "选择文件";
            this.btnSelectConfig.UseVisualStyleBackColor = true;
            this.btnSelectConfig.Click += new System.EventHandler(this.btnSelectConfig_Click);
            // 
            // txtConfig
            // 
            this.txtConfig.Location = new System.Drawing.Point(123, 23);
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.Size = new System.Drawing.Size(589, 21);
            this.txtConfig.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "配置文件地址：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btnSearchTable);
            this.groupBox2.Controls.Add(this.txtService);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxDbName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnConnectDb);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAccount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbxDbType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1109, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据库配置";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(750, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(130, 21);
            this.txtPort.TabIndex = 46;
            this.txtPort.Text = "3306";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(696, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 45;
            this.label16.Text = "端口号：";
            // 
            // btnSearchTable
            // 
            this.btnSearchTable.Location = new System.Drawing.Point(942, 55);
            this.btnSearchTable.Name = "btnSearchTable";
            this.btnSearchTable.Size = new System.Drawing.Size(126, 27);
            this.btnSearchTable.TabIndex = 44;
            this.btnSearchTable.Text = "表查询";
            this.btnSearchTable.UseVisualStyleBackColor = true;
            this.btnSearchTable.Click += new System.EventHandler(this.btnSearchTable_Click);
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(412, 22);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(248, 21);
            this.txtService.TabIndex = 43;
            this.txtService.Text = "localhost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 42;
            this.label5.Text = "服务器地址：";
            // 
            // cbxDbName
            // 
            this.cbxDbName.FormattingEnabled = true;
            this.cbxDbName.Location = new System.Drawing.Point(675, 56);
            this.cbxDbName.Name = "cbxDbName";
            this.cbxDbName.Size = new System.Drawing.Size(209, 20);
            this.cbxDbName.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "数据库名称：";
            // 
            // btnConnectDb
            // 
            this.btnConnectDb.Location = new System.Drawing.Point(942, 16);
            this.btnConnectDb.Name = "btnConnectDb";
            this.btnConnectDb.Size = new System.Drawing.Size(126, 29);
            this.btnConnectDb.TabIndex = 39;
            this.btnConnectDb.Text = "连接服务器";
            this.btnConnectDb.UseVisualStyleBackColor = true;
            this.btnConnectDb.Click += new System.EventHandler(this.btnConnectDb_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(412, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 21);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.Text = "123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "登录密码：";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(123, 55);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(166, 21);
            this.txtAccount.TabIndex = 36;
            this.txtAccount.Text = "root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "登录账号：";
            // 
            // cbxDbType
            // 
            this.cbxDbType.FormattingEnabled = true;
            this.cbxDbType.Location = new System.Drawing.Point(123, 22);
            this.cbxDbType.Name = "cbxDbType";
            this.cbxDbType.Size = new System.Drawing.Size(166, 20);
            this.cbxDbType.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "数据库类型：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSaveConfigName);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btnSavePath);
            this.groupBox3.Controls.Add(this.txtSaveConfigPath);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnCreateGenerator);
            this.groupBox3.Controls.Add(this.btnExcuteCmd);
            this.groupBox3.Controls.Add(this.btnSaveConfig);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 680);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1109, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // txtSaveConfigName
            // 
            this.txtSaveConfigName.Location = new System.Drawing.Point(556, 20);
            this.txtSaveConfigName.Name = "txtSaveConfigName";
            this.txtSaveConfigName.Size = new System.Drawing.Size(104, 21);
            this.txtSaveConfigName.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(499, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 42;
            this.label15.Text = "文件名：";
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(403, 16);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(84, 27);
            this.btnSavePath.TabIndex = 41;
            this.btnSavePath.Text = "选择路径";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // txtSaveConfigPath
            // 
            this.txtSaveConfigPath.Location = new System.Drawing.Point(73, 20);
            this.txtSaveConfigPath.Name = "txtSaveConfigPath";
            this.txtSaveConfigPath.Size = new System.Drawing.Size(318, 21);
            this.txtSaveConfigPath.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 39;
            this.label14.Text = "保存地址：";
            // 
            // btnCreateGenerator
            // 
            this.btnCreateGenerator.Location = new System.Drawing.Point(777, 17);
            this.btnCreateGenerator.Name = "btnCreateGenerator";
            this.btnCreateGenerator.Size = new System.Drawing.Size(158, 27);
            this.btnCreateGenerator.TabIndex = 38;
            this.btnCreateGenerator.Text = "生成Generator.xml";
            this.btnCreateGenerator.UseVisualStyleBackColor = true;
            this.btnCreateGenerator.Click += new System.EventHandler(this.btnCreateGenerator_Click);
            // 
            // btnExcuteCmd
            // 
            this.btnExcuteCmd.Location = new System.Drawing.Point(941, 16);
            this.btnExcuteCmd.Name = "btnExcuteCmd";
            this.btnExcuteCmd.Size = new System.Drawing.Size(146, 27);
            this.btnExcuteCmd.TabIndex = 37;
            this.btnExcuteCmd.Text = "执行CMD生成代码";
            this.btnExcuteCmd.UseVisualStyleBackColor = true;
            this.btnExcuteCmd.Click += new System.EventHandler(this.btnExcuteCmd_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(668, 17);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(103, 27);
            this.btnSaveConfig.TabIndex = 36;
            this.btnSaveConfig.Text = "保存当前配置";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSelectGeneratorJar);
            this.groupBox4.Controls.Add(this.txtGeneratorJar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnSelectSqlJar);
            this.groupBox4.Controls.Add(this.txtMapping);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtModel);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtDao);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtSqlJar);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnOutputpath);
            this.groupBox4.Controls.Add(this.txtOutputPath);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtPackage);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 525);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1109, 155);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "输出配置";
            // 
            // btnSelectGeneratorJar
            // 
            this.btnSelectGeneratorJar.Location = new System.Drawing.Point(941, 119);
            this.btnSelectGeneratorJar.Name = "btnSelectGeneratorJar";
            this.btnSelectGeneratorJar.Size = new System.Drawing.Size(126, 27);
            this.btnSelectGeneratorJar.TabIndex = 48;
            this.btnSelectGeneratorJar.Text = "选择文件";
            this.btnSelectGeneratorJar.UseVisualStyleBackColor = true;
            this.btnSelectGeneratorJar.Click += new System.EventHandler(this.btnSelectGeneratorJar_Click);
            // 
            // txtGeneratorJar
            // 
            this.txtGeneratorJar.Location = new System.Drawing.Point(97, 123);
            this.txtGeneratorJar.Name = "txtGeneratorJar";
            this.txtGeneratorJar.Size = new System.Drawing.Size(803, 21);
            this.txtGeneratorJar.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 46;
            this.label13.Text = "GeneratorJAR：";
            // 
            // btnSelectSqlJar
            // 
            this.btnSelectSqlJar.Location = new System.Drawing.Point(942, 84);
            this.btnSelectSqlJar.Name = "btnSelectSqlJar";
            this.btnSelectSqlJar.Size = new System.Drawing.Size(126, 27);
            this.btnSelectSqlJar.TabIndex = 45;
            this.btnSelectSqlJar.Text = "选择文件";
            this.btnSelectSqlJar.UseVisualStyleBackColor = true;
            this.btnSelectSqlJar.Click += new System.EventHandler(this.btnSelectSqlJar_Click);
            // 
            // txtMapping
            // 
            this.txtMapping.Location = new System.Drawing.Point(735, 53);
            this.txtMapping.Name = "txtMapping";
            this.txtMapping.Size = new System.Drawing.Size(166, 21);
            this.txtMapping.TabIndex = 44;
            this.txtMapping.Text = "mapping";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(650, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 43;
            this.label12.Text = "Mapping包名：";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(403, 53);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(166, 21);
            this.txtModel.TabIndex = 42;
            this.txtModel.Text = "model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 41;
            this.label9.Text = "Model包名：";
            // 
            // txtDao
            // 
            this.txtDao.Location = new System.Drawing.Point(98, 52);
            this.txtDao.Name = "txtDao";
            this.txtDao.Size = new System.Drawing.Size(166, 21);
            this.txtDao.TabIndex = 40;
            this.txtDao.Text = "dao";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 39;
            this.label8.Text = "DAO包名：";
            // 
            // txtSqlJar
            // 
            this.txtSqlJar.Location = new System.Drawing.Point(98, 88);
            this.txtSqlJar.Name = "txtSqlJar";
            this.txtSqlJar.Size = new System.Drawing.Size(803, 21);
            this.txtSqlJar.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "数据库JAR：";
            // 
            // btnOutputpath
            // 
            this.btnOutputpath.Location = new System.Drawing.Point(942, 17);
            this.btnOutputpath.Name = "btnOutputpath";
            this.btnOutputpath.Size = new System.Drawing.Size(126, 27);
            this.btnOutputpath.TabIndex = 16;
            this.btnOutputpath.Text = "选择路径";
            this.btnOutputpath.UseVisualStyleBackColor = true;
            this.btnOutputpath.Click += new System.EventHandler(this.btnOutputpath_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(508, 22);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(393, 21);
            this.txtOutputPath.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "输出路径：";
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(98, 20);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(293, 21);
            this.txtPackage.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "包名：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1109, 380);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "数据表配置";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rtxtTablesMap);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(525, 17);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(581, 360);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            // 
            // rtxtTablesMap
            // 
            this.rtxtTablesMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtTablesMap.Location = new System.Drawing.Point(3, 17);
            this.rtxtTablesMap.Name = "rtxtTablesMap";
            this.rtxtTablesMap.Size = new System.Drawing.Size(575, 340);
            this.rtxtTablesMap.TabIndex = 14;
            this.rtxtTablesMap.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.txtPrefix);
            this.groupBox7.Controls.Add(this.btnClearnAllTable);
            this.groupBox7.Controls.Add(this.btnAddAllTable);
            this.groupBox7.Controls.Add(this.btnAddSelectedTable);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox7.Location = new System.Drawing.Point(377, 17);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(148, 360);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // btnClearnAllTable
            // 
            this.btnClearnAllTable.Location = new System.Drawing.Point(35, 246);
            this.btnClearnAllTable.Name = "btnClearnAllTable";
            this.btnClearnAllTable.Size = new System.Drawing.Size(75, 23);
            this.btnClearnAllTable.TabIndex = 37;
            this.btnClearnAllTable.Text = "清空";
            this.btnClearnAllTable.UseVisualStyleBackColor = true;
            this.btnClearnAllTable.Click += new System.EventHandler(this.btnClearnAllTable_Click);
            // 
            // btnAddAllTable
            // 
            this.btnAddAllTable.Location = new System.Drawing.Point(35, 202);
            this.btnAddAllTable.Name = "btnAddAllTable";
            this.btnAddAllTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddAllTable.TabIndex = 36;
            this.btnAddAllTable.Text = "添加全部";
            this.btnAddAllTable.UseVisualStyleBackColor = true;
            this.btnAddAllTable.Click += new System.EventHandler(this.btnAddAllTable_Click);
            // 
            // btnAddSelectedTable
            // 
            this.btnAddSelectedTable.Location = new System.Drawing.Point(35, 151);
            this.btnAddSelectedTable.Name = "btnAddSelectedTable";
            this.btnAddSelectedTable.Size = new System.Drawing.Size(75, 23);
            this.btnAddSelectedTable.TabIndex = 35;
            this.btnAddSelectedTable.Text = "添加选中";
            this.btnAddSelectedTable.UseVisualStyleBackColor = true;
            this.btnAddSelectedTable.Click += new System.EventHandler(this.btnAddSelectedTable_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbxTables);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(3, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(374, 360);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // lbxTables
            // 
            this.lbxTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxTables.FormattingEnabled = true;
            this.lbxTables.HorizontalScrollbar = true;
            this.lbxTables.ItemHeight = 12;
            this.lbxTables.Location = new System.Drawing.Point(3, 17);
            this.lbxTables.Name = "lbxTables";
            this.lbxTables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxTables.Size = new System.Drawing.Size(368, 340);
            this.lbxTables.TabIndex = 13;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(42, 75);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(100, 21);
            this.txtPrefix.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 40;
            this.label17.Text = "前缀";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 736);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "MyBatis代码生成";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImportConfig;
        private System.Windows.Forms.Button btnSelectConfig;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSearchTable;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnectDb;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxTables;
        private System.Windows.Forms.Button btnClearnAllTable;
        private System.Windows.Forms.Button btnAddAllTable;
        private System.Windows.Forms.Button btnAddSelectedTable;
        private System.Windows.Forms.RichTextBox rtxtTablesMap;
        private System.Windows.Forms.Button btnOutputpath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSelectSqlJar;
        private System.Windows.Forms.TextBox txtMapping;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSqlJar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectGeneratorJar;
        private System.Windows.Forms.TextBox txtGeneratorJar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSaveConfigName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.TextBox txtSaveConfigPath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCreateGenerator;
        private System.Windows.Forms.Button btnExcuteCmd;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPrefix;
    }
}