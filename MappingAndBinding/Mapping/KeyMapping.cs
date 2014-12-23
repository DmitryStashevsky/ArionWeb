using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingAndBinding.Mapping;
using Models;

namespace MappingAndBinding.Mapping
{
    public class KeyMapping : BaseEntityMapping<Key>
    {
        public KeyMapping()
            : base()
        {
            ToTable("Keys");

            Property(e => e.KeyName).IsRequired();
            Property(e => e.Default).IsOptional();
        }
    }
}
