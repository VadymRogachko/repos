using System;

/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.  
Требуется:  
Создать метод, который будет выполнять увеличение длины массива переданного
в качестве аргумента, на 1 элемент. Элементы массива, должны сохранить свое значение и порядок индексов. 
Создайте метод, который принимает два аргумента, первый аргумент -  типа int [] array, 
второй аргумент - типа int value. В теле метода реализуйте возможность добавления второго аргумента метода
в массив по индексу – 0, при этом длина нового массива, должна увеличиться на 1 элемент, а элементы 
получаемого массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 1.
 */

namespace _04
{
	class Program
	{
		static void ArrayGrowing(ref int[] array)
		{
			int[] arr = new int[array.Length];
			for (int i = 0; i < arr.Length; ++i)
			{
				arr[i] = array[i];
			}
			array = new int[arr.Length + 1];
			for (int i = 0; i < array.Length - 1; ++i)
			{
				array[i] = arr[i];
			}
		}

		static void AddValue(ref int[] array, int value)
		{
			ArrayGrowing(ref array);
			for (int i = array.Length - 1; i > 0; --i)
			{
				array[i] = array[i - 1];
			}
			array[0] = value;
		}

		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			for (int i = 0; i < arr.Length; ++i)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();

			ArrayGrowing(ref arr);
			for (int i = 0; i < arr.Length; ++i)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();

			AddValue(ref arr, 77);
			for (int i = 0; i < arr.Length; ++i)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}
	}
}
