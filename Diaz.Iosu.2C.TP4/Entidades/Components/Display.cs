using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class Display : Component
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the Display class.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        public Display(string brand, string model) : base(brand, model)
        {
        }
        /// <summary>
        /// Constructor without parameters required to Serialize XML files.
        /// </summary>
        public Display() : base()
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

            sb.AppendLine("DISPLAY");
            sb.AppendLine(base.ToString());


            return sb.ToString();
        }
        #endregion
    }
}
