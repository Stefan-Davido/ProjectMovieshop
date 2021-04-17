namespace Movieshop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;


    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "User ID")]
        public string UserId { get; set; }

        [StringLength(150)]
        [Display(Name = "Movie Title")]
        public string MovieName { get; set; }

        [StringLength(150)]
        [Display(Name = "Producer Name")]
        public string ProducerName { get; set; }

        [StringLength(250)]
        [Display(Name = "Production Name")]
        public string ProductionName { get; set; }

        [StringLength(100)]
        public string Category { get; set; }
        [StringLength(100)]
        public string Genre { get; set; }

        [StringLength(100)]
        [Display(Name = "Movie Country")]
        public string MovieCountry { get; set; }

        [Display(Name = "Time Last")]
        public double TimeLast { get; set; }

        [Display(Name = "Year For Watching")]
        public int YearsToWatch { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Shipping Date")]
        public DateTime ShippingDate { get; set; }

        [Display(Name = "Delivery Date")]
        public DateTime DeliveryDate { get; set; }
        public double Price { get; set; }
    }
}
