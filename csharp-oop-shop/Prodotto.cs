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


		private string name;
		public int Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}	


		private string description;


		private float price;


		private int tax;
	}
}
