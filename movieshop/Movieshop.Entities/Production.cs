namespace Movieshop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;


    public class Production
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        public DateTime Year { get; set; }
        [StringLength(100)]
        public string Country { get; set; }

        public virtual ICollection<Movie> Movie { get; set; }
    }
}
