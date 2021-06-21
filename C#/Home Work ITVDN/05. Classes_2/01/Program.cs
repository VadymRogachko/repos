using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты).
Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса)
без возможности его дальнейшего изменения. 
Реализуйте вывод на экран информации о пользователе.
 */

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			User user = new User("login", "John", "Doe", "25");
			Console.WriteLine($"Login: {user.Login}\nName: {user.Name}\nSurname: {user.Surname}\n" +
				$"Age: {user.Age}\nDate of filling: {user.DateOfFilling}");

			Console.ReadKey();
		}
	}
}
