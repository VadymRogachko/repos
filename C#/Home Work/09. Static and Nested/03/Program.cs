using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes,
который позволит сохранять заметки читателя.
 */

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			Book.Notes notes = new Book.Notes();
			notes.NotesText = "First note";
			notes.NotesText = "Second note";

			Console.WriteLine(notes.NotesText);

			Console.ReadKey();
		}
	}
}
