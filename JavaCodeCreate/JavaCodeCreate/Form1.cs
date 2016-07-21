using JavaCodeCreate.DBConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaCodeCreate
{
    public partial class MyBatis : Form
    {
        public MyBatis()
        {
            InitializeComponent();
            InitForm();
        }

        List<String> dbTypes = new List<string> { "MySql", "Oracle", "Sql Server" };

        private void InitForm()
        {
            this.cbxDbType.DataSource = dbTypes;
            this.txtXMLPath.Text = System.Environment.CurrentDirectory + "\\generator";
            this.txtJarPath.Text = System.Environment.CurrentDirectory + "\\sqljar";

            string configPath = System.Environment.CurrentDirectory + "\\dbconfig\\config.ini";
            LoadConfig(configPath);

        }

        private void LoadConfig(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string source = sr.ReadToEnd();
                DbConfig config = source.JsonDeserialize<DbConfig>();
                this.txtAccount.Text = config.Account;
                this.txtDaoPath.Text = config.DaoFilePath;
                this.txtDaoPg.Text = config.DaoPackage;
                this.cbxDbName.DataSource = config.DbNameList;
                this.cbxDbName.SelectedItem = config.DbName;
                this.cbxDbType.SelectedItem = config.DbType;
                this.txtMapPath.Text = config.MappingFilePath;
                this.txtMapPg.Text = config.MappingPackage;
                this.txtModelPath.Text = config.ModelFilePath;
                this.txtModelPg.Text = config.ModelPackage;
                this.txtPassword.Text = config.Password;
                this.txtServiceAddress.Text = config.Service;
                this.txtJarPath.Text = config.SqlJarPath;
                this.lbxTables.DataSource = config.TableList;
                this.rtxtTablesMap.Text = config.TableMappings;
                this.cbxTmp.Checked = config.TempletChecked;
                this.txtTmpPath.Text = config.TempletFilePath;
                this.txtTmpPg.Text = config.TempletPackage;
                this.txtXMLPath.Text = config.XMLPath;
                this.txtPort.Text = config.Port;
            }
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

            string conn = db.GetConnectStr(this.txtServiceAddress.Text, this.txtPort.Text, this.txtAccount.Text, this.txtPassword.Text, dbName);
            return conn;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IDbConnect db = null;
            string conn = GetConnect(ref db);
            List<string> dbs = db.QueryDatabases(conn);
            this.cbxDbName.DataSource = dbs;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IDbConnect db = null;
            string conn = GetConnect(ref db);
            List<string> tables = db.QueryDataTables(conn);
            this.lbxTables.DataSource = tables;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (this.lbxTables.Items != null)
            {
                var tabMaps = GetTableMap();
                StringBuilder sb = new StringBuilder();
                foreach (var item in this.lbxTables.SelectedItems)
                {
                    if (tabMaps.Keys.Contains(item))
                        continue;
                    tabMaps.Add(item.ToString(), item.ToString());
                    sb.AppendFormat("{0} —> {0}\r\n", item);

                }
                this.rtxtTablesMap.Text = this.rtxtTablesMap.Text + sb.ToString();
            }
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

        private void btnModelFile_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog path = new FolderBrowserDialog();
                path.ShowDialog();
                this.txtModelPath.Text = path.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMappingFile_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog path = new FolderBrowserDialog();
                path.ShowDialog();
                this.txtMapPath.Text = path.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDaoFile_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog path = new FolderBrowserDialog();
                path.ShowDialog();
                this.txtDaoPath.Text = path.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJarFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();  //new一个方法  
                ofd.Filter = "JAR Files(*.jar)|*.jar";
                ofd.Multiselect = false;         //允许多选  
                ofd.RestoreDirectory = true;    //记住上一次的文件路径  
                ofd.ShowDialog();               //显示打开文件的窗口  
                foreach (var item in ofd.FileNames)
                {
                    // var temp = item.Split('\\');
                    this.txtJarPath.Text = item;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DbConfig GetDbConfig()
        {
            DbConfig config = new DbConfig();
            config.Account = this.txtAccount.Text.Trim();
            config.DaoFilePath = this.txtDaoPath.Text.Trim();
            config.DaoPackage = this.txtDaoPg.Text.Trim();
            if (this.cbxDbName.Items != null && this.cbxDbName.SelectedItem != null)
                config.DbName = this.cbxDbName.SelectedItem.ToString().Trim();

            List<string> dbNames = new List<string>();
            if (this.cbxDbName.Items != null)
                foreach (var item in this.cbxDbName.Items)
                {
                    dbNames.Add(item.ToString());
                }

            config.DbNameList = dbNames;

            if (this.cbxDbType.Items != null && this.cbxDbType.SelectedItem != null)
                config.DbType = this.cbxDbType.SelectedItem.ToString().Trim();
            config.MappingFilePath = this.txtMapPath.Text.Trim();
            config.MappingPackage = this.txtMapPg.Text.Trim();
            config.ModelFilePath = this.txtModelPath.Text.Trim();
            config.ModelPackage = this.txtModelPg.Text.Trim();
            config.Password = this.txtPassword.Text.Trim();
            config.Service = this.txtServiceAddress.Text.Trim();
            config.SqlJarPath = this.txtJarPath.Text.Trim();


            List<string> tables = new List<string>();
            if (this.lbxTables.Items != null)
                foreach (var item in this.lbxTables.Items)
                {
                    tables.Add(item.ToString());
                }
            config.TableList = tables;

            config.TableMappings = this.rtxtTablesMap.Text.Trim();
            config.TempletFilePath = this.txtTmpPath.Text.Trim();
            config.TempletPackage = this.txtTmpPg.Text.Trim();
            config.XMLPath = this.txtXMLPath.Text.Trim();
            config.TempletChecked = this.cbxTmp.Checked;
            config.Port = this.txtPort.Text;
            return config;
        }

        private void btnSaveCfg_Click(object sender, EventArgs e)
        {
            try
            {
                DbConfig config = GetDbConfig();
                string json = config.JsonSerialize<DbConfig>();
                string filePath = System.Environment.CurrentDirectory + "\\dbconfig";
                string fileName = "config.ini";
                SaveFile(json, filePath, fileName);
                MessageBox.Show("配置文件保存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnClearn_Click(object sender, EventArgs e)
        {
            this.rtxtTablesMap.Text = "";
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (this.lbxTables.Items != null)
            {
                var tabMaps = GetTableMap();
                StringBuilder sb = new StringBuilder();
                foreach (var item in this.lbxTables.Items)
                {
                    if (tabMaps.Keys.Contains(item))
                        continue;
                    tabMaps.Add(item.ToString(), item.ToString());
                    sb.AppendFormat("{0} —> {0}\r\n", item);

                }
                this.rtxtTablesMap.Text = this.rtxtTablesMap.Text + sb.ToString();

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog path = new FolderBrowserDialog();
                path.ShowDialog();
                this.txtXMLPath.Text = path.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string filePath = this.txtXMLPath.Text.Trim() + "\\generator";
            List<string> cmds = new List<string>();
            cmds.Add(filePath.Substring(0, 2));
            cmds.Add("cd " + filePath);
            cmds.Add(@"java -jar mybatis-generator-core-1.3.1.jar -configfile generator.xml -overwrite");
            MessageBox.Show(ExcuteCmd(cmds));
        }


        private string ExcuteCmd(List<string> cmds)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();//启动程序  
            foreach (var item in cmds)
            {
                p.StandardInput.WriteLine(item);
            }
            p.StandardInput.WriteLine("exit");
            return p.StandardOutput.ReadToEnd();
        }

        private void CreateGeneratorXml()
        {
            string tableTemp = "<table tableName=\"{0}\" domainObjectName=\"{1}\" enableCountByExample=\"false\" enableUpdateByExample=\"false\" enableDeleteByExample=\"false\" enableSelectByExample=\"false\" selectByExampleQueryId=\"false\" />";
            StringBuilder sbTables = new StringBuilder();
            var tabMaps = GetTableMap();
            foreach (var item in tabMaps)
                sbTables.AppendFormat(tableTemp, item.Key, item.Value);
            var dbconfig = GetDbConfig();
            StringBuilder sbstream = new StringBuilder();
            sbstream.Append(LoadTemplet());
            sbstream.Replace("$sqljar$", dbconfig.SqlJarPath);
            sbstream.Replace("$driverClass$", "com.mysql.jdbc.Driver");
            sbstream.Replace("$dblink$", "jdbc:mysql://" + dbconfig.Service + ":" + (String.IsNullOrEmpty(dbconfig.Port) ? "3306" : dbconfig.Port) + "/" + dbconfig.DbName);
            sbstream.Replace("$username$", dbconfig.Account);
            sbstream.Replace("$password$", dbconfig.Password);
            sbstream.Replace("$modelpackage$", dbconfig.ModelPackage);
            sbstream.Replace("$modelsrc$", dbconfig.ModelFilePath);
            sbstream.Replace("$mappingpackage$", dbconfig.MappingPackage);
            sbstream.Replace("$mappingsrc$", dbconfig.MappingFilePath);
            sbstream.Replace("$daopackage$", dbconfig.DaoPackage);
            sbstream.Replace("$daosrc$", dbconfig.DaoFilePath);
            sbstream.Replace("$tables$", sbTables.ToString());
            SaveFile(sbstream.ToString(), System.Environment.CurrentDirectory + "\\generator", "generator.xml");
        }

        private string LoadTemplet()
        {
            string directory = System.Environment.CurrentDirectory + "\\templet";
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateGeneratorXml();
        }

    }
}
