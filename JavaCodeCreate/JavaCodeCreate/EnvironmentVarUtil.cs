using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate
{
    public class EnvironmentVarUtil
    {
        //CLASSPATH
        public static IDictionary GetAllValues()
        {
            return System.Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine);

        }
        public static string GetValue(string key)
        {
            return System.Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.Machine);
        }
        public static void SetValue(string key, string value)
        {
            System.Environment.SetEnvironmentVariable(key, value, EnvironmentVariableTarget.Machine);
        }
    }
}
