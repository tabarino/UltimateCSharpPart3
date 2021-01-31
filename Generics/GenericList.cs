using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {
            Console.WriteLine("Add new generic.");
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
