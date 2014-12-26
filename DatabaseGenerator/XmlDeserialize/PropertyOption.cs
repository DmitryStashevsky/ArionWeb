using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DatabaseGenerator.XmlDeserialize
{
    public class PropertyOption
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlElement("prop")]
        public GroupProperty[] GroupProperty { get; set; }

        [XmlElement("key")]
        public Key[] Keys { get; set; }
    }
}
