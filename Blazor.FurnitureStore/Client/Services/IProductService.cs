using Blazor.FurnitureStore.Shared;

namespace Blazor.FurnitureStore.Client.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetByCategory(int productCategoryId);

    }
}
