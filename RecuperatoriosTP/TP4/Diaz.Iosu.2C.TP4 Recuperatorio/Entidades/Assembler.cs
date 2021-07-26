using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class Assembler 
    {
        static int serialNumber;

        static Assembler()
        {
            Assembler.serialNumber = 0;
        }

        /// <summary>
        /// Generates a new instances of the class passed by parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Assemble<T>() where T : new()
        {
            return new T();
        }
        /// <summary>
        /// Generates a new guid
        /// </summary>
        /// <returns></returns>
        public static Guid GenerateGuid()
        {
            return Guid.NewGuid();
        }
        /// <summary>
        /// Generates a new serial number
        /// </summary>
        /// <returns></returns>
        public static int GenerateSerialNumber()
        {
            Assembler.serialNumber++;
            return Assembler.serialNumber;
        }


    }
}
