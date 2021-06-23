using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Entities.Products;
using Entities.Components;


namespace Entities
{
    [Serializable]
    public class StockManager<T>
    {
        private List<T> stockList;

        public StockManager()
        {
            this.stockList = new List<T>();
        }

        public List<T> StockList
        {
            get
            {
                return this.stockList;
            }
            set
            {
                if (!value.Equals(null))
                {
                    this.stockList = value;
                }
            }
        }

        public void LoadInventory_FromXml(string path)
        {

        }

        public void SaveInventory_ToXml(string path)
        {
            this.SerializeStock(path, this.stockList);
        }


        private void SerializeStock(string path, List<T> stockList)
        {
            Serializer<List<T>>.Serialize(path, stockList);
        }

        public void AddToStock(T t)
        {
            if (!t.Equals(null))
            {
                this.stockList.Add(t);
            }
        }

    }
}
