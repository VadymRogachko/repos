using System;

/*
 Написать программу, которая находит среднее арифметическое значение из двух чисел.
 */

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите первое число: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			int average = (num1 + num2) / 2;
			Console.WriteLine($"Среднее арифметическое = {average}");

			Console.ReadKey();
		}
	}
}
