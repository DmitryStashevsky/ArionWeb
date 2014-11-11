using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class ManufacturingTechnologyMapping : EntityTypeConfiguration<ManufacturingTechnology>
    {
        public ManufacturingTechnologyMapping()
        {
            ToTable("ManufacturingTechnologies");

            Property(e => e.Name).IsRequired();
        }
    }
}
