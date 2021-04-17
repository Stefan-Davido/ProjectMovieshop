namespace Movieshop.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Movieshop.Services.ServiceInterfaces;


    public class ShoppingCardController : Controller
    {
        private readonly IShoppingCardService _shoppingCardService;
        private readonly IMovieService _movieService;

        public ShoppingCardController(IShoppingCardService shoppingCardService,
            IMovieService movieService)
        {
            _shoppingCardService = shoppingCardService;
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
