﻿using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать статический класс FindAndReplaceManager с методом void FindNext(string str) 
для поиска по книге из примера урока 005_Delegation. При вызове этого метода,
производится последовательный поиск строки в книге. 
 */

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			FindAndReplaceManager.FindNext("Hello");

			Console.ReadKey();
		}
	}
}
