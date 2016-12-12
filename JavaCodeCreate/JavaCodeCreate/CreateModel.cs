using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JavaCodeCreate
{
    public class CreateModel
    {
        private static string GetColumnDefinition(DbColumnMapping column)
        {
            if (column.DbColumnName == "create_by" || column.DbColumnName == "create_time") return "";
            return string.Format(
                    "\n\t\t/// <summary> \n\t\t/// {0} \n\t\t/// </summary> \n\t\t[DisplayName(\"{0}\")] \n\t\t[ColumnMapping(Name=\"{3}\")] \n\t\tpublic {1} {2} {{ get; set; }}"
                    , column.Comment, column.ColumnType, column.ColumnName, column.DbColumnName);
        }

        private static string GetTrimColumn(string columnName)
        {
            return string.Format("\n\t\t\tthis.{0} = (this.{0} ?? \"\").Trim();", columnName);

        }

        public static void Excute(DbTableMapping table, string filePath)
        {
            filePath = filePath + "Entity/";
            string fileName = filePath + table.ClassName + ".cs";
            StringBuilder sbColumns = new StringBuilder();
            StringBuilder sbTrims = new StringBuilder();
            foreach (var item in table.Columns)
            {

                sbColumns.AppendLine(GetColumnDefinition(item));
                if (item.ColumnType == "string")
                    sbTrims.AppendLine(GetTrimColumn(item.ColumnName));
            }
            string tempPath = System.Environment.CurrentDirectory + "/templet/Model.txt";

            var contentTmp = "";
            using (StreamReader sr = new StreamReader(tempPath))
            {
                contentTmp = sr.ReadToEnd();
            }
            string content = string.Format(contentTmp, table.ClassName, table.Comment, sbColumns.ToString(), sbTrims.ToString());

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            if (File.Exists(fileName))
                File.Delete(fileName);
            using (StreamWriter sw = new StreamWriter(fileName))
                sw.WriteLine(content);

        }
    }
}
