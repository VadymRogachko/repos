using System;


namespace _01
{
	class TXTHandler : AbstractHandler
	{
		public TXTHandler(string fileName) : base(fileName) { }

		public override void Open()
		{
			Console.WriteLine("TXT файл открыт");
		}

		public override void Create()
		{
			Console.WriteLine("TXT файл изменен");
		}

		public override void Change()
		{
			Console.WriteLine("TXT файл изменен");
		}

		public override void Save()
		{
			Console.WriteLine("TXT файл сохранен");
		}
	}
}
