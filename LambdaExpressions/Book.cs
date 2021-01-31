using System;

namespace LambdaExpressions
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }

        public bool IsCheaperThanTenDollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
