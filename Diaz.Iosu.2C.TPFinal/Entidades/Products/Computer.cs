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
    [XmlInclude(typeof(PC))]
    [XmlInclude(typeof(Notebook))]
    public class Computer : Product
    {
        #region Attributes
        Motherboard motherboard;
        PowerSource powerSource;

        #endregion

        #region Properties
        public Motherboard Motherboard
        {
            get
            {
                return this.motherboard;
            }
            set
            {
                if (!(value is null))
                {

                    this.motherboard = value;
                }
            }
        }

        public PowerSource PowerSource
        {
            get
            {
                return this.powerSource;
            }

            set
            {
                if (!(value is null))
                {

                    this.powerSource = value;
                }
            }
        }

        public Computer AddComputer
        {

            set
            {
                if (!(value is null) &&
                    !(value.motherboard is null) &&
                    !(value.motherboard.GraphicCard is null) &&
                    !(value.motherboard.Ram is null) &&
                    !(value.motherboard.Processor is null) &&
                    !(value.powerSource is null))
                {
                    this.Motherboard = value.Motherboard;
                    this.Motherboard.Processor = value.Motherboard.Processor;
                    this.Motherboard.Ram = value.Motherboard.Ram;
                    this.Motherboard.GraphicCard = value.Motherboard.GraphicCard;
                    this.PowerSource = value.PowerSource;
                }
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor without parameters required to Serialize XML files.
        /// </summary>
        public Computer():base()
        {

        }

        private Computer(string description,
                        Guid idProduct,
                        int serialNumber,
                        string color) : base(description, idProduct, serialNumber, color)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the Computer class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="idProduct"></param>
        /// <param name="serialNumber"></param>
        /// <param name="color"></param>
        /// <param name="motherboard"></param>
        /// <param name="powerSource"></param>
        public Computer(string description,
                        Guid idProduct,
                        int serialNumber,
                        string color,
                        Motherboard motherboard,
                        PowerSource powerSource) : this(description, idProduct, serialNumber, color)
        {
            this.motherboard = motherboard;
            this.powerSource = powerSource;

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

            sb.AppendLine(base.ToString());
            if(!(this.motherboard is null))
            sb.AppendLine(this.motherboard.ToString());
            if(!(this.powerSource is null))
            sb.AppendLine(this.powerSource.ToString());

            return sb.ToString();
        }
        #endregion

    }
}
