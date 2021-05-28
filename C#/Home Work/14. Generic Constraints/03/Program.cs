using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс ArrayList. Реализуйте в простейшем приближении возможность 
использования его экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.  
 */

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList list = new ArrayList();
			list.Add(7);
			list.Add(3.14);
			list.Add("Hello");

			for (int i = 0; i < list.Count; i++)
			{
				Console.WriteLine(list[i]);
			}

			Console.ReadKey();
		}
	}
}
