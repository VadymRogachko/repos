using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте 2 интерфейса IPlayable и IRecordable. В каждом из интерфейсов создайте по 3 метода
void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
Написать программу, которая выполняет проигрывание и запись. 
 */

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			Player player = new Player();
			player.Record();
			(player as IRecordable).Pause();
			player.Record();
			(player as IRecordable).Stop();
			player.Play();
			(player as IPlayable).Stop();

			Console.ReadKey();
		}
	}
}
