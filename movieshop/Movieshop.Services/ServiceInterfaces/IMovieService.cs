namespace Movieshop.Services.ServiceInterfaces
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;


    public interface IMovieService
    {
        void Add(Movie movie);
        void Edit(Movie movie);
        void Edit(int id);
        void Delete(int movieId);
        Movie GetMovieById(int id);
        IEnumerable<Movie> GetAllMovies();

        Tuple<List<SelectListItem>, List<SelectListItem>, List<SelectListItem>, List<SelectListItem>, List<SelectListItem>>
            FillDropdowns(
            IEnumerable<Actor> actors,
            IEnumerable<Category> categories,
            IEnumerable<Genre> genres,
            IEnumerable<Producer> producers,
            IEnumerable<Production> productions); 
    }
}
