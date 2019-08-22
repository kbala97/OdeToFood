using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
	public class OdeToFoodDb : DbContext
	{

		public Dbset<Restaurant> Restaurants { get; set; }
		public Dbset<RestaurantReview> Reviews { get; set; }


	}
}