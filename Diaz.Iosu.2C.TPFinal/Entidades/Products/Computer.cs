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
    public abstract class Computer : Product
    {
        #region Attributes
        Motherboard motherboard;
        PowerSource powerSource;
        bool powerButton;
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
                if (!value.Equals(null))
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
                if (!value.Equals(null))
                {

                    this.powerSource = value;
                }
            }
        }

        private string ComputerState
        {
            get
            {
                if (this.powerButton)
                {
                    return "ON";
                }
                else
                {
                    return "OFF";
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
            this.powerButton = false;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Switch state of the computer.
        /// ON -> OFF |
        /// OFF -> ON
        /// </summary>
        public void Boot()
        {
            List<Component> listaComponentes = new List<Component>();

            //if (!this.motherboard.Equals(null) && !this.powerSource.Equals(null) && !this.motherboard.Processor.Equals(null) && this.motherboard)
            if(listaComponentes.Contains(null))
            {
                this.powerButton = !this.powerButton;
            }
        }
        /// <summary>
        /// Override Method
        /// Returns a string that represents the current product.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine(this.motherboard.ToString());
            sb.AppendLine(this.powerSource.ToString());

            return sb.ToString();
        }
        #endregion

    }
}
