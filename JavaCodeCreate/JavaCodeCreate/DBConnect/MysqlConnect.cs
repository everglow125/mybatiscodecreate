using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate.DBConnect
{
    public class MysqlConnect : IDbConnect
    {


        private DataTable ExcuteDataTable(string sql, string conn)
        {
            using (MySqlConnection myconnection = new MySqlConnection(conn))
            {
                myconnection.Open();
                DataSet ds = new DataSet();
                try
                {
                    MySqlDataAdapter command = new MySqlDataAdapter(sql, myconnection);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                if (ds != null && ds.Tables.Count > 0)
                    return ds.Tables[0];
            }
            return null;
        }

        public DataTable QueryColumns(string conn, string tableName) {
            return null;
        }

        public List<string> QueryDatabases(string conn)
        {
            string mysql = "show databases;";
            return ExcuteDataTable(mysql, conn).ToStringList();
        }

        public List<string> QueryDataTables(string conn)
        {
            string mysql = "show tables;";
            return ExcuteDataTable(mysql, conn).ToStringList();
        }

        public string GetConnectStr(string serverAddress, string port, string account, string password, string dbName)
        {
            string connection = string.Format("Data Source={0};User ID={1};Password={2};CharSet=utf8;"
                      , serverAddress
                      , account
                      , password);
            if (!string.IsNullOrEmpty(dbName))
                connection += string.Format("Database='{0}';", dbName);
            if (!string.IsNullOrEmpty(port))
                connection += string.Format("port='{0}';", port);
            return connection;
        }
    }
}
