using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DatabaseGenerator.XmlDeserialize
{
    public class Hierarchy
    {
        [XmlElement("class")]
        public ElementClass[] ElementClasses { get; set; }
    }
}
