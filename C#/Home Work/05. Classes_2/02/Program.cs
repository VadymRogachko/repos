using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Converter. 
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - 
public Converter(double usd, double eur, double rub).  
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
также программа должна производить конвертацию из указанных валют в гривну. 
 */

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			ConverterMoney converter = new ConverterMoney(27, 32, 0.3);
			Console.WriteLine($"270 grn = {converter.ConvertFromGRNtoUSD(270)} usd\n" +
				$"320 grn = {converter.ConvertFromGRNtoEUR(320)} eur\n" +
				$"120 grn = {converter.ConvertFromGRNtoRUB(120)} rub\n" +
				$"10 usd = {converter.ConvertFromUSDtoGRN(10)} usd\n" +
				$"10 eur = {converter.ConvertFromEURtoGRN(10)} eur\n" +
				$"30 rub = {converter.ConvertFromRUBtoGRN(30)} rub\n");

			Console.ReadKey();
		}
	}
}
