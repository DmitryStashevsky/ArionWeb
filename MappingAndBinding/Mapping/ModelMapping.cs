using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class ModelMapping : BaseStringEntityMapping<Model>
    {
        public ModelMapping()
            : base()
        {
            ToTable("Models");

            HasMany(e => e.Coefficients);
        }
    }
}
