using System;


namespace _02
{
	class Player : IPlayable, IRecordable
	{
		public void Play()
		{
			Console.WriteLine("Проигрывание музыки");
		}

		public void Record()
		{
			Console.WriteLine("Запись музыки");
		}

		void IPlayable.Pause()
		{
			Console.WriteLine("Пауза проигрывания");
		}

		void IRecordable.Pause()
		{
			Console.WriteLine("Пауза записи");
		}

		void IPlayable.Stop()
		{
			Console.WriteLine("Остановка проигрывания");
		}

		void IRecordable.Stop()
		{
			Console.WriteLine("Остановка записи");
		}
	}
}
