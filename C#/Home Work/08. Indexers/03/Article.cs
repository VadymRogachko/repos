using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
	class Article
	{
		private string productName;
		private string shopName;
		private double cost;

		public Article(string productName, string shopName, double cost)
		{
			this.productName = productName;
			this.shopName = shopName;
			this.cost = cost;
		}

		public string ProductName
		{
			get
			{
				return productName;
			}
			set
			{
				productName = value;
			}
		}

		public string ShopName
		{
			get
			{
				return shopName;
			}
			set
			{
				shopName = value;
			}
		}

		public double Cost
		{
			get
			{
				return cost;
			}
			set
			{
				cost = value;
			}
		}
	}
}
