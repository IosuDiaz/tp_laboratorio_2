using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Assembler<T> where T : new ()
    {

        public static T Assemble()
        {
            return new T();
        }


    }
}
