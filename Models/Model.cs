using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Model : BaseStringEntity
    {
        public Model()
        {
            Coefficients = new List<Coefficient>();
        }

        public IList<Coefficient> Coefficients { get; set; }
    }
}
