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
    public class StockManager<T> : IStockeable<T>
    {
        #region Attributes
        private List<T> stockList;
        #endregion
        #region Contructors
        public StockManager()
        {
            this.stockList = new List<T>();
        }

        public StockManager(List<T> t)
        {
            if (!(t is null))
            {
                this.stockList = t;
            }
        }
        #endregion
        #region Properties
        public List<T> StockList
        {
            get
            {
                return this.stockList;
            }
            set
            {
                if (!(value is null))
                {
                    this.stockList = value;
                }
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Return the filtered list
        /// </summary>
        /// <typeparam name="X"></typeparam>
        /// <returns></returns>
        public List<X> Filter<X>() where X: T
        {
            List<X> xList = new List<X>();
            
            foreach (T item in this.stockList)
            {
                if (item.GetType() == typeof(X))
                {
                    xList.Add((X)item);
                }
            }

            return xList;
        }
        /// <summary>
        /// Serializes the actual stock to XML
        /// </summary>
        /// <param name="path"></param>
        public void SaveInventory_ToXml(string path)
        {
            this.SerializeStock(path, this.stockList);
        }

        /// <summary>
        /// Serializes the actual stock to XML
        /// </summary>
        /// <param name="path"></param>
        /// <param name="stockList"></param>
        private void SerializeStock(string path, List<T> stockList)
        {
            Serializer<List<T>>.Serialize(path, stockList);
        }
        /// <summary>
        /// Add an item to the stock list 
        /// </summary>
        /// <param name="t"></param>
        public void AddToStock(T t)
        {
            if (!t.Equals(null))
            {
                this.stockList.Add(t);
            }
        }
        /// <summary>
        /// List the actual stock
        /// </summary>
        /// <returns></returns>
        public string ListStock()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in this.stockList)
            {
                if (!item.Equals(null))
                {

                    sb.AppendLine(item.ToString());
                    sb.AppendLine("-----------------------------------");

                }
            }

            return sb.ToString();
        }
        #endregion

    }
}
