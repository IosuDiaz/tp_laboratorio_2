using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Components;
using Entities.Products;

namespace Entities
{
    public static class Factory
    {

        static StockManager<Stock<Product>> primaryStock;
        static StockManager<Stock<Component>> secondaryStock;



        static Factory()
        {
            primaryStock = new StockManager<Stock<Product>>();
            secondaryStock = new StockManager<Stock<Component>>();
        }

        public static void SaveCurrentStock(string primaryStockpath, string secondaryStockpath)
        {
            Factory.primaryStock.SaveInventory_ToXml(primaryStockpath);
            Factory.secondaryStock.SaveInventory_ToXml(secondaryStockpath);

        }

        public static void AddToPrimaryStock(Stock<Product> product)
        {
            if (!product.Equals(null))
            {
                Factory.primaryStock.AddToStock(product);
            }
                
        }

        public static void AddToPrimaryStock(Stock<Component> component)
        {
            if (!component.Equals(null))
            { 
                Factory.secondaryStock.AddToStock(component);
            }
        }


    }
}
