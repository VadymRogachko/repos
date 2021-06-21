using System;


namespace _01
{
	struct Notebook
	{
		private string model;
		private string manufacturer;
		private decimal price;

		public Notebook(string model, string manufacturer, decimal price)
		{
			this.model = model;
			this.manufacturer = manufacturer;
			this.price = price;
		}

		public string Model
		{
			get
			{
				return model;
			}
		}

		public string Manufacturer
		{
			get
			{
				return manufacturer;
			}
		}

		public decimal Price
		{
			get
			{
				return price;
			}
		}

		public void Print()
		{
			Console.WriteLine($"Модель: {model}\nПроизводитель: {manufacturer}\nЦена: {price}");
		}
	}
}
