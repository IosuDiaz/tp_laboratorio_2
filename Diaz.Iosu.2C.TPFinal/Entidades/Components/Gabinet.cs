using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class Gabinet : Component
    {
        public Gabinet(string marca, string modelo) : base(marca, modelo)
        {
        }

        public Gabinet() : base()
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"GABINET");
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
    }
}