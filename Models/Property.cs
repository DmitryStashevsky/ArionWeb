using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Property : BaseStringEntity
    {
        public Property()
        {
            Descriptions = new List<Description>();
            Keys = new List<Key>();
        }

        public int PropertyType { get; set; } 
        public string Key { get; set; } 
        public float? Min { get; set; } 
        public float? Max { get; set; }
        public float? Default { get; set; }
        public bool Visible { get; set; }
        public string Access { get; set; }

        public IList<Description> Descriptions { get; set; }
        public IList<Key> Keys { get; set; }
    }
}
