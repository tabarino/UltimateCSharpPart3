using System;
using System.Linq;

// It's a good practice when you extend a method of a existent class, you put in the same namespace.
// For example: String is on System. So, we add the System as namespace here
namespace System
{
    // Note: Extensions Methods can be trick. If the owner of the class creates a method called Shorten.
    // This code won't work anymore.
    // So, use Extensions Methods only if you really need to.

    // You have to set the class as static and declare the name of the class + "Extensions"
    public static class StringExtensions
    {
        // You need to define a static method as well
        public static string Shorten(this String originalString, int numberOfWords)
        {
            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0");
            }

            if (numberOfWords == 0)
            {
                return "";
            }

            var words = originalString.Split(' ');

            if (words.Length <= numberOfWords)
            {
                return originalString;
            }

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
