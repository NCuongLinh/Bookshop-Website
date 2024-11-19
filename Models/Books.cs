﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Bookshop_Website.Models
{
    public class Books
    {
        public Books(){}

        [Key]
        public int BookId { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]

        [Precision(18, 3)]
        [Display(Name = "Original Price")]
        public decimal OriginalPrice { get; set; }

        [Precision(18, 3)]
        [Display(Name = "Discount Percentage")]
        public decimal DiscountPercentage { get; set; }

        public decimal Price => OriginalPrice * (1 - DiscountPercentage / 100);

        public string Publisher { get; set; }

        public string Genre { get; set; }

        public string Language { get; set; }

        public string? Description { get; set; } 

    }
}
