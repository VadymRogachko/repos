namespace _04
{
	class Point
	{
		private int x;
		private int y;
		private string str;

		public int X
		{
			get
			{
				return x;
			}
		}

		public int Y
		{
			get
			{
				return y;
			}
		}

		public Point(int x, int y, string str = "")
		{
			this.x = x;
			this.y = y;
			this.str = str;
		}
	}
}
