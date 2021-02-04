using System;

namespace Dynamic
{
    public class DynamicExamples
    {
        public DynamicExamples()
        {
            // Example1();
            
            // Example2();
            
            // Example3();

            Example4();
        }

        public void Example1()
        {
            // Reflexion Example
            object excelReflexion = "Test";
            var methodInfo = excelReflexion.GetType().GetMethod("Optimize");
            methodInfo.Invoke(null, null);
            
            // Dynamic does the same as Reflexion, but is more beautiful and powerful
            dynamic excelDynamic = "Test";
            excelDynamic.Optimize();
        }

        public void Example2()
        {
            dynamic name = "Ivan";
            Console.WriteLine(name);

            name = 10;
            Console.WriteLine(name);

            name++;
            Console.WriteLine(name);
        }

        public void Example3()
        {
            // The variable c will also be a dynamic. In this case a dynamic(int)
            dynamic a = 10;
            dynamic b = 2;
            var c = a + b;

            Console.WriteLine(c.GetType());
        }

        public void Example4()
        {
            // In this case we don't need to specify a type casting or conversion
            // At run-time d will end up being an integer
            int i = 5;
            dynamic d = i;

            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            // We don't need any explicit casting in this case as well
            long l = d;

            Console.WriteLine(l);
            Console.WriteLine(l.GetType());
        }
    }
}
