namespace Movieshop.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Movieshop.Entities;
    using Movieshop.Services.ServiceInterfaces;


    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public IActionResult Index()
        {
            var genre = _genreService.GetAllGenres();
            return View(genre);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            _genreService.Add(genre);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var genre = _genreService.GetGenreById(id);
            return View(genre);
        }

        [HttpPost]
        public IActionResult Edit(Genre genre)
        {
            _genreService.Edit(genre);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var genre = _genreService.GetGenreById(id);
            return View(genre);
        }

        [HttpGet]
        public IActionResult delete(int id)
        {
            var genre = _genreService.GetGenreById(id);
            return View(genre);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteComfirmed(int id)
        {
            var genre = _genreService.GetGenreById(id);
            _genreService.Delete(genre.Id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public JsonResult CreateGenreAJAX(Genre genre)
        {
            if(genre != null)
            {
                if(!string.IsNullOrWhiteSpace(genre.Name))
                {
                    _genreService.Add(genre);
                    return Json(new { data = genre });
                }
                else
                {
                    return Json(new { data = "" });
                }
            }
            else
            {
                return Json(new { data = "" });
            }
        }

       
    }
}
