namespace Movieshop.Models
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;


    public class MovieViewModel
    {
        // ***** Movie Data *****
        public string Title { get; set; }
        public string GenreName { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public string CategoryName { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string ActersName { get; set; }
        public Actor Actor { get; set; }
        public int ActersId { get; set; }
        public string ProducerName { get; set; }
        public Producer Producer { get; set; }
        public int ProducerId { get; set; }
        public string ProductionName { get; set; }
        public Production Production { get; set; }
        public int ProductionId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Country { get; set; }
        public double Price { get; set; }
        public DateTime Realise { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string URL { get; set; }
        public double Rating { get; set; }
        public int Awards { get; set; }
        public double TimeLast { get; set; }
        public int YearsToWatch { get; set; }


        // ***** Actor Data *****
        public string ActorNameDTO { get; set; }
        public DateTime ActorBirthDateDTO { get; set; }
        public string ActorCountryDTO { get; set; }
        public string ActorAwardsDTO { get; set; }
        public string ActorGenderDTO { get; set; }
        public string ActorYearsActiveDTO { get; set; }


        // ***** Producer Data *****
        public string ProducerNameDTO { get; set; }
        public string ProducerCountryDTO { get; set; }
        public DateTime ProducerBirthDateDTO { get; set; }
        public string ProducerYearsActiveDTO { get; set; }


        // ***** Production Data *****
        public string ProductionNameDTO { get; set; }
        public int ProductionYearDTO { get; set; }
        public string ProductionCountryDTO { get; set; }


        // ***** Category Data *****
        public string CategoryNameDTO { get; set; }


        // ***** Genre Data *****
        public string GenreNameDTO { get; set; }
    }
}
