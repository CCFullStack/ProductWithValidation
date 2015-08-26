using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductWithValidation.Models {

    public class Product {

        [Remote("ValidateName", "Products", ErrorMessage = "Name can't contain numbers", HttpMethod = "POST")]
        [Required(ErrorMessage = "Name is required")]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters long")]
        public string Name { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be positive")]
        public decimal Price { get; set; }
    }
}