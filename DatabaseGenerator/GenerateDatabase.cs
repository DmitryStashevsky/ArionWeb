using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseGenerator.XmlDeserialize;

namespace DatabaseGenerator
{
    public class GenerateDatabase
    {
        public GenerateDatabase()
        {
            XmlHelper helper = new XmlHelper();
            var hierarchy = helper.GetHierarchy(@"D:\Classifier.xml");
        }
    }
}
