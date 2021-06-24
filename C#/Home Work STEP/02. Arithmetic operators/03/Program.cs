using System;

/*
 Пользователь вводит число. Программа вычисляет 3-ю степень этого числа.
 */

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите число: ");
			int num = Convert.ToInt32(Console.ReadLine());
			double pow = Math.Pow(num, 3);
			Console.WriteLine($"Третья степень числа {num} равна {pow}");

			Console.ReadKey();
		}
	}
}
