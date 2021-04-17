namespace Movieshop.Services.ServiceInterfaces
{
    using Movieshop.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface IProductionService
    {
        void Add(Production production);
        void Edit(Production production);
        void Delete(int productionId);
        Production GetProductionById(int id);
        IEnumerable<Production> GetAllProductions();
    }
}
