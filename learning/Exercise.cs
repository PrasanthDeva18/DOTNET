using System;

namespace Learning
{
    public class Exercise
    {
        public static void Run()
        {
            Console.WriteLine("From Operators and Conditional");

            int a = 10;
            int b = 20;

            // Post Increment a++
            // Pre Increment ++a
            // Post Dec, Pre Dec a--, --a

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(b / a);

            //Math.pow is a method
            Console.WriteLine(Math.Pow(5, 4));
            Console.WriteLine(Math.Sqrt(25));

            //String Concatination
            string aStr = "Prasanth";

            aStr += " Vennila";

            Console.WriteLine(aStr);

            aStr = aStr + " \"Deva\\ .";

            Console.WriteLine(aStr);

            // Split method in string

            string[] arrstr = aStr.Split('.');

            Console.WriteLine(arrstr.Length);


            // Conditional Statements same - && || < > <= >= == != equals-method
            
        }
    }

}