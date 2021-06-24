using System;

/*
 Написать программу, которая находит корень линейного уравнения ax + b = 0.
 */

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите первое число: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			int x = -num2 / num1;
			Console.WriteLine($"Корень линейного уравнения {num1}x + {num2} = 0 равен {x}");

			Console.ReadKey();
		}
	}
}
