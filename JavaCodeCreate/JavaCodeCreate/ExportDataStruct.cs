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
            string server = this.cbxServer.Text;
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
                if (objSave.ShowDialog() == DialogResult.OK)
                {

                    //创建document对象
                    XWPFDocument doc = new XWPFDocument();
                    IDbConnect db = null;
                    string conn = GetConnect(ref db);
                    var tables = db.QueryDataTablesFull(conn);
                    foreach (DataRow item in tables.Rows)
                    {
                        //创建段落对象
                        XWPFParagraph p1 = doc.CreateParagraph();
                        XWPFRun r1 = p1.CreateRun();
                        r1.SetText(item["comments"].ToString() + "——" + item["TABLE_NAME"].ToString());
                        r1.SetFontFamily("Arial", FontCharRange.Ascii);//设置雅黑字体
                      
                        p1.Style = "标题 1";
                        //创建表格对象列数写死了，可根据自己需要改进或者自己想想解决方案
                        var columns = db.QueryColumns(conn, item["TABLE_NAME"].ToString());
                        XWPFTable table = doc.CreateTable(columns.Rows.Count, 4);
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

                        for (int i = 1; i < columns.Rows.Count; i++)
                        {
                            table.GetRow(i).GetCell(0).SetText(columns.Rows[i - 1]["字段名"].ToString());
                            table.GetRow(i).GetCell(1).SetText(columns.Rows[i - 1]["类型"].ToString());
                            table.GetRow(i).GetCell(2).SetText(columns.Rows[i - 1]["长度"].ToString());
                            table.GetRow(i).GetCell(3).SetText(columns.Rows[i - 1]["备注"].ToString());
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

    }
}
