using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyManagementAPI.Data.PharmacyManagementAPI.Data;
using PharmacyManagementAPI.Entities;
using PharmacyManagementAPI.Repositories;
using PharmacyManagementAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PharmacyManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        private readonly IProjectService _projectService;


        public ProductController(IProductRepository productRepository, IProjectService projectService)
        {
            _productRepository = productRepository;
            _projectService = projectService;
        }

        // Get all products
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _projectService.GetAllProductsAsync();
            return Ok(products);
        }

        // Get product by id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // Add a new product
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            var addedProduct = await _productRepository.AddProductAsync(product);
            return CreatedAtAction(nameof(GetProductById), new { id = addedProduct.ProductID }, addedProduct);
        }

        // Update an existing product
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            if (id != product.ProductID)
            {
                return BadRequest();
            }

            var updatedProduct = await _productRepository.UpdateProductAsync(product);
            return Ok(updatedProduct);
        }

        // Delete a product
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _productRepository.DeleteProductAsync(id);
            return NoContent();
        }
    }
}
