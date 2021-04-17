namespace Movieshop.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Movieshop.Entities;
    using Movieshop.Services.ServiceInterfaces;


    public class ActorController : Controller
    {
        private readonly IActorService _actorService;

        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }

        public IActionResult Index()
        {
            var allActors = _actorService.GetAllActors();
            return View(allActors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Actor actor)
        {
            _actorService.Add(actor);
            return RedirectToAction(nameof(Index));
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var actor = _actorService.GetActorById(id);
            return View(actor);
        }

        [HttpPost]
        public IActionResult Edit(Actor actor)
        {
            _actorService.Edit(actor);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var actor = _actorService.GetActorById(id);
            return View(actor);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var actor = _actorService.GetActorById(id);
            return View(actor);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteComfirm(int id)
        {
            var actor = _actorService.GetActorById(id);
            _actorService.Delete(actor.Id);
            return RedirectToAction(nameof(Index));
        }
       

        [HttpPost]
        public JsonResult CreateActorAJAX(Actor actor)
        {
            if (actor != null)
            {
                if (!string.IsNullOrWhiteSpace(actor.Name))
                {
                   _actorService.Add(actor);
                    return Json(new { data = actor });
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
