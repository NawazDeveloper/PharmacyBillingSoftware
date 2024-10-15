using PharmacyManagementAPI.Entities;

namespace PharmacyManagementAPI.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}
