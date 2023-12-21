using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Визначення змінних
            byte byteValue = 5;
            short shortValue = 10;
            int intValue = 20;
            long longValue = 30L;
            bool boolValue = true;
            char charValue = 'A';
            float floatValue = 5.5f;
            double doubleValue = 10.5;
            decimal decimalValue = 20.5m;
            string stringValue = "Hello";

            // Математичні операції
            int result1 = intValue + shortValue; 
            int result2 = intValue - byteValue;  
            long result3 = intValue * longValue; 

            
            Console.WriteLine($"Result of addition: {result1}");
            Console.WriteLine($"Result of subtraction: {result2}");
            Console.WriteLine($"Result of multiplication: {result3}");

            
            double x = 2.5;
            double y = 3.5;
            double pi = Math.PI;

            double function1 = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
            double function2 = Math.Abs(x) * Math.Sin(x);
            double function3 = 2 * pi * x;
            double function4 = Math.Max(x, y);

            Console.WriteLine($"-6*x^3 + 5*x^2 - 10*x + 15 = {function1}");
            Console.WriteLine($"|x| * sin(x) = {function2}");
            Console.WriteLine($"2 * π * x = {function3}");
            Console.WriteLine($"max(x, y) = {function4}");
        }
    }
}


