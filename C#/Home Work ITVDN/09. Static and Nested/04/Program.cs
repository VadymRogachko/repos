using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется: Создать расширяющий метод для целочисленного массива, 
который сортирует элементы массива по возрастанию. 
 */

namespace _04
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 7, 33, 28, 4, 75, 11, 87, 45, 14, 91 };

			foreach (var value in arr)
			{
				Console.Write(value);
				Console.Write(" ");
			}

		    arr.MySort();

			Console.WriteLine();

			foreach(var value in arr)
			{
				Console.Write(value);
				Console.Write(" ");
			}

			Console.ReadKey();
		}
	}
}
