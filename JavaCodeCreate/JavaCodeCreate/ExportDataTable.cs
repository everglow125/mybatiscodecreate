using JavaCodeCreate.DBConnect;
using NPOI.XWPF.UserModel;
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
    public partial class ExportDataTable : Form
    {
        String ORACLE_HOME = "";
        public ExportDataTable()
        {
            InitializeComponent();
            ORACLE_HOME = EnvironmentVarUtil.GetValue("ORACLE_HOME");
            if (String.IsNullOrEmpty(ORACLE_HOME))
            {
                MessageBox.Show("ORACLE_HOME 环境变量配置错误");
                return;
            }
            string filePath = ORACLE_HOME + "\\NETWORK\\ADMIN\\tnsnames.ora";

            using (StreamReader sr = new StreamReader(filePath))
            {
                string source = sr.ReadToEnd().Replace("\r", "").Replace("\n", "").Replace(" ", "");
            }
        }

        private string GetConnect(ref IDbConnect db)
        {
            db = new OracleConnect();
            string conn = db.GetConnectStr(this.txtService.Text, "", this.txtAccount.Text, this.txtPassword.Text, "");
            return conn;
        }

        public void ExportWord()
        {
            System.Windows.Forms.SaveFileDialog objSave = new System.Windows.Forms.SaveFileDialog();
            objSave.Filter = "(*.doc)|*.doc|" + "(*.*)|*.*";
            objSave.FileName = DateTime.Now.ToString("yyyyMMddHHmm") + ".doc";
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


                //保存文件到磁盘
                using (FileStream fs = new FileStream(objSave.FileName, FileMode.Create))
                {
                    doc.Write(fs);
                }
            }
        }

        private void btn_ExportData_Click(object sender, EventArgs e)
        {
            try
            {
                ExportWord();
                MessageBox.Show("文件导出完成");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
