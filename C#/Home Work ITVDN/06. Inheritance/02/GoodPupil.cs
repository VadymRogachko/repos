using System;


namespace _02
{
	class GoodPupil : Pupil
	{
		public override void Study()
		{
			Console.WriteLine("GoodPupil study");
		}

		public override void Read()
		{
			Console.WriteLine("GoodPupil read");
		}

		public override void Write()
		{
			Console.WriteLine("GoodPupil write");
		}

		public override void Relax()
		{
			Console.WriteLine("GoodPupil relax");
		}
	}
}
