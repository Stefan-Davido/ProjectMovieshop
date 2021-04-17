namespace Movieshop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;


    public class WatchLatter
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Display(Name = "Movei ID")]
        public int MovieId { get; set; }

        [Display(Name = " Date Added")]
        public DateTime DateAdded { get; set; }
    }
}
