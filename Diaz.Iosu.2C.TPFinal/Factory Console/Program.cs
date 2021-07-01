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




            //PC primeraCompu = new PC("Computadora de Escritorio", Guid.NewGuid(), 0001,"White" , new Motherboard("ASUS","z490",new Processor("Intel","10900"),new GraphicCard("NVIDIA","GTX 3090"),new Ram("HyperX","8GB DDR4 2666")), new PowerSource("AeroCool", "AA-01"),new Gabinet("Thermal Take","Z100"));
            //PC p2 = new PC("Computadora de Escritorio", Guid.NewGuid(), 0002, "White", new Motherboard("ASUS", "z490", new Processor("Intel", "10900"), new GraphicCard("NVIDIA", "GTX 3090"), new Ram("HyperX", "8GB DDR4 2666")), new PowerSource("AeroCool", "AA-01"), new Gabinet("Thermal Take", "Z100"));
            //Factory.AddToPrimaryStock(primeraCompu);
            //Factory.AddToPrimaryStock(p2);

            //Motherboard m1 = new Motherboard("ASUS","z490");
            //Motherboard m2 = new Motherboard("ASUS", "A320M-K");
            //Motherboard m3 = new Motherboard("Gigabyte", "A320M-S2H");
            //Motherboard m4 = new Motherboard("AORUS", "B450");

            //Factory.AddToSecondaryStock(m1);
            //Factory.AddToSecondaryStock(m2);
            //Factory.AddToSecondaryStock(m3);
            //Factory.AddToSecondaryStock(m4);

            //Gabinet g1 = new Gabinet("Kolink", "void white");
            //Gabinet g2 = new Gabinet("Xigmatek", "Gemini Queen");
            //Gabinet g3 = new Gabinet("Redragon", "Ratchet Gc-530");
            //Gabinet g4 = new Gabinet("Thermal Take", "Z100");

            //Factory.AddToSecondaryStock(g1);
            //Factory.AddToSecondaryStock(g2);
            //Factory.AddToSecondaryStock(g3);
            //Factory.AddToSecondaryStock(g4);


            Ram r1 = new Ram("Gigabyte", "DDR4 8GB");
            //Ram r2 = new Ram("HyperX", "DDR3 4GB");
            //Ram r3 = new Ram("Kingston", "DDR4 16GB");
            //Ram r4 = new Ram("HyperX", "DDR4 16GB");
            object a = new object();
            //Factory.AddToSecondaryStock(r1);
            //Factory.AddToSecondaryStock(r2);
            //Factory.AddToSecondaryStock(r3);
            //Factory.AddToSecondaryStock(r4);

            //GraphicCard gc1 = new GraphicCard("Nvidia", "GTX 1660 SUPER");
            //GraphicCard gc2 = new GraphicCard("AMD","RX 570");
            //GraphicCard gc3 = new GraphicCard("AMD","RX 6700 XT");
            //GraphicCard gc4 = new GraphicCard("Nvidia","RTX 3060");

            //Factory.AddToSecondaryStock(gc1);
            //Factory.AddToSecondaryStock(gc2);
            //Factory.AddToSecondaryStock(gc3);
            //Factory.AddToSecondaryStock(gc4);

            //Processor p1 = new Processor("Intel","i9 10900");
            //Processor p2 = new Processor("AMD","Ryzen 9");
            //Processor p3 = new Processor("Intel","i3 9100f");
            //Processor p4 = new Processor("AMD","Athlon");

            //Factory.AddToSecondaryStock(p1);
            //Factory.AddToSecondaryStock(p2);
            //Factory.AddToSecondaryStock(p3);
            //Factory.AddToSecondaryStock(p4);

            //PowerSource ps1 = new PowerSource("Sentey", "Steel-Nitro Power 550w");
            //PowerSource ps2 = new PowerSource("Corsair", "CV650w");
            //PowerSource ps3 = new PowerSource("LNZ", "PX550w");
            //PowerSource ps4 = new PowerSource("Noga", "Atx600w");
            //Factory.AddToSecondaryStock(ps1);
            //Factory.AddToSecondaryStock(ps2);
            //Factory.AddToSecondaryStock(ps3);
            //Factory.AddToSecondaryStock(ps4);

            //Display d1 = new Display("Lenovo", "G450");
            //Display d2 = new Display("Noblex", "G5");
            //Display d3 = new Display("Dell", "Inspiron 15");
            //Display d4 = new Display("Lenovo", "G480");

            //Factory.AddToSecondaryStock(d1);
            //Factory.AddToSecondaryStock(d2);
            //Factory.AddToSecondaryStock(d3);
            //Factory.AddToSecondaryStock(d4);








            //Factory.SaveCurrentStock("productos.xml","componentes.xml");

            Console.WriteLine(Factory.ListPrimaryStock());
            Console.WriteLine("----------------------------COMPONENTES----------------------------");
            Console.WriteLine(Factory.ListSecondaryStock());


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
