using System;

namespace Restaurant.Core
{
	public class Dish
	{
		public Dish ()
		{
		}

		public int DishID {
			get;
			set;
		}
		public string Name {
			get;
			set;
		}

		public double Price {
			get;
			set;
		}

		public bool Available {
			get;
			set;
		}


	}
}

