using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class BaseStringEntityMapping<T> : BaseEntityMapping<T> where T : BaseStringEntity
    {
        public BaseStringEntityMapping() : base()
        {
            Property(e => e.Name).IsRequired();
        }
    }
}
