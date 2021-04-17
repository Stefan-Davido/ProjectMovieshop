namespace Movieshop.Services
{
    using Movieshop.Entities;
    using Movieshop.Repository.RepositoryInterfaces;
    using Movieshop.Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class ProductionService : IProductionService
    {
        private readonly IProductionRepository _productionRepository;

        public ProductionService(IProductionRepository productionRepository)
        {
            _productionRepository = productionRepository;
        }

        public void Add(Production production)
        {
            _productionRepository.AddProduction(production);
        }

        public void Delete(int productionId)
        {
            _productionRepository.DeleteProduction(productionId);
        }

        public void Edit(Production production)
        {
            _productionRepository.EditProduction(production);
        }

        public IEnumerable<Production> GetAllProductions()
        {
            var result = _productionRepository.GetAllProductions();
            return result;
        }

        public Production GetProductionById(int id)
        {
            var result = _productionRepository.GetProductionById(id);
            return result;
        }
    }
}
