

using System.Collections.Generic;

namespace Entities
{
    public interface ISerializable<T>
    {
        void Serialize(string path, T t);

        List<T> Deserialize(string path);
    }
}