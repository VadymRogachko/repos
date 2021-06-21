using System;

namespace _03
{
	class Title
	{
		private string title;

		public string Title_
		{
			get
			{
				return title;
			}
		}

		public Title(string title)
		{
			this.title = title;
		}

		public void Show()
		{
			Console.WriteLine(title);
		}
	}
}
