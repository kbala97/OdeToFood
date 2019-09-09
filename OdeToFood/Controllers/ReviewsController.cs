using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
	public class ReviewsController : Controller

	{
		OdeToFoodDb _db = new OdeToFoodDb();

		// GET: Reviews
		public ActionResult Index([Bind(Prefix = "Id")] int restaurantId)
		{
			var restaurant = _db.Restaurants.Find(restaurantId);
			if (restaurant != null)
			{
				return View(restaurant);
			}
			return HttpNotFound();

		}


		// Get and Post Reviews/Create
		[HttpGet]
		public ActionResult Create(int restaurantId)
		{
			
			return View();

		}
		[HttpPost]
		public ActionResult Create(RestaurantReview review)
		{
			if (ModelState.IsValid)
			{
				_db.Reviews.Add(review);
				_db.SaveChanges();
				return RedirectToAction("Index", new { id = review.RestaurantID });
			}
			return View(review);
		}

		// Get and Post Reviews/Edit
		[HttpGet]

		public ActionResult Edit(int id)
		{
                var review = _db.Reviews.Find(id);
                return View(review);

        }

		[HttpPost]
		public ActionResult Edit(RestaurantReview review)
		{
			if (ModelState.IsValid)
			{

				//RestaurantReview r = new RestaurantReview();
    //            r = _db.Reviews.Find(review);
    //            r.Rating = review.Rating;
				//r.RestaurantID = review.RestaurantID;
				//r.Rating = review.Rating;
				//r.ReviewerName = review.ReviewerName;
				//r.ReviewCity = review.ReviewCity;
								
				_db.SaveChanges();
				return RedirectToAction("Index", new { id = review.RestaurantID });
			}
			return View(review);
		}

		protected override void Dispose(bool disposing)
		{
			_db.Dispose();
			base.Dispose(disposing);
		}



	}

}
