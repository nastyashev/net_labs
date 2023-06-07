using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace lab2
{
    public static class ManageXML
    {
        public static void CreateXmlFile(string path, Data data)
        {
            using (var xw = XmlWriter.Create(path, new XmlWriterSettings { Indent = true, NewLineOnAttributes = true }))
            {
                var serializer = new XmlSerializer(data.GetType());
                serializer.Serialize(xw, data);
            }
        }

        public static Data OutputXmlFile(string path)
        {
            Data data;
            XmlSerializer ser = new XmlSerializer(typeof(Data));           
            using (Stream file = File.OpenRead(path))
            {
                data = (Data)ser.Deserialize(file);
            }
            return data;
        }
    }
}
