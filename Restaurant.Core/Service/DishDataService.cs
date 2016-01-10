using System;
using System.Collections.Generic;

namespace Restaurant.Core
{
	public class DishDataService
	{
		public DishDataService ()
		{
		}

		private static DishRepository dishRepository = new DishRepository();

		public List<Dish> GetAllDishes()
		{
			return dishRepository.GetAllDishes ();
		}

		public List<DishGroup> GetDishGroups()
		{
			return dishRepository.GetDishGroups();
		}
	}
}

