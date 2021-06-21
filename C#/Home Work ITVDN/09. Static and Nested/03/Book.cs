using System;


namespace _03
{
	class Book
	{
		public class Notes
		{
			string notesText = "";

			public string NotesText
			{
				get
				{
					return notesText;
				}
				set
				{
					if (notesText != "")
					{
						notesText += "\n";
					}
					notesText += value;
				}
			}
		}

		public void FindNext(string str)
		{
			Console.WriteLine("Поиск строки");
		}
	}
}
