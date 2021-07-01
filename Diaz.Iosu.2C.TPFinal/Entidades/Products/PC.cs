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
        #region Attributes
        Gabinet gabinet;
        #endregion

        #region Properties
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
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor without parameters required to Serialize XML files.
        /// </summary>
        public PC() : base()
        {

        }
        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="idProduct"></param>
        /// <param name="serialNumber"></param>
        /// <param name="color"></param>
        /// <param name="motherboard"></param>
        /// <param name="powerSource"></param>
        public PC(string description,
                  Guid idProduct,
                  int serialNumber,
                  string color,
                  Motherboard motherboard,
                  PowerSource powerSource)
            : base(description, idProduct, serialNumber, color, motherboard, powerSource)
        {
        }
        /// <summary>
        /// Initializes a new instance of the PC class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="idProduct"></param>
        /// <param name="serialNumber"></param>
        /// <param name="color"></param>
        /// <param name="motherboard"></param>
        /// <param name="powerSource"></param>
        /// <param name="gabinet"></param>
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

        #endregion

        #region Methods
        /// <summary>
        /// Returns a string that represents the current product.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine(base.ToString());
            sb.AppendLine(this.gabinet.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
