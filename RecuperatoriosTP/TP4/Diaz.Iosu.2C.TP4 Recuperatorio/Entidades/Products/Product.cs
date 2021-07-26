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
        #region Attributes
        protected string description;
        protected Guid idProduct;
        protected int serialNumber;
        protected string color;
        #endregion

        #region Properties
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

        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="idProduct"></param>
        /// <param name="serialNumber"></param>
        /// <param name="color"></param>
        public Product(string description, Guid idProduct, int serialNumber, string color)
        {
            this.description = description;
            this.idProduct = idProduct;
            this.serialNumber = serialNumber;
            this.color = color;

        }
        /// <summary>
        /// Constructor without parameters required to Serialize XML files.
        /// </summary>
        public Product()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Override Method
        /// Returns a string that represents the current product.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Description: {this.description}");
            sb.AppendLine($"ID Product: {this.idProduct}");
            sb.AppendLine($"Serial Number: {this.serialNumber}");
            sb.AppendLine($"Color: {this.color}");

            return sb.ToString();
        }

        /// <summary>
        /// Determinates whether the specified id is equal to the current product id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Equals(Guid id)
        {
            return this.idProduct == id;
        }

        #endregion
    }
}
