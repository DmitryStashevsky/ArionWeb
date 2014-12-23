using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ElementClass : BaseStringEntity
    {
        public ElementClass()
        {
            Positions = new List<Position>();
        }

        public IList<Position> Positions { get; set; }
    }
}
