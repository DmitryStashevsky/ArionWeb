using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class CoefficientMapping : BaseStringEntityMapping<Coefficient>
    {
        public CoefficientMapping() : base()
        {
            ToTable("Coefficients");

            Property(e => e.Key).IsRequired();
            Property(e => e.Default).IsRequired();
        }
    }
}
