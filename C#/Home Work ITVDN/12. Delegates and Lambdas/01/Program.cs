using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте анонимный метод, который принимает в качестве параметров 
три целочисленных аргумента и возвращает среднее арифметическое этих аргументов. 
 */

namespace _01
{
	class Program
	{
		public delegate double MyDeleg(int x, int y, int z);

		static void Main(string[] args)
		{
			MyDeleg myDeleg = delegate (int x, int y, int z)
			{
				double result = (double)(x + y + z) / 3;
				return result;
			};

			Console.Write("Введите первое число: ");
			int x = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите второе число: ");
			int y = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите третье число: ");
			int z = Convert.ToInt32(Console.ReadLine());

			Console.Clear();

			double result = myDeleg(x, y, z);
			Console.WriteLine("Среднее арифметическое = {0:##.###}", result);

			Console.ReadKey();
		}
	}
}
