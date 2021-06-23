using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Assembler 
    {
        public static T Assemble<T>() where T : new()
        {
            return new T();
        }

    }
}
