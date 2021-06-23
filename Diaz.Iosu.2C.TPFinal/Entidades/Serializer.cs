using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entities.Products;

namespace Entities
{
    public static class Serializer<T>
    {

        

        public static void Serialize(string path, T t)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;
            try
            {
                writer = new XmlTextWriter(path, Encoding.UTF8);
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, t);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }









    }

}