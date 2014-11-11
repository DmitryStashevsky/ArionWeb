using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class ElementMapping : EntityTypeConfiguration<Element>
    {
        public ElementMapping()
        {
            ToTable("Elements");

            Property(e => e.Name).IsRequired();
            Property(e => e.IsNative).IsRequired();
            Property(e => e.FailureRate).IsOptional();
            Property(e => e.FailureRateSwitch).IsOptional();
            Property(e => e.SubType).IsOptional();
            Property(e => e.TemperatureMax).IsOptional();
            Property(e => e.TemperatureSuperheat).IsOptional();
            Property(e => e.TemperatureTransition).IsOptional();
            Property(e => e.Quantity).IsOptional();

            HasRequired(e => e.ElementType);
            HasRequired(e => e.Specification);

            HasOptional(e => e.ManufacturingTechnology);
            HasOptional(e => e.TypeOfHousing);
        }
    }
}
