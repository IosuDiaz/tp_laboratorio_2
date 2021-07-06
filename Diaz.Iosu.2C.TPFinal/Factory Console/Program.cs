using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Products;
using Entities.Components;

namespace Factory_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Component c;


            c = Assembler<Motherboard>.Assemble();

            c.Brand = "Gigabyte";
            c.Model = "H310";

            Console.WriteLine(c.ToString());



            //Factory.SaveCurrentStock("productos.xml","componentes.xml");

            //Console.WriteLine(Factory.ListPrimaryStock());
            //Console.WriteLine("----------------------------COMPONENTES----------------------------");
            //Console.WriteLine(Factory.ListSecondaryStock());


            Console.ReadLine();
        }
    }
}
