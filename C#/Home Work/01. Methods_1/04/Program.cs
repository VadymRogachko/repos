using System;

/*
Используя Visual Studio, создайте проект по шаблону ConsoleApplication.  
Напишите метод, который будет определять:  
1) является ли введенное число положительным или отрицательным.  
2) Является ли оно простым (используйте технику перебора значений).  
(Простое число — это натуральное число, которое делится на 1 и само на себя. 
Чтобы определить простое число или нет, следует найти все его целые делители. Если делителей больше 2-х, значит оно не простое.) 
3) Делится ли на 2, 5, 3, 6, 9 без остатка.
 */

namespace _04
{
	class Program
	{
		static void Define(int num)
		{
			if (num > 0)
			{
				Console.WriteLine("Число положительное");
			}
			else if (num < 0)
			{
				Console.WriteLine("Число отрицательное");
			}
			else
			{
				Console.WriteLine("Вы ввели 0");
			}

			bool flag = true;
			if (num < 0)
			{
				Console.WriteLine("Число не простое");
				flag = false;
			}
			for (int i = 2; i < num; ++i)
			{
				if (num % i == 0)
				{
					Console.WriteLine("Число не простое");
					flag = false;
					break;
				}
			}
			if (flag == true)
			{
				Console.WriteLine("Число простое");
			}

			if (num % 2 == 0 && num % 3 == 0 && num % 5 == 0 && num % 6 == 0 && num % 9 == 0)
			{
				Console.WriteLine("Число делится на 2, 3, 5, 6, 9 без остатка");
			}
			else
			{
				Console.WriteLine("Число не делится на 2, 3, 5, 6, 9 без остатка");
			}
		}

		static void Main(string[] args)
		{
			int num;
			Console.WriteLine("Введите число");
			num = Convert.ToInt32(Console.ReadLine());
			Console.Clear();
			Define(num);
			Console.ReadKey();
		}
	}
}
