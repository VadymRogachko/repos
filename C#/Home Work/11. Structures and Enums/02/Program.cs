using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application. 
Создайте статический класс с методом void Print (string stroka, int color), 
который выводит на экран строку заданным цветом.  Используя перечисление, 
создайте набор цветов, доступных пользователю. Ввод строки и выбор цвета предоставьте пользователю. 
 */

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите строку: ");
			string str = Console.ReadLine();

			Console.WriteLine("Введите цвет: 0 - Red, 1 - Green, 2 - Blue, 3 - White, 4 - Yellow");
			int color = Convert.ToInt32(Console.ReadLine());
			Console.Clear();

			Printer.Print(str, color);

			Console.ReadKey();
		}
	}
}
