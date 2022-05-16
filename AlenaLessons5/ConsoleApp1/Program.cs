using System;
using System.Collections.Generic;

namespace Lesson1_Task3
{
    internal class Program
    {
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the matrix length (x) ");
			int x = int.Parse(Console.ReadLine());

			Console.WriteLine();

			Console.WriteLine("Enter the matrix width (y) ");
			int y = int.Parse(Console.ReadLine());

			Console.WriteLine();

			int[,] mas = new int[x, y];

			Random rn = new Random();

			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < y; j++)
				{
					mas[i, j] = rn.Next(100);
				}
			}
			for (int i = 0; i < x; i++)
			{
				for (int j = 0; j < y; j++)
				{
					Console.Write(String.Format("{0,3}", mas[i, j]));
				}
				Console.WriteLine();
			}
			int a = 0;
			for (int i = 0; i < x; i++)
		 {
			  for (int j = 0; j < y; j++)
			    {
			         if (i == j)
					   {
						   a += mas[i,j];
					   }
				   }
			 }
			Console.WriteLine("The sum of diagonal is {0}", a);
			Console.ReadKey();

		}
	}
}