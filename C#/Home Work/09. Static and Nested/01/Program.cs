using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать статический класс Calculator, с методами для выполнения основных арифметических операций. 
Написать программу, которая выводит на экран основные арифметические операции.
 */

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"7 + 8 = {Calculator.Add(7, 8)}");
			Console.WriteLine($"7 - 8 = {Calculator.Subtract(7, 8)}");
			Console.WriteLine($"7 * 8 = {Calculator.Multiply(7, 8)}");
			Console.WriteLine($"7 / 8 = {Calculator.Division(7, 8)}");

			Console.ReadKey();
		}
	}
}
