using System;


namespace _03
{
	class Vehicle
	{
		private double xCoord, yCoord;
		private decimal price;
		private double speed;
		private string yearOfManufacture;

		public Vehicle() { }

		public Vehicle(double xCoord, double yCoord, decimal price, double speed, string yearOfManufacture)
		{
			this.xCoord = xCoord;
			this.yCoord = yCoord;
			this.price = price;
			this.speed = speed;
			this.yearOfManufacture = yearOfManufacture;
		}

		public double XCoord
		{
			get
			{
				return xCoord;
			}
			set
			{
				xCoord = value;
			}
		}

		public double YCoord
		{
			get
			{
				return yCoord;
			}
			set
			{
				yCoord = value;
			}
		}

		public decimal Price
		{
			get
			{
				return price;
			}
			set
			{
				price = value;
			}
		}

		public double Speed
		{
			get
			{
				return speed;
			}
			set
			{
				speed = value;
			}
		}

		public string YearOfManufacture
		{
			get
			{
				return yearOfManufacture;
			}
			set
			{
				yearOfManufacture = value;
			}
		}

		public virtual void Print()
		{
			Console.WriteLine($"Координаты: x = {XCoord} y = {YCoord}\n" +
				$"Цена: {Price}\n" +
				$"Скорость:{Speed}\n" +
				$"Год выпуска: {yearOfManufacture}");
		}
	}
}
