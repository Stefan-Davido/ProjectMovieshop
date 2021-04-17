namespace Movieshop.Services
{
    using Movieshop.Repository.RepositoryInterfaces;
    using Movieshop.Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public class ShoppingCardService : IShoppingCardService
    {
        private readonly IShoppingCardRepository _shoppingCardRepository;
        private readonly IMovieRepository _movieRepository;

        public ShoppingCardService(IShoppingCardRepository shoppingCardRepository,
            IMovieRepository movieRepository)
        {
            _shoppingCardRepository = shoppingCardRepository;
            _movieRepository = movieRepository;
        }
    }
}
