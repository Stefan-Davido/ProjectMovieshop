namespace Movieshop.Repository
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Movieshop.Data;
    using Movieshop.Entities;
    using Movieshop.Repository.RepositoryInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class ProducerRepository : IProducerRepository
    {
        private readonly DataContext _dataContext;

        public ProducerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddProducer(Producer producer)
        {
            _dataContext.Producer.Add(producer);
            _dataContext.SaveChanges();
        }

        public void DeleteProducer(int producerId)
        {
            Producer producer = GetProducerById(producerId);
            _dataContext.Producer.Remove(producer);
            _dataContext.SaveChanges();
        }

        public void EditProducer(Producer producer)
        {
            _dataContext.Producer.Update(producer);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Producer> GetAllProducers()
        {
            var result = _dataContext.Producer.AsEnumerable();
            return result;
        }

        public Producer GetProducerById(int id)
        {
            var result = _dataContext.Producer.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
