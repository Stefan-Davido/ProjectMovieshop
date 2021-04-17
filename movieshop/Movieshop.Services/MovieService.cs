namespace Movieshop.Services
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Movieshop.Entities;
    using Movieshop.Repository.RepositoryInterfaces;
    using Movieshop.Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;


    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Add(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        public void Delete(int movieId)
        {
            _movieRepository.DeleteMovie(movieId);
        }

        public void Edit(Movie movie)
        {
            _movieRepository.EditMovie(movie);
        }

        public void Edit(int id)
        {
            _movieRepository.EditMovie(id);
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _movieRepository.GetAllMovies();
            return result;
        }

        public Movie GetMovieById(int id)
        {
            var result = _movieRepository.GetMovieById(id);
            return result;
        }


        #region Non-CRUD methods

        public Tuple<List<SelectListItem>, List<SelectListItem>, List<SelectListItem>, List<SelectListItem>, List<SelectListItem>>
            FillDropdowns(
            IEnumerable<Actor> actors,
            IEnumerable<Category> categories,
            IEnumerable<Genre> genres,
            IEnumerable<Producer> producers,
            IEnumerable<Production> productions)
        {
            List<SelectListItem> Actors = new List<SelectListItem>()
            {
                new SelectListItem() { Text =  "Select Actor:", Value = "0", Selected = true },           
            };

            foreach (var actor in actors)
            {
                Actors.Add( new SelectListItem { Value = actor.Id.ToString(), Text=actor.Name });
            }

            List<SelectListItem> Category = new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Select Category:", Value = "0", Selected= true},              
            };

            foreach(var category in categories)
            {
                Category.Add(new SelectListItem { Value = category.Id.ToString(), Text = category.Name });
            }

            List<SelectListItem> Genre = new List<SelectListItem>()
            {
                new SelectListItem() {Text="Select Genre:", Value="0"},              
            };

            foreach(var genre in genres)
            {
                Genre.Add(new SelectListItem { Value = genre.Id.ToString(), Text = genre.Name });
            };

            List<SelectListItem> Producer = new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Select Producer:", Value = "0"},
            };

            foreach(var producer in producers)
            {
                Producer.Add(new SelectListItem { Value = producer.Id.ToString(), Text = producer.Name });
            };

            List<SelectListItem> Production = new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Select Production:", Value = "0"},
            };

            foreach(var production in productions)
            {
                Production.Add(new SelectListItem { Value = production.Id.ToString(), Text = production.Name });
            };

            return Tuple.Create(Actors, Category, Genre, Producer, Production);
        }

        #endregion
    }
}
