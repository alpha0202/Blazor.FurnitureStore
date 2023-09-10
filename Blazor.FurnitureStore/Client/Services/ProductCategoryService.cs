using Blazor.FurnitureStore.Shared;
using System.Net.Http.Json;

namespace Blazor.FurnitureStore.Client.Services
{
    public class ProductCategoryService : IProductCategoryService
    {

        private readonly HttpClient _httpClient;

        public ProductCategoryService(HttpClient httpClient)
        {
            //*con httpClient podemos llamar a la api del proyecto servidor*/
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductCategory>> GetProductCategories()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ProductCategory>>($"api/productcategory");
        }

     
    }
}
