using System;

namespace Lesson1_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double diagonal = 0;

            if (width < 0.1 || length < 0.1 || height < 0.1)
            {
                Console.WriteLine("The value should be > 0!");
            }
            else
            {
                diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2) + Math.Pow(height, 2));

                Console.WriteLine($"Parallelepiped diagonal length: { diagonal}"); 
                Console.ReadKey();
            }
        }
    }
}
