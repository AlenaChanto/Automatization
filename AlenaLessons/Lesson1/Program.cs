using System;

namespace Lesson1_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = DigitCheck("x");
            double y = DigitCheck("y");
            double z = DigitCheck("z");

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
        public static Double DigitCheck(String letter)
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
