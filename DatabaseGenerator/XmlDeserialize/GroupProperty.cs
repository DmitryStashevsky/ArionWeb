using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DatabaseGenerator.XmlDeserialize
{
    public class GroupProperty
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Type")]
        public int Type { get; set; }

        [XmlAttribute("Min")]
        public string Min { get; set; }

        [XmlAttribute("Max")]
        public string Max { get; set; }

        [XmlAttribute("Key")]
        public string Key { get; set; }

        [XmlAttribute("Default")]
        public string Default { get; set; }

        [XmlAttribute("Visible")]
        public bool IsVisible { get; set; }

        [XmlAttribute("Access")]
        public string Access { get; set; }

        [XmlElement("ans")]
        public PropertyOption[] PropertyOptions { get; set; }
    }
}
