using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
	public class RestaurantReview
	{
		public int ID { get; set; }

        [Required]
        [Range (1,10, ErrorMessage = "Range is 1 through 10")]
		public int Rating { get; set; }

        [Required]
        [StringLength(1024)]
		public string Body { get; set; }

        [Display(Name = "User-Reviewer Name")]
        [DisplayFormat (NullDisplayText = "Anonymous")]
		public string ReviewerName { get; set; }
		public string ReviewCity { get; set; }
		public int RestaurantID { get; set; }

	}
}