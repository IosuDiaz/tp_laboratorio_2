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
    
    public class Notebook : Computer
    {
        #region Attributes
        Display display;
        #endregion

        #region Properties
        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                if(!(value is null))
                {
                    this.display = value;
                }
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor without parameters required to Serialize XML files.
        /// </summary>
        public Notebook():base()
        {

        }
        /// <summary>
        /// Initializes a new instance of the Notebook class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="idProduct"></param>
        /// <param name="serialNumber"></param>
        /// <param name="color"></param>
        /// <param name="motherboard"></param>
        /// <param name="powerSource"></param>
        public Notebook(string description,
                        Guid idProduct,
                        int serialNumber,
                        string color,
                        Motherboard motherboard,
                        PowerSource powerSource) 
            : base(description, idProduct, serialNumber, color, motherboard, powerSource)
        {
        }
        /// <summary>
        /// Initializes a new instance of the Notebook class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="idProduct"></param>
        /// <param name="serialNumber"></param>
        /// <param name="color"></param>
        /// <param name="motherboard"></param>
        /// <param name="powerSource"></param>
        /// <param name="display"></param>
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
            sb.AppendLine(this.display.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
