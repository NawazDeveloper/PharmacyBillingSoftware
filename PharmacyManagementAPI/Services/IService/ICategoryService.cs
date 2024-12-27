using PharmacyManagementAPI.Dtos;
using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Services.IService
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> GetAllCategorAsync();
        Task<CategoryModel> GetCategorByIdAsync(int productId);
        Task<CategoryModel> AddCategorAsync(CategoryModel product);
        Task<CategoryModel> UpdateCategorAsync(CategoryModel product);
        Task DeleteCategorAsync(int productId);
    }
}
