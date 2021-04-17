namespace Movieshop.Repository
{
    using Movieshop.Data;
    using Movieshop.Repository.RepositoryInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
