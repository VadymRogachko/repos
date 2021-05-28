namespace _02
{
	class CarCollection<T>: MyList<T>
	{
		private readonly MyList<string> carName;
		private readonly MyList<string> carYear;

		public CarCollection()
		{
			carName = new MyList<string>();
			carYear = new MyList<string>();
		}

		public void AddCar(string carName, string carYear)
		{
			this.carName.Add(carName);
			this.carName.Add(carYear);
		}

		public new string this[int index]
		{
			get
			{
				return carName[index] + " " + carYear[index];
			}
		}

		public new int Count
		{
			get
			{
				return carName.Count;
			}
		}

		public void DeleteAllCars()
		{
			carName.DeleteAll();
			carYear.DeleteAll();
		}
	}
}
