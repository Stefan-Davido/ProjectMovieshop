namespace Movieshop.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Movieshop.Entities;
    using Movieshop.Services.ServiceInterfaces;


    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _categoryService.Add(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            _categoryService.Edit(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            return View(category);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteComfirmed(int id)
        {
            var category = _categoryService.GetCategoryById(id);
            _categoryService.Delete(category.Id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public JsonResult CreateCategoryAJAX(Category category)
        {
            if(category != null)
            {
                if(!string.IsNullOrWhiteSpace(category.Name))
                {
                    _categoryService.Add(category);
                    return Json(new { data = category });
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
