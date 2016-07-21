using JavaCodeCreate.DBConnect;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaCodeCreate
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitForm();
        }


        List<String> dbTypes = new List<string> { "MySql", "Oracle", "Sql Server" };

        private void InitForm()
        {
            this.cbxDbType.DataSource = dbTypes;
            SysPath = System.Environment.CurrentDirectory;
            this.txtSqlJar.Text = SysPath + "\\jar\\mysql-connector-java-5.1.39-bin.jar";
            this.txtGeneratorJar.Text = SysPath + "\\generator\\mybatis-generator-core.jar";
            this.txtSaveConfigPath.Text = SysPath + "\\config";
            this.txtSaveConfigName.Text = "dbconfig";
            string configPath = SysPath + "\\config\\dbconfig.ini";
            if (File.Exists(configPath))
            {
                this.txtConfig.Text = configPath;
                LoadConfig(configPath);
            }
            GeneratorJar = this.txtGeneratorJar.Text.Trim();
            InitDataByDbtype();
        }

        static string SysPath = "";
        static string SqlJar = "";
        static string GeneratorJar = "";

        private void btnSelectConfig_Click(object sender, EventArgs e)
        {
            string filter = "INI Files(*.ini)|*.ini";
            string path = SelectFile(filter);
            if (path != "")
                this.txtConfig.Text = path;
        }

        private void btnImportConfig_Click(object sender, EventArgs e)
        {
            try
            {
                LoadConfig(this.txtConfig.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadConfig(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string source = sr.ReadToEnd();
                MyDbConfig config = source.JsonDeserialize<MyDbConfig>();
                this.cbxDbType.SelectedItem = config.DbType;
                this.txtService.Text = config.Service;
                this.txtPort.Text = config.Port;
                this.txtAccount.Text = config.Account;
                this.txtPassword.Text = config.Password;
                this.cbxDbName.DataSource = config.DbNameList;
                this.cbxDbName.SelectedItem = config.DbName;
                this.lbxTables.DataSource = config.TableList;
                this.rtxtTablesMap.Text = config.TableMap;
                this.txtPackage.Text = config.Package;
                this.txtOutputPath.Text = config.OutputPath;
                this.txtDao.Text = config.Dao;
                this.txtModel.Text = config.Model;
                this.txtMapping.Text = config.Mapping;
                this.txtSqlJar.Text = config.SqlJarPath;
                this.txtGeneratorJar.Text = config.GeneratorJarPath;
                this.txtSaveConfigPath.Text = config.SaveConfigPath;
                this.txtSaveConfigName.Text = config.SaveConfiName;
            }
        }

        private void btnConnectDb_Click(object sender, EventArgs e)
        {
            try
            {
                this.cbxDbName.DataSource = null;
                this.lbxTables.DataSource = null;
                this.rtxtTablesMap.Clear();
                IDbConnect db = null;
                string conn = GetConnect(ref db);
                List<string> dbs = db.QueryDatabases(conn);
                this.cbxDbName.DataSource = dbs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            try
            {
                this.lbxTables.DataSource = null;
                this.rtxtTablesMap.Clear();
                IDbConnect db = null;
                string conn = GetConnect(ref db);
                List<string> tables = db.QueryDataTables(conn);
                this.lbxTables.DataSource = tables;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSelectedTable_Click(object sender, EventArgs e)
        {
            try
            {
                SetTableMap(this.lbxTables.SelectedItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetTableMap(IList list)
        {
            if (this.lbxTables.Items != null)
            {
                var tabMaps = GetTableMap();
                StringBuilder sb = new StringBuilder();
                string prefix = this.txtPrefix.Text.Trim();
                if (string.IsNullOrEmpty(prefix))
                {
                    foreach (var item in list)
                    {
                        var value = item.ToString().ToClassName();
                        if (tabMaps.Keys.Contains(item))
                            continue;
                        tabMaps.Add(item.ToString(), value);
                        sb.AppendFormat("{0} —> {1}\r\n", item, value);

                    }
                }
                else
                {
                    foreach (var item in this.lbxTables.Items)
                    {
                        var value = item.ToString().ToClassName(prefix);
                        if (tabMaps.Keys.Contains(item))
                            continue;
                        tabMaps.Add(item.ToString(), value);
                        sb.AppendFormat("{0} —> {1}\r\n", item, value);

                    }
                }
                this.rtxtTablesMap.Text = this.rtxtTablesMap.Text + sb.ToString();
            }
        }

        private void btnAddAllTable_Click(object sender, EventArgs e)
        {
            try
            {
                SetTableMap(this.lbxTables.Items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearnAllTable_Click(object sender, EventArgs e)
        {
            this.rtxtTablesMap.Clear();
        }

        private void btnOutputpath_Click(object sender, EventArgs e)
        {
            var path = SelectPath();
            if (path != "")
                this.txtOutputPath.Text = path;
        }

        private void btnSelectSqlJar_Click(object sender, EventArgs e)
        {
            string filter = "JAR Files(*.jar)|*.jar";
            var path = SelectFile(filter);
            if (path != "")
                this.txtSqlJar.Text = path;
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            this.txtSaveConfigPath.Text = SelectPath();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                MyDbConfig db = GetDbConfig();
                string json = db.JsonSerialize<MyDbConfig>();
                string filePath = db.SaveConfigPath;
                string fileName = db.SaveConfiName + ".ini";
                SaveFile(json, filePath, fileName);
                MessageBox.Show(this, "配置文件保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateGenerator_Click(object sender, EventArgs e)
        {
            try
            {
                CreateGeneratorXml();
                MessageBox.Show(this, "生成Generator文件成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenFileDir(SysPath + "\\generator\\generator.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcuteCmd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(this.txtOutputPath.Text.Trim()))
                {
                    MessageBox.Show(this, this.txtOutputPath.Text.Trim() + "输出目录不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CoverFile(SqlJar, this.txtSqlJar.Text.Trim());
                CoverFile(GeneratorJar, this.txtGeneratorJar.Text.Trim());
                string filePath = SysPath + "\\generator";
                List<string> cmds = new List<string>();
                cmds.Add(filePath.Substring(0, 2));
                cmds.Add("cd " + filePath);
                cmds.Add(@"java -jar mybatis-generator-core.jar -configfile generator.xml -overwrite");
                string result = ExcuteCmd(cmds);
                if (result.Contains("Generator finshed successfully"))
                {
                    OpenFileDir(this.txtOutputPath.Text.Trim());
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSqlserverJar()
        {
            var items = EnvironmentVarUtil.GetAllValues();

            var sqlJar = SysPath + "\\jar";
            var sqlTarget = "C:\\sqljdbc4";
            var sqlJarName = "sqljdbc4.jar";
            CopyFile(sqlJar, sqlTarget, sqlJarName);
            string value = EnvironmentVarUtil.GetValue("CLASSPATH");
            if (!value.EndsWith(";"))
                value = value + ";";
            value = value.Replace(EnvironmentVarUtil.GetValue("JAVA_HOME"), "%JAVA_HOME%");
            if (!value.Contains(sqlTarget + "\\" + sqlJarName))
                EnvironmentVarUtil.SetValue("CLASSPATH", value + sqlTarget + "\\" + sqlJarName + ";");
            var jdkHome = EnvironmentVarUtil.GetValue("JAVA_HOME").Trim() + @"\jre\lib\ext";
            CopyFile(jdkHome, sqlTarget, sqlJarName);
        }

        private void CopyFile(string source, string target, string fileName)
        {
            if (!Directory.Exists(target))
                Directory.CreateDirectory(target);
            if (!File.Exists(target + "\\" + fileName))
                File.Copy(source + "\\" + fileName, target + "\\" + fileName);
        }

        private void CoverFile(string oldPath, string newPath)
        {
            if (oldPath.Trim() == newPath.Trim())
                return;
            File.Copy(newPath, oldPath, true);
        }

        private void btnSelectGeneratorJar_Click(object sender, EventArgs e)
        {
            string filter = "JAR Files(*.jar)|*.jar";
            string path = SelectFile(filter);
            if (path != "")
                this.txtGeneratorJar.Text = path;
        }

        private void OpenFileDir(string filePath)
        {
            Process open = new Process();
            open.StartInfo.FileName = "explorer";
            open.StartInfo.Arguments = @"/select," + filePath;
            open.Start();
        }

        private string SelectPath()
        {
            string result = "";
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.SelectedPath = SysPath;
            path.ShowDialog();
            result = path.SelectedPath;
            return result;
        }

        private string SelectFile(string filter)
        {
            string result = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = filter;
            ofd.Multiselect = false;
            ofd.RestoreDirectory = true;
            ofd.ShowDialog();
            foreach (var item in ofd.FileNames)
            {
                result = item;
            }
            return result;
        }



        private string ExcuteCmd(List<string> cmds)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            foreach (var item in cmds)
            {
                p.StandardInput.WriteLine(item);
            }
            p.StandardInput.WriteLine("exit");
            return p.StandardOutput.ReadToEnd();
        }


        private MyDbConfig GetDbConfig()
        {
            MyDbConfig config = new MyDbConfig();
            config.ConfigPath = this.txtConfig.Text.Trim();
            config.Service = this.txtService.Text.Trim();
            config.Port = this.txtPort.Text;
            config.Account = this.txtAccount.Text.Trim();
            config.Password = this.txtPassword.Text.Trim();
            List<string> dbNames = new List<string>();
            if (this.cbxDbName.Items != null)
                foreach (var item in this.cbxDbName.Items)
                    dbNames.Add(item.ToString());

            config.DbNameList = dbNames;
            if (this.cbxDbName.Items != null && this.cbxDbName.SelectedItem != null)
                config.DbName = this.cbxDbName.SelectedItem.ToString().Trim();

            if (this.cbxDbType.Items != null && this.cbxDbType.SelectedItem != null)
                config.DbType = this.cbxDbType.SelectedItem.ToString().Trim();

            List<string> tables = new List<string>();
            if (this.lbxTables.Items != null)
                foreach (var item in this.lbxTables.Items)
                    tables.Add(item.ToString());
            config.TableList = tables;
            config.TableMap = this.rtxtTablesMap.Text;
            config.Package = this.txtPackage.Text.Trim();
            config.OutputPath = this.txtOutputPath.Text.Trim();
            config.Model = this.txtModel.Text.Trim();
            config.Dao = this.txtDao.Text.Trim();
            config.Mapping = this.txtMapping.Text.Trim();
            config.SqlJarPath = this.txtSqlJar.Text.Trim();
            config.GeneratorJarPath = this.txtGeneratorJar.Text.Trim();
            config.SaveConfigPath = this.txtSaveConfigPath.Text.Trim();
            config.SaveConfiName = this.txtSaveConfigName.Text.Trim();
            return config;
        }

        private void CreateGeneratorXml()
        {
            var dbconfig = GetDbConfig();
            var sqlserverLink = "jdbc:sqlserver://" + dbconfig.Service + ":" + (String.IsNullOrEmpty(dbconfig.Port) ? "1143" : dbconfig.Port) + ";DatabaseName=" + dbconfig.DbName; ;

            if (dbconfig.Service.Contains("/"))
            {
                var temp = dbconfig.Service.Split('/');
                sqlserverLink = "jdbc:sqlserver://" + temp[0] + ":" + (String.IsNullOrEmpty(dbconfig.Port) ? "1143" : dbconfig.Port) + "/" + temp[1] + ";DatabaseName=" + dbconfig.DbName; ;
            }
            else if (dbconfig.Service.Contains("\\"))
            {
                var temp = dbconfig.Service.Split('\\');
                sqlserverLink = "jdbc:sqlserver://" + temp[0] + ":" + (String.IsNullOrEmpty(dbconfig.Port) ? "1143" : dbconfig.Port) + "\\" + temp[1] + ";DatabaseName=" + dbconfig.DbName; ;
            }
            string driverClass = "";
            string dblink = "";
            switch (this.cbxDbType.SelectedItem.ToString())
            {
                case "MySql":
                    driverClass = "com.mysql.jdbc.Driver";
                    dblink = "jdbc:mysql://" + dbconfig.Service + ":" + (String.IsNullOrEmpty(dbconfig.Port) ? "3306" : dbconfig.Port) + "/" + dbconfig.DbName; break;
                case "Oracle":
                    driverClass = "com.mysql.jdbc.Driver";
                    dblink = "jdbc:oracle://" + dbconfig.Service + ":" + (String.IsNullOrEmpty(dbconfig.Port) ? "1521" : dbconfig.Port) + ";DatabaseName=" + dbconfig.DbName;
                    break;
                case "Sql Server":
                    driverClass = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
                    dblink = sqlserverLink;
                    break;
            }

            string tableTemp = "\r\n\t\t<table tableName=\"{0}\" domainObjectName=\"{1}\" enableCountByExample=\"false\" enableUpdateByExample=\"false\" enableDeleteByExample=\"false\" enableSelectByExample=\"false\" selectByExampleQueryId=\"false\" />";
            StringBuilder sbTables = new StringBuilder();
            var tabMaps = GetTableMap();
            foreach (var item in tabMaps)
                sbTables.AppendFormat(tableTemp, item.Key, item.Value);

            StringBuilder sbstream = new StringBuilder();
            sbstream.Append(LoadTemplet());
            sbstream.Replace("$sqljar$", dbconfig.SqlJarPath);
            sbstream.Replace("$driverClass$", driverClass);
            sbstream.Replace("$dblink$", dblink);
            sbstream.Replace("$username$", dbconfig.Account);
            sbstream.Replace("$password$", dbconfig.Password);
            sbstream.Replace("$modelpackage$", dbconfig.Package + "." + dbconfig.Model);
            sbstream.Replace("$modelsrc$", dbconfig.OutputPath);
            sbstream.Replace("$mappingpackage$", dbconfig.Package + "." + dbconfig.Mapping);
            sbstream.Replace("$mappingsrc$", dbconfig.OutputPath);
            sbstream.Replace("$daopackage$", dbconfig.Package + "." + dbconfig.Dao);
            sbstream.Replace("$daosrc$", dbconfig.OutputPath);
            sbstream.Replace("$tables$", sbTables.ToString());
            SaveFile(sbstream.ToString(), SysPath + "\\generator", "generator.xml");
        }

        private string LoadTemplet()
        {
            string directory = SysPath + "\\templet";
            string fileName = "templet.xml";
            return ReadFile(directory, fileName);
        }



        private string ReadFile(string directory, string fileName)
        {
            string result = "";
            if (!File.Exists(directory + "\\" + fileName))
                throw new Exception(directory + "\\" + fileName + "文件不存在！");
            using (StreamReader sw = new StreamReader(directory + "\\" + fileName))
                result = sw.ReadToEnd();
            return result;
        }

        private void SaveFile(string content, string directory, string fileName)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            using (StreamWriter sw = new StreamWriter(directory + "\\" + fileName))
                sw.Write(content);
        }

        private Dictionary<string, string> GetTableMap()
        {
            string source = this.rtxtTablesMap.Text.Replace("\r", "").Replace("\n", "~").Replace(" ", "").Replace("—>", "^");
            if (source == "") return new Dictionary<string, string>();
            string[] strList = source.Split('~');
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (var item in strList)
            {
                if (item == "") continue;
                var items = item.Split('^');
                result.Add(items[0], items[1]);
            }
            return result;
        }

        private string GetConnect(ref IDbConnect db)
        {
            switch (this.cbxDbType.SelectedItem.ToString())
            {
                case "MySql": db = new MysqlConnect(); break;
                case "Oracle": db = new SqlServerConnect(); break;
                case "Sql Server": db = new SqlServerConnect(); break;
            }
            string dbName = "";
            if (this.cbxDbName.Items != null && this.cbxDbName.SelectedItem != null)
                dbName = this.cbxDbName.SelectedItem.ToString();
            string conn = db.GetConnectStr(this.txtService.Text, this.txtPort.Text, this.txtAccount.Text, this.txtPassword.Text, dbName);
            return conn;
        }

        private void InitDataByDbtype()
        {
            switch (this.cbxDbType.SelectedItem.ToString())
            {
                case "MySql":
                    this.txtSaveConfigName.Text = "mysql_cfg";
                    this.txtSqlJar.Text = SysPath + "\\jar\\mysql-connector-java-5.1.39-bin.jar";
                    this.txtPort.Text = "3306";
                    break;
                case "Oracle":
                    this.txtSaveConfigName.Text = "oracle_cfg";
                    this.txtSqlJar.Text = SysPath + "\\jar\\oracle_jdbc.jar";
                    this.txtPort.Text = "1521";
                    break;
                case "Sql Server":
                    this.txtSqlJar.Text = SysPath + "\\jar\\sqljdbc4.jar";
                    this.txtSaveConfigName.Text = "sqlserver_cfg";
                    this.txtPort.Text = "1433";
                    break;
            }
            SqlJar = this.txtSqlJar.Text.Trim();
        }

        private void cbxDbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitDataByDbtype();
        }
    }
}
