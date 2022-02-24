using System;

namespace Lesson1_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 2;
            double y = 3;
            double z = 4;
            double result1 = 0;
            double result2 = 0;
            double result3 = 0;

            result1 = (x + y) * (Math.Pow(z, 2) + 1);
            result2 = (x / z - 1) * Math.Sqrt(y);
            result3 = (x * y + y * z) / Math.Pow(z, 3);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadKey();
        }
    }
}
