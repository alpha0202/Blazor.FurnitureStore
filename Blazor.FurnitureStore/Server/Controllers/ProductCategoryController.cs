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
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoryRepository _productCategoryrRpository;

        public ProductCategoryController(IProductCategoryRepository productCategoryRepository)
        {
                _productCategoryrRpository = productCategoryRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductCategory>> Get()
        {
            return await _productCategoryrRpository.GetAll();
        }

    }


   
}
