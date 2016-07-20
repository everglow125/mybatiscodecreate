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
        DataTable QueryDatabases(string conn);
        string GetConnectStr(string serverAddress, string account, string password, string dbName);
    }
}
