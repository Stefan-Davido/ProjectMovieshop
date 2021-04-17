namespace Movieshop.Repository.RepositoryInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface IProductionRepository
    {
        void AddProduction(Production production);
        void EditProduction(Production production);
        void DeleteProduction(int productionId);
        Production GetProductionById(int id);
        IEnumerable<Production> GetAllProductions();
    }
}
