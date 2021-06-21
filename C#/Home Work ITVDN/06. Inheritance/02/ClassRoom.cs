using System;


namespace _02
{
	class ClassRoom
	{
		Random rand = new Random();
		Pupil[] pupils = new Pupil[4];

		public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
		{
			pupils[0] = pupil1;
			pupils[1] = pupil2;
			pupils[2] = pupil3;
			pupils[3] = pupil4;
		}

		public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
		{
			pupils[0] = pupil1;
			pupils[1] = pupil2;
			pupils[2] = pupil3;
			pupils[3] = GeneratePupil();
		}

		public ClassRoom(Pupil pupil1, Pupil pupil2)
		{
			pupils[0] = pupil1;
			pupils[1] = pupil2;
			pupils[2] = GeneratePupil(); ;
			pupils[3] = GeneratePupil();
		}

		private Pupil GeneratePupil()
		{
			int randNum = rand.Next(0, 3);

			switch (randNum)
			{
				case 0:
					return new ExcelentPupil();
				case 1:
					return new GoodPupil();
				case 2:
					return new BadPupil();
				default:
					return new GoodPupil();
			}
		}

		public void Study()
		{
			foreach(var pupil in pupils)
			{
				pupil.Study();
			}
		}

		public void Read()
		{
			foreach(var pupil in pupils)
			{
				pupil.Read();
			}
		}

		public void Write()
		{
			foreach(var pupil in pupils)
			{
				pupil.Write();
			}
		}

		public void Relax()
		{
			foreach(var pupil in pupils)
			{
				pupil.Relax();
			}
		}
	}
}
