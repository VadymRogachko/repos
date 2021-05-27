namespace _02
{
	class MyList<T>
	{
		private T[] arr = new T[size];
		private int count;
		private static int size = 10;

		public int Count
		{
			get
			{
				return count;
			}
		}

		public void Add(T val)
		{
			if (count >= size)
			{
				size *= 2;
				T[] arrTemp = new T[size];
				for(int i = 0; i < arr.Length; ++i)
				{
					arrTemp[i] = arr[i];
				}
				arr = arrTemp;
			}
			arr[count] = val;
			count++;
		}

		public T this[int i]
		{
			get
			{
				if (i < arr.Length)
				{
					return arr[i];
				}
				else
				{
					return default(T);
				}
			}
		}
	}
}
