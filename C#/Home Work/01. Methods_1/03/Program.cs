using System;

/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.  
Напишите программу, которая будет выполнять конвертирование валют.  
Пользователь вводит: 
сумму денег в определенной валюте. 
курс для конвертации в другую валюту. 
Организуйте вывод результата операции конвертирования валюты на экран.

 */

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal money;
			double currency;
			Console.WriteLine("Введите сумму денег");
			money = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine("Введите курс");
			currency = Convert.ToDouble(Console.ReadLine());
			Console.Clear();
			Console.WriteLine($"Результат = {money * (decimal) currency}");
			Console.ReadKey();
		}
	}
}
