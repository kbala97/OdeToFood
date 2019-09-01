﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
	public class RestaurantReview
	{
		public int ID { get; set; }
		public int Rating { get; set; }
		public string Body { get; set; }
		public string ReviewerName { get; set; }
		public string ReviewCity { get; set; }
		public int RestaurantID { get; set; }

	}
}