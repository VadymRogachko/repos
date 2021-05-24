using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Реализуйте программу, которая будет принимать от пользователя дату его рождения и
выводить количество дней до его следующего дня рождения. 
 */

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите дату вашего рождения: ");
			DateTime dayOfBirth = Convert.ToDateTime(Console.ReadLine());
			DateTime today = DateTime.Now;
			Console.Clear();

			DateTime currentYear = new DateTime(today.Year, dayOfBirth.Month, dayOfBirth.Day);

			Console.Write("До вашего дня рождения осталось: ");
			if(currentYear < today)
			{
				currentYear = new DateTime(today.Year + 1, dayOfBirth.Month, dayOfBirth.Day);
				Console.WriteLine((currentYear - today).Days);
			}
			else
			{
				Console.WriteLine((currentYear - today).Days);
			}

			Console.ReadKey();
		}
	}
}
