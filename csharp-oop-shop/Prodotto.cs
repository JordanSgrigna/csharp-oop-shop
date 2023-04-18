using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
	public class Prodotto
	{
		//ATTRIBUTES + PROPERTIES
		private int code;
		public int Code
		{
			get
			{
				return code;
			}
		}

		private string namePlusCode;
		public string NamePlusCode
		{
			get
			{
				return namePlusCode;
			}
			set
			{
				namePlusCode = value;
			}
		}

		private string formattedCode;
		public string FormattedCode
		{
			get
			{
				return formattedCode;
			}
		}


		private string name;
		public string Name
		{
			get{
				return name;
			}
			set{
				name = value;
			}
		}	


		private string description;
		public string Description
		{
			get{
				return description;
			}
			set{
				description = value; 
			}
		}


		private float price;
		public float Price
		{
			get
			{
				return price;
			}
			set
			{
				price = value;
			}
		}


		private float tax;
		public float Tax
		{
			get
			{
				return tax;
			}
			set
			{
				tax = value;
			}
		}

		private float priceWithTax;
		public float PriceWithTax
		{
			get
			{
				return priceWithTax;
			}
			set
			{
				priceWithTax = value;
			}
		}

		//CONSTRUCTOR
		public Prodotto(string name, string description, float price)
		{
			this.Name = name;
			this.Description = description;
			this.Price = price;
			this.Tax = 1.22f;
			this.code = RandomNumber();
			this.formattedCode = RandomFormattedNumber();
			this.NamePlusCode = nameCode();
			this.PriceWithTax = taxedPrice();
		}


		//METHODS
		private int RandomNumber()
		{
			Random randomGenerator = new Random();
			int randomNumber = randomGenerator.Next(10000000);
			

			return randomNumber;
		}

		private string RandomFormattedNumber()
		{
			Random randomGenerator = new Random();
			int randomNumber = randomGenerator.Next(10000000);

			string zero = "";
			for(int i = 0; i < randomNumber.ToString().Length; i++)
			{
				zero += "0";
			}

			zero = zero + Code;
			return zero;
		}

		public float basePrice()
		{
			return price;
		}


		public float taxedPrice()
		{
			float priceWithTax = price * tax;
			return priceWithTax;
		}

		public string nameCode()
		{
			namePlusCode = name + code;
			return namePlusCode;
		}
	}
}
