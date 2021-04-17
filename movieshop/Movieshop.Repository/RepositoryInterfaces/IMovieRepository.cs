namespace Movieshop.Repository.RepositoryInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface IMovieRepository
    {
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void EditMovie(int id);
        void DeleteMovie(int movieId);
        Movie GetMovieById(int id);
        IEnumerable<Movie> GetAllMovies();
    }
}
