using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Repositories
{
    public interface ICategoryRepository
    {

        Task<IEnumerable<Category>> GetAllCategorAsync();
        Task<Category> GetCategorByIdAsync(int productId);
        Task<Category> AddCategorAsync(Category product);
        Task<Category> UpdateCategorAsync(Category product);
        Task DeleteCategorAsync(int productId);




    }
}
