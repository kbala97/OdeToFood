namespace OdeToFood.Migrations
{
	using OdeToFood.Models;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDb context)
        {
			//  This method will be called after migrating to the latest version.

			context.Restaurants.AddOrUpdate(r => r.Name,
				new Models.Restaurant { Name = "AlbanyFood", City = "Cohoes", Country = "USA" },
				new Models.Restaurant {Name = "IthacaFood", City = "Ithaca", Country = "USA"},
				new Models.Restaurant
				{
					Name = "HomeFood",
					City = "NYC",
					Country = "USA",
					Reviews = new List<RestaurantReview>
					{
						new RestaurantReview { Rating = 9, Body = "Love it", ReviewerName = "Me"},
						new RestaurantReview {Rating = 10, Body = "Our Mama cooks the best!", ReviewerName = "ManFromDC"}
					}
				}

				);

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
