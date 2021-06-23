using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entities.Components
{
    [Serializable]
    [XmlInclude(typeof(Motherboard))]
    [XmlInclude(typeof(Processor))]
    [XmlInclude(typeof(Ram))]
    [XmlInclude(typeof(Gabinet))]
    [XmlInclude(typeof(GraphicCard))]
    [XmlInclude(typeof(PowerSource))]
    [XmlInclude(typeof(Display))]
    public abstract class Component
    {
        protected string brand;
        protected string model;
        
        public Component(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
        public Component()
        {

        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
            set
            {
                this.brand = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Brand: {this.brand}");
            sb.AppendLine($"Model: {this.model}");

            return sb.ToString();
        }
    }
}
