using Microsoft.AspNetCore.Mvc;
using SkillsMatrix.Models;
using SkillsMatrix.Services;

namespace SkillsMatrixAPI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult GetCategories()
        {
            var category = _categoryService.GetAll();
            return View(category);
        }

        public IActionResult GetCategory(int id)
        {
            var category = _categoryService.GetById(id);
            return View(category);
        }

        //public IActionResult UpdateCategory(Category category)
        //{
        //    _categoryService.UpdateCategory(category);
        //    return RedirectToAction("Index");
        //}

        //public IActionResult DeleteCategory(int id)
        //{
        //    _categoryService.DeleteCategory(id);
        //    return RedirectToAction("Index");
        //}
    }
}
