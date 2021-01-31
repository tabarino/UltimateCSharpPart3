using System;

namespace Generics
{
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            Console.WriteLine("Add new generic dictionary.");
        }
    }
}
