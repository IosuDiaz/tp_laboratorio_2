using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class Display : Component
    {
        public Display(string brand, string model) : base(brand, model)
        {
        }
        public Display() : base()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DISPLAY");
            sb.AppendLine(base.ToString());


            return sb.ToString();
        }
    }
}
