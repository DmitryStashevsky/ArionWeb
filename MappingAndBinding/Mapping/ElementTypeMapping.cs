using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class ElementTypeMapping : EntityTypeConfiguration<ElementType>
    {
        public ElementTypeMapping()
        {
            ToTable("ElementTypies");

            Property(e => e.Name).IsRequired();
        }
    }
}
