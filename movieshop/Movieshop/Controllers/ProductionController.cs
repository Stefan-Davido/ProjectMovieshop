namespace Movieshop.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Movieshop.Entities;
    using Movieshop.Services.ServiceInterfaces;


    public class ProductionController : Controller
    {
        private readonly IProductionService _productionService;

        public ProductionController(IProductionService productionService)
        {
            _productionService = productionService;
        }

        public IActionResult Index()
        {
            var productions = _productionService.GetAllProductions();
            return View(productions);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Production production)
        {
            _productionService.Add(production);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var production = _productionService.GetProductionById(id);
            return View(production);
        }

        [HttpPost]
        public IActionResult Edit(Production production)
        {
            _productionService.Edit(production);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var production = _productionService.GetProductionById(id);
            return View(production);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var production = _productionService.GetProductionById(id);
            return View(production);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteComfirmed(int id)
        {
            var production = _productionService.GetProductionById(id);
            _productionService.Delete(production.Id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public JsonResult CreateProductionAJAX(Production production)
        {
            if (production != null)
            {
                if(!string.IsNullOrWhiteSpace(production.Name))
                {
                    _productionService.Add(production);
                    return Json(new { data = production } );
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
