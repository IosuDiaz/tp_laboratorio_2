using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Products;
using Entities.Components;
using static System.Environment;

namespace Factory_Console
{
    class Program
    {
        static void Main(string[] args)
        {


            Processor p1 = new Processor("Intel", "i9 10900");
            Processor p2 = new Processor("Intel", "i9 10900");

            Console.WriteLine(p1.Equals(p2));


            //Factory.SaveCurrentStock("productos.xml","componentes.xml");

            //Console.WriteLine(Factory.ListPrimaryStock());
            //Console.WriteLine("----------------------------COMPONENTES----------------------------");
            //Console.WriteLine(Factory.ListSecondaryStock());


            Console.ReadLine();
        }
    }
}
