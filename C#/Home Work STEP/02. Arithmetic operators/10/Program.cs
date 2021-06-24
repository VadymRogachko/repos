using System;

/*
 Пользователь трижды вводит достоинство купюр и их количество. Программа должна посчитать общую сумму денег.
 */

namespace _10
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите достоинство купюр: ");
			int denomination1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество купюр: ");
			int count1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите достоинство купюр: ");
			int denomination2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество купюр: ");
			int count2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите достоинство купюр: ");
			int denomination3 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество купюр: ");
			int count3 = Convert.ToInt32(Console.ReadLine());

			int sum = (denomination1 * count1) + (denomination2 * count2) + (denomination3 * count3);
			Console.WriteLine($"Общая сумма денег: {sum}");

			Console.ReadKey();
		}
	}
}
