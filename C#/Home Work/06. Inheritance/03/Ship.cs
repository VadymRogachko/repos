using System;


namespace _03
{
	class Ship : Vehicle
	{
		private int amountOfPassengers;
		private string homePort;

		public Ship() { }

		public Ship(double xCoord, double yCoord, decimal price, double speed, string yearOfManufacture,
			int amountOfPassengers, string homePort) : base(xCoord, yCoord, price, speed, yearOfManufacture)
		{
			this.amountOfPassengers = amountOfPassengers;
			this.homePort = homePort;
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

		public string HomePort
		{
			get
			{
				return homePort;
			}
			set
			{
				homePort = value;
			}
		}

		public override void Print()
		{
			base.Print();
			Console.WriteLine($"Количество пассажиров: {AmountOfPassengers}\n" +
				$"Порт приписки: {homePort}");
		}
	}
}
