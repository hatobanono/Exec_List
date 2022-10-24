using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Product> products = new List<Product>();
		}
	}

	class Product
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int Amount { get; set; }
	}
}
