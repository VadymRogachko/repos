using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать классы Point и Figure.  
Класс Point должен содержать два целочисленных поля и одно строковое поле. 
Создать три свойства с одним методом доступа get.  
Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
void PerimeterCalculator(), который рассчитывает периметр многоугольника. 
Написать программу, которая выводит на экран название и периметр многоугольника. 
 */

namespace _04
{
	class Program
	{
		static void Main(string[] args)
		{
			Point point1 = new Point(7, 8);
			Point point2 = new Point(3, 11);
			Point point3 = new Point(5, 9);
			Point point4 = new Point(12, 4);
			Point point5 = new Point(3, 4);

			Figure figure3Sides = new Figure(point1, point2, point3);
			Console.WriteLine($"{figure3Sides.Name} Периметр = {figure3Sides.Perimeter}");

			Figure figure4Sides = new Figure(point1, point2, point3, point4);;
			Console.WriteLine($"{figure4Sides.Name} Периметр = {figure4Sides.Perimeter}");

			Figure figure5Sides = new Figure(point1, point2, point3, point4, point5);
			Console.WriteLine($"{figure5Sides.Name} Периметр = {figure5Sides.Perimeter}");

			Console.ReadKey();
		}
	}
}
