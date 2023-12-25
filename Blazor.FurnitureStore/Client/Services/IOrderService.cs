using Blazor.FurnitureStore.Shared;

namespace Blazor.FurnitureStore.Client.Services
{
    public interface IOrderService
    {
        Task SaveOrder(Order order);

    }
}
