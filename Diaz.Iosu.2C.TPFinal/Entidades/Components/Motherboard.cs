using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class Motherboard : Component
    {
        #region Attributes
        Processor processor;
        GraphicCard graphicCard;
        Ram ram;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor without parameters required to Serialize XML files.
        /// </summary>
        public Motherboard() : base()
        {

        }
        /// <summary>
        /// Initializes a new instance of the Motherboard class.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        public Motherboard(string brand, string model) : base(brand, model)
        {

        }
        /// <summary>
        /// Initializes a new instance of the Motherboard class.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="processor"></param>
        /// <param name="graphicCard"></param>
        /// <param name="ram"></param>
        public Motherboard(string brand,
                            string model,
                            Processor processor,
                            GraphicCard graphicCard,
                            Ram ram) : this(brand, model)
        {
            this.processor = processor;
            this.graphicCard = graphicCard;
            this.ram = ram;
        }

        #endregion

        #region Properties
        public Processor Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                if (!value.Equals(null))
                {
                    this.processor = value;
                }
            }
        }

        public GraphicCard GraphicCard
        {
            get
            {
                return this.graphicCard;
            }

            set
            {
                if (!value.Equals(null))
                {
                    this.graphicCard = value;
                }
            }
        }

        public Ram Ram
        {
            get
            {
                return this.ram;
            }

            set
            {
                if (!value.Equals(null))
                {
                    this.ram = value;
                }
            }
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
            sb.AppendLine("MOTHERBOARD");
            sb.AppendLine(base.ToString());
            if (!(this.processor is null))
            {
                sb.AppendLine(this.processor.ToString());
            }
            if (!(this.graphicCard is null))
            {
                sb.AppendLine(this.graphicCard.ToString());
            }
            if (!(this.ram is null))
            {
                sb.AppendLine(this.ram.ToString());
            }



            return sb.ToString();
        }
        /// <summary>
        /// Method Overloading
        /// Returns true if both Motherboards are equal. False if not.
        /// </summary>
        /// <param name="motherboard1"></param>
        /// <param name="motherboard2"></param>
        /// <returns></returns>
        public static bool operator ==(Motherboard motherboard1, Motherboard motherboard2)
        {
            bool matching = false;
            if (!(motherboard1 is null) && !(motherboard2 is null))
            {
                matching = motherboard1.brand == motherboard2.brand &&
                            motherboard1.model == motherboard2.model &&
                            motherboard1.graphicCard == motherboard2.graphicCard &&
                       motherboard1.ram == motherboard2.ram &&
                       motherboard1.processor == motherboard2.processor;
            }
            return matching;
        }
        /// <summary>
        /// Return the negation of the equals.
        /// </summary>
        /// <param name="motherboard1"></param>
        /// <param name="motherboard2"></param>
        /// <returns></returns>
        public static bool operator !=(Motherboard motherboard1, Motherboard motherboard2)
        {
            return !(motherboard1 == motherboard2);
        }
        #endregion
    }
}