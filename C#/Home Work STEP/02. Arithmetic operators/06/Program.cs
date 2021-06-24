using System;

/*
 Написать программу, которая переводит сухопутные мили в километры. Одна миля – 1.609 км.
 */

namespace _06
{
	class Program
	{
		private const double mile = 1.609; 

		static void Main(string[] args)
		{
			Console.Write("Введите количество миль: ");
			double miles = Convert.ToDouble(Console.ReadLine());
			double kilometers = mile * miles;
			Console.WriteLine($"{miles} миль = {kilometers} километров");

			Console.ReadKey();
		}
	}
}
