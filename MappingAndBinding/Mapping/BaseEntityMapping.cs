using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class BaseEntityMapping<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseEntityMapping()
        {
            HasKey(e => e.Id);
        }
    }
}
