using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность
использования его экземпляра аналогично экземпляру класса List<T>.
Минимально требуемый интерфейс взаимодействия с экземпляром, 
должен включать метод добавления элемента, индексатор для получения
значения элемента по указанному индексу и свойство только для чтения
для получения общего количества элементов.   
 */

namespace _02
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
			for (int i = 0; i < myList.Count; i++)
			{
				Console.WriteLine(myList[i] + " ");
			}

			Console.ReadKey();
		}
	}
}
