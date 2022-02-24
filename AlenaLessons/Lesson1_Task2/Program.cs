using System;

namespace Lesson1_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = 5;
            double length = 3;
            double height = 4;
            double diagonal = 0;

            diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2) + Math.Pow(height, 2));

            Console.WriteLine(diagonal);
            Console.ReadKey();
        }
    }
}
