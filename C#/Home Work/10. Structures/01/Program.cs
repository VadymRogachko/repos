using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте структуру с именем - Notebook.  
Поля структуры: модель, производитель, цена.  
В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.  
 */

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			Notebook notebook = new Notebook("NV 6530", "LG", 22000);
			notebook.Print();

			Console.ReadKey();
		}
	}
}
