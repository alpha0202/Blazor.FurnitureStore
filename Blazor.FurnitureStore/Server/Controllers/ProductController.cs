using Blazor.FurnitureStore.Repositories;
using Blazor.FurnitureStore.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.FurnitureStore.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("GetByCategory/{productCategoryId}")]
        public async Task<IEnumerable<Product>> GetbyCategory(int productCategoryId)
        {
            return await _productRepository.GetByCategory(productCategoryId);
        }

    }
}
