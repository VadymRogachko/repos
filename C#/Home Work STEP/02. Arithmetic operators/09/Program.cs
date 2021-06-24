using System;

/*
 Написать программу для определения диаметра окружности, которую можно получить из отрезка проволоки длиной Х (X задает пользователь).
 */

namespace _09
{
	class Program
	{
		private const double Pi = 3.14;
		static void Main(string[] args)
		{
			Console.Write("Введите длину отрезка проволоки: ");
			double X = Convert.ToDouble(Console.ReadLine());
			double D = X / Pi;
			Console.WriteLine($"Диаметр окружности равен {D}");

			Console.ReadKey();

		}
	}
}
