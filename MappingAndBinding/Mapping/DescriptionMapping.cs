using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class DescriptionMapping : BaseStringEntityMapping<Description>
    {
        public DescriptionMapping()
            : base()
        {
            ToTable("Descriptions");

            HasMany(e => e.Properties);
            HasMany(e => e.Keys);
        }
    }
}
