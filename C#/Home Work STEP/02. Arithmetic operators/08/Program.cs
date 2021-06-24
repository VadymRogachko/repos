using System;

/*
 Написать программу, которая находит процент P от суммы S.
 */

namespace _08
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите сумму: ");
			double S = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите процент: ");
			double P = Convert.ToDouble(Console.ReadLine());
			double mult = P / 100;
			double num = mult * S;
			Console.WriteLine($"Процент {P} от суммы {S} = {num}");

			Console.ReadKey();
		}
	}
}
