namespace Movieshop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;


    public class ShoppingCard
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Display(Name = "Movie ID")]
        public int MovieId { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

    }
}
