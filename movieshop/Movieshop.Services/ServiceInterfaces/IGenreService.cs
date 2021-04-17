namespace Movieshop.Services.ServiceInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface IGenreService
    {
        void Add(Genre genre);
        void Edit(Genre genre);
        void Delete(int genreId);
        Genre GetGenreById(int id);
        IEnumerable<Genre> GetAllGenres();
    }
}
