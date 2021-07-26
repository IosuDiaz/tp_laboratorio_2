

using System.Collections.Generic;

namespace Entities
{
    public interface IStockeable<T>
    {
        void AddToStock(T t);

    }
}