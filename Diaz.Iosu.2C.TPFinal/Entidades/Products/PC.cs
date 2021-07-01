using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Components;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

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
            : this(description, idProduct, serialNumber, color, motherboard, powerSource)
        {
            this.gabinet = gabinet;
        }


        public Gabinet Gabinet
        {
            get
            {
                return this.gabinet;
            }
            set
            {
                if (!value.Equals(null))
                {
                    this.gabinet = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine(base.ToString());
            sb.AppendLine(this.gabinet.ToString());

            return sb.ToString();
        }
    }
}
