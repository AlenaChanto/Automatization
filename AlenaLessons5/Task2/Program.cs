using System;
using System.Collections.Generic;

namespace Lesson1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rectangle side1 (x) ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the rectangle side1 (y) ");
            int y = int.Parse(Console.ReadLine());

            Rectangle rect = new Rectangle(); //создан объект прямоугольник 
            rect.side1 = x; //стороне1 объекта присвоена переменная
            rect.side2 = y; //стороне2 объекта присвоена переменная

            int result1 = rect.AreaCalculator(x, y);
            int result2 = rect.PerimeterCalculator(x, y);
            Console.WriteLine($"Square is { result1}") ;
            Console.WriteLine($"Perimeter is { result2}");
        }
    }

    public class Rectangle //класс прямоугольник со свойствами поля
    {
       public int side1;
       public int side2;
        public int AreaCalculator(int _side1,int _side2) //метод, который считает площадь сторон
        {
            int calc = _side1 * _side2;
            return calc;


        }
        public int PerimeterCalculator(int _side1, int _side2)
        {
            int calc2 = _side1 * 2 + _side2 * 2;
            return calc2;
        }
    }

}