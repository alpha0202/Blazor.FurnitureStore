using Blazor.FurnitureStore.Shared;

namespace Blazor.FurnitureStore.Client.Services
{
    public interface IProductCategoryService
    {

        Task<IEnumerable<ProductCategory>>? GetProductCategories();
    }
}
