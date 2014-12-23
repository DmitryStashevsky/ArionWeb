using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Description : BaseStringEntity
    {
        public Description()
        {
            Properties = new List<Property>();
            Keys = new List<Key>();
        }
        
        public IList<Property> Properties { get; set; }
        public IList<Key> Keys { get; set; }
    }
}
