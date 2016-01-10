using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant.Core
{
	public class DishRepository
	{
		public DishRepository ()
		{
		}

		public List<Dish> GetAllDishes()
		{
			IEnumerable<Dish> dishes = 
				from dishGroup in dishGroups
				from dish in dishGroup.Dishes
				select dish;

			return dishes.ToList<Dish> ();
		}

		public Dish GetDishByID(int dishID)
		{
			IEnumerable<Dish> dishes = 
				from dishGroup in dishGroups
				from dish in dishGroup.Dishes
					where dish.DishID == dishID
				select dish;

			return dishes.FirstOrDefault ();
		}

		public List<DishGroup> GetDishGroups()
		{
			return dishGroups;
		}

		public List<Dish> GetDishesForGroup(int dishGroupID)
		{
			var group = dishGroups.Where (d => d.DishGroupID == dishGroupID).FirstOrDefault ();

			return group == null ? null : group.Dishes;
		}

		private static List<DishGroup> dishGroups = new List<DishGroup> () {
			new DishGroup
			{
				DishGroupID = 1, Title = "Vegetarian", Dishes = new List<Dish>()
				{
					new Dish()
					{
						DishID = 1, 
						Available = true, 
						Name = "Salad", 
						Price = 100
					},
					new Dish()
					{
						DishID = 2, 
						Available = true, 
						Name = "Vegetables", 
						Price = 50.5
					}
				}
			},
			new DishGroup
			{
				DishGroupID = 1, Title = "Meat", Dishes = new List<Dish>()
				{
					new Dish()
					{
						DishID = 3, 
						Available = true, 
						Name = "Pulled Beef Hamburger", 
						Price = 150.25
					},
					new Dish()
					{
						DishID = 4, 
						Available = true, 
						Name = "Chicken Soup", 
						Price = 120
					}
				}
			}
		};
	}
}

