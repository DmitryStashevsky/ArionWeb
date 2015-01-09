using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseGenerator.Mapping;
using DatabaseGenerator.Visitor;
using DatabaseGenerator.XmlDeserialize;
using MappingAndBinding.ArionWebDbContext;

namespace DatabaseGenerator
{
    public class GenerateDatabase
    {
        public GenerateDatabase()
        {
            //add automapper configuration
            AutoMapperConfigurationForGenerator.Configure();
            //process xml file
            XmlHelper helper = new XmlHelper();
            var hierarchy = helper.GetHierarchy(@"D:\Classifier.xml");
            //save xml entities to SQL
            HierarchyVisitor.Visit(hierarchy);
        }
    }
}
