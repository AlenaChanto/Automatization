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

            /*    Console.WriteLine("String = {0}", wholeString);
                int lastPosition = 0;

                while (wholeString.Length > 0)
                {
                    int firstPosition = wholeString.IndexOf(symbol);

                    if (firstPosition == -1)

                    {

                        break;
                    }
                    else
                    {
                        lastPosition = lastPosition + firstPosition;
                        wholeString = wholeString.Substring(firstPosition + 1);
                    }
                }
            */

            Console.WriteLine($"Index of {symbol} in {wholeString}: {index}");
            Console.ReadKey();






















            /*  while (true)
              {
                  string Symbol = Console.ReadLine();

                  double LengthSymbol = Symbol.Length;
                  if (LengthSymbol > 1)
                  {
                      Console.WriteLine("Input doesn't have one symbol, enter one symbol");
                  }

                  else if (!Symbol.Contains("@") || Symbol.Contains("#") || Symbol.Contains("$"))
                  {
                      Console.WriteLine("It is not a symbol, enter the symbol");
                  }
                  else
                  {
                      string wholeString = String.Concat(firstString, secondString, Symbol);
                      Console.WriteLine("String = {0}", wholeString);

                      int Index = wholeString.IndexOf(Symbol);
                      Console.WriteLine($"Index of {Symbol} in {wholeString}: {Index}");
                      Console.ReadKey();
                  }
              }
            */
        }
    }
}
