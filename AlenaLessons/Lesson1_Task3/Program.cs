using System;

namespace Lesson1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string ");
            string firstString = Console.ReadLine().ToUpper();
            Console.WriteLine($"Formatted string1: {firstString}");

            Console.WriteLine("Enter the second string ");
            string secondString = Console.ReadLine().ToUpper();
            Console.WriteLine($"Formatted string2: {secondString}");

            Console.WriteLine("Enter the third string ");
            string thirdString = Console.ReadLine().ToUpper();
            Console.WriteLine($"Formatted string3: {thirdString}");
            //Console.ReadLine().ToUpper();

            Boolean result = firstString.StartsWith(secondString);  //Проверяем, что первая строка начинается также, как вторая
            Boolean result2 = firstString.EndsWith(thirdString); //Проверяем, что первая строка заканчивается также, как начинается третья

            Console.WriteLine($"The first string starts with the second? {result}");
            Console.WriteLine($"The first string ends as the third string starts? {result2}");

            Console.ReadKey();       
        }
    }
}

