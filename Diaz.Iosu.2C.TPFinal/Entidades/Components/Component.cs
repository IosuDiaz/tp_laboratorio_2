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

        public static bool operator ==(Component comp1, Component comp2)
        {
            bool matching = false;

            if (!comp1.Equals(null) && !comp2.Equals(null))
            {
                matching = comp1.GetType() == comp2.GetType() && comp1.brand == comp2.brand && comp1.model == comp2.model;
            }


            return matching;
        }

        public static bool operator !=(Component comp1, Component comp2)
        {
            if (!comp1.Equals(null) && !comp2.Equals(null))
            {
                return !(comp1 == comp2);
            }
            else
            {
                return true;
            }

        }
    }
}
