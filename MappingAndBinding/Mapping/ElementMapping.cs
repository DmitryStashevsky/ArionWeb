using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class ElementMapping : BaseStringEntityMapping<Element>
    {
        public ElementMapping() : base()
        {
            ToTable("Elements");

            Property(e => e.Specification).IsOptional();
            Property(e => e.FailureRate).IsOptional();
            Property(e => e.FailureRateSwitch).IsOptional();
            Property(e => e.SubType).IsOptional();
            Property(e => e.TemperatureMax).IsOptional();
            Property(e => e.TemperatureSuperheat).IsOptional();
            Property(e => e.TemperatureTransition).IsOptional();
            Property(e => e.Quantity).IsOptional();
            Property(e => e.ManufacturingTechnology).IsOptional();
            Property(e => e.TypeOfHousing).IsOptional();

            HasRequired(e => e.ElementClass);
            HasRequired(e => e.ElementGroup);
            HasRequired(e => e.Position);
        }
    }
}
