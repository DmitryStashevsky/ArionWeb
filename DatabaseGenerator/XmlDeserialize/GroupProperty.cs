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
        [XmlAttribute("Id")]
        public int Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Type")]
        public int Type { get; set; }

        [XmlAttribute("L")]
        public float L { get; set; }

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

        [XmlElement("ans")]
        public PropertyOption[] PropertyOptions { get; set; }

        [XmlElement("model")]
        public GroupModel GroupModel { get; set; }
    }
}
