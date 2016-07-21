using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate
{
    public class DbConfig
    {

        public string Account { get; set; }
        public string DaoFilePath { get; set; }
        public string DaoPackage { get; set; }
        public string DbName { get; set; }
        public List<string> DbNameList { get; set; }
        public string DbType { get; set; }
        public string MappingFilePath { get; set; }
        public string MappingPackage { get; set; }
        public string ModelFilePath { get; set; }
        public string ModelPackage { get; set; }
        public string Password { get; set; }
        public string Service { get; set; }
        public string SqlJarPath { get; set; }
        public List<string> TableList { get; set; }
        public string TableMappings { get; set; }
        public string TempletFilePath { get; set; }
        public string TempletPackage { get; set; }
        public string XMLPath { get; set; }
        public bool TempletChecked { get; set; }
        public string Port { get; set; }
    }
}
