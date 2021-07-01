using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class Motherboard : Component
    {
        Processor processor;
        GraphicCard graphicCard;
        Ram ram;

        public Motherboard() : base()
        {

        }

        public Motherboard(string brand, string model) : base(brand, model)
        {

        }

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

        public static bool operator ==(Motherboard motherboard1, Motherboard motherboard2)
        {
            bool matching = false;
            if (!motherboard1.Equals(null) && !motherboard2.Equals(null))
            {
                matching = motherboard1.brand == motherboard2.brand &&
                            motherboard1.model == motherboard2.model &&
                            motherboard1.graphicCard == motherboard2.graphicCard &&
                       motherboard1.ram == motherboard2.ram &&
                       motherboard1.processor == motherboard2.processor;
            }
            return matching;
        }

        public static bool operator !=(Motherboard motherboard1, Motherboard motherboard2)
        {
            return !(motherboard1 == motherboard2);
        }
    }
}