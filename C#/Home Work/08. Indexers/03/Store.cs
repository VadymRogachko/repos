using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
	class Store
	{
		private Article[] articles;

		public Store(int size)
		{
			articles = new Article[size];
		}

		public string this[int index]
		{
			get
			{
				if (index >= 0 && index < articles.Length)
				{
					return articles[index].ProductName + "\n" +
					articles[index].ShopName + "\n" +
					Convert.ToString(articles[index].Cost);
				}
				else
				{
					return "Обращение за границы массива";
				}
			}
		}

		public string this[string productName]
		{
			get
			{
				string productInfo = "Товар не найден";
				for (int i = 0; i < articles.Length; ++i)
				{
					if (articles[i].ProductName == productName)
					{
						productInfo = articles[i].ProductName + "\n" +
						articles[i].ShopName + "\n" +
						Convert.ToString(articles[i].Cost);
					}
				}
				return productInfo;
			}
		}

		public void AddArticle(Article article, int index)
		{
			if (index >= 0 && index < articles.Length)
			{
				articles[index] = article;
			}
			else
			{
				Console.WriteLine("Обращение за границы массива");
			}
		}
	}
}