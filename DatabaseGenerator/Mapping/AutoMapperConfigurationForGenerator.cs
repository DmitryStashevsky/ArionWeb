using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DatabaseGenerator.XmlDeserialize;


namespace DatabaseGenerator.Mapping
{
    public static class AutoMapperConfigurationForGenerator
    {
        public static void Configure()
        {
            Mapper.CreateMap<Coefficient, Models.Coefficient>();
            Mapper.CreateMap<ElementClass, Models.ElementClass>();
            Mapper.CreateMap<Group, Models.ElementGroup>();
            Mapper.CreateMap<GroupModel, Models.Model>();
            Mapper.CreateMap<GroupProperty, Models.Property>();
            Mapper.CreateMap<Key, Models.Key>();
            Mapper.CreateMap<Owner, Models.Position>();
            Mapper.CreateMap<PropertyOption, Models.Description>();
        }
    }
}
