using System;
using Generics;
using Delegates;

namespace UltimateCSharpPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics();

            Delegates();
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

        static void Delegates()
        {
            // Delegates are objects that knows how to call a method (or a group of methods)
            // It is also a reference to a function
            // We use delegates to achieve extensibility and flexibility (eg.: frameworks)

            // Interfaces or Delegates???
            // Use a Delegate when:
            // - An eventing design pattern is used
            // - The caller doesn't need to access other properties or methods on the object implementing the method

            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            var newFilters = new NewPhotoFilters();

            // Dotnet has its own delegates. So, we do not need to create ours
            // PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            filterHandler += newFilters.RemoveRedEye;

            processor.Process("photo.jpg", filterHandler);
        }
    }
}
