using JavaCodeCreate.DBConnect;
using NPOI.XWPF.UserModel;
using System;
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
    public partial class ExportDataStruct : Form
    {
        public ExportDataStruct()
        {
            InitializeComponent();
        }

        private void btnExportSqlserver_Click(object sender, EventArgs e)
        {
            string server = this.cbx_sqlserver_server.Text;
            ExportWord();
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
            string conn = "";
            switch (this.tbcDataBase.SelectedTab.Text.Trim())
            {
                case "MySql":
                    {
                        db = new MysqlConnect();
                        string dbName = this.cbx_sqlserver_database.Text.ToString();
                        conn = db.GetConnectStr(this.cbx_mysql_server.Text.Trim(), this.txt_mysql_port.Text, this.txt_mysql_account.Text, this.txt_mysql_pwd.Text, dbName);
                    } break;
                case "Oracle":
                    {
                        db = new SqlServerConnect();
                        string dbName = this.cbx_sqlserver_database.Text.ToString();
                        conn = db.GetConnectStr(this.cbx_sqlserver_server.Text.Trim(), "", this.txt_sqlserver_account.Text, this.txt_sqlserver_pwd.Text, dbName);
                    } break;
                case "Sql Server":
                    {
                        db = new SqlServerConnect();
                        string dbName = this.cbx_sqlserver_database.Text.ToString();
                        conn = db.GetConnectStr(this.cbx_sqlserver_server.Text.Trim(), "", this.txt_sqlserver_account.Text, this.txt_sqlserver_pwd.Text, dbName);
                    } break;
            }

            return conn;
        }

        private void AutoQueryDataBases()
        {
            try
            {
                if (this.cbx_sqlserver_server.Text.Trim() == "" || this.cbx_sqlserver_server.Text.Trim().Length < 7) return;
                bool usePwd = this.rbtn_sqlserver_account.Checked && this.txt_sqlserver_account.Text.Trim() != "" && this.txt_sqlserver_pwd.Text.Trim().Length > 5;
                if (this.rbtn_sqlserver_local.Checked || usePwd)
                {
                    IDbConnect db = null;
                    string conn = GetConnect(ref db);
                    List<string> dbs = db.QueryDatabases(conn);
                    this.cbx_sqlserver_database.DataSource = dbs;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void ExportDataStruct_Load(object sender, EventArgs e)
        {
            try
            {
                switch (this.tbcDataBase.SelectedTab.Text.Trim())
                {
                    case "MySql": break;
                    case "Oracle": break;
                    case "Sql Server":
                        {
                            var temp = SqlLocator.GetLocalSqlServerNamesWithSqlClientFactory();
                            foreach (var item in temp)
                                this.cbx_sqlserver_server.Items.Add(item);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OpenFileDir(string filePath)
        {
            Process open = new Process();
            open.StartInfo.FileName = "explorer";
            open.StartInfo.Arguments = @"/select," + filePath;
            open.Start();
        }
        bool IsComplite;
        public void ExportWord()
        {
            try
            {
                System.Windows.Forms.SaveFileDialog objSave = new System.Windows.Forms.SaveFileDialog();
                objSave.Filter = "(*.doc)|*.doc|" + "(*.*)|*.*";
                objSave.FileName = "数据库结构.doc";
                string dbName = "";
                switch (this.tbcDataBase.SelectedTab.Text.Trim())
                {
                    case "MySql": dbName = this.cbx_mysql_database.Text; break;
                    case "Oracle": break;
                    case "Sql Server": break;
                }

                if (objSave.ShowDialog() == DialogResult.OK)
                {

                    //创建document对象
                    XWPFDocument doc = new XWPFDocument();
                    IDbConnect db = null;
                    string conn = GetConnect(ref db);
                    var tables = db.QueryDataTablesFull(conn, dbName);
                    foreach (DataRow item in tables.Rows)
                    {
                        //创建段落对象
                        XWPFParagraph p1 = doc.CreateParagraph();
                        XWPFRun r1 = p1.CreateRun();
                        r1.SetText(string.Format("{0}[{1}]", item["TABLE_NAME"].ToString(), item["comments"].ToString()));
                        r1.SetFontFamily("Arial", FontCharRange.Ascii);//设置雅黑字体

                        p1.Style = "标题 1";
                        //创建表格对象列数写死了，可根据自己需要改进或者自己想想解决方案
                        var columns = db.QueryColumns(conn, item["TABLE_NAME"].ToString(), dbName);
                        XWPFTable table = doc.CreateTable(columns.Rows.Count + 1, 4);
                        table.SetColumnWidth(0, 2000);
                        table.SetColumnWidth(1, 1500);
                        table.SetColumnWidth(2, 800);
                        table.SetColumnWidth(3, 3500);

                        table.GetRow(0).GetCell(0).SetText("字段名");
                        table.GetRow(0).GetCell(0).SetColor("ff0");
                        table.GetRow(0).GetCell(1).SetText("数据类型");
                        table.GetRow(0).GetCell(1).SetColor("ff0");
                        table.GetRow(0).GetCell(2).SetText("长度");
                        table.GetRow(0).GetCell(2).SetColor("ff0");
                        table.GetRow(0).GetCell(3).SetText("备注");
                        table.GetRow(0).GetCell(3).SetColor("ff0");

                        for (int i = 0; i < columns.Rows.Count; i++)
                        {
                            table.GetRow(i + 1).GetCell(0).SetText((columns.Rows[i]["字段名"] ?? "").ToString());
                            table.GetRow(i + 1).GetCell(1).SetText((columns.Rows[i]["类型"] ?? "").ToString());
                            table.GetRow(i + 1).GetCell(2).SetText((columns.Rows[i]["长度"] ?? "").ToString());
                            table.GetRow(i + 1).GetCell(3).SetText((columns.Rows[i]["备注"] ?? "").ToString());
                        }
                    }
                    if (File.Exists(objSave.FileName))
                        File.Delete(objSave.FileName);

                    //保存文件到磁盘
                    using (FileStream fs = new FileStream(objSave.FileName, FileMode.Create))
                    {
                        doc.Write(fs);
                    }
                    OpenFileDir(objSave.FileName);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                IsComplite = true;
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mysql_export_Click(object sender, EventArgs e)
        {
            ExportWord();
        }


        #region Mysql自动查询数据库
        private void cbx_mysql_server_SelectedIndexChanged(object sender, EventArgs e)
        {
            AutoQueryMysqlDataBases();
        }

        private void txt_mysql_port_TextChanged(object sender, EventArgs e)
        {
            AutoQueryMysqlDataBases();
        }

        private void txt_mysql_account_TextChanged(object sender, EventArgs e)
        {
            AutoQueryMysqlDataBases();
        }

        private void txt_mysql_pwd_TextChanged(object sender, EventArgs e)
        {
            AutoQueryMysqlDataBases();
        }

        private void AutoQueryMysqlDataBases()
        {
            try
            {
                if (this.cbx_mysql_server.Text.Trim() == "") return;
                bool usePwd = this.txt_mysql_account.Text.Trim() != "" && this.txt_mysql_pwd.Text.Trim().Length > 5 && this.txt_mysql_port.Text.Trim() != "";
                if (usePwd)
                {
                    IDbConnect db = null;
                    string conn = GetConnect(ref db);
                    List<string> dbs = db.QueryDatabases(conn);
                    this.cbx_mysql_database.DataSource = dbs;
                }
            }
            catch (Exception ex)
            {
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            List<DbTableMapping> tableList = new List<DbTableMapping>();
            try
            {

                string dbName = "";
                switch (this.tbcDataBase.SelectedTab.Text.Trim())
                {
                    case "MySql": dbName = this.cbx_mysql_database.Text; break;
                    case "Oracle": break;
                    case "Sql Server": break;
                }
                IDbConnect db = null;
                string conn = GetConnect(ref db);
                var tables = db.QueryDataTablesFull(conn, dbName);
                foreach (DataRow item in tables.Rows)
                {

                    var table = new DbTableMapping();
                    table.TableName = item["TABLE_NAME"].ToString().Trim();
                    table.ClassName = table.TableName.ToClassName();
                    table.Comment = item["comments"].ToString().Trim();
                    table.Columns = new List<DbColumnMapping>();
                    var columns = db.QueryColumns(conn, item["TABLE_NAME"].ToString(), dbName);
                    foreach (DataRow col in columns.Rows)
                    {
                        var column = new DbColumnMapping();
                        column.DbColumnName = col["字段名"].ToString().Trim();
                        column.DBColumnType = col["类型"].ToString().Trim();
                        column.Comment = col["备注"].ToString().Trim();
                        column.ColumnName = column.DbColumnName.ToFieldName();
                        column.ColumnType = column.DBColumnType.ToFieldType();
                        column.IsPrimeyKey = col["主键"] != DBNull.Value && col["主键"].ToString().ToUpper() == "PRI";
                        table.Columns.Add(column);
                    }
                    table.DbPrimeyKey = table.Columns.Where(x => x.IsPrimeyKey).FirstOrDefault().DbColumnName;
                    tableList.Add(table);

                }
                foreach (var item in tableList)
                {
                    CreateModel.Excute(item, "E:/Entity/");
                    CreateIDal.Excute(item, "E:/Entity/");
                    CreateIBll.Excute(item, "E:/Entity/");
                    CreateBll.Excute(item, "E:/Entity/");
                    CreateDal.Excute(item, "E:/Entity/");
                }
                CreateGlobal.Excute(tableList, "E:/Entity/");
            }
            catch (Exception ex)
            {
            }
            finally
            {
                IsComplite = true;
            }

        }
    }
}
