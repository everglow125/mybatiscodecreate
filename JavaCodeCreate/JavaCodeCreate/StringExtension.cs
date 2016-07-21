using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCodeCreate
{
    public static class StringExtension
    {
        public static string ToClassName(this string source)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(source).Replace("_", "");
        }
        public static string ToClassName(this string source, string prefix)
        {
            source = source.Trim();
            prefix = prefix.Trim();
            int index = source.ToLower().IndexOf(prefix.ToLower());
            if (index == 0)
                source = source.Substring(prefix.Length, source.Length - prefix.Length);
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(source).Replace("_", "");
        }
    }
}
