using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class GraphicCard : Component
    {
        public GraphicCard(string marca, string modelo) : base(marca, modelo)
        {
        }

        public GraphicCard() : base()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"GRAPHIC CARD");
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
    }
}