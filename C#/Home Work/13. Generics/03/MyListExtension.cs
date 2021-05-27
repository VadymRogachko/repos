namespace _03
{
	static class MyListExtension
	{
		public static T[] GetArray<T>(this MyList<T> list)
		{
			T[] arr = new T[list.Count];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = list[i];
			}
			return arr;
		}
	}
}
