using System;

namespace Lesson1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login = "AlenaChanto";
            string password = "WaterPark1!";
            // int attempts = 0;

            Console.WriteLine("Enter your login and password");


            for (int attempts = 1; attempts < 4; attempts++)

            {
                Console.WriteLine("Login");
                string enteredLogin = Console.ReadLine();
                Console.WriteLine("Password");
                string enteredPassword = Console.ReadLine();
                bool successful = false;
                successful = Equals(enteredLogin, login); //if successful - true
                bool successful2 = false;
                successful2 = Equals(enteredPassword, password);

                if (attempts < 3 && (!successful || !successful2))
                {
                    Console.WriteLine("Your data is incorrect. Try again.");
                }

                else if (attempts == 3 && (!successful || !successful2))
                {
                    Console.WriteLine("The amount of attempts is over");
                    break;
                }
                else
                {
                    Console.WriteLine("You have entered the system succesfully.");
                    break;
                }
                }
               Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }

   // public static double Authentification(string data)
}

