using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate.DBConnect
{
    public class SqlServerConnect : IDbConnect
    {

        public List<string> QueryDatabases(string conn)
        {
            string sql = "select [name] from [sysdatabases] order by [name]";
            return ExecuteDataTable(conn, sql).ToStringList();
        }

        public List<string> QueryDataTables(string conn)
        {
            string sql = "SELECT  name FROM  sysobjects WHERE   xtype = 'U' ORDER BY name;";
            return ExecuteDataTable(conn, sql).ToStringList();
        }

        public string GetConnectStr(string serverAddress, string port, string account, string password, string dbName)
        {
            string connection = string.Format("Data Source={0};User Id={1};Password={2};"
                                  , serverAddress
                                  , account
                                  , password);
            if (!string.IsNullOrEmpty(dbName))
                connection += string.Format("Initial Catalog={0};", dbName);
            return connection;
        }

        public DataTable ExecuteDataTable(string constr, string cmdText)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                DataSet ds = new DataSet();
                try
                {
                    SqlDataAdapter command = new SqlDataAdapter(cmdText, cnn);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                if (ds != null && ds.Tables.Count > 0)
                    return ds.Tables[0];
                return null;
            }
        }
    }
}
