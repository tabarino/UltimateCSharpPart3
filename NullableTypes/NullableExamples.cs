using System;

namespace NullableTypes
{
    public class NullableExamples
    {
        public NullableExamples()
        {
            // Example1();

            // Example2();

            Example3();
        }

        public void Example1()
        {
            DateTime? date = null;

            // GetValueOrDefault is the correct way to get a value if the parameter accepts nullables
            Console.WriteLine(date.GetValueOrDefault());

            // HasValues just checks if there is or no value
            // However, if you try to access the value when it is null, you get an exception
            Console.WriteLine(date.HasValue);
            // Console.WriteLine(date.Value);
        }

        public void Example2()
        {
            // If you try to set date2 with date you get an error, because date is nullable and date2 is not.
            // You can use GetValueOrDefault to get rid of the error
            DateTime? date = new DateTime(2014, 1, 1);
            DateTime date2 = date.GetValueOrDefault();
            DateTime? date3 = date2;

            Console.WriteLine(date);
            Console.WriteLine(date2);
            Console.WriteLine(date3.GetValueOrDefault());
        }

        public void Example3()
        {
            DateTime? date = null;
            DateTime date2;

            // if (date != null)
            // {
            //     date2 = date.GetValueOrDefault();
            // }
            // else
            // {
            //     date2 = DateTime.Today;
            // }

            // This is the same as the above if statement (Null Coalescing Operator)
            date2 = date ?? DateTime.Today;

            Console.WriteLine(date2);

            // This is the Ternaly Operator
            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date3);
        }
    }
}
