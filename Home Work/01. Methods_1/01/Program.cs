using System;

/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.  
Создайте метод с именем Calculate, который принимает в качестве параметров 
три целочисленных аргумента и выводит на экран среднее арифметическое значений аргументов. 

 */

namespace _01
{
	class Program
	{
		static void Calculate(int a, int b, int c)
		{
			double result = (a + b + c) / 3;
			Console.WriteLine($"Среднее арифметическое значений 5, 7, 6 = {result}");
		}

		static void Main(string[] args)
		{
			Calculate(5, 7, 6);
			Console.ReadKey();
		}
	}
}
