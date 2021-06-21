using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте анонимный метод, который принимает в качестве аргумента массив делегатов
и возвращает среднее арифметическое возвращаемых значений методов сообщенных
с делегатами в массиве. Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.  
 */

namespace _03
{
	class Program
	{
		private delegate int MyDeleg();
		private delegate double Calculate(MyDeleg[] delegs);

		static public int GetNumber()
		{
			return new Random().Next(10);
		}

		static void Main(string[] args)
		{
			MyDeleg[] delegs = new MyDeleg[3];
			for (int i = 0; i < delegs.Length; ++i)
			{
				delegs[i] = () => new MyDeleg(GetNumber).Invoke();
			}

			Calculate calculate = delegate (MyDeleg[] delegs)
			{
				double sum = 0;
				for (int i = 0; i < delegs.Length; ++i)
				{
					sum += delegs[i].Invoke();
				}
				return (double)sum / delegs.Length;
			};

			for (int i = 0; i < delegs.Length; ++i)
			{
				Console.WriteLine(delegs[i].Invoke() + " ");
			}

			Console.WriteLine($"Среднее арифметическое = {calculate(delegs)}");

			Console.ReadKey();
		}
	}
}
