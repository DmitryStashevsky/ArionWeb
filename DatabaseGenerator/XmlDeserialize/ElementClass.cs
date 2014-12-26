using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DatabaseGenerator.XmlDeserialize
{
    public class ElementClass
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlElement("owner")]
        public Owner[] Owner { get; set; }
    }
}
