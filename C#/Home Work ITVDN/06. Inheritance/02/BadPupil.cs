using System;


namespace _02
{
	class BadPupil : Pupil
	{
		public override void Study()
		{
			Console.WriteLine("BadPupil study");
		}

		public override void Read()
		{
			Console.WriteLine("BadPupil read");
		}

		public override void Write()
		{
			Console.WriteLine("BadPupil write");
		}

		public override void Relax()
		{
			Console.WriteLine("BadPupil relax");
		}
	}
}
