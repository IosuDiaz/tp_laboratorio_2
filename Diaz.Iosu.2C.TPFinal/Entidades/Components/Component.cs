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
        #region Attributes
        protected string brand;
        protected string model;
        #endregion

        #region Properties
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
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the Component class.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        public Component(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
        /// <summary>
        /// Constructor without parameters required to Serialize XML files.
        /// </summary>
        public Component()
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns a string that represents the current product.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Brand: {this.brand}");
            sb.AppendLine($"Model: {this.model}");

            return sb.ToString();
        }
        /// <summary>
        /// Method Overloading
        /// Returns true if both components are equal. False if not.
        /// </summary>
        /// <param name="comp1"></param>
        /// <param name="comp2"></param>
        /// <returns></returns>
        public static bool operator ==(Component comp1, Component comp2)
        {
            bool matching = false;

            if (!(comp1 is null) && !(comp2 is null))
            {
                matching = comp1.GetType() == comp2.GetType() && comp1.brand == comp2.brand && comp1.model == comp2.model;
            }


            return matching;
        }
        /// <summary>
        /// Return the negation of the equals.
        /// </summary>
        /// <param name="comp1"></param>
        /// <param name="comp2"></param>
        /// <returns></returns>
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
        #endregion
    }
}
