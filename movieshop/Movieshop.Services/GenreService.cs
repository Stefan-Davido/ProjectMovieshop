namespace Movieshop.Services
{
    using Movieshop.Entities;
    using Movieshop.Repository.RepositoryInterfaces;
    using Movieshop.Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public void Add(Genre genre)
        {
            _genreRepository.AddGenre(genre);
        }

        public void Delete(int genreId)
        {
            _genreRepository.DeleteGenre(genreId);
        }

        public void Edit(Genre genre)
        {
            _genreRepository.EditGenre(genre);
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            var result = _genreRepository.GetAllGenres();
            return result;
        }

        public Genre GetGenreById(int id)
        {
            var result = _genreRepository.GetGenreById(id);
            return result;
        }
    }
}
