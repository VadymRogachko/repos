using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант. 
Присвойте каждой константе значение,  задающее количество часов, которые должен отработать сотрудник за месяц.  
Создайте класс  Accauntant с методом bool AskForBonus(Post worker, int hours), 
отражающее давать или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему положена премия. 
 */

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите количество отработанных часов: ");
			int workedDays = Convert.ToInt32(Console.ReadLine());

			Accauntant accauntant = new Accauntant();

			Console.Clear();

			if (accauntant.AskForBonus(Positions.Programmer, workedDays))
			{
				Console.WriteLine("Дать премию программисту");
			}
			else
			{
				Console.WriteLine("Не давать премию программисту");
			}

			if (accauntant.AskForBonus(Positions.Manager, workedDays))
			{
				Console.WriteLine("Дать пермию менеджеру");
			}
			else
			{
				Console.WriteLine("Не давать премию менеджеру");
			}

			Console.ReadKey();
		}
	}
}
