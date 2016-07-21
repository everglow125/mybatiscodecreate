using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace JavaCodeCreate
{
    public static class SerializerHelper
    {
        /// <summary>
        /// json序列化
        /// </summary>
        /// <returns>json格式字符串</returns>
        public static string JsonSerialize<T>(this T obj)
        {
            return (new JavaScriptSerializer()).Serialize(obj);
        }
        /// <summary>
        /// json反序列化
        /// </summary>
        /// <returns>泛型对象</returns>
        public static T JsonDeserialize<T>(this string json)
        {
            return (new JavaScriptSerializer()).Deserialize<T>(json);
        }
        /// <summary>
        /// XML序列化
        /// </summary>
        /// <returns>字符串类型</returns>
        public static string XMLSerialize<T>(this T obj)
        {
            string result = "";
            using (StringWriter sw = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(sw, obj, null);
                result = sw.ToString();
            }
            return result;
        }
        /// <summary>
        /// XML反序列化
        /// </summary>
        /// <returns>泛型对象</returns>
        public static T XMLDeserialize<T>(this string xml)
        {
            T result = default(T);
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                result = (T)serializer.Deserialize(sr);
            }
            return result;
        }
    }
}
