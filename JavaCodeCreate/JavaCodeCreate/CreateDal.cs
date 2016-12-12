using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate
{
    public class CreateDal
    {
        public static void Excute(DbTableMapping table, string filePath)
        {
            string tempPath = System.Environment.CurrentDirectory + "/templet/DataBase.txt";

            var contentTmp = "";
            using (StreamReader sr = new StreamReader(tempPath))
            {
                contentTmp = sr.ReadToEnd();
            }
            string insertSql = GetInsert(table);
            string updateSql = GetUpdate(table);
            string content = string.Format(contentTmp, table.ClassName, table.TableName, table.DbPrimeyKey, insertSql, updateSql);
            filePath = filePath + "DataBase/";
            string fileName = filePath + table.ClassName + "Dal.cs";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            if (File.Exists(fileName))
                File.Delete(fileName);
            using (StreamWriter sw = new StreamWriter(fileName))
                sw.WriteLine(content);
        }


        private static string GetInsert(DbTableMapping table)
        {
            StringBuilder sbInsert = new StringBuilder();
            sbInsert.AppendFormat("Insert into {0} (", table.TableName);
            sbInsert.Append(string.Join(",", table.Columns.Where(x => !x.IsPrimeyKey).Select(x => x.DbColumnName)));
            sbInsert.Append(") values (");
            sbInsert.Append(string.Join(",", table.Columns.Where(x => !x.IsPrimeyKey).Select(x => "@" + x.ColumnName)));
            sbInsert.Append(")");
            return sbInsert.ToString();
        }

        private static string GetUpdate(DbTableMapping table)
        {
            StringBuilder sbInsert = new StringBuilder();
            sbInsert.AppendFormat("Update {0} with(RowLock) set ", table.TableName);
            sbInsert.Append(string.Join(",", table.Columns.Where(x => !x.IsPrimeyKey).Select(x => x.DbColumnName + "= @" + x.ColumnName)));
            sbInsert.AppendFormat(" where {0}=@{1}", table.DbPrimeyKey, table.DbPrimeyKey.ToFieldName());
            return sbInsert.ToString();
        }
    }
}
