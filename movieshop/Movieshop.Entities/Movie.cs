namespace Movieshop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;


    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Title { get; set; }


        // *** get data from Genre.cs *** 
        [StringLength(100)]
        [Display(Name = "Genre Name")]
        public string GenreName { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Genre ID")]
        public int GenreId { get; set; }


        // *** get data from Category.cs *** 
        [StringLength(100)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        public Category Category { get; set; }
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }


        // *** get data from Actor.cs *** 
        [StringLength(250)]
        [Display(Name = "Actors Name")]
        public string ActersName { get; set; }
        public Actor Actor { get; set; }
        [Display(Name = "Actors ID")]
        public int ActersId { get; set; }


        // *** get data from Producer.cs *** 
        [StringLength(250)]
        [Display(Name = "Producer Name")]
        public string ProducerName { get; set; }
        public Producer Producer { get; set; }
        [Display(Name = " Producer ID")]
        public int ProducerId { get; set; }


        // *** get data from Production.cs *** 
        [StringLength(250)]
        [Display(Name = " Production Name")]
        public string ProductionName { get; set; }
        public Production Production { get; set; }
        [Display(Name = " Production ID")]
        public int ProductionId { get; set; }


        [Display(Name = " Date Added")]
        public DateTime DateAdded { get; set; }
        [StringLength(150)]
        public string Country { get; set; }
        public double Price { get; set; }
        public DateTime Realise { get; set; }
        [StringLength(1500)]
        public string Description { get; set; }
        [StringLength(100)]
        public string Language { get; set; }
        public string URL { get; set; }
        public double Rating { get; set; }
        public int Awards { get; set; }
        [Display(Name = "Time Last")]
        public double TimeLast { get; set; }
        [Display(Name = " Years For Watching")]
        public int YearsToWatch { get; set; }

    }
}
