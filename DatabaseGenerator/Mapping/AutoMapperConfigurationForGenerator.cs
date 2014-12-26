using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DatabaseGenerator.XmlDeserialize;
using DatabaseGenerator.Extensions;


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
            Mapper.CreateMap<GroupProperty, Models.Property>().ForMember(e => e.Default, o => o.MapFrom(s => s.Default.ToNullable<float>()))
                .ForMember(e => e.Min, o => o.MapFrom(s => s.Min.ToNullable<float>()))
                .ForMember(e => e.Max, o => o.MapFrom(s => s.Max.ToNullable<float>()))
                .ForMember(e => e.PropertyType, o => o.MapFrom(s => s.Type))
                .ForMember(e => e.Visible, o => o.MapFrom(s => s.IsVisible));
            Mapper.CreateMap<Key, Models.Key>().ForMember(e => e.KeyName, o => o.MapFrom(s => s.InternalKey))
                .ForMember(e => e.Default, o => o.MapFrom(s => s.Default.ToNullable<float>()));
            Mapper.CreateMap<Owner, Models.Position>();
            Mapper.CreateMap<PropertyOption, Models.Description>();
        }
    }
}
