namespace OdeToFood.Models
{
	public class OdeToFoodDb : DbContext
	{
		public OdeToFoodDb() : base("name=DefaultConnection")
		{

		}
		public Dbset<Restaurant> Restaurants { get; set; }
		public Dbset<RestaurantReview> Reviews { get; set; }


	}
}