using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Components;

namespace Entities.Products
{
    public class PC : Computer
    {
        Gabinet gabinet;

        public PC() : base()
        {

        }

        public PC(string description, 
                  Guid idProduct,
                  int serialNumber,
                  string color,
                  Motherboard motherboard,
                  PowerSource powerSource) 
            : base(description, idProduct, serialNumber, color, motherboard, powerSource)
        {
        }

        public PC(string description,
                  Guid idProduct,
                  int serialNumber,
                  string color,
                  Motherboard motherboard,
                  PowerSource powerSource,
                  Gabinet gabinet)
            :this(description, idProduct, serialNumber, color, motherboard, powerSource)
        {
            this.gabinet = gabinet;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Desktop Computer");
            sb.AppendLine(this.gabinet.ToString());
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
    }
}
