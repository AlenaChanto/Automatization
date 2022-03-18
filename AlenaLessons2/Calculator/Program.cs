// See husing System;

namespace Lesson1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double digit1 = myMethod("first digit"); //вызов метода, предлагающего по очереди ввести две цифры
            double digit2 = myMethod("second digit");

            Console.WriteLine("Enter the math operation +, -, /, *, ^"); //ввод одного из допустимых символов
            char[] arraySymbols = new char[] { '+', '-', '/', '*', '^' }; //объявление массива с разрешенными символами

            while (true)
            {
                char enteredsymbol = Console.ReadKey().KeyChar;
                Console.WriteLine();
                bool successful = false;
                successful = Enumerable.Contains(arraySymbols, enteredsymbol); //в переменную кладем сравнение элемента массива с введенным символом.

                if (!successful) //если введенный символ не соответствует ни одному элементу массива, то выводим ошибку
                {
                    Console.WriteLine("Enter the suggested symbol! ");
                }
                else if (enteredsymbol.Equals(arraySymbols[0])) //если соответствует первому символу из массива, тогда выполняем сложение, и тд.
                {
                    Console.WriteLine();
                    double sum = digit1 + digit2;
                    Console.WriteLine($"Result is: {sum}");
                    break;
                }
                else if (enteredsymbol.Equals(arraySymbols[1]))
                {
                    Console.WriteLine();
                    double subtraction = digit1 - digit2;
                    Console.WriteLine($"Result is: {subtraction}");
                    break;
                }
                else if (enteredsymbol.Equals(arraySymbols[2]))
                {
                    if (digit2 == 0)
                    {
                        Console.WriteLine("it's not possible to devide by 0! Enter another operation symbol. ");
                    }
                    else
                    {
                        Console.WriteLine();
                        double devision = digit1 / digit2;
                        Console.WriteLine($"Result is: {devision}");
                        break;
                    }
                }
                else if (enteredsymbol.Equals(arraySymbols[3]))
                {
                    Console.WriteLine();
                    double multiplication = digit1 * digit2;
                    Console.WriteLine($"Result is: {multiplication}");
                    break;
                }
                else if (enteredsymbol.Equals(arraySymbols[4]))
                {
                    Console.WriteLine();
                    double exponent = Math.Pow(digit1, digit2);
                    Console.WriteLine($"Result is: {exponent}");
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        public static Double myMethod(String digit)
        {
            Console.WriteLine($"Enter {digit} value: ");
            double enteredDigit = 0;
            while (true)
            {
                bool successful = false;

                successful = Double.TryParse(Console.ReadLine(), out enteredDigit); // if successful is number (true), give first entered digit a value
                if (!successful) // if its not a number (not successful)
                {
                    Console.WriteLine("Enter the digit! ");
                }
                else
                {
                    break;
                }
            }
            return enteredDigit;
        }
    }
}