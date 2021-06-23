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

        public Motherboard():base()
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
            sb.AppendLine(this.processor.ToString());
            sb.AppendLine(this.graphicCard.ToString());
            sb.AppendLine(this.ram.ToString());
            
            

            return sb.ToString();
        }
    }
}