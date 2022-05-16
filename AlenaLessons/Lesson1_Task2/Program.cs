using System;

namespace Lesson1_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double width = DigitCheck("width");
            double length = DigitCheck("length");
            double height = DigitCheck("height");
            double diagonal = 0;

            if (width == 0 || length == 0 || height == 0)
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
