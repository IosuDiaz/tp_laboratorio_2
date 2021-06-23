using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class Ram : Component
    {
        public Ram(string marca, string modelo) : base(marca, modelo)
        {
        }

        public Ram() : base()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"RAM");
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
    }
}