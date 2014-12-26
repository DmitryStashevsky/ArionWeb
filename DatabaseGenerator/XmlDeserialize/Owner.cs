using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DatabaseGenerator.XmlDeserialize
{
   public class Owner
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlElement("group")]
        public Group[] Groups { get; set; }
    }
}
