using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Components;
using Entities.Products;

namespace Entities
{
    public delegate void RefreshProductList(Product product);
    public static class Factory
    {
        #region Attributes
        static StockManager<Product> primaryStock;
        static StockManager<Component> secondaryStock;
        public static event RefreshProductList NewProduct;
        #endregion

        #region Properties
        public static StockManager<Component> SecondaryStock
        {
            get
            {
                return Factory.secondaryStock;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Static constructor
        /// </summary>
        static Factory()
        {
            try
            {
                
                primaryStock = new StockManager<Product>(Serializer<Product>.Deserialize("C:\\Users\\PC\\Desktop\\tp_laboratorio_2\\Diaz.Iosu.2C.TPFinal\\productos.xml"));
                secondaryStock = new StockManager<Component>(Serializer<Component>.Deserialize("C:\\Users\\PC\\Desktop\\tp_laboratorio_2\\Diaz.Iosu.2C.TPFinal\\componentes.xml"));
            }
            catch
            {

                primaryStock = new StockManager<Product>();
                secondaryStock = new StockManager<Component>();
            }
            

        }
        #endregion

        #region Methods
        /// <summary>
        /// Saves the stock in XML format
        /// </summary>
        /// <param name="primaryStockpath"></param>
        /// <param name="secondaryStockpath"></param>
        public static void SaveCurrentStock(string primaryStockpath, string secondaryStockpath)
        {
            Factory.primaryStock.SaveInventory_ToXml(primaryStockpath);
            Factory.secondaryStock.SaveInventory_ToXml(secondaryStockpath);

        }

        /// <summary>
        /// Add a product to the primary stock
        /// </summary>
        /// <param name="product"></param>
        public static void AddToPrimaryStock(Product product)
        {
            if (!(product is null))
            {
                Factory.primaryStock.AddToStock(product);
                Factory.NewProduct(product);
            }
                
        }
        /// <summary>
        /// Add a component to the secondary stock
        /// </summary>
        /// <param name="component"></param>
        public static void AddToSecondaryStock(Component component)
        {
            if (!(component is null))
            { 
                Factory.secondaryStock.AddToStock(component);
            }
        }
        /// <summary>
        /// Lists the primary stock
        /// </summary>
        /// <returns></returns>
        public static string ListPrimaryStock()
        {
            return Factory.primaryStock.ListStock();
        }

        /// <summary>
        /// Lists the secondary stock
        /// </summary>
        /// <returns></returns>
        public static string ListSecondaryStock()
        {
            return Factory.secondaryStock.ListStock();
        }
        #endregion
    }
}
