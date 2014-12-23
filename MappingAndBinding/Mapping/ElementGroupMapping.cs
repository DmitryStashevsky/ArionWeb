using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class ElementGroupMapping : BaseStringEntityMapping<ElementGroup>
    {
        public ElementGroupMapping() : 
            base()
        {
            ToTable("ElementGroups");

            Property(e => e.Access);

            HasMany(e => e.Properties);
            HasRequired(e => e.Model);

            HasRequired(e => e.ElementClass);
            HasRequired(e => e.Position);
        }
    }
}
