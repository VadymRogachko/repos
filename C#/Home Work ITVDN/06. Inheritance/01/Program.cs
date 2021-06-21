using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте класс Printer.  
В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.  
Реализуйте возможность того, чтобы в случае наследования от данного класса других классов,
и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.  
Обязательно используйте приведение типов.
 */

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			Printer printer1 = new Printer();
			printer1.Print("Hello World");

			Printer printerYellow = new ColourPrinter(ConsoleColor.Yellow);
			printerYellow.Print("Hello World");

			ColourPrinter printerRed = new ColourPrinter(ConsoleColor.Red);
			printerRed.Print("Hello World");

			ColourPrinter printerGreen = new ColourPrinter(ConsoleColor.Green);
			Printer printer2 = printerGreen;
			printer2.Print("Hello World");

			Console.ReadKey();
		}
	}
}
