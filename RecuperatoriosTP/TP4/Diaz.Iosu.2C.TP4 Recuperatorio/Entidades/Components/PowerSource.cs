using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class PowerSource : Component
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the PowerSource class.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        public PowerSource(string marca, string modelo) : base(marca, modelo)
        {
        }
        /// <summary>
        /// Constructor without parameters required to Serialize XML files.
        /// </summary>
        public PowerSource() : base()
        {

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
            sb.AppendLine($"POWER SOURCE");
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
        #endregion
    }
}