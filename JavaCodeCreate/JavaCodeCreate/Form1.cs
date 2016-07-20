using JavaCodeCreate.DBConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IDbConnect db = new SqlServerConnect();
            string conn = db.GetConnectStr(this.txtServiceAddress.Text, this.txtAccount.Text, this.txtPassword.Text, "");
            DataTable dbs = db.QueryDatabases(conn);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {

        }

        private void btnModelFile_Click(object sender, EventArgs e)
        {

        }

        private void btnMappingFile_Click(object sender, EventArgs e)
        {

        }

        private void btnDaoFile_Click(object sender, EventArgs e)
        {

        }

        private void btnJarFile_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCfg_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();//启动程序  
            p.StandardInput.WriteLine(@"d:");
            p.StandardInput.WriteLine(@"cd D:\generator");
            p.StandardInput.WriteLine(@"java -jar mybatis-generator-core-1.3.1.jar -configfile generator.xml -overwrite");
            p.StandardInput.WriteLine("exit");
            string sOutput = p.StandardOutput.ReadToEnd();
            MessageBox.Show(sOutput);
        }
    }
}
