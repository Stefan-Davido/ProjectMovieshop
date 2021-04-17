namespace Movieshop.Repository
{
    using Movieshop.Data;
    using Movieshop.Entities;
    using Movieshop.Repository.RepositoryInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class ProductionRepository : IProductionRepository
    {
        private readonly DataContext _dataContext;

        public ProductionRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddProduction(Production production)
        {
            _dataContext.Production.Add(production);
            _dataContext.SaveChanges();
        }

        public void DeleteProduction(int productionId)
        {
            Production production = GetProductionById(productionId);
            _dataContext.Production.Remove(production);
            _dataContext.SaveChanges();
        }

        public void EditProduction(Production production)
        {
            _dataContext.Production.Update(production);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Production> GetAllProductions()
        {
            var result = _dataContext.Production.AsEnumerable();
            return result;
        }

        public Production GetProductionById(int id)
        {
            var result = _dataContext.Production.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
