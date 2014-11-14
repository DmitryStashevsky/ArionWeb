using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DatabaseGenerator.XmlDeserialize
{
    public class Coefficient
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Key")]
        public string Key { get; set; }

        [XmlAttribute("Default")]
        public string Default { get; set; }
    }
}
