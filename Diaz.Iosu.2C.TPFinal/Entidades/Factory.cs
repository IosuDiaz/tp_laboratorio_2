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

        static StockManager<Product> primaryStock;
        static StockManager<Component> secondaryStock;



        static Factory()
        {
            try
            {
                //generar ex para catchear si no existe el el archivo xml
                primaryStock = new StockManager<Product>(Serializer<Product>.Deserialize("productasdos.xml"));
                secondaryStock = new StockManager<Component>(Serializer<Component>.Deserialize("componentes.xml"));
            }
            catch
            {
                primaryStock = new StockManager<Product>();
                secondaryStock = new StockManager<Component>();
            }
            

        }

        public static void SaveCurrentStock(string primaryStockpath, string secondaryStockpath)
        {
            Factory.primaryStock.SaveInventory_ToXml(primaryStockpath);
            Factory.secondaryStock.SaveInventory_ToXml(secondaryStockpath);

        }

        public static void AddToPrimaryStock(Product product)
        {
            if (!(product is null))
            {
                Factory.primaryStock.AddToStock(product);
            }
                
        }

        public static void AddToSecondaryStock(Component component)
        {
            if (!(component is null))
            { 
                Factory.secondaryStock.AddToStock(component);
            }
        }

        public static void RemoveFromPrimaryStock(Guid id)
        {
            Factory.primaryStock.RemoveFromStock(id);
        }

        public static void RemoveFromSecondaryStock(Guid id)
        {
            Factory.secondaryStock.RemoveFromStock(id);
        }

        public static string ListPrimaryStock()
        {
            return Factory.primaryStock.ListStock();
        }

        public static string ListSecondaryStock()
        {
            return Factory.secondaryStock.ListStock();
        }
    }
}
