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


        public DataTable QueryDatabases(string conn)
        {
            string mysql = "show databases;";
            return ExcuteDataTable(mysql, conn);
        }

        public string GetConnectStr(string serverAddress, string account, string password, string dbName)
        {
            string connection = string.Format("Data Source={0};User ID={1};Password={2};CharSet=utf8;port=3306;"
                      , serverAddress
                      , account
                      , password);
            if (!string.IsNullOrEmpty(dbName))
                connection += string.Format("Database='{0}';", dbName);
            return connection;
        }
    }
}
