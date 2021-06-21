using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте класс AbstractHandler. 
В теле класса создать методы void Open(), void Create(), void Change(), void Save(). 
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. 
Написать программу, которая будет выполнять определение документа и для каждого формата должны быть
методы открытия, создания, редактирования, сохранения определенного формата документа.
 */

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			AbstractHandler handler = null;

			Console.Write("Введите имя документа: ");
			string fileName = Console.ReadLine();
			Console.Clear();

			string documentType = fileName.Substring(fileName.Length - 4);
			documentType = documentType.ToLower();

			switch(documentType)
			{
				case ".xml":
					handler = new XMLHandler(fileName);
					break;
				case ".doc":
					handler = new DOCHandler(fileName);
					break;
				case ".txt":
					handler = new TXTHandler(fileName);
					break;
				default:
					Console.WriteLine("Неизвестный формат файла");
					break;
			}

			if (handler != null)
			{
				handler.Open();
				handler.Change();
				handler.Save();
			}

			Console.ReadKey();
		}
	}
}
