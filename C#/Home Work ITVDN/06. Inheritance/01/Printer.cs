using System;


namespace _01
{
	class Printer
	{
		protected ConsoleColor colour = ConsoleColor.Gray;

		public virtual void Print(string value)
		{
			Console.WriteLine(value);
		}
	}
}
