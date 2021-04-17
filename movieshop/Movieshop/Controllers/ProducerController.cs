namespace Movieshop.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Movieshop.Entities;
    using Movieshop.Services.ServiceInterfaces;


    public class ProducerController : Controller
    {
        private readonly IProducerService _producerService;

        public ProducerController(IProducerService producerService)
        {
            _producerService = producerService;
        }

        public IActionResult Index()
        {
            var producer = _producerService.GetAllProducers();
            return View(producer);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producer producer)
        {
            _producerService.Add(producer);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var producer = _producerService.GetProducerById(id);
            return View(producer);
        }

        [HttpPost]
        public IActionResult Edit(Producer producer)
        {
            _producerService.Edit(producer);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            var producer = _producerService.GetProducerById(id);
            //var producerMovies = _producerService.MovieOfProducer(id);
            return View(producer);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var producer = _producerService.GetProducerById(id);
            return View(producer);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteComfirmed(int id)
        {
            var producer = _producerService.GetProducerById(id);
            _producerService.Delete(producer.Id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public JsonResult CreateProducerAJAX(Producer producer)
        {
            if(producer != null)
            {
                if(!string.IsNullOrWhiteSpace(producer.Name))
                {
                    _producerService.Add(producer);
                    return Json(new { data = producer });
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
