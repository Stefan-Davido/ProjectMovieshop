namespace Movieshop.Repository
{
    using Movieshop.Data;
    using Movieshop.Repository.RepositoryInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class WatchLatterRepository : IWatchLatterRepository
    {
        private readonly DataContext _dataContext;

        public WatchLatterRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
