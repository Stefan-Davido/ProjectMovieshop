namespace Movieshop.Services
{
    using Movieshop.Entities;
    using Movieshop.Repository.RepositoryInterfaces;
    using Movieshop.Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository _producerRepository;
        public ProducerService(IProducerRepository producerRepository)
        {
            _producerRepository = producerRepository;
        }

        public void Add(Producer producer)
        {
            _producerRepository.AddProducer(producer);
        }

        public void Delete(int producerId)
        {
            _producerRepository.DeleteProducer(producerId);
        }

        public void Edit(Producer producer)
        {
            _producerRepository.EditProducer(producer);
        }

        public IEnumerable<Producer> GetAllProducers()
        {
            var result = _producerRepository.GetAllProducers();
            return result;
        }

        public Producer GetProducerById(int id)
        {
            var result = _producerRepository.GetProducerById(id);
            return result;
        }


        #region Non-CRUD Methods     
        public IEnumerable<Movie> MovieOfProducer(int id)
        {
            List<Movie> movies = new List<Movie>();
            Movie movie = new Movie();
            if (movie.Id == id)
            {
                movies.Add(movie);
            }
            return movies;
        }

        #endregion
    }
}
