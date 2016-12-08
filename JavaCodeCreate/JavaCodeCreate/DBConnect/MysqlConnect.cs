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

        public DataTable QueryColumns(string conn, string tableName, string dbName = "")
        {
            string sql = string.Format(@"select Column_Name '字段名',Data_type '类型',Is_Nullable '可空',CHARACTER_MAXIMUM_LENGTH '长度',column_type,COLUMN_COMMENT '备注'
from INFORMATION_SCHEMA.COLUMNS  
Where table_name = '{0}'
AND table_schema = '{1}';", tableName, dbName);
            return ExcuteDataTable(sql, conn);
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
        public DataTable QueryDataTablesFull(string conn, string dbName = "")
        {
            string sql = string.Format(@"Select table_name as TABLE_NAME,table_comment as comments from INFORMATION_SCHEMA.TABLES where engine='InnoDB' and TABLE_SCHEMA='{0}'", dbName);
            return ExcuteDataTable(sql, conn);
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
