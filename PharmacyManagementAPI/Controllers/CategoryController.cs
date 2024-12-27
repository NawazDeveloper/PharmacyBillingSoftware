using Microsoft.AspNetCore.Mvc;
using PharmacyManagementAPI.Dtos;
using PharmacyManagementAPI.Entities;
using PharmacyManagementAPI.Repositories;
using PharmacyManagementAPI.Services.IService;

namespace PharmacyManagementAPI.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class CategoryController : ControllerBase
        {
            private readonly ICategoryService _categoryService;

            public CategoryController(ICategoryService categoryService)
            {
                _categoryService = categoryService;
            }

            // GET: api/Category
            [HttpGet]
            public async Task<ActionResult<IEnumerable<CategoryModel>>> GetAllCategories()
            {
                var categories = await _categoryService.GetAllCategorAsync();
                return Ok(categories);
            }

            // GET: api/Category/{id}
            [HttpGet("{id}")]
            public async Task<ActionResult<CategoryModel>> GetCategoryById(int id)
            {
                var category = await _categoryService.GetCategorByIdAsync(id);
                if (category == null)
                {
                    return NotFound();
                }
                return Ok(category);
            }

            // POST: api/Category
            [HttpPost]
            public async Task<ActionResult<CategoryModel>> AddCategory(CategoryModel categoryModel)
            {
                var createdCategory = await _categoryService.AddCategorAsync(categoryModel);
                return CreatedAtAction(nameof(GetCategoryById), new { id = createdCategory.CategoryID }, createdCategory);
            }

            // PUT: api/Category/{id}
            [HttpPut("{id}")]
            public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryModel categoryModel)
            {
                if (id != categoryModel.CategoryID)
                {
                    return BadRequest("Category ID mismatch.");
                }

                var updatedCategory = await _categoryService.UpdateCategorAsync(categoryModel);
                if (updatedCategory == null)
                {
                    return NotFound();
                }

                return NoContent();
            }

            // DELETE: api/Category/{id}
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCategory(int id)
            {
                var existingCategory = await _categoryService.GetCategorByIdAsync(id);
                if (existingCategory == null)
                {
                    return NotFound();
                }

                await _categoryService.DeleteCategorAsync(id);
                return NoContent();
            }
        }
    
}


