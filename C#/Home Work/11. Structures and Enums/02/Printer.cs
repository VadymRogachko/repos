using System;


namespace _02
{
	static class Printer
	{
		public static void Print(string line, int color)
		{
			Colors strokaColor = (Colors)color;
			switch(strokaColor)
			{
				case Colors.Red:
					Console.ForegroundColor = ConsoleColor.Red;
					break;
				case Colors.Green:
					Console.ForegroundColor = ConsoleColor.Green;
					break;
				case Colors.Blue:
					Console.ForegroundColor = ConsoleColor.Blue;
					break;
				case Colors.White:
					Console.ForegroundColor = ConsoleColor.White;
					break;
				case Colors.Yellow:
					Console.ForegroundColor = ConsoleColor.Yellow;
					break;
				default:
					break;
			}
			Console.WriteLine(line);
			Console.ResetColor();
		}
	}
}
