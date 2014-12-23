using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Position : BaseStringEntity
    {
        public Position()
        {
            ElementGroups = new List<ElementGroup>();
        }

        public IList<ElementGroup> ElementGroups { get; set; }
    }
}
