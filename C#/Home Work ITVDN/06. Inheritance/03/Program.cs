using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Vehicle.  
В теле класса создайте поля:  координаты и параметры средств передвижения (цена, скорость, год выпуска).  
Создайте 2 производных класса Plane и Ship.  
Для класса Plane должна быть определена высота и количество пассажиров.  
Для класса Ship — количество пассажиров и порт приписки.  
Написать программу, которая выводит на экран информацию о каждом средстве передвижения. 

 */

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			Vehicle vehiclePlane = new Plane(25.4, 73.8, 3000000, 900, "2020", 10000, 300);
			vehiclePlane.Print();

			Console.WriteLine();

			Vehicle vehicleShip = new Ship(71.8, 33.4, 20000000, 20, "2015", 2500, "Copenhagen");
			vehicleShip.Print();

			Console.ReadKey();
		}
	}
}
