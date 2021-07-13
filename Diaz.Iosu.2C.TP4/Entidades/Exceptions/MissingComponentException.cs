using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class MissingComponentException : Exception
    {
        public MissingComponentException(string message) : base(message)
        {
        }

        public MissingComponentException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
