using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate
{
    public class CreateGlobal
    {
        public static void Excute(List<DbTableMapping> tables, string filePath)
        {
            string tempPath = System.Environment.CurrentDirectory + "/templet/Global.txt";

            var contentTmp = "";
            using (StreamReader sr = new StreamReader(tempPath))
            {
                contentTmp = sr.ReadToEnd();
            }
            StringBuilder sbcontent = new StringBuilder();
            foreach (var item in tables)
            {
                sbcontent.AppendLine(GetDefind(item.ClassName, item.Comment));
            }
            string content = string.Format(contentTmp, sbcontent.ToString());
            filePath = filePath;
            string fileName = filePath + "Global.asax.cs";
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            if (File.Exists(fileName))
                File.Delete(fileName);
            using (StreamWriter sw = new StreamWriter(fileName))
                sw.WriteLine(content);
        }


        public static string GetDefind(string className, string comment)
        {
            return string.Format("\t\t\t#region {1}\n\t\t\tbuilder.RegisterType<{0}Dal>().As<I{0}Dal>().InstancePerRequest();\n\t\t\tbuilder.RegisterType<{0}Bll>().As<I{0}Bll>().InstancePerRequest();\n\t\t\t#endregion", className, comment);
        }
    }
}
