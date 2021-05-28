using System;
using System.Collections;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
В коллекцию  ArrayList, через вызов метода Add добавьте элементы структурного
и ссылочного типа, переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись? 
 */

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList myList = new ArrayList();
			myList.Add(1);
			myList.Add(3.14);
			myList.Add("Hello");

			for(int i = 0; i < myList.Count; i++)
			{
				Console.WriteLine(myList[i] + " ");
			}

			Console.ReadKey();
		}
	}
}
