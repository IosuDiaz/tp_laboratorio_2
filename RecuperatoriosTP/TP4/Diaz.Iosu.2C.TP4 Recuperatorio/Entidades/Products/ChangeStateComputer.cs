using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Products
{
    public static class ChangeStateComputer
    {
        static bool isOn = false;
        /// <summary>
        /// Change the state of the computer
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool Boot(this Computer t)
        {
            return !ChangeStateComputer.isOn;
        }
    }
}
