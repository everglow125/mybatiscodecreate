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
    public partial class ExportDataStruct : Form
    {
        public ExportDataStruct()
        {
            InitializeComponent();
        }

        private void btnExportSqlserver_Click(object sender, EventArgs e)
        {
            string server = this.cbxServer.Text;
        }

        private void cbxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoQueryDataBases();
        }

        private void cbxServer_TextChanged(object sender, EventArgs e)
        {
            AutoQueryDataBases();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            AutoQueryDataBases();
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            AutoQueryDataBases();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AutoQueryDataBases();
        }

        private string GetConnect(ref IDbConnect db)
        {
            switch (this.tbcDataBase.SelectedTab.Text.Trim())
            {
                case "MySql": db = new MysqlConnect(); break;
                case "Oracle": db = new SqlServerConnect(); break;
                case "Sql Server": db = new SqlServerConnect(); break;
            }
            string dbName = this.cbxDataBase.Text.ToString();
            string conn = db.GetConnectStr(this.cbxServer.Text.Trim(), "", this.txtAccount.Text, this.txtPwd.Text, dbName);
            return conn;
        }

        private void AutoQueryDataBases()
        {
            try
            {
                if (this.cbxServer.Text.Trim() == "") return;
                bool usePwd = this.rbtnAccount.Checked && this.txtAccount.Text.Trim() != "" && this.txtPwd.Text.Trim().Length > 5;
                if (this.rbtnLoacl.Checked || usePwd)
                {
                    IDbConnect db = null;
                    string conn = GetConnect(ref db);
                    List<string> dbs = db.QueryDatabases(conn);
                    this.cbxDataBase.DataSource = dbs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportDataStruct_Load(object sender, EventArgs e)
        {
            try
            {
                switch (this.tbcDataBase.SelectedTab.Text.Trim())
                {
                    case "MySql": this.cbxServer.DataSource = SqlLocator.GetLocalSqlServerNamesWithAPI(); break;
                    case "Oracle": break;
                    case "Sql Server":
                        {
                            var temp = SqlLocator.GetLocalSqlServerNamesWithSqlClientFactory();
                            foreach (var item in temp)
                                this.cbxServer.Items.Add(item);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    }
}
