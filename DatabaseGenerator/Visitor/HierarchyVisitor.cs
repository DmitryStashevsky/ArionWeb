using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseGenerator.Mapping;
using DatabaseGenerator.XmlDeserialize;
using Repositories.Interfaces;

namespace DatabaseGenerator.Visitor
{
    public class HierarchyVisitor : IHierarchyVisitor
    {
        public HierarchyVisitor()
        {
            AutoMapperConfigurationForGenerator.Configure();
        }

        public void Visit(Hierarchy hierarchy)
        {
            Parallel.ForEach (hierarchy.ElementClasses, elementClass => 
                {
                    Visit(elementClass);
                });
        }

        protected void Visit(ElementClass elementClass)
        {
            //Positions count = 2, no sense use parallel foreach
            foreach (var owner in elementClass.Owner)
            {
                Visit(owner);
            }
        }

        protected void Visit(Owner owner)
        {
        }
    }
}
