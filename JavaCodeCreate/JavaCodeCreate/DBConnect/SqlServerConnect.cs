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
        public DataTable QueryColumns(string conn, string tableName, string dbName = "")
        {
            string mysql = string.Format(
@"SELECT 
Convert(varchar,T1.Name) as '字段名',--字段名
Convert(varchar,T2.Name) as '类型',--字段类型
T1.prec as '长度',--最大长度
Convert(varchar,T5.COLUMN_DEFAULT) as '默认值',--默认值
Convert(varchar,T4.value) as '备注',--描述
T1.isnullable as '可空'--是否为空
FROM syscolumns T1   
LEFT JOIN systypes T2 ON T1.xusertype=T2.xusertype   
INNER JOIN sysobjects T3 ON T1.id=T3.id AND T3.xtype='U ' AND T3.name<>'dtproperties '   
LEFT JOIN sys.extended_properties T4 ON T1.id=T4.major_id AND T1.colid = T4.minor_id   
join  information_schema.columns T5 on T1.name=T5.COLUMN_NAME and T5.TABLE_NAME='{0}'
WHERE T3.name='{0}'", tableName);
            return ExecuteDataTable(conn, mysql);
        }
        public DataTable QueryDataTablesFull(string conn, string dbName = "")
        {
            string mysql = @"SELECT  a.name AS 'TABLE_NAME' ,
        ISNULL(g.[value], '') AS 'comments' 
FROM    sys.tables a
        LEFT JOIN sys.extended_properties g ON ( a.object_id = g.major_id
                                                 AND g.minor_id = 0
                                               )
WHERE   a.name <> 'sysdiagrams'
ORDER BY a.name;";
            return ExecuteDataTable(conn, mysql);
        }

        public List<string> QueryDataTables(string conn)
        {
            string sql = "SELECT  name FROM  sysobjects WHERE   xtype = 'U' ORDER BY name;";
            return ExecuteDataTable(conn, sql).ToStringList();
        }

        public string GetConnectStr(string serverAddress, string port, string account, string password, string dbName)
        {
            string connection = "";
            if (account != "" && password != "")
            {
                connection = string.Format("Data Source={0};User Id={1};Password={2};"
                                       , serverAddress
                                       , account
                                       , password);
                if (!string.IsNullOrEmpty(dbName))
                    connection += string.Format("Initial Catalog={0};", dbName);
            }
            else
            {
                connection = string.Format("Server={0};Trusted_Connection=Yes;Connect Timeout=90;", serverAddress);
                if (!string.IsNullOrEmpty(dbName))
                    connection += string.Format("Database={0};", dbName);
            }

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
