using System;

/*
 Написать программу, которая предлагает пользователю ввести год своего рождения и текущий год и в ответ показывает возраст пользователя.
 */

namespace _07
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите год своего рождения: ");
			int yearOfBirth = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите текущий год: ");
			int currentYear = Convert.ToInt32(Console.ReadLine());
			int age = currentYear - yearOfBirth;
			Console.WriteLine($"Ваш возраст {age} лет");

			Console.ReadKey();
		}
	}
}
