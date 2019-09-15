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
			context.Restaurants.AddOrUpdate
			(r => r.Name,
				new Restaurant { Name = "IthacaHome", City = "NYC", Country = "USA" },
				new Restaurant
				{
					Name = "AlbanyHome",
					City = "Cohoes",
					Country = "USA",
					Reviews =
						new List<RestaurantReview>
						{
							new RestaurantReview {Rating = 10, Body = "Healthy Food", ReviewerName = "ManFromDC1"},
							new RestaurantReview {Rating = 10, Body = "Healthy Food Yes", ReviewerName = "ManFromDC2"},
						}
				},
				new Restaurant
				{
					Name = "NYCHome",
					City = "NYC",
					Country = "USA",
					Reviews =
						new List<RestaurantReview>
						{
							new RestaurantReview {Rating = 3, Body = "Maama!!", ReviewerName = "NYCGal1"},
							new RestaurantReview {Rating = 3, Body = "Maama is best!!", ReviewerName = "NYCGal2"},
							new RestaurantReview {Rating = 3, Body = "Go East or West, Maama is best", ReviewerName = "NYCGal3", ReviewCity = "NYC"},
						}

				}
            );

            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate (r => r.Name,
                    new Restaurant { Name = i.ToString(), City = "Nowhere", Country = "Nocountry" }
                 );
            }


		}
	}
}
					//  This method will be called after migrating to the latest version.

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
//				}
//	}
//}
