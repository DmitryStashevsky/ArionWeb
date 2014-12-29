using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace MappingAndBinding.Mapping
{
    public class PositionMapping : BaseStringEntityMapping<Position>
    {
        public PositionMapping()
            : base()
        {
            ToTable("Positions");

            HasRequired(e => e.ElementClass).WithMany(e => e.Positions).HasForeignKey(e => e.ElementClassId).WillCascadeOnDelete(false);
        }
    }
}
