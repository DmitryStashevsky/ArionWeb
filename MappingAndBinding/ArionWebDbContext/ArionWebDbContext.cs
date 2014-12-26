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
            Database.SetInitializer<ArionWebDbContext>(new CreateDatabaseIfNotExists<ArionWebDbContext>());
        }

        public ArionWebDbContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ArionWebDbContext>(new DropCreateDatabaseAlways<ArionWebDbContext>());
            modelBuilder.Configurations.Add(new CoefficientMapping());
            modelBuilder.Configurations.Add(new DescriptionMapping());
            modelBuilder.Configurations.Add(new ElementClassMapping());
            modelBuilder.Configurations.Add(new ElementGroupMapping());
            modelBuilder.Configurations.Add(new ElementMapping());
            modelBuilder.Configurations.Add(new KeyMapping());
            modelBuilder.Configurations.Add(new ModelMapping());
            modelBuilder.Configurations.Add(new PositionMapping());
            modelBuilder.Configurations.Add(new PropertyMapping());
        }
    }
}
