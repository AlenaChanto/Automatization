using System;

namespace Lesson1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
       {
         Console.WriteLine("Enter x value: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y value: ");
            double y = Convert.ToDouble(Console.ReadLine());

           

            Console.WriteLine("Enter z value: ");
            double z = 0;
            bool notNumber = false;

            notNumber = Double.TryParse(Console.ReadLine(), out z);
            if (!notNumber)
            {
                Console.WriteLine("Enter the number! ");
            }
            else if (z == 0)
            {
                Console.WriteLine("The value Z can not be null! ");
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

           
        }
    }
}
