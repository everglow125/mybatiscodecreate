
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate
{
    public static class DataTableHelper
    {
        public static List<string> ToStringList(this DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return null;
            List<string> result = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                result.Add(dr[0].ToString());
            }
            return result;
        }
    }
}
