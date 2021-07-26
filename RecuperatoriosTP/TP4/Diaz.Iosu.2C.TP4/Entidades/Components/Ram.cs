﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Components
{
    public class Ram : Component
    {
        #region Constructors
        /// <summary>
        
        /// Initializes a new instance of the Ram class.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        public Ram(string marca, string modelo) : base(marca, modelo)
        {
        }
        /// <summary>
        /// Constructor without parameters required to Serialize XML files.
        /// </summary>
        public Ram() : base()
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
            sb.AppendLine($"RAM");
            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
        #endregion
    }
}