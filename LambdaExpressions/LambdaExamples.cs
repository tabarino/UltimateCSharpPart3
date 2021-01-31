using System;

namespace LambdaExpressions
{
    public class LambdaExamples
    {
        public LambdaExamples()
        {
            var squareFunction = Square(5);
            Console.WriteLine($"Function: {squareFunction}");

            Func<int, int> squareLambda = number => number * number;
            Console.WriteLine($"Lambda: {squareLambda(5)}");

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine($"Multiplier: {multiplier(10)}");
        }

        public int Square(int number)
        {
            return number * number;
        }
    }
}
