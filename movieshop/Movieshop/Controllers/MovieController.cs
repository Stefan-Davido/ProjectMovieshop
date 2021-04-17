namespace Movieshop.Controllers
{
    using System;
    //using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http.Headers;
    //using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    //using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.Extensions.Logging;
    using Movieshop.Entities;
    using Movieshop.Models;
    using Movieshop.Services.ServiceInterfaces;
    using Movieshop.Entities.Logger;

    //using NLog;

    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IActorService _actorService;
        private readonly ICategoryService _categoryService;
        private readonly IGenreService _genreService;
        private readonly IProducerService _producerService;
        private readonly IProductionService _productionService;
        private readonly ILogger<MovieController> _logger;

        public MovieController(
            IMovieService movieService,
            IActorService actorService,
            ICategoryService categoryService,
            IGenreService genreService,
            IProducerService producerService,
            IProductionService productionService,
            ILogger<MovieController> logger)
        {
            _movieService = movieService;
            _actorService = actorService;
            _categoryService = categoryService;
            _genreService = genreService;
            _producerService = producerService;
            _productionService = productionService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                var movie = _movieService.GetAllMovies();
                _logger.LogInformation(LoggerMessagesDisplay.MoviesListed);
                return View(movie);              
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.NoMoviesInDB + " " + ex);
                throw;
            }
           
        }

        [HttpGet]
        public IActionResult Create()
        {        
            var actors = _actorService.GetAllActors();
            var categories = _categoryService.GetAllCategories();
            var genres = _genreService.GetAllGenres();
            var producers = _producerService.GetAllProducers();
            var productions = _productionService.GetAllProductions();
            var dropdowns = _movieService.FillDropdowns(actors, categories, genres, producers, productions);


            ViewBag.Actors = dropdowns.Item1;
            ViewBag.Category = dropdowns.Item2;
            ViewBag.Genres = dropdowns.Item3;
            ViewBag.Producer = dropdowns.Item4;
            ViewBag.Production = dropdowns.Item5;

            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieViewModel model)
        {
            try
            {
                var movie = new Movie();
                movie.ActersId = model.ActersId;
                movie.ActersName = model.ActersName;
                movie.Awards = model.Awards;
                movie.CategoryId = model.CategoryId;
                movie.CategoryName = model.CategoryName;
                movie.Country = model.Country;
                movie.DateAdded = DateTime.Now;
                movie.Description = model.Description;
                movie.GenreId = model.GenreId;
                movie.GenreName = model.GenreName;
                movie.Language = model.Language;
                movie.Price = model.Price;
                movie.ProducerId = model.ProducerId;
                movie.ProducerName = model.ProducerName;
                movie.ProductionName = model.ProductionName;
                movie.ProductionId = model.ProductionId;
                movie.Rating = model.Rating;
                movie.Realise = model.Realise;
                movie.TimeLast = model.TimeLast;
                movie.Title = model.Title;
                movie.URL = model.URL;
                movie.YearsToWatch = model.YearsToWatch;

                _movieService.Add(movie);

                _logger.LogInformation(LoggerMessagesDisplay.MovieCreated);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.MovieNotCreatedModelStateInvalid + " " + ex);
                throw;
            }         
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var actors = _actorService.GetAllActors();
            var categories = _categoryService.GetAllCategories();
            var genres = _genreService.GetAllGenres();
            var producers = _producerService.GetAllProducers();
            var productions = _productionService.GetAllProductions();
            var dropdowns = _movieService.FillDropdowns(actors, categories, genres, producers, productions);

            ViewBag.Actors = dropdowns.Item1;
            ViewBag.Category = dropdowns.Item2;
            ViewBag.Genres = dropdowns.Item3;
            ViewBag.Producer = dropdowns.Item4;
            ViewBag.Production = dropdowns.Item5;

            var movie = _movieService.GetMovieById(id);
            _logger.LogInformation(LoggerMessagesDisplay.MovieFoundDisplayDetails);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(int id, Movie movie)
        {
            try
            {
                //_movieService.Edit(id);
                _movieService.Edit(movie);
                _logger.LogInformation(LoggerMessagesDisplay.MovieEdited);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.MovieEditNotFound + " " + ex);
                throw;
            }           
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            try
            {
                var movie = _movieService.GetMovieById(id);
                _logger.LogInformation(LoggerMessagesDisplay.MovieFoundDisplayDetails);
                return View(movie);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.NoMovieFound + " " + ex);
                throw;
            }          
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var movie = _movieService.GetMovieById(id);
                _logger.LogInformation(LoggerMessagesDisplay.MovieFoundDisplayDetails);
                return View(movie);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.NoMovieFound + " " + ex);
                throw;
            }           
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteComfirmed(int id)
        {
            try
            {
                var book = _movieService.GetMovieById(id);
                _movieService.Delete(book.Id);
                _logger.LogInformation(LoggerMessagesDisplay.MovieDeleted);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessagesDisplay.MovieDeletedError + " " + ex);
                throw;
            }            
        }

        // ***** Upload Photo *****

        [HttpPost]
        public IActionResult UploadPhoto()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "photos");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = fileName;

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server Error" + ex);
            }
        }
    }
}
