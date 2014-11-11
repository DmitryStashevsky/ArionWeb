using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DatabaseGenerator.XmlDeserialize
{
    [XmlRootAttribute("group")]
    public class Group
    {
        [XmlAttribute("Id")]
        public int Id { get; set; }
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Access")]
        public string Access { get; set; }

        [XmlElement("prop")]
        public GroupProperty[] GroupProperties { get; set; }

        [XmlElement("model")]
        public GroupModel GroupModel { get; set; }
    }
}
