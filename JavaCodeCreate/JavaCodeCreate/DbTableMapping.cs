using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate
{
    /// <summary>
    /// 数据库表映射
    /// </summary>
    public class DbTableMapping
    {
        /// <summary>
        /// 数据库表名
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// 表名转换的类名
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 表注释 表说明
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// 数据表中主键
        /// </summary>
        public string DbPrimeyKey { get; set; }
        /// <summary>
        /// 数据库中所有列名
        /// </summary>
        public List<DbColumnMapping> Columns { get; set; }
    }

    /// <summary>
    /// 数据库字段名映射
    /// </summary>
    public class DbColumnMapping
    {
        /// <summary>
        /// 数据库列名
        /// </summary>
        public string DbColumnName { get; set; }
        /// <summary>
        /// 程序中字段名
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// 数据库中字段类型
        /// </summary>
        public string DBColumnType { get; set; }
        /// <summary>
        /// 程序中字段类型
        /// </summary>
        public string ColumnType { get; set; }
        /// <summary>
        /// 是否主键
        /// </summary>
        public bool IsPrimeyKey { get; set; }
    }
}
