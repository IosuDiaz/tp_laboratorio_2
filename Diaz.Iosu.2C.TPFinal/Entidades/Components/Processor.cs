using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class Processor : Component
    {
        public Processor(string marca, string modelo) : base(marca, modelo)
        {

        }
        public Processor():base()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"PROCESSOR");
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
    }
}