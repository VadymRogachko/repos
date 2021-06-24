using System;

/*
 Написать программу, которая предлагает пользователю ввести радиус окружности и считает площадь этой окружности.
 Число Pi задать в программе как константу.
 */

namespace _04
{
	class Program
	{
		private const double Pi = 3.14; 

		static void Main(string[] args)
		{
			Console.Write("Введите радиус окружности: ");
			int r = Convert.ToInt32(Console.ReadLine());
			double s = Pi * Math.Pow(r, 2);
			Console.WriteLine($"Площадь окружности равна {s}");

			Console.ReadKey();
		}
	}
}
