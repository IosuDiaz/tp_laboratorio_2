using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Components;
using Entities.Products;

namespace Entities
{
    public delegate void RefreshProductAdd(Product product);
    public delegate void RefreshProductList(StockManager<Product> productList);
    public static class Factory
    {
        #region Attributes
        static StockManager<Product> primaryStock;
        static StockManager<Component> secondaryStock;
        public static event RefreshProductAdd NewProduct;
        public static event RefreshProductList NewProductList;
        static OpenFileDialog ofdPrimaryStock;
        static OpenFileDialog ofdSecondaryStock;
        #endregion

        #region Properties

        public static StockManager<Product> PrimaryStock
        {
            get
            {
                return Factory.primaryStock;
            }
        }
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
            
            primaryStock = new StockManager<Product>();
            secondaryStock = new StockManager<Component>();

            //Factory.ImportPrimaryStockFromXML();
            //Factory.ImportSecondaryStockFromXML();

        }
        #endregion

        #region Methods
        /// <summary>
        /// Saves the stock in XML format
        /// </summary>
        /// <param name="primaryStockpath"></param>
        /// <param name="secondaryStockpath"></param>
        public static void SavePrimaryStockToXml()
        {
            Factory.primaryStock.SaveInventory_ToXml(Factory.ofdPrimaryStock.FileName);
            

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

        public static void ImportPrimaryStockFromXML()
        {
            Factory.ofdPrimaryStock = new OpenFileDialog();

            if (Factory.ofdPrimaryStock.ShowDialog() == DialogResult.OK)
            {
                Factory.primaryStock = new StockManager<Product>(Serializer<Product>.Deserialize(Factory.ofdPrimaryStock.FileName));
                Factory.NewProductList(Factory.PrimaryStock);
            }

            

        }

        public static void ImportSecondaryStockFromXML()
        {
            Factory.ofdSecondaryStock = new OpenFileDialog();

            if (Factory.ofdSecondaryStock.ShowDialog() == DialogResult.OK)
            {
                Factory.secondaryStock = new StockManager<Component>(Serializer<Component>.Deserialize(Factory.ofdSecondaryStock.FileName));
            }
        }
        #endregion
    }
}
