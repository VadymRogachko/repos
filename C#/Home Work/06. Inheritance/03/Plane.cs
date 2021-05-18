using System;


namespace _03
{
	class Plane : Vehicle
	{
		private double height;
		private int amountOfPassengers;

		public Plane() { }

		public Plane(double xCoord, double yCoord, decimal price, double speed, string yearOfManufacture, 
			         double height, int amountOfPassengers) : base(xCoord, yCoord, price, speed, yearOfManufacture)
		{
			this.height = height;
			this.amountOfPassengers = amountOfPassengers;
		}

		public double Height
		{
			get
			{
				return height;
			}
			set
			{
				height = value;
			}
		}

		public int AmountOfPassengers
		{
			get
			{
				return amountOfPassengers;
			}
			set
			{
				amountOfPassengers = value;
			}
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Высота: {Height}\n" +
				$"Количество пассажиров: {AmountOfPassengers}");
		}
	}
}
