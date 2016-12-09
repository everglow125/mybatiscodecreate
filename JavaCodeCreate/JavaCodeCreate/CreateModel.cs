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
        private string GetColumnDefinition(string columnName, string columnType, string columnComment, string orgColumnName)
        {
            return string.Format(
"\n/// <summary> \n/// {0} \n/// </summary> \n[DisplayName(\"{0}\")] \n[ColumnMapping(Name=\"{3}\")] \npublic {1} {2} {{ get; set; }}", columnComment, columnType, columnName, orgColumnName);
        }

        private string GetTrimColumn(string columnName)
        {
            return string.Format("this.{0} = (this.{0} ?? \"\").Trim();", columnName);

        }

        private string GetColumnName(string columnName)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = columnName.Split('_');
            foreach (var item in words)
                sb.Append(System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(item));
            return sb.ToString();
        }

        private string GetTableName(string tableName)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = tableName.Split('_');
            foreach (var item in words)
                sb.Append(System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(item));
            if (sb.ToString().EndsWith("s"))
                return sb.ToString().Substring(0, sb.Length - 1);
            else return sb.ToString();
        }

        private string GetColumnType(string columnType)
        {
            columnType = columnType.Trim().ToLower();
            string result = "";
            switch (columnType)
            {
                case "varchar":
                case "nvarchar":
                case "char":
                case "nchar":
                case "text":
                case "ntext": result = "string"; break;
                case "int": result = "int"; break;
                case "bigint": result = "long"; break;
                case "float": result = "double"; break;
                case "decimal": result = "decimal"; break;
                case "date":
                case "datetime": result = "DateTime"; break;
                case "bit": result = "bool"; break;
            }
            return result;
        }


        public void Excute(string tableName, string tableComment, DataTable source, string filePath)
        {
            filePath = filePath + "Entity/";
            tableName = GetTableName(tableName);
            string fileName = filePath + tableName + ".cs";
            StringBuilder sbColumns = new StringBuilder();
            StringBuilder sbTrims = new StringBuilder();
            foreach (DataRow dr in source.Rows)
            {
                string columnName = dr["字段名"].ToString().Trim();
                string columnType = dr["类型"].ToString().Trim();
                string columnComment = dr["备注"].ToString().Trim();
                string newColumnName = GetColumnName(columnName);
                columnType = GetColumnType(columnType);
                sbColumns.AppendLine(GetColumnDefinition(newColumnName, columnType, columnComment, columnName));
                if (columnType == "string")
                    sbTrims.AppendLine(GetTrimColumn(newColumnName));
            }
            string content = string.Format(
                @"using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Common;
namespace Entity.LogicModel
{{
	/// <summary>
        /// {1}
        /// </summary>
 [Serializable]
    public class {0}
    {{
	{2}

        public void TrimColumns()
        {{
            {3}
        }}
    }}

}}", tableName, tableComment, sbColumns.ToString(), sbTrims.ToString());

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
