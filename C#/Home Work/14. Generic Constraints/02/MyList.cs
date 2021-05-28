using System;

namespace _02
{
	interface IMyList<T>
	{
		void Add(T car);
		T this[int index] { get; }
		int Count { get; }
		void DeleteAll();
	}

	class MyList<T>: IMyList<T>
	{
		T[] cars;

		public MyList()
		{
			cars = new T[0];
		}

		public void Add(T car)
		{
			T[] tempArr = new T[cars.Length + 1];
			for (int i = 0; i < cars.Length; i++)
			{
				tempArr[i] = cars[i];
			}
			tempArr[cars.Length] = car;
			cars = tempArr;
		}

		public T this[int index]
		{
			get
			{
				if (index < cars.Length)
				{
					return cars[index];
				}
				else
				{
					Console.WriteLine("Вы ввели неверный индекс");
					return default(T);
				}
			}
		}

		public int Count
		{
			get
			{
				return cars.Length;
			}
		}

		public void DeleteAll()
		{
			cars = new T[0];
		}
	}
}
