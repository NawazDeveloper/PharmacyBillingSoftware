using Microsoft.EntityFrameworkCore;
using PharmacyManagementAPI.Data.PharmacyManagementAPI.Data;
using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Category> AddCategorAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

      

        public async Task DeleteCategorAsync(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Category>> GetAllCategorAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategorByIdAsync(int categoryId)
        {
            return await _context.Categories.FindAsync(categoryId);
        }

        public async Task<Category> UpdateCategorAsync(Category category)
        {
            var existingCategory = await _context.Categories.FindAsync(category.CategoryID);
            if (existingCategory != null)
            {
                existingCategory.CategoryName = category.CategoryName;
                existingCategory.Description = category.Description;

                _context.Categories.Update(existingCategory);
                await _context.SaveChangesAsync();
            }
            return existingCategory;
        }

    }
}
