namespace Movieshop.Repository
{
    using Movieshop.Data;
    using Movieshop.Repository.RepositoryInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class ShoppingCardRepository : IShoppingCardRepository
    {
        private readonly DataContext _dataContext;

        public ShoppingCardRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
