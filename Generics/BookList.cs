using System;

namespace Generics
{
    public class BookList
    {
        public void Add(Book book)
        {
            Console.WriteLine("Add new book.");
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
