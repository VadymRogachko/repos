using System;


namespace _02
{
	class ExcelentPupil : Pupil
	{
		public override void Study()
		{
			Console.WriteLine("ExcelentPupil study");
		}

		public override void Read()
		{
			Console.WriteLine("ExcelentPupil read");
		}

		public override void Write()
		{
			Console.WriteLine("ExcelentPupil write");
		}

		public override void Relax()
		{
			Console.WriteLine("ExcelentPupil relax");
		}
	}
}
