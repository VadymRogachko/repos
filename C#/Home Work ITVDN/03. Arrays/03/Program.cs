using System;

/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.  
Требуется:  
1) Создать метод MyReverse(int [] array), который принимает в качестве
аргумента массив целочисленных элементов и возвращает инвертированный массив (элементы массива в обратном порядке).  
2) Создайте метод int []  SubArray(int [] array, int index, int count). 
Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции
указанной в аргументе index, размерностью, которая соответствует значению аргумента count.  
 */

namespace _03
{
	class Program
	{
		static void MyReverse(int[] array)
		{
			int temp;
			for (int i = 0; i < array.Length / 2; ++i)
			{
				temp = array[array.Length - 1 - i];
				array[array.Length - 1 - i] = array[i];
				array[i] = temp;

			}
		}

		static int[] SubArray(int[] array, int index, int count)
		{
			int[] arr = new int[count];
			for (int i = 0; i < arr.Length; ++i, index++)
			{
				arr[i] = array[index];
			}
			return arr;
		}

		static void Main(string[] args)
		{
			int[] arr = new int[10];
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

			MyReverse(arr);
			for (int i = 0; i < arr.Length; ++i)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();

			int[] newArr = SubArray(arr, 3, 5);
			for (int i = 0; i < newArr.Length; ++i)
			{
				Console.Write(newArr[i] + " ");
			}
			Console.WriteLine();
		}
	}
}
