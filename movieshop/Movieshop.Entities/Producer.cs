namespace Movieshop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;


    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Country { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Active Years")]
        public string YearsActive { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        public virtual ICollection<Movie> Movie { get; set; }
    }
}
