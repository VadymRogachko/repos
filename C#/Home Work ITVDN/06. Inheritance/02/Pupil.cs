using System;


namespace _02
{
	class Pupil
	{
		public virtual void Study()
		{
			Console.WriteLine("Pupil study");
		}

		public virtual void Read()
		{
			Console.WriteLine("Pupil read");
		}

		public virtual void Write()
		{
			Console.WriteLine("Pupil write");
		}

		public virtual void Relax()
		{
			Console.WriteLine("Pupil relax");
		}
	}
}
