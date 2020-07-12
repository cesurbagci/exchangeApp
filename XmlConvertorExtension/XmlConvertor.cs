using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace XmlConvertorExtension
{
    public static class XmlConvertor
    {
        public static string ConvertToXml<T>(this List<T> items) 
        {
            XmlSerializer XML = new XmlSerializer(typeof(List<T>));
            using (var stringWriter = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(stringWriter))
                {
                    XML.Serialize(writer, items);
                    
                    return stringWriter.ToString();
                }
            }
        }
    }
}
