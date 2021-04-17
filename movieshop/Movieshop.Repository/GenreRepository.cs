namespace Movieshop.Repository
{
    using Movieshop.Data;
    using Movieshop.Entities;
    using Movieshop.Repository.RepositoryInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class GenreRepository : IGenreRepository
    {
        private readonly DataContext _dataContext;

        public GenreRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddGenre(Genre genre)
        {
            _dataContext.Genre.Add(genre);
            _dataContext.SaveChanges();
        }

        public void DeleteGenre(int genreId)
        {
            Genre genre = GetGenreById(genreId);
            _dataContext.Genre.Remove(genre);
            _dataContext.SaveChanges();
        }

        public void EditGenre(Genre genre)
        {
            _dataContext.Genre.Update(genre);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            var result = _dataContext.Genre.AsEnumerable();
            return result;
        }

        public Genre GetGenreById(int id)
        {
            var result = _dataContext.Genre.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
