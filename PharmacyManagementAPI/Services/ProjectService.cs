using PharmacyManagementAPI.Entities;
using PharmacyManagementAPI.Repositories;

namespace PharmacyManagementAPI.Services
{
    public class ProjectService : IProjectService
    {
       readonly IProductRepository _productRepository;
        public ProjectService(IProductRepository productRepository)
        {
            _productRepository= productRepository;
        }
        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
           return  _productRepository.GetAllProductsAsync();

        }
    }
}
