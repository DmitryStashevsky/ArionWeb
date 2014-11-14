using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DatabaseGenerator.XmlDeserialize
{
    public class Key
    {
        [XmlAttribute("Key")]
        public string InternalKey { get; set; }

        [XmlAttribute("Default")]
        public string Default { get; set; }
    }
}
