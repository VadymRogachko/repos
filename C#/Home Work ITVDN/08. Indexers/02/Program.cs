using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.  
Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов,
среднее арифметическое всех элементов, вывести все нечетные значения. 
*/

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[10] { 3, 77, 11, 25, 14, 98, 56, 71, 20, 7 };

			Console.WriteLine($"Наибольшее значение массива = {FindMaxValue(arr)}");
			Console.WriteLine($"Наименьшее значение массива = {FindMinValue(arr)}");
			Console.WriteLine($"Общая сумма элементов массива = {CalculateSumOfElements(arr)}");
			Console.WriteLine($"Среднее арифметическое всех элементов массива = {CalculateArithmeticMean(arr)}");
			Console.Write("Все нечетные значения массива: ");
			PrintOdds(arr);
			Console.WriteLine();

			Console.ReadKey();
		}

		static public int FindMaxValue(int[] arr)
		{
			int maxValue = arr[0];
			for (int i = 1; i < arr.Length; ++i)
			{
				if (arr[i] > maxValue)
				{
					maxValue = arr[i];
				}
			}
			return maxValue;
		}

		static public int FindMinValue(int[] arr)
		{
			int minValue = arr[0];
			for (int i = 1; i < arr.Length; ++i)
			{
				if (arr[i] < minValue)
				{
					minValue = arr[i];
				}
			}
			return minValue;
		}

		static public int CalculateSumOfElements(int[] arr)
		{
			int sumOfElements = 0;
			for (int i = 0; i < arr.Length; ++i)
			{
				sumOfElements += arr[i];
			}
			return sumOfElements;
		}

		static public double CalculateArithmeticMean(int[] arr)
		{
			int sumOfElements = CalculateSumOfElements(arr);
			double arithmeticMean = (double) sumOfElements / arr.Length;
			return arithmeticMean;
		}

		static public void PrintOdds(int[] arr)
		{
			for (int i = 0; i < arr.Length; ++i)
			{
				if (arr[i] % 2 != 0)
				{
					Console.Write(arr[i] + " ");
				}
			}
		}
	}
}
