using System;

namespace Lesson1_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = myMethod("x");
            double y = myMethod("y");
            double z = myMethod("z");

            double result1 = 0;
            double result2 = 0;
            double result3 = 0;

            result1 = (x + y) * (Math.Pow(z, 2) + 1);
            result2 = (x / z - 1) * Math.Sqrt(y);
            result3 = (x * y + y * z) / Math.Pow(z, 3);

            Console.WriteLine($"First result: {result1}");
            Console.WriteLine($"Second result: {result2}");
            Console.WriteLine($"Third result: {result3}");

            /* Console.WriteLine("Enter y value: ");
             double y = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter z value: ");

             while (true)
             {
                 double z = 0;
                 bool successful = false; 

                 successful = Double.TryParse(Console.ReadLine(), out z); // if successful is number (true), give z a value
                 if (!successful) // if its not a number (not successful)
                 {
                     Console.WriteLine("Enter the number! ");
                 }
                 else if (z == 0)
                 {
                     Console.WriteLine("The value Z can not be null! Enter another number ");
                 }
                 else
                 {
                     double result1 = 0;
                     double result2 = 0;
                     double result3 = 0;

                     result1 = (x + y) * (Math.Pow(z, 2) + 1);
                     result2 = (x / z - 1) * Math.Sqrt(y);
                     result3 = (x * y + y * z) / Math.Pow(z, 3);

                     Console.WriteLine($"First result: {result1}");
                     Console.WriteLine($"Second result: {result2}");
                     Console.WriteLine($"Third result: {result3}");
                 }

             } */


        }
        public static Double myMethod(String letter)
        {
            Console.WriteLine($"Enter {letter} value: ");
            double letterValue = 0;
            while (true)
            {

                bool successful = false;

                successful = Double.TryParse(Console.ReadLine(), out letterValue); // if successful is number (true), give x a value
                if (!successful) // if its not a number (not successful)
                {
                    Console.WriteLine("Enter the number! ");
                }
                else if (letterValue == 0)
                {
                    Console.WriteLine($"The value {letter} can not be null! Enter another number ");
                }
                else
                {
                    break;
                }

            }
            return letterValue;
        }
    }
}
