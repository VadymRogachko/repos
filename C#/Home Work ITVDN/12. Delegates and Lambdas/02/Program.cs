using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте четыре лямбда оператора для выполнения арифметических действий: 
(Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). 
Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.
Лямбда оператор деления должен делать проверку деления на ноль.  
Написать программу, которая будет выполнять арифметические действия указанные пользователем.
 */

namespace _02
{
	class Program
	{
		private delegate double MyDeleg(double x, double y);

		static void Main(string[] args)
		{
			MyDeleg Add = (x, y) => x + y;
			MyDeleg Sub = (x, y) => x - y;
			MyDeleg Mul = (x, y) => x * y;
			MyDeleg Div = (x, y) =>
			{
				double result = 0;
				if (y != 0)
				{
					result = x / y;
				}
				Console.WriteLine("Попытка деления на 0");
				return result;
			};

			double x, y;
			Console.Write("Введите первое число: ");
			x = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите второе число: ");
			y = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите операцию : +, -, * или /: ");
			string operation = Console.ReadLine();
			Console.Clear();

			switch(operation)
			{
				case "+":
					Console.WriteLine($"{x} + {y} = {Add(x, y)}");
					break;
				case "-":
					Console.WriteLine($"{x} - {y} = {Sub(x, y)}");
					break;
				case "*":
					Console.WriteLine($"{x} * {y} = {Mul(x, y)}");
					break;
				case "/":
					Console.WriteLine($"{x} / {y} = {Div(x, y)}");
					break;
				default:
					Console.WriteLine("Неверный знак операции");
					break;
			}

			Console.ReadKey();
		}
	}
}
