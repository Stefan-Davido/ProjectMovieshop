namespace Movieshop.Repository
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using Movieshop.Data;
    using Movieshop.Entities;
    using Movieshop.Entities.Logger;
    using Movieshop.Repository.RepositoryInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<MovieRepository> _logger;

        public MovieRepository(
            DataContext dataContext,
            ILogger<MovieRepository> logger)
        {
            _dataContext = dataContext;
            _logger = logger;
        }

        public void AddMovie(Movie movie)
        {
            try
            {
                _dataContext.Movie.Add(movie);
               _dataContext.SaveChanges();
                _logger.LogInformation(LoggerMessagesDisplay.MovieCreated);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.MovieNotCreatedModelStateInvalid + " " + ex);
                throw;
            }
            
        }

        public void DeleteMovie(int movieId)
        {
            try
            {
                Movie movie = GetMovieById(movieId);
                _dataContext.Movie.Remove(movie);
                _dataContext.SaveChanges();
                _logger.LogInformation(LoggerMessagesDisplay.MovieDeleted);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.MovieDeletedError + " " + ex);
                throw;
            }         
        }

        public void EditMovie(Movie movie)
        {
            try
            {
                _dataContext.Movie.Update(movie);
                _dataContext.SaveChanges();
                _logger.LogInformation(LoggerMessagesDisplay.MovieEdited);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.MovieEditErrorModelStateInvalid + " " + ex);
                throw;
            }           
        }

        public void EditMovie(int id)
        {
            try
            {
                var book = GetMovieById(id);
                _dataContext.Movie.Update(book);
                _dataContext.SaveChanges();
                _logger.LogInformation(LoggerMessagesDisplay.MovieEdited);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.MovieEditErrorModelStateInvalid + " " + ex);
                throw;
            }
           
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            try
            {
                var result = _dataContext.Movie.AsEnumerable();               
                _logger.LogInformation(LoggerMessagesDisplay.MovieEdited);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.NoMoviesInDB + " " + ex);
                throw;
            }
           
        }

        public Movie GetMovieById(int id)
        {
            try
            {
                var result = _dataContext.Movie.FirstOrDefault(x => x.Id == id);               
                _logger.LogInformation(LoggerMessagesDisplay.MovieFoundDisplayDetails);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.NoMovieFound + " " + ex);
                throw;
            }
           
        }
    }
}
