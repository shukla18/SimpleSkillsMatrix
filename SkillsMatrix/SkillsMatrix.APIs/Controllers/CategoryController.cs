using Microsoft.AspNetCore.Mvc;
using SkillsMatrix.Models;
using SkillsMatrix.Services;
using System.Linq;
using System.Net;

namespace SkillsMatrix.APIs.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CategoryController
    {
        private readonly CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet(Name = "GetCategories")]
        public async Task<IEnumerable<Category>> Get()
        {
            return await _categoryService.GetAllAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            var user = await _categoryService.GetByIdAsync(id);
            return user;
        }

        [HttpPost]
        public async Task AddCategory(Category category)
        {
            await _categoryService.AddAsync(category);
        }
    }
}
