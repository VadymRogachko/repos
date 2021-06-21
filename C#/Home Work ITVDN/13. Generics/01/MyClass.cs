namespace _01
{
	class MyClass<T>
	{
		public static T FactoryMethod()
		{
			T instance = default(T);
			return instance;
		}
	}
}
