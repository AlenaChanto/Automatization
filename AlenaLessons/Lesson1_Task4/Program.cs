using System;

namespace Lesson1_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string ");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter the second string ");
            string secondString = Console.ReadLine();

            Console.WriteLine("Enter the symbol ");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine();

            string wholeString = String.Concat(firstString, secondString);
            int index = wholeString.LastIndexOf(symbol);

            Console.WriteLine($"Index of {symbol} in {wholeString}: {index}");
            Console.ReadKey();
        }
    }
}
