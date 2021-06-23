using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Components;

namespace Entities.Products
{
    public class Notebook : Computer
    {
        Display display;

        public Notebook():base()
        {

        }
        public Notebook(string description,
                        Guid idProduct,
                        int serialNumber,
                        string color,
                        Motherboard motherboard,
                        PowerSource powerSource) 
            : base(description, idProduct, serialNumber, color, motherboard, powerSource)
        {
        }

        public Notebook(string description,
                        Guid idProduct,
                        int serialNumber,
                        string color,
                        Motherboard motherboard,
                        PowerSource powerSource,
                        Display display)
            : this(description, idProduct, serialNumber, color, motherboard, powerSource)
        {
            this.display = display;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Notebook");
            sb.AppendLine(this.display.ToString());
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
    }
}
