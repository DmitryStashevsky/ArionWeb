using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ElementGroup : BaseStringEntity
    {
        public ElementGroup()
        {
            Properties = new List<Property>();
        }

        public string Access { get; set; }
        //Navigation
        public int ModelId { get; set; }
        public Model Model { get; set; }

        public int ElementClassId { get; set; }
        public ElementClass ElementClass { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public IList<Property> Properties { get; set; }
    }
}
