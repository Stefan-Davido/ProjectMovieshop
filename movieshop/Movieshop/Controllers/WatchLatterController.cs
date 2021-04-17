namespace Movieshop.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Movieshop.Services.ServiceInterfaces;


    public class WatchLatterController : Controller
    {
        private readonly IWatchLatterService _watchLatterService;

        public WatchLatterController(IWatchLatterService watchLatterService)
        {
            _watchLatterService = watchLatterService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
