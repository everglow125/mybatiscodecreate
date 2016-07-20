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
        public DataTable QueryDatabases(string conn)
        {
            return null;
        }
        public string GetConnectStr(string serverAddress, string account, string password, string dbName)
        {
            return null;
        }
    }
}
