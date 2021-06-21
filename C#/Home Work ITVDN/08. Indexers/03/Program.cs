using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Article, содержащий следующие закрытые поля: 
• название товара; 
• название магазина, в котором продается товар; 
• стоимость товара в гривнах. 
Создать класс Store, содержащий закрытый массив элементов типа Article.  
Обеспечить следующие возможности: 
• вывод информации о товаре по номеру с помощью индекса; 
• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; 
Написать программу, вывода на экран информации о товаре. 
 */

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			int sizeOfStore = 3;
			Store store = new Store(sizeOfStore);
			store.AddArticle(new Article("HDD", "PC Store", 1500), 0);
			store.AddArticle(new Article("SSD", "PC Store", 2500), 1);
			store.AddArticle(new Article("Видеокарта", "PC Store", 4000), 2);

			for (int i = 0; i <= sizeOfStore; ++i)
			{
				Console.WriteLine(store[i]);
				Console.WriteLine();
			}

			Console.WriteLine(store["Видеокарта"]);
			Console.WriteLine();
			Console.WriteLine(store["HDD"]);
			Console.WriteLine();
			Console.WriteLine(store["Звуковая карта"]);
			
			Console.ReadKey();
		}
	}
}
