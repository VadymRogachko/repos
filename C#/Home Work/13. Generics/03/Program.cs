using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list) 
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2
для данного урока. Выведите на экран значения элементов массива, который вернул расширяющий метод GetArray(). 
 */

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> myList = new MyList<int>();
			myList.Add(7);
			myList.Add(15);
			myList.Add(10);
			myList.Add(1);
			myList.Add(2);
			myList.Add(3);
			myList.Add(4);
			myList.Add(5);
			myList.Add(6);
			myList.Add(7);
			myList.Add(8);
			myList.Add(9);
			myList.Add(10);
			myList.Add(11);
			myList.Add(12);
			int[] arr = myList.GetArray<int>();
			foreach(int val in arr)
			{
				Console.WriteLine(val + " ");
			}

			Console.ReadKey();
		}
	}
}
