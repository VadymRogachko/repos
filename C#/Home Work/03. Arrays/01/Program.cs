using System;

/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.  
Создайте массив размерностью в 10 элементов, выведите на экран все элементы массива в обратном порядке.

 */

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			for (int i = arr.Length - 1; i >= 0; --i)
			{
				Console.Write(arr[i] + " ");
			}
			Console.ReadKey();
		}
	}
}
