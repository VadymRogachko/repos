using System;

/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.  
Создайте четыре метода для выполнения арифметических операций, с именами: Add – сложение,
Sub – вычитание, Mul – умножение, Div – деление. Каждый метод должен принимать два целочисленных
аргумента и выводить на экран результат выполнения арифметической операции соответствующей имени метода.
Метод деления Div, должен выполнять проверку попытки деления на ноль.  
Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов 
и знак арифметической операции, для выполнения вычислений.
 */

namespace _02
{
	class Program
	{
		static void Add(int a, int b)
		{
			Console.WriteLine($"{a} + {b} = {a + b}");
		}

		static void Sub(int a, int b)
		{
			Console.WriteLine($"{a} - {b} = {a - b}");
		}

		static void Mul(int a, int b)
		{
			Console.WriteLine($"{a} * {b} = {a * b}");
		}

		static void Div(int a, int b)
		{
			if(b == 0)
			{
				Console.WriteLine("Ошибка: попытка деления на ноль");
				return;
			}
			Console.WriteLine($"{a} / {b} = {Math.Round((double) a / b, 2)}");
		}

		static void Main(string[] args)
		{
			int a, b;
			char sign;
			Console.WriteLine("Введите первое значение");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите второе значение");
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Введите знак операции");
			sign = Convert.ToChar(Console.ReadLine());

			Console.Clear();

			switch (sign)
			{
				case '+':
					Add(a, b);
					break;
				case '-':
					Sub(a, b);
					break;
				case '*':
					Mul(a, b);
					break;
				case '/':
					Div(a, b);
					break;
				default:
					Console.WriteLine("Вы ввели неверный знак");
					break;
			}
			Console.ReadKey();
		}
	}
}
