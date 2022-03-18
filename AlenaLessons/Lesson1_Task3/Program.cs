using System;

namespace Lesson1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string ");
            string firstString = Console.ReadLine();
            string firstString2 = firstString.ToUpper();
            Console.WriteLine($"Fromatted string1: {firstString2}");

            Console.WriteLine("Enter the second string ");
            string secondString = Console.ReadLine();
            string secondString2 = secondString.ToUpper();
            Console.WriteLine($"Fromatted string2: {secondString2}");

            Console.WriteLine("Enter the third string ");
            string thirdString = Console.ReadLine();
            string thirdString2 = thirdString.ToUpper();
            Console.WriteLine($"Fromatted string3: {thirdString2}");

            Boolean result = firstString2.StartsWith(secondString2);  //Проверяем, что первая строка начинается также, как вторая
            Boolean result2 = firstString2.EndsWith(thirdString2); //Проверяем, что первая строка заканчивается также, как начинается третья

            Console.WriteLine($"The first string starts with the second? {result}");
            Console.WriteLine($"The first string ends as the third string starts? {result2}");

            Console.ReadKey();       
        }
    }
}

