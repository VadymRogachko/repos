using System;


namespace _01
{
	abstract class AbstractHandler
	{
		protected string fileName;

		public AbstractHandler(string fileName)
		{
			this.fileName = fileName;
		}

		public abstract void Open();
		public abstract void Create();
		public abstract void Change();
		public abstract void Save();
	}
}
