using System;


namespace _01
{
	class DOCHandler : AbstractHandler
	{
		public DOCHandler(string fileName) : base(fileName) { }

		public override void Open()
		{
			Console.WriteLine("DOC файл открыт");
		}

		public override void Create()
		{
			Console.WriteLine("DOC файл создан");
		}

		public override void Change()
		{
			Console.WriteLine("DOC файл изменен");
		}

		public override void Save()
		{
			Console.WriteLine("DOC файл сохранен");
		}
	}
}
