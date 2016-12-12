using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate
{
    public static class DbMappingHelper
    {
        /// <summary>
        /// 转换成类名
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static string ToClassName(this string tableName)
        {
            if (string.IsNullOrEmpty(tableName)) return "";
            StringBuilder sb = new StringBuilder();
            string[] words = tableName.Split('_');
            foreach (var item in words)
                sb.Append(System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(item));
            if (sb.ToString().EndsWith("ies"))
                return sb.ToString().Substring(0, sb.Length - 3) + "y";
            else if (sb.ToString().EndsWith("s"))
                return sb.ToString().Substring(0, sb.Length - 1);
            else return sb.ToString();
        }
        /// <summary>
        /// 转换成字段名
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string ToFieldName(this string columnName)
        {
            if (string.IsNullOrEmpty(columnName)) return "";
            StringBuilder sb = new StringBuilder();
            string[] words = columnName.Split('_');
            foreach (var item in words)
                sb.Append(System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(item));
            return sb.ToString();
        }
        /// <summary>
        /// 转换成字段类型
        /// </summary>
        /// <param name="columnType"></param>
        /// <returns></returns>
        public static string ToFieldType(this string columnType)
        {
            if (string.IsNullOrEmpty(columnType)) return "";
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

    }
}
