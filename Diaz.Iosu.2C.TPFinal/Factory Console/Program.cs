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
            
            


            PC primeraCompu = new PC("Computadora de Escritorio", Guid.NewGuid(), 0001,"White" , new Motherboard("ASUS","z490",new Processor("Intel","10900"),new GraphicCard("NVIDIA","GTX 3090"),new Ram("HyperX","8GB DDR4 2666")), new PowerSource("AeroCool", "AA-01"),new Gabinet("Thermal Take","Z100"));
            PC p2 = new PC("Computadora de Escritorio", Guid.NewGuid(), 0002, "White", new Motherboard("ASUS", "z490", new Processor("Intel", "10900"), new GraphicCard("NVIDIA", "GTX 3090"), new Ram("HyperX", "8GB DDR4 2666")), new PowerSource("AeroCool", "AA-01"), new Gabinet("Thermal Take", "Z100"));
            Factory.AddToPrimaryStock(new Stock<Product>(primeraCompu,1));
            Factory.AddToPrimaryStock(new Stock<Product>(p2, 1));
            Factory.SaveCurrentStock("productos.xml","componentes.xml");

            //Console.WriteLine(primeraCompu.ToString());



            //Serializer<Product>.Serialize("compu2.xml", primeraCompu);
            


            
            //Console.Read();

            //Motherboard b;

            //Motherboard m = Assembler.Assemble<Motherboard>();

            //m.Brand = "Gigabyte";
            //m.Model = "H310";
            //m.GraphicCard = new GraphicCard("NVIDIA", "GTX 3090");
            //m.Processor = new Processor("Intel", "10900");
            //m.Ram = new Ram("Corsair", "8G DDR 2666");
            //Console.WriteLine(m.ToString());
            Console.ReadLine();
        }
    }
}
