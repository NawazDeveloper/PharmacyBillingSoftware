using PharmacyManagementAPI.Dtos;
using PharmacyManagementAPI.Entities;
using PharmacyManagementAPI.Repositories;
using PharmacyManagementAPI.Services.IService;

namespace PharmacyManagementAPI.Services.Service
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryModel>> GetAllCategorAsync()
        {
            var categories = await _categoryRepository.GetAllCategorAsync();
            return categories.Select(category => new CategoryModel
            {
                CategoryID = category.CategoryID,
                CategoryName = category.CategoryName,
                Description = category.Description
            });
        }

        public async Task<CategoryModel> GetCategorByIdAsync(int categoryId)
        {
            var category = await _categoryRepository.GetCategorByIdAsync(categoryId);
            if (category == null) return null;

            return new CategoryModel
            {
                CategoryID = category.CategoryID,
                CategoryName = category.CategoryName,
                Description = category.Description
            };
        }

        public async Task<CategoryModel> AddCategorAsync(CategoryModel model)
        {
            var categoryEntity = new Category
            {
                CategoryName = model.CategoryName,
                Description = model.Description
            };

            var addedCategory = await _categoryRepository.AddCategorAsync(categoryEntity);
            model.CategoryID = addedCategory.CategoryID;
            return model;
        }

        public async Task<CategoryModel> UpdateCategorAsync(CategoryModel model)
        {
            var categoryEntity = new Category
            {
                CategoryID = model.CategoryID,
                CategoryName = model.CategoryName,
                Description = model.Description
            };

            var updatedCategory = await _categoryRepository.UpdateCategorAsync(categoryEntity);
            if (updatedCategory == null) return null;

            return model;
        }

        public async Task DeleteCategorAsync(int categoryId)
        {
            await _categoryRepository.DeleteCategorAsync(categoryId);
        }
    }
}

