namespace Movieshop.Services
{
    using Movieshop.Repository.RepositoryInterfaces;
    using Movieshop.Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class WatchLatterService : IWatchLatterService
    {
        private readonly IWatchLatterRepository _watchLatterRepository;
        public WatchLatterService(IWatchLatterRepository watchLatterRepository)
        {
            _watchLatterRepository = watchLatterRepository;
        }
    }
}
