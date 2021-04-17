namespace Movieshop.Repository.RepositoryInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface IGenreRepository
    {
        void AddGenre(Genre genre);
        void EditGenre(Genre genre);
        void DeleteGenre(int genreId);
        Genre GetGenreById(int id);
        IEnumerable<Genre> GetAllGenres();
    }
}
