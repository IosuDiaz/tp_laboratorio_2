using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entities.Components
{
    
    public interface IStockeable
    {
        int Amount { get; set; }
        
        void SubstractAmount();
        void SubstractAmount(int amountToSubstract);
        void AddAmount();
        void AddAmount(int amount);
    }
}