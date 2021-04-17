namespace Movieshop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;


    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }
        [StringLength(100)]
        public string Country { get; set; }
        [StringLength(200)]
        public string Awards { get; set; }

        // *** two ways-connection ***
        //[StringLength(200)]
        //public string Movies{ get; set; }
        //public Movie Movie { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [Display(Name = "Active Years")]
        public string YearsActive { get; set; }


        public virtual ICollection<Movie> Movie{ get; set; }
    }
}
