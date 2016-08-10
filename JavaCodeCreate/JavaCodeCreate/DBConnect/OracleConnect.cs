using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate.DBConnect
{
    public class OracleConnect : IDbConnect
    {


        private DataTable ExcuteDataTable(string sql, string conn)
        {
            using (OracleConnection myconnection = new OracleConnection(conn))
            {
                myconnection.Open();
                DataSet ds = new DataSet();
                try
                {
                    OracleDataAdapter command = new OracleDataAdapter(sql, myconnection);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                catch (Exception ex) { 
                }
                if (ds != null && ds.Tables.Count > 0)
                    return ds.Tables[0];
            }
            return null;
        }



        public List<string> QueryDatabases(string conn)
        {
            string mysql = "show databases;";
            return ExcuteDataTable(mysql, conn).ToStringList();
        }

        public List<string> QueryDataTables(string conn)
        {
            string mysql = "SELECT T1.TABLE_NAME FROM user_tab_comments T1";
            return ExcuteDataTable(mysql, conn).ToStringList();
        }

        public DataTable QueryDataTablesFull(string conn)
        {
            string mysql = "SELECT T1.TABLE_NAME '表名',T1.comments '备注' FROM user_tab_comments T1";
            return ExcuteDataTable(mysql, conn);
        }

        public DataTable QueryColumns(string conn, string tableName)
        {
            string mysql = string.Format(
@"SELECT NLS_INITCAP(T1.column_Name) 字段名, NLS_INITCAP(T1.data_Type) 类型,T1.Data_Length 长度 ,T2.COMMENTS 备注
FROM
  (SELECT *
   FROM user_tab_columns
   WHERE TABLE_NAME='{0}') T1
JOIN
  (SELECT *
   FROM user_col_comments
   WHERE TABLE_NAME='{0}') T2 ON T1.column_name=T2.column_Name", tableName);
            return ExcuteDataTable(mysql, conn);
        }

        public string GetConnectStr(string serverAddress, string port, string account, string password, string dbName)
        {
            return "Data Source=115.28.180.117;User Id=microcredit;Password=microcredit;Integrated Security=no;";
            string connection = string.Format("Data Source={0};User Id={1};Password={2};Integrated Security=no;"
                      , serverAddress
                      , account
                      , password);
            //if (!string.IsNullOrEmpty(dbName))
            //    connection += string.Format("Database='{0}';", dbName);
            //if (!string.IsNullOrEmpty(port))
            //    connection += string.Format("port='{0}';", port);
            return connection;
        }
    }
}
