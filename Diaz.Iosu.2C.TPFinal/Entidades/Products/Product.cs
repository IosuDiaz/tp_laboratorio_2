using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entities.Products
{
    [Serializable]
    [XmlInclude(typeof(Computer))]
    public abstract class Product
    {
        protected string description;
        protected Guid idProduct;
        protected int serialNumber;
        protected string color;

        public Product(string description, Guid idProduct, int serialNumber, string color)
        {
            this.description = description;
            this.idProduct = idProduct;
            this.serialNumber = serialNumber;
            this.color = color;

        }

        public Product()
        {

        }
        

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public Guid IdProduct
        {
            get
            {
                return this.idProduct;
            }

            set
            {
                this.idProduct = value;
            }
        }

        public int SerialNumber
        {
            get
            {
                return this.serialNumber;
            }
            set
            {
                this.serialNumber = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Description: {this.description}");
            sb.AppendLine($"ID Product: {this.idProduct}");
            sb.AppendLine($"Serial Number: {this.serialNumber}");
            sb.AppendLine($"Color: {this.color}");

            return sb.ToString();
        }

        //public static bool operator ==(Product product1, Guid id)
        //{
        //    return product1.idProduct == id;
        //}

        //public static bool operator !=(Product product1, Guid id)
        //{
        //    return !(product1.idProduct == id);
        //}

        public bool Equals(Guid id)
        {
            return this.idProduct == id;
        }
    }
}
