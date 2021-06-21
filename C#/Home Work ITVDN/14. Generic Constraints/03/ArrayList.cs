using System;

namespace _03
{
	class ArrayList
	{
		private object[] arr;

		public ArrayList()
		{
			arr = new object[0];
		}

		public void Add(object obj)
		{
			object[] tempArr = new object[arr.Length + 1];
			for (int i = 0; i < arr.Length; i++)
			{
				tempArr[i] = arr[i];
			}
			tempArr[arr.Length] = obj;
			arr = tempArr;
		}

		public object this[int i]
		{
			get
			{
				if (i < arr.Length)
				{
					return arr[i];
				}
				else
				{
					Console.WriteLine("Вы ввели неверный индекс");
					return new object();
				}
			}
		}

		public int Count
		{
			get
			{
				return arr.Length;
			}

		}

		public void DeleteAll()
		{
			arr = new object[0];
		}
	}
}
