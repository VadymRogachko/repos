using System;

/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс с именем Address. 
В теле класса требуется создать поля: index, country, city, street, house, apartment.
Для каждого поля, создать свойство с двумя методами доступа.  
Создать экземпляр класса Address.  
В поля экземпляра записать информацию о почтовом адресе.  
Выведите на экран значения полей, описывающих адрес.
*/

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			Address address = new Address();
			address.Index = "0845";
			address.Country = "Ukraine";
			address.City = "Odessa";
			address.Street = "Pushkinskaya";
			address.House = "25";
			address.Apartment = "17";

			Console.WriteLine($"Index: {address.Index}\nCountry: {address.Country}\n" +
				$"City: {address.City}\nStreet: {address.Street}\nHouse: {address.House}\n" +
				$"Apartment: {address.Apartment}\n");

			Console.ReadKey();
		}
	}
}
