using System;

namespace _01
{
	class User
	{
		private string login;
		private string name;
		private string surname;
		private string age;
		private readonly DateTime dateOfFilling;

		public string Login
		{
			get
			{
				return login;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
		}

		public string Surname
		{
			get
			{
				return surname;
			}
		}

		public string Age
		{
			get
			{
				return age;
			}
		}

		public DateTime DateOfFilling
		{
			get
			{
				return dateOfFilling;
			}
		}

		public User(string login, string name, string surname, string age)
		{
			this.login = login;
			this.name = name;
			this.surname = surname;
			this.age = age;
			this.dateOfFilling = DateTime.Now;
		}
	}
}
