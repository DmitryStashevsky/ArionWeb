using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseGenerator;
using DatabaseGenerator.MsAccess;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key for staring generation");
            //var dataMining = new DataMining();
            //dataMining.Mining("ИМС отечественные гибридные");
            var generator = new GenerateDatabase();
            Console.ReadKey();
        }
    }
}
