using System;

namespace Generics
{
    public class List
    {
        public void Add(int number)
        {
            Console.WriteLine("Add new list.");
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
