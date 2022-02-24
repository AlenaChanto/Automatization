using System;

namespace Lesson1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // not finished yet

            Console.WriteLine("Enter the first string ");

            string firstString = Console.ReadLine();

            Console.WriteLine("Enter the second string ");

            string secondString = Console.ReadLine();

            Console.WriteLine("Enter the third string ");

            string thirdString = Console.ReadLine();

            Boolean result = firstString.StartsWith(secondString);

            Console.WriteLine($"The first string starts with the second? {result}");
            Console.ReadKey();
            // Console.WriteLine("Enter x value: {0:G}", x);
            // Console.ReadKey();

        }


    }
}

