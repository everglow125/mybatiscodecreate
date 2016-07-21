using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate.DBConnect
{
    public interface IDbConnect
    {
        List<string> QueryDatabases(string conn);
        List<string> QueryDataTables(string conn);
        string GetConnectStr(string serverAddress, string port, string account, string password, string dbName);
    }
}
