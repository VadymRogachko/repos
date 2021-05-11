using System;

/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.  
Требуется:  
Создать массив размера N элементов, заполнить его произвольными целыми значениями (размер массива задает пользователь).  
Вывести на экран: наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов, 
среднее арифметическое всех элементов, вывести все нечетные значения. 

 */

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			int N;
			Console.WriteLine("Введите количество элементов массива");
			N = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[N];
			for (int i = 0; i < arr.Length; ++i)
			{
				Random rand = new Random();
				arr[i] = rand.Next(1, 11);
			}

			for (int i = 0; i < arr.Length; ++i)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();

			int biggestNum = arr[0];
			for (int i = 0; i < arr.Length; ++i)
			{
				if (arr[i] > biggestNum)
				{
					biggestNum = arr[i];
				}
			}
			Console.WriteLine($"Наибольшее значение массива = {biggestNum}");

			int lowestNum = arr[0];
			for (int i = 0; i < arr.Length; ++i)
			{
				if (arr[i] < lowestNum)
				{
					lowestNum = arr[i];
				}
			}
			Console.WriteLine($"Наименьшее значение массива = {lowestNum}");

			int sum = 0;
			for (int i = 0; i < arr.Length; ++i)
			{
				sum += arr[i];
			}
			Console.WriteLine($"Общая сумма всех элементов = {sum}");

			double average = (double) sum / arr.Length;
			Console.WriteLine($"Среднее арифметическое всех элементов = {average}");

			Console.Write("Все нечетные элементы: ");
			for(int i = 0; i < arr.Length; ++i)
			{
				if (arr[i] % 2 != 0)
				{
					Console.Write(arr[i] + " ");
				}
			}

			Console.ReadKey();
		}
	}
}
