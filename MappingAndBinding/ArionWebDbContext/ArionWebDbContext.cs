using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MappingAndBinding.Mapping;

namespace MappingAndBinding.ArionWebDbContext
{
    public class ArionWebDbContext : DbContext
    {
        public ArionWebDbContext()
            : base("DefaultConnection")
        {
            
        }

        public ArionWebDbContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ArionWebDbContext>());
            modelBuilder.Configurations.Add(new ElementMapping());
            modelBuilder.Configurations.Add(new ElementTypeMapping());
           // modelBuilder.Configurations.Add(new ManufacturingTechnologyMapping());
           // modelBuilder.Configurations.Add(new SpecificationMapping());
           //modelBuilder.Configurations.Add(new TypeOfHousingMapping());
        }
    }
}
