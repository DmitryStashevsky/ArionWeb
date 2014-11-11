using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DatabaseGenerator.XmlDeserialize
{
    public class XmlHelper
    {
        public Hierarchy GetHierarchy(string pathToXml)
        {
            using (var fs = new FileStream(pathToXml, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Hierarchy));
                XmlReader reader = XmlReader.Create(fs);
                var s = serializer.Deserialize(reader);
                return (Hierarchy)s;
            }
        }
    }
}
