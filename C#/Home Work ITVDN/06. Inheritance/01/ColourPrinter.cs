using System;


namespace _01
{
	class ColourPrinter : Printer
	{
		public ColourPrinter(ConsoleColor colour)
		{
			this.colour = colour;
		}

		public override void Print(string value)
		{
			Console.ForegroundColor = colour;
			base.Print(value);
			Console.ResetColor();
		}
	}
}
