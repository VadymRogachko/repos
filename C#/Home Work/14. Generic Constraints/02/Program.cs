using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность
использования его экземпляра для создания парка машин. Минимально требуемый интерфейс
взаимодействия с экземпляром, должен включать метод добавления машин с названием 
машины и года ее выпуска, индексатор для получения значения элемента по указанному
индексу и свойство только для чтения для получения общего количества элементов.  
Создайте метод удаления всех машин автопарка.  
 */

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			CarCollection<string> carCollection = new CarCollection<string>();
			carCollection.AddCar("Toyota", "1995");
			carCollection.AddCar("Mazda", "2010");
			carCollection.AddCar("BMW", "2021");

			for (int i = 0; i < carCollection.Count; i++)
			{
				Console.Write(carCollection[i]);
			}

			Console.ReadKey();
		}
	}
}
