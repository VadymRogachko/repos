using System;

namespace _03
{
	class Author
	{
		private string author;

		public string Author_
		{
			get
			{
				return author;
			}
		}

		public Author(string author)
		{
			this.author = author;
		}

		public void Show()
		{
			Console.WriteLine(author);
		}
	}
}
