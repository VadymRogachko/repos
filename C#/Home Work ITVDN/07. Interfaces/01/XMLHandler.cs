using System;


namespace _01
{
	class XMLHandler : AbstractHandler
	{
		public XMLHandler(string fileName) : base(fileName) { }

		public override void Open()
		{
			Console.WriteLine("XML файл открыт");
		}

		public override void Create()
		{
			Console.WriteLine("XML файл создан");
		}

		public override void Change()
		{
			Console.WriteLine("XML файл изменен");
		}

		public override void Save()
		{
			Console.WriteLine("XML файл сохранен");
		}
	}
}
