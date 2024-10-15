using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<Category> AddCategorAsync(Category product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategorAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllCategorAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategorByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateCategorAsync(Category product)
        {
            throw new NotImplementedException();
        }
    }
}
