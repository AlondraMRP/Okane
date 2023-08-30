using Microsoft.AspNetCore.Mvc;
using Okane.Core.Entities;
using Okane.Core.Repositories;

namespace Okane.WebApi.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        [HttpPost]
        public IActionResult CreateCategory([FromBody] Category? category)
        {
            if (category == null)
            {
                return BadRequest("Category data is null.");
            }

            _categoryRepository.Add(category);

            return CreatedAtRoute("GetCategoryById", new { id = category.Id }, category);
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categories = _categoryRepository.All();
            return Ok(categories);
        }
        
    }
}