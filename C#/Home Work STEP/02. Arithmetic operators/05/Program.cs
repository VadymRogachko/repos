using System;

/*
 Написать программу, которая переводит доллары в гривны. Курс доллара задать в программе как константу.
 */

namespace _05
{
	class Program
	{
		private const double rate = 27.4;

		static void Main(string[] args)
		{
			Console.Write("Введите количество долларов: ");
			double dollars = Convert.ToInt32(Console.ReadLine());
			double grivnas = dollars * rate;
			Console.WriteLine($"{dollars} долларов = {grivnas} гривен");

			Console.ReadKey();
		}
	}
}
