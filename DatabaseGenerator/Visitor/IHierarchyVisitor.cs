using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseGenerator.XmlDeserialize;

namespace DatabaseGenerator.Visitor
{
    public interface IHierarchyVisitor
    {
        void Visit(Hierarchy hierarchy);
    }
}
