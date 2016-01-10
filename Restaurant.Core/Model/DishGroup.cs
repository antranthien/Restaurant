using System;
using System.Collections.Generic;

namespace Restaurant.Core
{
	public class DishGroup
	{
		public DishGroup ()
		{
		}

		public int DishGroupID {
			get;
			set;
		}

		public string Title {
			get;
			set;
		}

		public string ImagePath {
			get;
			set;
		}

		public List<Dish> Dishes {
			get;
			set;
		}

	}
}

