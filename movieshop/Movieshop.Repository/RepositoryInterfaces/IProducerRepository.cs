namespace Movieshop.Repository.RepositoryInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface IProducerRepository
    {
        void AddProducer(Producer producer);
        void EditProducer(Producer producer);
        void DeleteProducer(int producerId);
        Producer GetProducerById(int id);
        IEnumerable<Producer> GetAllProducers();
    }
}
