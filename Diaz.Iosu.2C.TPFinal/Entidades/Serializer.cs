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
    public static class Serializer<T> //: ISerializable<T> //Lo serializable va a ser la fabrica y no la serializadora
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

        public static List<T> Deserialize(string path)
        {
            XmlTextReader reader = null;
            XmlSerializer serializer = null;
            List<T> tList = null;

            
            try
            {
                tList = new List<T>();
                reader = new XmlTextReader(path);
                serializer = new XmlSerializer(typeof(List<T>));
                tList = (List<T>)serializer.Deserialize(reader);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return tList;
        }









    }

}