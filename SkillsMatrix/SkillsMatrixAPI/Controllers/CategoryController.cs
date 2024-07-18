using Microsoft.AspNetCore.Mvc;
using SkillsMatrix.Models;
using SkillsMatrix.Services;

namespace SkillsMatrixAPI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(CategoryService categoryService, ILogger<CategoryController> logger)
        {
            _categoryService = categoryService;
            _logger = logger;
        }

        public IEnumerable<Category> GetCategories()
        {
            _logger.LogDebug("Get categories Called.");
            var category = await _categoryService.Get();
            return category;
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
