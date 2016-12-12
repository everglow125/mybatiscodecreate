using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate
{
    public class CreateIBll
    {
        public static void Excute(DbTableMapping table, string filePath)
        {
            string tempPath = System.Environment.CurrentDirectory + "/templet/ILogicModel.txt";

            var contentTmp = "";
            using (StreamReader sr = new StreamReader(tempPath))
            {
                contentTmp = sr.ReadToEnd();
            }
            string content = string.Format(contentTmp, table.ClassName);
            filePath = filePath + "ILogic/";
            string fileName = filePath + "I" + table.ClassName + "Bll.cs";
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
