using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте метод с именем Calculate, который принимает в качестве параметров
три целочисленных значения и возвращает значение каждого аргумента деленного на 5.  

 */

namespace _01
{
	class Program
	{
		static void Calculate(ref int a, ref int b, ref int c)
		{
			a /= 5;
			b /= 5;
			c /= 5;
		}

		static void Main(string[] args)
		{
			int a = 15, b = 25, c = 45;
			Console.WriteLine($"a = {a}, b = {b}, c = {c}");

			Calculate(ref a, ref b, ref c);
			Console.WriteLine($"a = {a}, b = {b}, c = {c}");

			Console.ReadKey();
		}
	}
}
