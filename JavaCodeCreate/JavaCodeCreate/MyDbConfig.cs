using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate
{
    public class MyDbConfig
    {
        public string DbType { get; set; }
        public string Service { get; set; }
        public string Port { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string ConfigPath { get; set; }
        public List<string> DbNameList { get; set; }
        public List<string> TableList { get; set; }
        public string DbName { get; set; }
        public string TableMap { get; set; }
        public string Package { get; set; }
        public string OutputPath { get; set; }
        public string Dao { get; set; }
        public string Model { get; set; }
        public string Mapping { get; set; }
        public string SqlJarPath { get; set; }
        public string GeneratorJarPath { get; set; }
        public string SaveConfigPath { get; set; }
        public string SaveConfiName { get; set; }

    }
}
