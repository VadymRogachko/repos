using System;

namespace _03
{
	class Content
	{
		private string content;

		public string Content_
		{
			get
			{
				return content;
			}
		}

		public Content(string content)
		{
			this.content = content;
		}

		public void Show()
		{
			Console.WriteLine(content);
		}
	}
}
