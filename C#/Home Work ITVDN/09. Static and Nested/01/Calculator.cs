namespace _01
{
	static class Calculator
	{
		public static double Add(double x, double y)
		{
			double result = x + y;
			return result;
		}

		public static double Subtract(double x, double y)
		{
			double result = x - y;
			return result;
		}

		public static double Multiply(double x, double y)
		{
			double result = x * y;
			return result;
		}

		public static double Division(double x, double y)
		{
			double result = 0;
			if (y != 0)
			{
				result = x / y;
			}
			return result;
		}
	}
}
