using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс MyClass<T>, содержащий статический фабричный метод -  T FactoryMethod(),
который будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т).  
 */

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			int val1 = MyClass<int>.FactoryMethod();
			double val2 = MyClass<double>.FactoryMethod();
			Console.WriteLine($"val1 = {val1}\nval2 = {val2}");

			Console.ReadKey();
		}
	}
}
