using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class PowerSource : Component
    {
        public PowerSource(string marca, string modelo) : base(marca, modelo)
        {
        }
        public PowerSource() : base()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"POWER SOURCE");
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
    }
}