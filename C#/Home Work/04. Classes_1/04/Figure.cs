using System;

namespace _04
{
	class Figure
	{
		private Point point1;
		private Point point2;
		private Point point3;
		private Point point4;
		private Point point5;

		public double Perimeter
		{
			get; private set;
		}

		public string Name
		{
			get; private set;
		}

		public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
		{
			this.point1 = point1;
			this.point2 = point2;
			this.point3 = point3;
			this.point4 = point4;
			this.point5 = point5;
			PerimeterCalculator();
		}

		public Figure(Point point1, Point point2, Point point3, Point point4)
			: this(point1, point2, point3, point4, null) { }

		public Figure(Point point1, Point point2, Point point3)
			: this(point1, point2, point3, null, null) { }

		public double LengthSide(Point A, Point B)
		{
			double lengthSide = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
			return lengthSide;
		}

		private void PerimeterCalculator()
		{
			if (point5 != null)
			{
				Perimeter = Math.Round(LengthSide(point1, point2) + LengthSide(point2, point3) +
					LengthSide(point3, point4) + LengthSide(point4, point5) +
					LengthSide(point5, point1), 1); ;
				Name = "Пятиугольник";
			}
			else if (point4 != null)
			{
				Perimeter = Math.Round(LengthSide(point1, point2) + LengthSide(point2, point3) +
					LengthSide(point3, point4) + LengthSide(point4, point1), 1);
				Name = "Четырехугольник";
			}
			else
			{
				Perimeter = Math.Round(LengthSide(point1, point2) + LengthSide(point2, point3) +
					LengthSide(point3, point1), 1);
				Name = "Треугольник";
			}
		}

	}
}