namespace Movieshop.Services.ServiceInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface IProducerService
    {
        void Add(Producer producer);
        void Edit(Producer producer);
        void Delete(int producerId);
        Producer GetProducerById(int id);
        IEnumerable<Producer> GetAllProducers();

        IEnumerable<Movie> MovieOfProducer(int id);
    }
}
