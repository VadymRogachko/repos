namespace _02
{
	class Rectangle
	{
		private double side1;
		private double side2;

		public Rectangle(double side1, double side2)
		{
			this.side1 = side1;
			this.side2 = side2;
		}

		public double Area
		{
			get
			{
				return AreaCalculator();
			}
		}

		public double Perimeter
		{
			get
			{
				return PerimeterCalculator();
			}
		}

		private double AreaCalculator()
		{
			double area = side1 * side2;
			return area;
		}

		private double PerimeterCalculator()
		{
			double perimeter = 2 * (side1 + side2);
			return perimeter;
		}
	}
}
