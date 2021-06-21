namespace _02
{
	class ConverterMoney
	{
		private double usd;
		private double eur;
		private double rub;

		public ConverterMoney(double usd, double eur, double rub)
		{
			this.usd = usd;
			this.eur = eur;
			this.rub = rub;
		}

		public double ConvertFromGRNtoUSD(double grn)
		{
			double usdAmmount = grn / usd;
			return usdAmmount;
		}

		public double ConvertFromGRNtoEUR(double grn)
		{
			double eurAmmount = grn / eur;
			return eurAmmount;
		}

		public double ConvertFromGRNtoRUB(double grn)
		{
			double rubAmmount = grn / rub;
			return rubAmmount;
		}

		public double ConvertFromUSDtoGRN(double usd)
		{
			double grnAmmount = this.usd * usd;
			return grnAmmount;
		}

		public double ConvertFromEURtoGRN(double eur)
		{
			double eurAmmount = this.eur * eur;
			return eurAmmount;
		}

		public double ConvertFromRUBtoGRN(double rub)
		{
			double grnAmmount = this.rub * rub;
			return grnAmmount;
		}
	}
}
