using System;
using Generics;

namespace UltimateCSharpPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            Generics();
        }

        static void Generics()
        {
            // var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            // Without Generics we need to do in this way
            // var numbers = new List();
            // numbers.Add(0);
            // var books = new BookList();
            // books.Add(book);

            // With Generics we eliminate the code duplication
            // We could avoid code duplication (List and BookList) using and ObjectList
            // However, we will have to handle with performance problems because of boxing and unboxing
            // So, forget about these options and always use Generics
            // var numbers = new GenericList<int>();
            // numbers.Add(10);
            // var books = new GenericList<Book>();
            // books.Add(new Book());
            // var dictionary = new GenericDictionary<string, Book>();
            // dictionary.Add("1234", new Book());
            // var utilities = new Utilities();
            // Console.WriteLine(utilities.Max(11, 22));
            // Console.WriteLine(utilities.MaxGeneric<int>(11, 22));

            var number = new Generics.Nullable<int>(5);
            Console.WriteLine($"Has Value ? {number.HasValue}");
            Console.WriteLine($"Value: {number.getValueOrDefault()}");
            var number2 = new Generics.Nullable<int>();
            Console.WriteLine($"Has Value ? {number2.HasValue}");
            Console.WriteLine($"Value: {number2.getValueOrDefault()}");
        }
    }
}
